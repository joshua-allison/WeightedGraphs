using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGraphClasses
{
    /// <summary> An edge, in a weighted graph, is 2 nodes connected by a path with a weight. </summary>   
    public class Edge<T>
    {
        public int Weight { get; set; }
        public Node<T> Node1 { get; set; }
        public Node<T> Node2 { get; set; }

        public Edge(Node<T> n1, Node<T> n2, int weight)
        {
            Node1 = n1;
            Node2 = n2;
            Weight = weight;
        }
    }
}
