using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListImplemented
{
    
        public class Node
        {
            public int id;
            public  String name;
            public Node next;
            public Node prev;

            public Node(int id, String name, Node next, Node prev)
            {
                this.id = id;
                this.name = name;
                this.next = next;
                this.prev = prev;
            }

            public void displayANode()
            {
                Console.WriteLine("id: " + id + " name:" + name);
            }

         public override String ToString()
            {   // Required
                return "" + id + " " + name;
            }

        }
    }
