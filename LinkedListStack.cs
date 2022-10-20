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
        
        public void Display()
        {
            Console.WriteLine("Item in the stack");
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
