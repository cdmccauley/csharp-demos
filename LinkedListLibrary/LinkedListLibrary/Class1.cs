using System;

namespace LinkedListLibrary
{
    public class ListNode
    {
        public object Data { get; private set; }

        public ListNode Next { get; set; }

        public ListNode(object dataValue) : this(dataValue, null)
        {
        }

        public ListNode(object dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }

        public class List
        {
            private ListNode firstNode;
            private ListNode lastNode;
            private string name;

            public List(string listName)
            {
                name = listName;
                firstNode = lastNode = null;
            }

            public List() : this("list")
            {
            }

            public void InsertAtFront(object insertItem)
            {
                if (IsEmpty())
                    firstNode = lastNode = new ListNode(insertItem);
                else
                    firstNode = new ListNode(insertItem, firstNode);
            }

            public void InsertAtBack(object insertItem)
            {
                if (IsEmpty())
                    firstNode = lastNode = new ListNode(insertItem);
                else
                    lastNode = lastNode.Next = new ListNode(insertItem);
            }

            public object RemoveFromFront()
            {
                if (IsEmpty())
                    throw new EmptyListException(name);

                object removeItem = firstNode.Data;

                if (firstNode == lastNode)
                    firstNode = lastNode = null;
                else
                    firstNode = firstNode.Next;

                return removeItem;
            }

            public object RemoveFromBack()
            {
                if (IsEmpty())
                    throw new EmptyListException(name);

                object removeItem = lastNode.Data;

                if (firstNode == lastNode)
                    firstNode = lastNode = null;
                else
                {
                    ListNode current = firstNode;

                    while (current.Next != lastNode)
                        current = current.Next;

                    lastNode = current;
                    current.Next = null;
                }

                return removeItem;
            }

            public bool IsEmpty()
            {
                return firstNode == null;
            }

            public void Display()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Empty " + name);
                }
                else
                {
                    Console.Write("The " + name + " is: ");

                    ListNode current = firstNode;

                    while (current != null)
                    {
                        Console.Write(current.Data + " ");
                        current = current.Next;
                    }

                    Console.WriteLine("\n");
                }
            }
        }

        public class EmptyListException : Exception
        {
            public EmptyListException() : base("The list is empty")
            {
            }

            public EmptyListException(string name) : base("The " + name + " is empty")
            {
            }

            public EmptyListException(string exception, Exception inner) : base(exception, inner)
            {
            }
        }
    }
}
