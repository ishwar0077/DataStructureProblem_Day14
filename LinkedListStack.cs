using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgramStackAndQueue
{
    public class LinkedListStack
    {
        public Node head;
        //public void Push(int data)
        //{
        //    Add(data);
        //}

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = head;
            }
            head = newNode;
            Console.WriteLine("{0} pushed to stack", data);
        }


        internal void Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack Underflow.");
                return;
            }

            Console.WriteLine("{0} is on the top of Stack", this.head.data);
        }


        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
                return;
            }

            Console.WriteLine("Item popped is {0}", head.data);
            head = head.next;
        }

        internal void IsEmpty()
        {
            while (this.head != null)
            {
                Peek();
                Pop();
            }
        }

            public void Display()
        {
            Console.WriteLine("\nItem in the stack");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
