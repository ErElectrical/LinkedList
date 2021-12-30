using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the linkedlist");
            LinkedList list=new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.toprint();

            
        }
    }
}
