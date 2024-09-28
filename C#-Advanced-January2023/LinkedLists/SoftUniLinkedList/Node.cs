using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniLinkedList
{
     public class Node
    {
        public Node(int value, Node next = null, Node previous =null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }

        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }
}
