using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace MyDataStructures
{
    public interface iLinkedList<T>
    {
        //Default Add  method, adds an object to the back of the list by default
        public void AddBack(T data);

        //Add Front Method, Adds an object to the front of the list
        public void AddFront(T data);

        //Clears all the items in the LinkedList
        public void clearList();
        
        //Returns the number of elements in the linked list
        public int Size();
    }
    class LinkedList <T> : iLinkedList<T> where T : IComparable
    {
        //Linked list Node
        public class linkedNode
        {
            public T data;
            public linkedNode next;
            public linkedNode prev;
        }

        int size;
        linkedNode head;
        linkedNode tail;

        public delegate void Insert(T data);

        //Default constructor 
        public LinkedList()
        {
            size = 0;
        }
        //Adds an object to the linkedList but uses delegates to determin what type of Add operation, AddBack or AddFront
        public void Add(T data)
        {
            Insert addType;
            char type;
            Console.Write("To add to back eneter b, else to add to the front eneter f:  ");
            type = Convert.ToChar(Console.ReadLine());
            type = char.ToLower(type);

            switch (type)
            {
                case 'b':
                    {
                        addType = AddBack;
                        addType(data);
                        break;
                    }
                case 'f':
                    {
                        addType = AddFront;
                        addType(data);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invlaid option entered.");
                        break;
                    }
            }
        }
        //AddBack implentation
        //O(N), where n is the number size of the linkedList
        //Returns void
        public void AddBack(T data)
        {
            if(head==null)
            {
                head = new linkedNode();
                head.data = data;
            }
            else
            {
                linkedNode current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new linkedNode();
                current.next.data = data;
                current.next.prev = current;
                tail = current.next;
            }
        }

        //AddFront implentation
        //O(N), where n is the number size of the linkedList
        //Returns void
        public void AddFront(T data)
        {
            if(tail==null)
            {
                tail = new linkedNode();
                tail.data = data;
            }
            else
            {

            }
        }

        //Clears the list
        //O(1)
        //Returns void
        public void clearList()
        {
            head = null;
            tail = null;
        }

        //Returns the number of items in the list
        //O(1)
        //Returns an integer
        public int Size()
        {
            return size;
        }

        //Checks if the linked list contains some data/object
        //O(N), where n is the number size of the linkedList
        //Returns true if the object is in the list, false if it is not
        public bool contains(T data) 
        {
            linkedNode current = head;
            while (current.next != null)
            {
                if(data.Equals(current.data))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        //Searches for some data/object in the LinkedList
        //O(N), where n is the number size of the linkedList
        //Returns the object if it is found else returns default T
        public T search(T data)
        {
            linkedNode current = head;
            while (current.next != null)
            {
                if (data.Equals(current.data))
                {
                    return current.data;
                }
                current = current.next;
            }
            return default(T);
        }
        //Searches for some data/object in the LinkedList
        //O(N), where n is the number size of the linkedList
        //Returns the object if it is found else returns default T
        public void printList()
        {
            linkedNode current = head;
            int i = 0;
            while(current.next != null)
            {
                Console.WriteLine("{0}. {1}", i++, current.data);
                current = current.next;
            }
        }
    }
}
