using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_linklist
{
    class Linkedlist
    {
        public Node head;
        public Node sorted;

        public void push(int val)
        {
            Node newnode = new Node(val);

            newnode.next = head;

            head = newnode;
        }

        public void insertionSort(Node headref)
        {
            sorted = null;
            Node current = headref;

            while (current != null)
            {
                Node next = current.next;

                sortedInsert(current);

                current = next;
            }

            head = sorted;
        }
        public void sortedInsert(Node newnode)
        {
            if (sorted == null || sorted.data >= newnode.data)
            {
                newnode.next = sorted;
                sorted = newnode;
            }
            else
            {
                Node current = sorted;

                while (current.next != null &&
                        current.next.data < newnode.data)
                {
                    current = current.next;
                }
                newnode.next = current.next;
                current.next = newnode;
            }
        }

        public void printlist(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }
        public Node newNode(int data)
        {
            Node x = new Node(data);
            return x;
        }
    }
}
