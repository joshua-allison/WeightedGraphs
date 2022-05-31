using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WGraphClasses
{
    public class WeightedGraph<T>
    {
        //private members
        private const int SIZE = 20; // the default size of the graph
        private int Count; // the number of vertices in the graph
        private List<Node<T>> NodeList; // the list of vertices in the graph        
        private int[,] EdgeMatrix; // the edge matrix of the weighted graph

        //public members

        //private methods

        //public methods:

        /// <summary>Constructor for the weighted graph.</summary>
        /// <param name="size">Determines the length and width of the EdgeMatrix, and the maximum number of nodes. Default 20. </param>
        public WeightedGraph(int size = -1)
        {
            size = (size <= 0) ? SIZE : size;
            Count = 0;
            NodeList = new List<Node<T>>();
            EdgeMatrix = new int[size, size];
        }

        public void AddNode() =>
            throw new NotImplementedException();

        public void AddEdge() =>
            throw new NotImplementedException();

        public void ListNodes() =>
            throw new NotImplementedException();

        public void DisplayAdjacency() =>
            throw new NotImplementedException();

        public void DisplayMatrix() =>
            throw new NotImplementedException();

        public void BreadthFirst() =>
            throw new NotImplementedException();

        public void DepthFirst() =>
            throw new NotImplementedException();

        public void MinCostTree() =>
            throw new NotImplementedException();

        public void MinCostPaths() =>
            throw new NotImplementedException();





    }
}
