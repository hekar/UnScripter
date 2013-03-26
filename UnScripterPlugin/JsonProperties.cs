using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace UnScripterPlugin
{
    public class JsonProperties
    {
        public Dictionary<string, string> Properties {get; private set;}

        public JsonProperties()
        {
            Properties = new Dictionary<string, string>();
        }

        public void Save(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.Write(Serialize());
            }
        }

        public void Load(string path)
        {
            using (var reader = new StreamReader(path))
            {
                var content = reader.ReadToEnd();
                var props = Deserialize(content);
                Properties.Clear();
                foreach (var kv in props)
                {
                    Properties.Add(kv.Key, kv.Value);
                }
            }
        }

        private Dictionary<string, string> Deserialize(string content)
        {
            var reader = new StringReader(content);
            var serializer = new JsonSerializer();
            var props = serializer.Deserialize(reader, typeof(Dictionary<string, string>)) as Dictionary<string, string>;
            return props;
        }

        private string Serialize()
        {
            using (var writer = new StringWriter())
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(writer, Properties);
                return writer.ToString();
            }
        }
    }
}
