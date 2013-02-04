using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue
{    
    public class PriorityQueue
    {
        private Node front;
        private Node rear;
        private int length;

        public PriorityQueue()
        {
            front = new Node();
            rear = new Node();
            length = 0;
        }

        public bool Dequeue()
        {
            if (length > 0)
            {

                length--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Enqueue(string name, Priority priority)
        {
            Node node = new Node();
            node.name = name;
            node.priority = priority;

            if (length == 0)
            {
                front.next = node;
                rear.next = node;
            }
            else
            {
                
            }

            length++;
            return true;
        }

        public string PeekAtFront()
        {
            return "";
        }
    }    
}
