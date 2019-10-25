using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            DoublyLinkedList dll = new DoublyLinkedList();
            Console.WriteLine(dll.size());

            dll.append(1, "A");
            dll.append(2, "B");
            dll.prepend(3, "C");
            dll.append(4, "D");
            dll.append(5, "E");

            dll.displayAllNodes();

            dll.iterateForward();
            dll.removeFirst();
            dll.removeLast();
            dll.iterateBackward();
            Console.ReadKey();

        }
    }

}
