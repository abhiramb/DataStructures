using System;
using System.Text;

namespace CircularList
{    
    public class CircularLinkedList
    {
        public Node head;

        public CircularLinkedList()
        {
            head = new Node();
            head.Name = "Head Node";
        }

        public CircularLinkedList(string n)
        {
            head = new Node();
            head.Name = n;
        }

        public void AddNode(string n)
        {
            Node node = new Node();
            node.Name = n;

            Node cur = head;
            while (cur.next != head && cur.next != null)
            {
                cur = cur.next;
            }
            node.next = head;
            cur.next = node;
        }

        public void PrintNodes()
        {
            Node cur = head;
            while (cur.next != head && cur.next != null)
            {
                Console.WriteLine(cur.Name);
                cur = cur.next;
            }
            Console.WriteLine(cur.Name);
        }

        public bool FindNodes(string n)
        {
            Node cur = head;
            while (cur.next != head)
            {
                if (cur.Name == n)
                {
                    return true;
                }
                cur = cur.next;
            }
            if (cur.Name == n)
            {
                return true;
            }
            return false;
        }

        public bool RemoveNode(string n)
        {
            Node cur = head;
            Node prev = head;
            while (cur.next != head && cur.Name != n)
            {
                cur = cur.next;
                if (cur.Name == n)
                {
                    cur = cur.next;
                    prev.next = cur;
                    return true;
                }
                else
                {
                    prev = prev.next;
                }                
            }
            return false;
        }
    }
}
