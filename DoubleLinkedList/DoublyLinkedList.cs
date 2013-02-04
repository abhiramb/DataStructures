using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLinkedList
{
    public class DoublyLinkedList
    {
        private DoubleNode head;
        private DoubleNode tail;
        private int count;

        public DoublyLinkedList()
        {
            head = new DoubleNode();
            tail = new DoubleNode();
            head.Name = "Head";
            head.prev = null;
            head.next = tail;
            tail.prev = head;
            tail.Name = "Tail";
            tail.next = null;
            count = 0;
        }

        public bool InsertAtHead(string n)
        {
            DoubleNode node = new DoubleNode();
            node.Name = n;

            node.next = head.next;
            node.next.prev = node;
            node.prev = head;
            head.next = node;
            count++;
            return true;
        }

        public bool InsertAtTail(string n)
        {
            DoubleNode node = new DoubleNode();
            node.Name = n;

            node.next = tail;
            node.prev = tail.prev;
            node.prev.next = node;
            tail.prev = node;
            count++;
            return true;
        }

        public bool InsertAtPosition(int pos, string n)
        {
            if (pos <= count)
            {
                DoubleNode cur = head;
                DoubleNode newNode = new DoubleNode();
                newNode.Name = n;
                while (pos >= 0 && cur != tail)
                {
                    cur = cur.next;
                    pos--;
                }
                newNode.next = cur;
                newNode.prev = cur.prev;
                cur.prev.next = newNode;
                count++;
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool InsertBefore(string ToFind, string n)
        {
            DoubleNode cur = head;

            while (cur != tail)
            {
                if (cur.Name == ToFind)
                {
                    DoubleNode newNode = new DoubleNode();
                    newNode.Name = n;

                    newNode.next = cur;
                    newNode.prev = cur.prev;
                    cur.prev.next = newNode;
                    count++;
                    return true;
                }
                else
                {
                    cur = cur.next;
                }
            }
            cur = null;
            return false;
        }

        public bool InsertAfter(string ToFind, string n)
        {
            DoubleNode cur = head;
            
            while (cur != tail)
            {
                if (cur.Name == ToFind)
                {
                    DoubleNode newNode = new DoubleNode();
                    newNode.Name = n;
                    newNode.next = cur.next;
                    newNode.prev = cur;
                    cur.next = newNode;
                    count++;
                    return true;
                }
                else
                {
                    cur = cur.next;
                }
            }
            cur = null;
            return false;
        }

        public bool RemoveNode(string n)
        {
            DoubleNode cur = head;
            while (cur != tail)
            {
                if (cur.Name == n)
                {
                    cur.prev.next = cur.next;
                    cur.next.prev = cur.prev;
                    cur = null;
                    count--;
                    return true;
                }
                else
                {
                    cur = cur.next;
                }
            }
            cur = null;
            return false;
        }

        public void PrintFromHead()
        {
            if (head.next != null && head.next != tail)
            {
                DoubleNode cur = head.next;
                Console.WriteLine(cur.Name);
                while (cur.next != tail)
                {
                    cur = cur.next;
                    Console.WriteLine(cur.Name);
                }
                cur = null;
            }
        }

        public void PrintFromTail()
        {
            if (tail.prev != null && tail.prev != head)
            {
                DoubleNode cur = tail.prev;
                Console.WriteLine(cur.Name);
                while (cur.prev != head)
                {
                    cur = cur.prev;
                    Console.WriteLine(cur.Name);
                }
                cur = null;
            }
        } 
    }
}
