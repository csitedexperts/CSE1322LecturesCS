using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementQueue
{
   public class Queue
    {

       public  Node top;
       public Node tail;

       public  Queue()
        {   // Optional 
            top = null;  // null initialization
            tail = null;  // null initialization
                          // Here to show the head and tail always start as null
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

        public void enQueue(int id, String name)
        {
            Node node = new Node(id, name);

            if (tail == null)
            {
                top = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }

        }

        public void deQueue()
        {
            if (top == null)
            {
                tail = null;
                Console.WriteLine("There is no node to delete");
                return;
            }
            else
            {
                int id = top.id;
                String name = top.name;
                Console.WriteLine("The node with Id: " + id + " and Name: " + name + "  is deleted ");
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

    }  // end of the Queue Class
}
