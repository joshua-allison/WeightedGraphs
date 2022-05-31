//
//  main.cpp
//  CS 260 Lab 8
//
//  Created by Jim Bailey on June 2, 2020.
//  Licensed under a Creative Commons Attribution 4.0 International License.
//
//  Transpiled into C# 6/5/2020 by Katie Strauss
//

using System;
using WGraphClasses;

namespace GraphsDriver
{
    class Driver
    {
        static void Main(string[] args)
        {
            // create the graph
            WGraph graph = SetupGraph();
            OutputBasics(graph);
            
            // uncomment tests to run
            //MinCostTest(graph);
            //MinPathsTest(graph);

            Console.Write("Press Enter to close.");
            Console.Read();
        }

        static WGraph SetupGraph()
        {
            // create the graph
            WGraph graph = new WGraph();

            // Add nodes to graph
            graph.AddNode('A');
            graph.AddNode('B');
            graph.AddNode('C');
            graph.AddNode('D');
            graph.AddNode('E');
            graph.AddNode('F');
            graph.AddNode('G');
            graph.AddNode('H');
            graph.AddNode('I');
            graph.AddNode('J');

            // Add edges to the graph
            graph.AddEdge('A', 'B', 4);
            graph.AddEdge('A', 'H', 8);
            graph.AddEdge('B', 'C', 8);
            graph.AddEdge('B', 'H', 11);
            graph.AddEdge('C', 'D', 7);
            graph.AddEdge('C', 'F', 4);
            graph.AddEdge('C', 'I', 2);
            graph.AddEdge('D', 'E', 9);
            graph.AddEdge('D', 'F', 14);
            graph.AddEdge('E', 'F', 10);
            graph.AddEdge('F', 'G', 2);
            graph.AddEdge('G', 'H', 1);
            graph.AddEdge('G', 'I', 6);
            graph.AddEdge('H', 'I', 7);

            return graph;
        }

        static void OutputBasics(WGraph graph)
        {
            Console.Write("The list of nodes \n");
            Console.Write(" expected A B C D E F G H I J\n");
            Console.Write(" actually " + graph.ListNodes() + "\n\n");

            Console.Write("The adjacency list is: \n");
            Console.Write(graph.DisplayAdjacency() + "\n\n");

            Console.Write("The adjacency matrix is\n");
            Console.Write(graph.DisplayMatrix() + "\n");

            Console.Write("The breadth first traversal starting at A\n");
            Console.Write(" expected A H B I G C F D E Unreached Node(s): J\n");
            Console.Write(" actually " + graph.BreadthFirst('A') + "\n");

            Console.Write("The depth first traversal starting at A\n");
            Console.Write(" expected A H I G F E D C B Unreached Node(s): J\n");
            Console.Write(" actually " + graph.DepthFirst('A') + "\n");
        }

        static void MinCostTest(WGraph graph)
        {
            Console.Write("This test displays a minimum cost spanning tree for a weighted graph\n\n");

            Console.Write("The min cost tree starting at A \n");
            Console.Write(" Expected A: A-B A-H H-G G-F F-C C-I C-D D-E Unreached Node(s): J\n");
            Console.Write(" Actually " + graph.MinCostTree('A')+ "\n");

            Console.Write("The min cost tree starting at D \n");
            Console.Write(" Expected D: D-C C-I C-F F-G G-H C-B B-A D-E Unreached Node(s): J\n");
            Console.Write(" Actually " + graph.MinCostTree('D')+ "\n");

            Console.Write("Done with testing min cost spanning tree " + "\n\n");
        }

        static void MinPathsTest(WGraph graph)
        {
            Console.Write("The minimum cost paths starting at A \n");
            Console.Write(" Expected B(4) C(12) D(19) E(21) F(11) G(9) H(8) I(14) J(inf) \n");
            Console.Write(" Actually " + graph.MinCostPaths('A')+ "\n");

            Console.Write("The minimum cost paths starting at D \n");
            Console.Write(" Expected A(19) B(15) C(7) E(9) F(11) G(13) H(14) I(9) J(inf) \n");
            Console.Write(" Actually " + graph.MinCostPaths('D')+ "\n");

            Console.Write("Done with testing min cost paths " + "\n\n");

        }
    }
}