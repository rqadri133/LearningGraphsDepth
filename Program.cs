// An Iterative C# program to do DFS traversal from
// a given source vertex. DFS(int s) traverses vertices
// reachable from s.
using System; 
using System.Collections.Generic;



	GenericGraph g = new GenericGraph(5);
		
		g.addEdge(1, new Node {NodeTag = "Person A" , NodeInternalID = 1 , CurrentDataNode = new ETANodeData() {}} );
		g.addEdge(0, new Node {NodeTag = "Person B" , NodeInternalID = 2 , CurrentDataNode = new ETANodeData() {}});
		g.addEdge(2, new Node {NodeTag = "Person C" , NodeInternalID = 3 , CurrentDataNode = new ETANodeData() {}});
		g.addEdge(0, new Node {NodeTag = "Person D" , NodeInternalID = 4 , CurrentDataNode = new ETANodeData() {}});
		g.addEdge(1, new Node {NodeTag = "Person E" , NodeInternalID = 4 , CurrentDataNode = new ETANodeData() {}});
			
		Console.Write("Following is the Depth First Traversal\n");
		g.DFS( new Node {NodeTag = "Person A" , NodeInternalID = 1 , CurrentDataNode = new ETANodeData() {}});
// This class represents a directed graph using adjacency
	// list representation
	
	
	// Driver code

