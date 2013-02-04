using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularList
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList list = new CircularLinkedList("Head");
            list.AddNode("Arthur");
            list.AddNode("Shelley");
            list.AddNode("Jon");
            list.AddNode("Mel");
            list.AddNode("Jenny");
            list.PrintNodes();
            Console.WriteLine("Shelley: " + list.FindNodes("Shelley"));
            Console.WriteLine("Katie: " + list.FindNodes("Katie"));
            Console.WriteLine("Remove Jon: " + list.RemoveNode("Jon"));
            list.PrintNodes();
        }
    }
}
