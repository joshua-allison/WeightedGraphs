using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGraphClasses
{
    /// <summary>An edge, in a non-directed weighted graph, is 2 nodes connected by a path with a weight.</summary>   
    public class Edge<T>
    {
        public int Weight { get; set; }
        public Node<T> Adjacent { get; set; }
        
        public Edge(Node<T> n1, Node<T> adjacent, int weight)
        {
            Adjacent = adjacent;
            Weight = weight;
        }
        public override string ToString() => Adjacent.Name.ToString(); // override the ToString method as the name of the node2 for easy debugging and programming
    }
}
