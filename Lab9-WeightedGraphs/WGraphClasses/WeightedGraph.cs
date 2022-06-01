using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WGraphClasses
{
    class Program { public static void Main(string[] args) { } }
    
    public class WeightedGraph<T>
    {
        //private members
        private const int SIZE = 20; // the default size of the graph
        private int MaxSize; // the maximum size of the graph
        private int Count; // the number of vertices in the graph
        private Node<T>[] NodeList; // the list of vertices in the graph        
        private int[,] EdgeMatrix; // the edge matrix of the weighted graph

        //private methods

        public int FindIndex(T name)
        {
            for (int i = 0; i < Count; i++)
                if (NodeList[i].Name.Equals(name))
                    return i;
            return -1;
        }

        private Node<T> GetNode(T name) => NodeList[FindIndex(name)];

        private void ResetVisited()
        {
            for (int i = 0; i < Count; i++)
                NodeList[i].Visited = false;
        }

        //public methods:
        /// <summary>Constructor for the weighted graph.</summary>
        /// <param name="size">Determines the length and width of the EdgeMatrix, and the maximum number of nodes. Default 20. </param>
        public WeightedGraph(int size = SIZE)
        {
            if (size < 1)
                size = SIZE;
            MaxSize = size;
            Count = 0;
            NodeList = new Node<T>[size];
            EdgeMatrix = new int[size, size];
        }

        public void AddNode(T name)
        {
            if (Count >= MaxSize)
                throw new IndexOutOfRangeException("Graph is full.");
            NodeList[Count] = new Node<T>(name);
            Count++;
        }

        public void AddEdge(T name1, T name2, int weight)
        {
            // set the edges weight on the edge matrix
            int index1 = FindIndex(name1);
            int index2 = FindIndex(name2);
            if (index1 == -1 || index2 == -1)
                throw new IndexOutOfRangeException("One or more nodes not found.");
            EdgeMatrix[index1, index2] = weight;
            EdgeMatrix[index2, index1] = weight;

            // then add the edge to the nodes
            NodeList[index1].AddEdge(new Edge<T>(NodeList[index1], NodeList[index2], weight));
            NodeList[index2].AddEdge(new Edge<T>(NodeList[index2], NodeList[index1], weight));
        }

        public string ListNodes()
        {
            string output = "";
            for (int i = 0; i < Count; i++)
            {
                output += NodeList[i].Name + " ";
            }
            return output;
        }

        public string DisplayAdjacency()
        {
            string output = "";
            for (int i = 0; i < Count; i++)
            {
                output += NodeList[i].Name + ": ";
                for (int j = 0; j < Count; j++)
                    if (EdgeMatrix[i, j] != 0)
                        output += NodeList[j].Name + " ";
                output += "\n";
            }
            return output;
        }

        public string DisplayMatrix()
        {
            string output = "   ";
            for (int f = 0; f < Count; f++)
                output += f.ToString().PadLeft(3);
            output += "   <= 'NodeList' index (for debugging) \n   ";
            for (int g = 0; g < Count; g++)
                output += NodeList[g].Name.ToString().PadLeft(3);
            output += "\n   ";
            for (int h = 0; h < Count*3; h++)
                output += "_";
            output += "\n";
            for (int i = 0; i < Count; i++)
            {
                output += NodeList[i].Name + " |";
                for (int j = 0; j < Count; j++)
                {
                    if(i != j)
                        output += EdgeMatrix[i, j].ToString().PadLeft(3);
                    else
                        output += "   ";
                }
                output += "\n";
            }
            return output;
        }

        public string BreadthFirst(T name)
        {
            ResetVisited();
            string buffer = "";
            Node<T> node = GetNode(name);
            Queue<Node<T>> Q = new();

            node.Visited = true;
            Q.Enqueue(node);

            for (int i = 0; i < NodeList.Length && Q.Count > 0; i++)
            {
                // get the next node to evaluate
                node = Q.Peek();
                // for every edge of the node
                foreach(var item in node.Edges)
                {
                    // if the node on the edge is unvisited...
                    if (item.Node2.Visited is false)
                    {
                        // mark it as visited then add it to the Q.
                        item.Node2.Visited = true;
                        Q.Enqueue(item.Node2);
                    }
                }
                // After every edge node of node has been evaluated, add Q.Dequeue to the buffer.
                buffer += Q.Dequeue() + " ";
            }

            // special case: unreached nodes
            buffer += "Unreached Node(s): ";
            string allNodes = "";
            foreach (Node<T> item in NodeList)
                allNodes += item;
            foreach (var nodeName in allNodes)
                if (!buffer.Contains(nodeName))
                    buffer += nodeName + " ";


            return buffer;
        }

        public string DepthFirst(T name)
        {
            ResetVisited();
            Stack <Node<T>> stack = new();
            Node<T> node = GetNode(name);
            Node<T> nextAdjacent = node;
            Edge<T> nextEdge;
            stack.Push(node);
            node.Visited = true;
            string buffer = node + " ";
            bool allVisited = false;

            //while (node is not null)
            //{
            for (int i = FindIndex(node.Name); i > -1 ; i--)
            {
                node = NodeList[i];
                for (int j = 0; j < node.Edges.Count; j++)
                {
                    nextEdge = node.Edges.First();
                    if (nextEdge.Node2.Visited)
                        nextEdge = nextEdge.Node2.Edges.First();
                    else
                        nextAdjacent = nextEdge.Node2;
                }
                if (!nextAdjacent.Visited)
                {
                    stack.Push(nextAdjacent);
                    nextAdjacent.Visited = true;
                    i = FindIndex(nextAdjacent.Name) +1;
                }
            }
            //    foreach (var item in node.Edges)
            //    {
            //        if (item.Node2.Visited == false)
            //        {
            //            stack.Push(item.Node2);
            //            item.Node2.Visited = true;
            //            node = item.Node2;
            //            allVisited = false;
            //            break;
            //        }
            //    }
            //}


            return buffer;
        }

        public string MinCostTree(T name) =>
            throw new NotImplementedException();

        public string MinCostPaths(T name) =>
            throw new NotImplementedException();
    }
    
}
