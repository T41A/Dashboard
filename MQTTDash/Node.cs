using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTTDash
{
    class Node
    {
        public string Identifier { get; private set; }
        public NodeType Type { get; }

        private string[] messages;
        public Node(string identifier, NodeType type)
        {
            Identifier = identifier;
            Type = type;
        }

        public Node()
        {
            
        }

        public void AddMessage(string msg)
        {
            
        }
    }
}
