using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignments
{
    public class LinkedList
    {
        internal Node head;
        // creting head position for our linkedlist
        internal void Add(int data)
        {
            // although this method are pre available in the
            // library of linkedlist but to get more clearity on linkedlist
            //concept we define them 
            Node node =new Node(data);
            // creating a object for node class and pushing the data varible in it.
            // now our head of linked list is created.
            if (this.head==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                // craeting a temp varible of node class
                // and initialize it the value of head.
                while(temp.next !=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                // we are going to iterate the temp varible untill we do not get that position 
                // where next position to the temp is  empty .
                // here keep in mind that actually behind the scene temp varible is created to hold the refernce 
                // of the next node so evantually we are searching for the last node which has values with it but
                //dont have refernce for next node so that we can put our value here 
                //and initialize the refernce of current node pointer to it.
            }
            Console.WriteLine("{0} element is inserted to the linked list ", node.data);
        }
        internal void toprint()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("linkedlist is empty");
                return;
                // according to rule of linkedlist if head is empty than linkedlist is empty.
            }
            while(temp != null)
            {
                Console.Write(temp.data+"  ");
                temp = temp.next;
                // we are going to iterate it untill we donot get null in temp
                // means we do not have refrence to next node .
                // and we are pushing the value of next to the temp.
            }


        }
        internal Node Insertatparticularposition(int position,int data)
        {
            if(position < 1)
            {
                Console.WriteLine("invalid position");
            }
            if (position == 1)
            {
                var newnode = new Node(data);
                newnode.next = this.head;
                head = newnode;
            }
            else
            {
                while(position-- != 0)
                {
                    Node node = new Node(data);
                    node.next = this.head.next;
                    head.next = node;
                    break;
                }
                head = head.next;
            }
            if(position != 1)
            {
                Console.WriteLine("position is out of range");
            }
            return head;
        }
    }
}
