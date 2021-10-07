using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{

    class LinkListStack
    {
        /// <summary>
        /// UC1 Create stack 
        /// stack means Last in first out(LIFO)
        /// </summary>
        public Node top;
        public void Push(int  new_Data)
        {
            ///creating a link between newnode and where top is pointing
            ///then pointing top towards the new node 
            ///new node is inserted on the top 

            Node newNode = new Node(new_Data);
            if(this.top != null)
            {
                newNode.next = this.top; //new node will hold the address of top element
            }
            this.top = newNode; //top will point to new element
            Console.WriteLine("new node{0} is added", newNode.data);
        }

        public void Display()
        {
            Console.WriteLine("Displaying Node");
            Node temp = this.top;
            if(temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            else
            {
                while(temp != null)
                {
                    Console.WriteLine("+ temp.data +");
                    temp = temp.next;
                }
                //Console.WriteLine("+ temp.data +");

            }

        }
    }

}
