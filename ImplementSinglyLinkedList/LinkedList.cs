using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementSinglyLinkedList
{
    public class LinkedList
    {
        // Reference to head in list
        // The last Link added to the LinkedList
      public Node head;

       public LinkedList()
        {   // Optional 
            head = null;  // null initialization
                          // Here to show the head always starts as null
        }

        // Returns true if LinkList is empty

        public Boolean isEmpty()
        {
            return (head == null);

        }

        public void prepend(int id, String name)
        {
            if (head == null)
            {
                head = new Node(id, name);
                return;
            }
            Node newHead = new Node(id, name);
            // Connects the head field to the newHead 
            newHead.next = head;
            //		newHead.setNext(head);  // If you use setter
            head = newHead;
        }


        public void append(int id, String name)
        {
            if (head == null)
            {
                head = new Node(id, name);
                return;
            }
            Node currentNode = head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = new Node(id, name);
        }


        public Node removeFirst()
        {

            Node deleteLink = head;

            if (!isEmpty())
            {

                // Removes the Link from the List

                head = head.next;

            }
            else
            {

                Console.WriteLine("Empty LinkedList");

            }

            return deleteLink;

        }

        public void displayAllNodes()
        {

            Node theNode = head;

            // Start at the reference stored in head and
            // keep getting the references stored in next for
            // every Link until next returns null

            while (theNode != null)
            {

                theNode.displayANode();

                Console.WriteLine("Next Link: " + theNode.next);

                theNode = theNode.next;

                Console.WriteLine();

            }

        }

        public Node findById(int id)
        {

            Node theNode = head;

            if (!isEmpty())
            {

                while (theNode.id != id)
                {

                    // Checks if at the end of the LinkedList

                    if (theNode.next == null)
                    {

                        // Got to the end of the Links in LinkedList
                        // without finding a match

                        return null;

                    }
                    else
                    {

                        // Found a matching Link in the LinkedList

                        theNode = theNode.next;

                    }

                }

            }
            else
            {

                Console.WriteLine("Empty LinkedList");

            }

            return theNode;

        }


        public Node findByName(String name)
        {

            Node theLink = head;

            if (!isEmpty())
            {

                while (theLink.name != name)
                {

                    // Checks if at the end of the LinkedList

                    if (theLink.next == null)
                    {

                        // Got to the end of the Links in LinkedList
                        // without finding a match

                        return null;

                    }
                    else
                    {

                        // Found a matching Link in the LinkedList

                        theLink = theLink.next;

                    }

                }

            }
            else
            {

                Console.WriteLine("Empty LinkedList");

            }

            return theLink;

        }

        public Node removeById(int id)
        {


            Node currentLink = head;
            Node previousLink = head;

            // Keep searching as long as a match isn't made

            while (currentLink.id != id)
            {

                // Check if at the last Link in the LinkedList

                if (currentLink.next == null)
                {

                    // id not found so leave the method

                    return null;

                }
                else
                {

                    // We checked here so let's look in the
                    // next Link on the list

                    previousLink = currentLink;

                    currentLink = currentLink.next;

                }

            }

            if (currentLink == head)
            {

                // If you are here that means there was a match
                // in the reference stored in head in the
                // LinkedList so just assign next to head

                head = head.next;

            }
            else
            {

                // If you are here there was a match in a Link other 
                // than the head. Assign the value of next for
                // the Link you want to delete to the Link that's 
                // next previously pointed to the reference to remove

                Console.WriteLine("FOUND A MATCH");
                Console.WriteLine("currentLink: " + currentLink);
                Console.WriteLine("head: " + head);
                previousLink.next = currentLink.next;

                //			previousLink.setNext(currentLink.next);  // If use getter and setter

            }

            return currentLink;

        }


        public Node removeByName(String name)
        {
            Node currentNode = head;
            Node previousNode = head;

            // Keep searching as long as a match isn't made

            while (currentNode.name != name)
            {
                // Check if at the last Link in the LinkedList

                if (currentNode.next == null)
                {

                    // Name not found so leave the method
                    return null;

                }
                else
                {

                    // We checked here so let's look in the
                    // next Link on the list

                    previousNode = currentNode;

                    currentNode = currentNode.next;

                }

            }

            if (currentNode == head)
            {

                // If you are here that means there was a match
                // in the reference stored in head in the
                // LinkedList so just assign next to head

                head = head.next;

            }
            else
            {

                // than the head. Assign the value of next for
                // the node you want to delete to the node that's 
                // next previously pointed to the reference to remove

                Console.WriteLine("Name found:");
                Console.WriteLine("currentNode: " + currentNode);
                Console.WriteLine("head: " + head);
                previousNode.next = currentNode.next;

                //			previousNode.setNext(currentNode.next);  // If use getter and setter

            }

            return currentNode;

        }

    }

}
