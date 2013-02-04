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

        public PriorityQueue()
        {
            front = new Node();
            rear = new Node();
        }
    }    
}
