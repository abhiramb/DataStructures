using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue
{
    public class Node
    {
        public string name;
        public Priority priority;
        public Node next;

        public Node()
        {
            name = "";
            priority = Priority.Low;
        }
    }
}
