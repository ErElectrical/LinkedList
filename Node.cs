using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignments
{
    public class Node
    {
        public int data;
        public Node next;
        // creating two varible for our node
        // one which takes tha values and
        // second which takes the pointer refernce of next node
        public Node (int data)
        {
            this.data = data;
        }
        // constructor for our node class that will
        // initialize the head value to head of our Linked list.
    }
}
