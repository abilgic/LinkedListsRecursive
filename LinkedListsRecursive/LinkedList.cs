using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsRecursive
{
    public class LinkedList
    {
        public Node root;

        public class Node
        {
            public int Data;
            public Node(int Data) { this.Data = Data; }
            public Node next;
        }

        public Node Insert(Node head, int Data)
        {
            if (head == null)
            {
                var newnode = new Node(Data);
                head = newnode;
                return newnode;
            }
            else
            {
                head.next = Insert(head.next, Data);
                return head;

            }
        }

        public void Print(Node head)
        {
            if (head == null)
                return;
            Console.Write($"{head.Data} ");
            Print(head.next);
        }
    }


}
