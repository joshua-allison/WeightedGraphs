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
        WeightedGraph<char> graph;

        //public members

        //private methods

        //public methods:
        public WGraph(int? size = 0) => graph = new WeightedGraph<char>( size is null ? 0 : (int)size);

        public void AddNode(char name) => graph.AddNode(name);

        public void AddEdge(char name1, char name2, int weight) => graph.AddEdge(name1, name2, weight);

        public string ListNodes() => graph.ListNodes();

        public string DisplayAdjacency() => graph.DisplayAdjacency();

        public string DisplayMatrix() => graph.DisplayMatrix();

        public string BreadthFirst(char name) => graph.BreadthFirst(name);

        public string DepthFirst(char name) => graph.DepthFirst(name);

        public string MinCostTree(char name) => graph.MinCostTree(name);

        public string MinCostPaths(char name) => graph.MinCostPaths(name);
    }
}
