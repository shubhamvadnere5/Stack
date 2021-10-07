using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListStack stack = new LinkListStack(); //created object 
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.ReadLine();

        }
    }
}
