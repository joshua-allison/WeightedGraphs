using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGraphClasses
{
    /// <summary>The object used to represent a node.</summary>
    public class Node<T>
    {
        public Node(T name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            Name = name;
            Visited = false;
            Edges = null;
        }
        
        public void AddEdge(Edge<T> edge) 
        {
            if (edge == null)
                throw new ArgumentNullException("edge");
            if (Edges == null)
                Edges = new LinkedList<Edge<T>>();
            Edges.AddFirst(edge);
        }
        public T Name { get; set; } // the name of the node
        public LinkedList<Edge<T>>? Edges { get; set; } // the list of connections with their associated weights
        public bool Visited { get; set; } // (for graph traversal)
        public override string ToString() => Name.ToString(); // override the ToString method as the name of the node for easy debugging and programming
    }
}
