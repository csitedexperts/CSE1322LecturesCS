using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementStack
{
    public class Node
    {
       public int id;
        public String name;
        public Node next;

        public Node(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public void displayANode()
        {
            Console.WriteLine("id: " + id + " name:" + name);
        }

        
    public override String ToString()
        {   // Required
            return name;
        }

    }  // End of the Node class
}
