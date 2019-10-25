using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDoublyLinkedList
{
    class DoublyLinkedList
    {

        private Node head;
        private Node tail;
        public int Size;

        public DoublyLinkedList()
        {
            head = null;  // null head initialization
            tail = null;  // null head initialization
            Size = 0;
        }

        public int size()
        {
            return Size;
        }

        public bool isEmpty()
        {
            return (Size == 0);
        }

        /**
         * adds element at the front of the linked list
         */
        public void prepend(int id, String name)
        {
            Node tmp = new Node(id, name, head, null);
            if (head != null) { head.prev = tmp; }
            head = tmp;
            if (head == null) { tail = tmp; }
            Size++;
            Console.WriteLine("prepending id: " + id + " name: " + name);
        }

        /**
         * adds element at the end of the linked list
         */
        public void append(int id, String name)
        {

            Node tmp = new Node(id, name, null, tail);
            if (tail != null) { tail.next = tmp; }
            tail = tmp;
            if (head == null) { head = tmp; }
            Size++;
            Console.WriteLine("appending id: " + id + " name: " + name);
        }

        /**
         * displays all nodes of the linked list
         */
        public void displayAllNodes()
        {
            Node theNode = head;
            // Start at the reference stored in head and
            // keep getting the references stored in next for
            // every Link until next returns null

            Console.WriteLine("Displaying all nodes ..... ");

            while (theNode != null)
            {
                theNode.displayANode();
                Console.WriteLine("Previous node: " + theNode.prev + "\t Next node: " + theNode.next);
                theNode = theNode.next;
                Console.WriteLine();
            }

        }


        /**
         * this method walks forward through the linked list
         */
        public void iterateForward()
        {

            Console.WriteLine("Iterating forward.....");
            Node tmp = head;
            while (tmp != null)
            {
                //            System.out.println(tmp.element);
                Console.WriteLine("iterateForward id: " + tmp.id + "+ name: " + tmp.name);
                tmp = tmp.next;
            }
        }

        /**
         * this method walks backward through the linked list
         */
        public void iterateBackward()
        {

            Console.WriteLine("Iterating backword.....");
            Node tmp = tail;
            while (tmp != null)
            {
                //            System.out.println(tmp.element);
                Console.WriteLine("iterateBackward id: " + tmp.id + "+ name: " + tmp.name);
                tmp = tmp.prev;
            }
        }

        /**
         * this method removes element from the start of the linked list
         */
        public void removeFirst()
        {
            if (Size == 0)
                return;
                //throw new NoSuchElementException();
            Node tmp = head;
            head = head.next;
            head.prev = null;
            Size--;
            Console.WriteLine("removeFirst id: " + tmp.id + "+ name: " + tmp.name);

        }

        /**
         * this method removes element from the end of the linked list
         * @return
         */
        public void removeLast()
        {
            if (Size == 0) return;
            //throw new NoSuchElementException();
            Node tmp = tail;
            tail = tail.prev;
            tail.next = null;
            Size--;
            Console.WriteLine("removeFirst id: " + tmp.id + "+ name: " + tmp.name);

        }
    }
}
