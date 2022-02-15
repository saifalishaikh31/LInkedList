using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2,30);
            list.PopFirstNode();
            list.Display();
            Console.ReadLine();
        }
    }
}
