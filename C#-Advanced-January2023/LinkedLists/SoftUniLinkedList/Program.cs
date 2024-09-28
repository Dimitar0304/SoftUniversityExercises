using System;

namespace SoftUniLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node node = new Node(1);
            //Node node2 = new Node(2);
            //Node node3 = new Node(3);
            //Node node4 = new Node(4);
            //Node node5 = new Node(5);

            //node.Next = node2;
            //node2.Next = node3;
            //node3.Next = node4;
            //node4.Next = node5;

            //node5.Previous = node4;
            //node4.Previous = node3;
            //node3.Previous = node2;
            //node2.Previous = node;

            SoftUniLinkedList linkedList = new SoftUniLinkedList();

            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);



            int[] result = linkedList.ToArray();
            Console.WriteLine(string.Join(" ",result));


            linkedList.ForEach(e => Console.WriteLine(e));

        }
    }
}
