using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGraphClasses
{
    public class WGraph
    {
        //private members
        const int SIZE = 20; // the default size of the graph
        private int Count; // the number of vertices in the graph
        private List<Node<char>> NodeList; // the list of vertices in the graph
        private int[,] EdgeMatrix; // the edge matrix of the weighted graph

        //public members

        //private methods

        //public methods:
        public WGraph() =>
            throw new NotImplementedException();
        
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
