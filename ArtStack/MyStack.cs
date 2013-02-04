using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtStack
{
    public class MyStack
    {
        private Node TopOfStack;
        private int size;

        public MyStack()
        {
            TopOfStack = new Node();
            size = 0;
        }

        public void SetTopNumber(int num)
        {
            TopOfStack.next.num = num;
        }

        public void Push(int num)
        {
            Node newNode = new Node();
            newNode.num = num;
            newNode.next = TopOfStack.next;
            TopOfStack.next = newNode;
            size++;
        }

        public void Pop()
        {
            if (TopOfStack.next != null)
            {
                Node newNode = TopOfStack;
                newNode = newNode.next;
                if (newNode.next != null)
                {
                    newNode = newNode.next;
                    TopOfStack.next = newNode;
                }
                else
                {
                    TopOfStack.next = null;
                }
                size--;
            }
        }

        public void Peek()
        {
            if (TopOfStack.next != null)
            {
                Console.WriteLine(TopOfStack.next.num);
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }

        public int Height
        {
            get { return size; }
        }
    }
}
