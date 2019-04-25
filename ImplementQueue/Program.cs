using System;

namespace ImplementQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Queue Implementation Explained ....... ");

            Queue myq = new Queue();

            myq.enQueue(1, "AA");
            Console.WriteLine("myq.top = " + myq.top);
            Console.WriteLine("myq.tail = " + myq.tail);

            Console.WriteLine("myq.top.next = " + myq.top.next);
            Console.WriteLine("myq.tail.next = " + myq.tail.next);

            myq.enQueue(2, "BB");

            Console.WriteLine("myq.top = " + myq.top);
            Console.WriteLine("myq.tail = " + myq.tail);

            Console.WriteLine("myq.top.next = " + myq.top.next);
            Console.WriteLine("myq.tail.next = " + myq.tail.next);

            myq.enQueue(3, "CC");
            myq.enQueue(4, "DD");
            myq.enQueue(5, "EE");


            myq.displayAllNodes();

            myq.peek();

            myq.deQueue();
            myq.deQueue();
            myq.deQueue();
            myq.deQueue();
            myq.deQueue();
            myq.deQueue();
            myq.deQueue();
            myq.deQueue();

            myq.displayAllNodes();
            Console.ReadKey();
        }
    }
}
