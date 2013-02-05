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

        public string Dequeue()
        {
            if (length > 0)
            {
                if (length > 1)
                {
                    string frontName = front.next.name;
                    Node cur = rear.next;

                    while (cur.next != front.next)
                    {
                        cur = cur.next;
                    }

                    front = new Node();
                    cur.next = null;
                    front.next = cur;
                    cur = null;
                    length--;
                    return frontName;
                }
                else
                {
                    string frontName = front.next.name;
                    front.next = null;
                    rear.next = null;
                    length--;
                    return frontName;
                }
            }
            else
            {
                return "";
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
                if (node.priority > rear.next.priority)
                {
                    Node cur = rear.next;
                    while (cur.next != null && node.priority > cur.next.priority)
                    {
                        cur = cur.next;
                    }
                    if (cur.next == null) //we've reached the front
                    {
                        cur.next = node;
                        front.next = node;
                    }
                    else
                    {
                        node.next = cur.next;
                        cur.next = node;
                    }
                }
                else
                {
                    node.next = rear.next;
                    rear.next = node;
                }
            }
            length++;
            return true;
        }

        public string PeekAtFrontName()
        {
            if (front.next != null)
            {
                return front.next.name;
            }
            else
            {
                return "";
            }
        }

        public int PeekAtFrontPriority()
        {
            if (front.next != null)
            {
                return (int)front.next.priority;
            }
            else
            {
                return -1;
            }
        }
    }    
}
