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
            queue.Enqueue("Name1", Priority.Low);
            queue.Enqueue("Name2", Priority.Low);
            queue.Enqueue("Name3", Priority.Low);
            queue.Enqueue("Name4", Priority.Low);
            queue.Enqueue("Name5", Priority.Low);
            queue.Enqueue("Name6", Priority.Low);
            queue.Enqueue("Name7", Priority.Low);
            queue.Enqueue("Name8", Priority.Low);
            queue.Enqueue("Name9", Priority.Low);
            Console.WriteLine("There are " + queue.Length + " people in line.");
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
            queue.Dequeue();
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
            queue.Dequeue();
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
            queue.Enqueue("Name10", Priority.Medium);
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
            queue.Enqueue("Name11", Priority.Medium);
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
            queue.Dequeue();
            queue.Enqueue("Dad", Priority.High);
            Console.WriteLine("Person in front: " + queue.PeekAtFrontName() + " with priority " + queue.PeekAtFrontPriority());
        }
    }
}
