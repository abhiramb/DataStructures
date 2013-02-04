using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtQueue queue = new ArtQueue();
            queue.Enqueue("Arthur");
            queue.Enqueue("Shelley");
            queue.Enqueue("Katie");
            Console.WriteLine("There are " + queue.Length + " people in line. " + queue.PeekAtFront() + " is in front.");
            queue.Dequeue();
            Console.WriteLine("There are " + queue.Length + " people in line. " + queue.PeekAtFront() + " is in front.");
            queue.Dequeue();
            Console.WriteLine("There are " + queue.Length + " people in line. " + queue.PeekAtFront() + " is in front.");
            queue.Dequeue();
            Console.WriteLine("There are " + queue.Length + " people in line. " + queue.PeekAtFront() + " is in front.");

        }
    }
}
