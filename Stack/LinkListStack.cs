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


        /// <summary>
        /// UC2 Peek & Pop
        /// </summary>
        //The Peek() method returns the lastly added value from the stack but does not remove it.
        public void peek() 
        {
            ///Checking if top element is null
            ///otherwise printing the top element
            if (this.top !=null)
            {
                Console.WriteLine("NO elemets present to peek");
                return;
            }
            Console.WriteLine("Top Elements" + this.top.data);
        }

        //The Pop() method returns the last element and removes it from a stack.
        public void pop()
        {
            ///Checking if top element is null
            ///otherwise printing the top element and deleting it also
            if(this.top == null)
            {
                Console.WriteLine("No elemets present for pop");
                return;
            }
            else
            {
                Console.WriteLine("Top elements" + this.top.data);
                int deletenode = this.top.data;
                peek();
                this.top = this.top.next;
                Console.WriteLine("Deleted elements" + deletenode);
            }   
        }
        public void ISEmpty()
        {
            while(this.top !=null)
            {
                pop();
            }
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
