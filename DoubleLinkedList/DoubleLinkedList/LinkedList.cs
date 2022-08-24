using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class LinkedList
    {
        public Node head;

        public void InsertFirst(int value)
        {
            if (head == null)
            {
                Node newItem = new Node();
                newItem.value = value;
                head = newItem;
            }
            else
            {
                Node newItem = new Node();
                newItem.value = value;

                Node temp = head;

                head = newItem;
                head.next = temp;
                temp.prev = head;
            }
        }

        public void InsertAfter(int value, int after)
        {

            Node node = head;
            while (node != null)
            {
                if (node.next == null && node.value != after)
                {
                    Console.WriteLine("There is no such item!");
                    return;
                }
                else if (node.value == after)
                {
                    Node temp = node.next;

                    Node newItem = new Node();
                    newItem.value = value;
                    newItem.next = temp;
                    newItem.prev = node;

                    node.next = newItem;

                    if (node.next != null)
                    {
                        node.next.prev = newItem;
                    }
                    return;
                }

                node = node.next;
            }
        }

        public void InsertLast(int value)
        {
            Node node = head;
            while (node.next != null)
            {
                node = node.next;
            }

            Node newItem = new Node();
            newItem.value = value;

            node.next = newItem;
            newItem.prev = node;
            newItem.next = null;
        }

        public void DeleteFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The linkedList is empty!");
            }
            else
            {
                head = head.next;
            }
        }

        public void Delete(int value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.next == null && node.value != value)
                {
                    Console.WriteLine("errorrrorr delelte af");
                    return;
                }
                else if (node.next.next == null)
                {
                    node.next = null;
                }
                else if (node.value == value)
                {
                    node.prev.next = node.next;
                    node.next.prev = node.prev;

                    node = null;
                    return;
                }

                node = node.next;
            }
        }

        public void DeleteLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The linkedList is empty!");
            }
            else
            {
                Node node = head;
                if (node.next == null)
                {
                    head = null;
                }
                else
                {
                    while (node.next.next != null)
                    {
                        node = node.next;
                    }

                    node.next = null;
                }

            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The linkedList is empty!");
            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    Console.WriteLine(node.value);
                    node = node.next;
                }
            }
        }

        public bool IsExist(int value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == value)
                {
                    return true;
                }

                node = node.next;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
