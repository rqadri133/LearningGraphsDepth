public class Node 
{
   public int NodeInternalID
   {
      get;
      set;
   }

   public ETANodeData CurrentDataNode 
   { 
       get;
       set;
   }

   public string NodeTag
   {
     get;
     set;
   }

   public Node NextNode 
   {
     get;
     set;
   }

   public Node PreviousNode 
   {
      get;
      set;
   }


}