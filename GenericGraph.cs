using System;
using System.Collections.Generic; 


public class GenericGraph
	{
		public int V; // Number of Vertices
		
		public LinkedList<Node>[] adj; // adjacency lists
		
		// Constructor
		public GenericGraph(int V)
		{
			this.V = V;
			adj = new LinkedList<Node>[V];
			
			for (int i = 0; i < adj.Length; i++)
				adj[i] = new LinkedList<Node>();
			  
		}
		
		// To add an edge to graph
	
		
         public void addEdge(int v, Node node)
		{
			adj[v].AddLast(node); // Add w to v’s list.
		}
		// prints all not yet visited vertices reachable from s
		public void DFS(Node s)
		{
			// Initially mark all vertices as not visited
			Boolean []visited = new Boolean[V];
				
			// Create a stack for DFS
			Stack<Node> stack = new Stack<Node>();
			
			// Push the current source node
			stack.Push(s);
			
			while(stack.Count > 0)
			{
				// Pop a vertex from stack and print it
				s = stack.Peek();
				stack.Pop();
				Console.WriteLine($"I found this s edge as {s}");
				
				// Stack may contain same vertex twice. So
				// we need to print the popped item only
				// if it is not visited.
				if(visited[s.NodeInternalID] == false)
				{
					Console.Write(s + " ");
					visited[s.NodeInternalID] = true;  
				}
				
				// Get all adjacent vertices of the popped vertex s
				// If a adjacent has not been visited, then push it
				// to the stack.
				foreach(Node v in adj[s.NodeInternalID])
				{
					if(!visited[v.NodeInternalID])
						stack.Push(v);
				}
				
			}
		}
	
}