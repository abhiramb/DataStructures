using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedLists
{
    public class SingleLinkedList
    {
        public Node head;
        private int listCount;

        public SingleLinkedList()
        {
            head = new Node();
            listCount++;
        }

        public SingleLinkedList(string n)
        {
            head = new Node();
            head.Name = n;
            listCount++;
        }

        public void AddNewNode(string n)
        {
            Node newNode = new Node();

            newNode.Name = n;
            Node cur = head;
            while (cur.next != null)
            {
                cur = cur.next;
            }
            cur.next = newNode;
            listCount++;
        }

        public void PrintNodes()
        {
            Node cur = head;
            while (cur.next != null)
            {
                Console.WriteLine(cur.Name);
                cur = cur.next;                
            }
            Console.WriteLine(cur.Name);
        }

        public bool FindNode(string n)
        {
            Node cur = head;
            while (cur.next != null)
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
            else
            {
                return false;
            }
        }

        public void RemoveNode(string n)
        {
            Node prev = head;
            Node cur = head;
            while (cur.next != null)
            {
                cur = cur.next;
                if (cur.Name == n)
                {
                    if (cur.next != null)
                    {
                        prev.next = cur.next;
                    }
                    else
                    {
                        prev.next = null;
                    }                    
                    listCount--;
                }
                else
                {
                    prev = prev.next;
                }
            }
        }

        public int Length
        {
            get
            {
                return listCount;
            }
        }
    }
}
