using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class List
    {
        private Node head;
        private Node tail;
        public List()
        {
            head = null;
        }
        public void Insert(int data)
        {
            Node newNode = new Node(data);

            // 1. Ematy Linked List . HEAd is null
            if (head == null)
            {
                head = newNode;
            }
            // 2. When item is data added at the end.
            else
            {
                Node currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }
        }
        public void Display()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
        public void Delete(int data)
        {
            //1. Data is null
            if (head == null)
            {
                Console.WriteLine("Linked List is empty. ");
                return;
            }
            //2. Head is not null
            else
            {
                //a. Delete Head
                if (head.data == data)
                {
                    head = head.next;
                }
                else
                {
                    Node prevNode = null;
                    Node currentNode = head;
                    while (currentNode.next != null && currentNode.data != data)
                    {
                        prevNode = currentNode;
                        currentNode = currentNode.next;
                    }
                    if (currentNode == null)
                    {
                        Console.WriteLine("Data not found in the linked list");
                        return;
                    }
                    prevNode.next = currentNode.next;
                }
            }
        }

        //Task 1: Add functionality to insert new node at any point.
        public void insertNewNode(int data, int position)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            newNode.next = null;

            if (position < 0)
            {
                Console.WriteLine("Position should more than 0 ");
                return;
            }
            else if (position == 0)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node currentNode = new Node(data);
                currentNode = head;
                for (int i = 0; i < position - 1; i++)
                {
                    if (currentNode == null)
                    {
                        currentNode = head;
                    }
                    currentNode = currentNode.next;
                }
                if (currentNode != null)
                {
                    newNode.next = currentNode.next;
                    currentNode.next = newNode;
                }
                else
                {
                    Console.WriteLine("The previous node is null.");
                }
            }

        }

        //Task 2: Add functionality to find data, return node position.
        public int findData(int data)
        {
            Node currentNode = head;
            int position = 0;
            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    Console.Write("The position of the node contain data " + data + " is: ");
                    return position;
                }
                currentNode = currentNode.next;
                position++;
            }
            return -1;
        }
    }
}
