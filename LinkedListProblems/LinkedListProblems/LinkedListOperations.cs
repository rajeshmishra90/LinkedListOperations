using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedList
    {
        public Node Head { get; set; } = null;

        public void Insert(int d)
        {
            Console.WriteLine("Insert at top : " + d);
            var newNode = new Node() { Data = d, Next = null };
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public void Delete(int d)
        {
            Console.WriteLine("Delete at top: "+d);
            var node = Head;
            Node currNode = Head;
            Node prevNode = null;
            while (node != null)
            {
                currNode = node;
                if (node.Data == d)
                {
                    if(prevNode != null)
                    {
                        prevNode.Next = currNode.Next;
                    }
                    else
                    {
                        Head = Head.Next;
                    }
                    break;
                }
                prevNode = currNode;
                node = node.Next;
            }
        }

        public void Print()
        {
            var list = Head;
            Console.Write("Elements: ");
            while (list != null)
            {
                Console.Write(list.Data + " ");
                list = list.Next;
            }
            Console.WriteLine();
        }
    }
    class LinkedListOperations
    {
        static void MainL(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Print();
            list.Insert(6);
            list.Print();
            list.Insert(8);
            list.Print();
            list.Insert(42);
            list.Print();
            list.Insert(14);
            list.Print();
            list.Insert(54);
            list.Print();
            list.Delete(42);
            list.Print();
            list.Insert(10);
            list.Print();
            Console.Read();
        }
    }
}
