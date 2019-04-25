using System;

namespace ImplementSinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Node n1 = new Node(1, "n1");
            Node n2 = new Node(2, "n2");
            Node n3 = new Node(3, "n3");
            Node n4 = new Node(4, "n4");
            Node n5 = new Node(5, "n5");
            Node n6 = new Node(6, "n6");

            n1.displayANode();
            n2.displayANode();
            n3.displayANode();
            n4.displayANode();
            n5.displayANode();
            n6.displayANode();

            Console.WriteLine("n1.next :" + n1.next);
            Console.WriteLine("n2.next :" + n2.next);
            Console.WriteLine("n3.next :" + n3.next);
            Console.WriteLine("n4.next :" + n4.next);
            Console.WriteLine("n5.next :" + n5.next);
            Console.WriteLine("n6.next :" + n6.next);

            Console.WriteLine("\n= ==  After liking the nodes = = = =  = \n");

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            n6.next = null;

            Console.WriteLine("n1.next :" + n1.next);
            Console.WriteLine("n2.next :" + n2.next);
            Console.WriteLine("n3.next :" + n3.next);
            Console.WriteLine("n4.next :" + n4.next);
            Console.WriteLine("n5.next :" + n5.next);
            Console.WriteLine("n6.next :" + n6.next);


            Console.WriteLine("++++++++++++++++++++++++++");
            n1.next.displayANode();

            n2.displayANode();
            n3.displayANode();
            n4.displayANode();
            n5.displayANode();
            n6.displayANode();

            Console.WriteLine("++++++++++++++++++++++++++");




            Console.WriteLine("===========================");


            LinkedList theLinkedList = new LinkedList();

            // Insert Link and add a reference to the name Link added just prior
            // to the field next
            theLinkedList.prepend(0, "O");

            theLinkedList.append(1, "A");
            theLinkedList.prepend(2, "B");
            theLinkedList.append(3, "C");
            theLinkedList.prepend(4, "D");
            theLinkedList.append(5, "E");


            theLinkedList.displayAllNodes();

            Console.WriteLine("Value of first in LinkedList " + theLinkedList.head + "\n");

            // Removes the last Link entered

            theLinkedList.removeFirst();

            theLinkedList.displayAllNodes();

            Console.WriteLine(theLinkedList.findByName("C").name + " Was Found");

            //		theLinkedList.removeByName("B");
            theLinkedList.removeById(2);
            Console.WriteLine("\nB Removed\n");

            theLinkedList.displayAllNodes();

            Console.ReadKey();
        }
    }
}
