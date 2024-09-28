using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniLinkedList
{
    class SoftUniLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void AddFirst(int value)
        {
            Count++;
             Node node = new Node(value);


            //ako v linked lista nqma nikakvi elementi tekushtiq node e rave i na head i na tail ednovremenno
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            //na noda koito sme suzdali nexta e raven na staria head
            node.Next = Head;
            //na stariat head previousa e noviat node
            Head.Previous = node;
            //noviat head e raven na noviqt node zashtoto e addFirst
            Head = node;
        }
        public void AddLast(int value)
        {
            Count++;
            Node node = new Node(value);

            if (Tail == null)
            {
                Tail = node;
                Head = node;
                return;
            }
            node.Previous = Tail;
            Tail.Next = node;
            Tail = node;
        }
        public void RemoveFirst()
        {
            Count--;
            Node oldHead = Head;
            if (Tail==Head)
            {
                Tail = null;
                Head = null;
            }
            
            Head = Head.Next;
            oldHead.Next = null;
            Head.Previous = null;
        }
        public void RemoveLast()
        {
            Count--;
            Node oldTail = Tail;
            if (Tail == Head)
            {
                Tail = null;
                Head = null;
            }
           
            Tail = Tail.Previous;
            oldTail.Previous = null;
            Tail.Next = null;
           
        }
        public void ForEach(Action<int> callback)
        {
            Node node = Head;
            while (node!=null)
            {

                callback(node.Value);
                node = node.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int index = 0;
            ForEach(e =>array[index++] = e);
            return array;
        }


    }
}
