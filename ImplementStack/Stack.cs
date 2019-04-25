using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementStack
{
   public class Stack
    {
        public Node top;

        public Stack()
        {   // Optional 
            top = null;  // null initialization
                         // Here to show the top always start as null
        }

        public Boolean isEmpty()
        {
            return (top == null);
        }

        public void peek()
        {
            if (isEmpty())
                Console.WriteLine("There is nothing to peek");
		else {
                Console.WriteLine("The top node's id is : " + top.id);
            }
        }

        public void push(int id, String name)
        {
            Node node = new Node(id, name);

            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
        }

        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("There is no node to delete");
                return;
            }
            else
            {
                int id = top.id;
                String name = top.name;
                Console.WriteLine("Poped the node with Id: " + id + " and Name:" + name);
                top = top.next;
            }
        }

        public void displayAllNodes()
        {

            Node thisNode = top;

            while (thisNode != null)
            {
                thisNode.displayANode();
                Console.WriteLine("Next Node: " + thisNode.next);
                thisNode = thisNode.next;
                Console.WriteLine();

            }

        }


    }  // end of the Stack Class
}
