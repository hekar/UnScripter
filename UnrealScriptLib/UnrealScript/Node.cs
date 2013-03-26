using System.Collections.Generic;

namespace UnrealScriptLib.Unreal
{
    public class Node
    {
        public string Name { get; private set; }

        public List<Node> Nodes { get; private set; }

        public Node(string Name)
        {
            this.Name = Name;
            Nodes = new List<Node>();
        }
    }
}
