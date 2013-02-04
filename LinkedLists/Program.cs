using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList("Arthur");            
            list.AddNewNode("Shelley");
            list.AddNewNode("Chris");
            list.AddNewNode("jkfdljfls");
            list.AddNewNode("Karen");
            list.AddNewNode("fkdljasf");
            list.PrintNodes();
            Console.WriteLine("\nList contains " + list.Length + " nodes");
            Console.WriteLine("Node \"Chris\" found: " + list.FindNode("Chris"));
            Console.WriteLine("Removing \"jkfdljfls\"");
            list.RemoveNode("jkfdljfls");
            Console.WriteLine("\nList contains " + list.Length + " nodes");
            list.PrintNodes();

            Console.WriteLine("Removing \"fkdljasf\"");
            list.RemoveNode("fkdljasf");
            Console.WriteLine("\nList contains " + list.Length + " nodes");
            list.PrintNodes();
            Console.WriteLine("***************Singly linked list code all done.***************\n");
        }
    }
}
