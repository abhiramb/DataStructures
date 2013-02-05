using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue queue = new PriorityQueue();
            queue.Enqueue("Arthur", Priority.Low);
            queue.Enqueue("Matt", Priority.Low);
            queue.Enqueue("Chris", Priority.Low);
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
            queue.Dequeue();
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
            queue.Dequeue();
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
            queue.Enqueue("Shelley", Priority.Medium);
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
            queue.Enqueue("Drew", Priority.Medium);
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
            queue.Dequeue();
            queue.Enqueue("Dad", Priority.High);
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
        }
    }
}
