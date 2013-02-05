using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queues
{
    public class ArtQueue
    {
        private Node front;
        private Node back;
        private int length;

        public ArtQueue()
        {
            front = new Node();
            back = new Node();
            length = 0;
        }

        public bool Enqueue(string n)
        {
            Node newNode = new Node();
            newNode.name = n;
            if (length > 0)
            {
                newNode.next = back.next;
                back.next = newNode;
            }
            else
            {
                back.next = newNode;
                front.next = newNode;
            }
            length++;
            return true;
        }

        public string Dequeue()
        {
            if (length > 0)
            {
                if (length > 1)
                {
                    string frontName = front.next.name;
                    Node cur = back.next;                   

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
                    back.next = null;
                    length--;
                    return frontName;
                }
            }
            else
            {
                return "";
            }
        }

        public string PeekAtFront()
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

        public int Length
        {
            get { return length; }
        }
    }
}
