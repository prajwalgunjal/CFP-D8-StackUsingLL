using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLL
{
    internal class Stack<T>
    {
        Node<T> head;
        Node<T> tail;
        public void add(T Data) {
            Node<T> newNode = new Node<T>(Data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }

        public void pop()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty. Cannot pop.");
                return;
            }

            if (head == tail)
            {
                Console.WriteLine("Popped Data: " + head.Data);
                head = null;
                tail = null;
                return;
            }
            Node<T> newNode = head;
            while (newNode.next != tail)
            {
                newNode = newNode.next;
            }
                Console.WriteLine("Popped Data :- " + tail.Data);
                tail = newNode;
                tail.next = null;
            
        }


        public void isEmpty()
        {
            if (head == null)
            {
                Console.WriteLine("Your stack is empty !!!");
            }
            else
            {
                Console.WriteLine("Size of your stack is " +size());
            }
        }

        public int size()
        {
            Node <T> node = head;
            int count = 1;
            if (head == null)
            {
                return 0;
            }
            while (node.next!= null)
            {
                count++;

                node = node.next;
            }
            return  count;
        }

        public void peek()
        {
            Console.WriteLine("Data on top is:- " +tail.Data);
        }
        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("Stack is empty !!!!");
            }
            else
            {
                Node < T > temp = head;
                while(temp != null)
                {
                    Console.Write(temp.Data+" -> ");
                    temp = temp.next;
                }
            }
        }
    }
}
