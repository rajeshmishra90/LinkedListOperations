namespace LinkedListProblems
{
    internal class LinkedListI : LinkedListProblems.LinkedList
    {
        public void InsertAt(int index, int data)
        {
            System.Console.WriteLine($"Insert at {index} : {data}");
            var newNode = new Node() { Data = data, Next = null };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            var node = Head;
            if (index == 1)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }
            var currentNode = Head;
            for (int i = 1; i < index; i++)
            {
                currentNode = node;
                node = node.Next;
            }

            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;
            Head = currentNode;
        }

        public void DeleteAt(int index)
        {
            System.Console.WriteLine($"Delete at {index}");
            if (Head == null)
            {
                throw new System.Exception("No nodes found!!");
            }
            var node = Head;
            if (index == 1)
            {
                Head = Head.Next;
                return;
            }
            var currentNode = Head;
            for (int i = 1; i < index; i++)
            {
                currentNode = node;
                node = node.Next;
            }
            
            currentNode.Next = node.Next;
        }
    }

    public class LinkedListIndexedBased
    {
        private static void MainLI(string[] args)
        {
            LinkedListI list = new LinkedListI();
            list.Insert(10);
            list.Print();
            list.Insert(60);
            list.Print();
            list.Insert(90);
            list.Print();
            list.Insert(30);
            list.Print();
            list.InsertAt(2, 20);
            list.Print();
            list.DeleteAt(1);
            list.Print();
        }
    }
}