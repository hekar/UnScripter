using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UnrealScriptLib.Unreal;

namespace UnScripter.Unreal
{
    public class UnrealClass
    {
        public string FullName { get; private set; }
        public string Name { get; private set; }
        public string ParentName { get; private set; }
        public List<UnrealFunction> Functions { get; private set; }
        public List<UnrealVariable> Variables { get; private set; }
        public Node RootNode { get; private set; }
        public bool CompletedParsing { get; private set; }

        public UnrealClass(string fullname)
        {
            CompletedParsing = false;
            FullName = fullname;
            Name = ReadClassName(fullname);
            RootNode = new Node(Name);
        }

        private string ReadClassName(string fullname)
        {
            // TODO: Fix OS specific path
            if (fullname.EndsWith("\\"))
            {
                fullname = fullname.Substring(0, fullname.Count());
            }

            string classname = fullname.Substring(fullname.LastIndexOf("\\") + 1,
                fullname.Count() - fullname.LastIndexOf("\\") - 1).Replace(".uc", "");

            return classname;
        }

        public void Parse()
        {
            ParentName = ParseOutParentClassName(FullName);
            Functions = ParseOutFunctions(FullName);
            Variables = ParseOutVariables(FullName);

            CompletedParsing = true;
        }

        public UnrealFunction GetFunctionBySignature(string func_signature)
        {
            foreach (var func in Functions)
            {
                if (func_signature == func.Signature)
                {
                    return func;
                }
            }

            return null;
        }

        public UnrealVariable GetVariableBySignature(string var_signature)
        {
            foreach (var variable in Variables)
            {
                if (var_signature == variable.Signature)
                {
                    return variable;
                }
            }

            return null;
        }

        private string ParseOutParentClassName(string fullname)
        {
            StreamReader reader = new StreamReader(fullname);
            string readline = null;
            Regex re = new Regex("^\\w*class.*extends.*$");

            readline = reader.ReadLine();
            while (reader.Peek() != -1)
            {
                readline = reader.ReadLine();
                if (re.IsMatch(readline))
                {
                    break; // TODO: might not be correct. Was : Exit While
                }
            }

            reader.Close();

            string class_def = "No Parent";
            if (re.IsMatch(readline))
            {
                class_def = re.Match(readline).ToString();
                class_def = class_def.Substring(class_def.IndexOf("extends ") + "extends ".Length, class_def.Length - class_def.IndexOf("extends ") - "extends ".Length);
            }

            return class_def;
        }

        private List<UnrealFunction> ParseOutFunctions(string fullname)
        {
            List<UnrealFunction> funcs = new List<UnrealFunction>();
            StreamReader reader = new StreamReader(fullname);
            string[] contents = reader.ReadToEnd().Split("\r\n".ToCharArray());
            reader.Close();

            int linenum = 0;
            Regex re = new Regex("^.*(function|virtual|void).*\\(.*\\).*$");
            foreach (string line in contents)
            {
                linenum += 1;

                if (re.IsMatch(line))
                {
                    string sig = line.Replace("\t", " ").Replace(";", "");
                    RootNode.Nodes.Add(new Node(sig));
                    funcs.Add(new UnrealFunction(sig, linenum));
                }
            }

            return funcs;
        }

        private List<UnrealVariable> ParseOutVariables(string fullname)
        {
            List<UnrealVariable> vars = new List<UnrealVariable>();

            StreamReader reader = new StreamReader(fullname);
            string[] contents = reader.ReadToEnd().Split("\n".ToCharArray());
            reader.Close();

            int linenum = 0;
            Regex re = new Regex("^\\w*var\\(*\\)*.*;");
            foreach (string line in contents)
            {
                linenum += 1;

                if (re.IsMatch(line))
                {
                    string sig = line.Replace("\t", " ").Replace(";", "");
                    RootNode.Nodes.Add(new Node(sig));
                    vars.Add(new UnrealVariable(sig, linenum));
                }
            }

            return vars;
        }
    }
}
