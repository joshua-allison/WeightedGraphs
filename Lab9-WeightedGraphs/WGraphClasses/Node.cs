using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGraphClasses
{
    /// <summary> "The object used to represent a node." </summary>
    /// <accreditation> This class is from "CS 260 - Graphs" by Jim Bailey</accreditation>
    public class Node<T>
    {
        public Node(T name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            Name = name;
        }
        public T Name { get; set; } //
        public LinkedList<Edge>? Edges { get; set; } // the list of connections with their associated weights
        public bool Visited { get; set; } // (for graph traversal)
        public override string ToString() => Name.ToString(); // override the ToString method as the name of the node for easy debugging and programming
    }
}
