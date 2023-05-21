using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_linklist
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist list = new Linkedlist();
            list.push(5);
            list.push(20);
            list.push(4);
            list.push(3);
            list.push(30);
            Console.WriteLine("Linked List before Sorting..");
            list.printlist(list.head);
            list.insertionSort(list.head);
            Console.WriteLine("\nLinkedList After sorting");
            list.printlist(list.head);

            Console.ReadKey();
        }
    }
}
