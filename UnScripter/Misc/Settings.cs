using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Threading;
using System.Xml;

namespace UnScripter
{

    // Stores settings in a keyvalue form that's ready for xml reading/writing
    public class Settings
    {
        // Lock the reads and writes to prevent dirty reads
        private Mutex mutex = new Mutex();

        // Dictionary to hold all the application settings
        private Dictionary<string, string> settings = new Dictionary<string, string>();

        private string headername;

        // Filepath of the xml file
        public string Filename { get; set; }


        // Write on each trait change
        public bool ImmediateWrite { get; set; }

        public Settings(string settingsfile, string headername = "settings", bool LoadFile = true)
        {
            Filename = settingsfile;
            this.headername = headername;

            SetTrait(headername + "Version", "1");

            // Load the settings immediately, if asked of
            if (LoadFile)
            {
                ReadFile(settingsfile);
            }

        }

        // Read from an xml file
        private void ReadFile(string settingsfile)
        {
            mutex.WaitOne();

            if (!File.Exists(settingsfile))
            {
                // Write the file if it doesn't exist
                WriteToXml();
                return;
            }

            var xmlreader = new XmlTextReader(Filename);

            try
            {
                // Read the XMLDoc header
                xmlreader.Read();

                // Read through each element
                while (xmlreader.Read())
                {
                    if (xmlreader.NodeType == XmlNodeType.Element)
                    {
                        string name = xmlreader.Name;
                        xmlreader.Read();
                        SetTrait(name, xmlreader.ReadContentAsString());
                    }
                }
            }
            catch (XmlException)
            {
                MessageBox.Show("Error in Parsing" + Filename);
            }
            finally
            {
                xmlreader.Close();
            }


            mutex.ReleaseMutex();
        }

        // Write to an xml file
        private void WriteFile(string settingsfile)
        {
            mutex.WaitOne();

            Directory.CreateDirectory(Path.GetDirectoryName(settingsfile));

            var xmlwriter = new XmlTextWriter(settingsfile, System.Text.Encoding.Unicode);
            xmlwriter.Formatting = Formatting.Indented;
            try
            {
                // Write the start of the document
                xmlwriter.WriteStartDocument();
                xmlwriter.WriteStartElement(headername);

                foreach (var comm in settings)
                {
                    xmlwriter.WriteElementString(comm.Key, comm.Value);
                }

                // End the document
                xmlwriter.WriteEndElement();
                xmlwriter.WriteEndDocument();

            }
            finally
            {
                // In case of an exception, finish writing anyway
                xmlwriter.Close();
            }

            mutex.ReleaseMutex();
        }

        public void ReadFromXml()
        {
            ReadFile(Filename);
        }

        public void WriteToXml()
        {
            WriteFile(Filename);
        }

        public void SetTrait(string key, string value)
        {
            // Create key if it doesn't exist
            if (!settings.ContainsKey(key))
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key] = value;
            }

            if (ImmediateWrite)
            {
                WriteToXml();
            }

        }

        public void SetTrait<T>(string key, T value)
        {
            SetTrait(key, value.ToString());
        }

        public string GetTrait(string key, string defaultvalue = "")
        {
            // Return default value if key is not found
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            else
            {
                return defaultvalue;
            }
        }

        public bool GetTrait(string key, bool defaultvalue)
        {
            return GetTrait(key, defaultvalue.ToString()).Equals("true", StringComparison.InvariantCultureIgnoreCase);
        }

    }
}
