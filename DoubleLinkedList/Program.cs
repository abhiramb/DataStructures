using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.InsertAtHead("Arthur");
            list.InsertAtHead("Katie");
            list.InsertAtPosition(2, "Shelley");
            list.PrintFromHead();            
        }
    }
}
