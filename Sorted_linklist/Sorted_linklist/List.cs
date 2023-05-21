using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_linklist_0
{
    class List
    {
        Node head;
        Node next;
        public void AddSorted(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                next = n;
            }
            else
            {
                if (n.data <= head.data)
                {
                    AddFirst(n);
                }
                else if (n.data >= next.data)
                {
                    AddLast(n);
                }
                else
                {
                    Node temp = head;
                    while (n.data > temp.data)
                    {
                        temp = temp.next;
                    }
                    AddBefore(n, temp);
                }
            }
        }
        private void AddFirst(Node insert)
        {
            Node temp = head;
            head = insert;
            head.next = temp;
            head.next.prev = head;
        }
        private void AddLast(Node insert)
        {
            Node temp = next;
            next = insert;
            next.prev = temp;
            next.prev.next = next;
        }
        private void AddBefore(Node insert, Node nextNode)
        {
            Node temp = nextNode.prev;
            nextNode.prev = insert;
            nextNode.prev.prev = temp;
            nextNode.prev.prev.next = nextNode.prev;
            nextNode.prev.next = nextNode;
        }
        public void Print()
        {
            Console.WriteLine("Output");
            if (head != null)
            {
                Node temp = head;
                temp.Print();
                while (temp.next != null)
                {
                    temp = temp.next;
                    temp.Print();
                }
            }
        }
    }
}
