using System;

namespace LinkedListProblems
{
    public class NodeL
    {
        public int Data { get; set; }

        public NodeL Prev { get; set; }

        public NodeL Next { get; set; }
    }

    public class DoubleLinkedList
    {
        public NodeL Head { get; set; }

        public void InsertAtHead(int data)
        {
            Console.WriteLine("Inserting " + data);
            var node = new NodeL() { Data = data };
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public void DeleteHead()
        {
            if (Head == null)
                throw new Exception("Empty List!!!");
            Console.WriteLine("Deleting head");
            Head = Head.Next;
        }

        public void Print()
        {
            var list = Head;
            while (list != null)
            {
                Console.Write(list.Data + " ");
                list = list.Next;
            }
            Console.WriteLine("");
        }
    }

    public class DoublyLinkedListOperations
    {
        private static void MainDL(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();
            list.InsertAtHead(1);
            list.Print();
            list.InsertAtHead(3);
            list.Print();
            list.InsertAtHead(5);
            list.Print();
            list.InsertAtHead(7);
            list.Print();
            list.DeleteHead();
            list.Print();
            list.DeleteHead();
            list.Print();
        }
    }
}