using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Struct.Linked_List
{
    public class DLinkedList<T>
    {
        DNode<T> head; 
        DNode<T> tail;

        public DLinkedList()
        {
          this.head = null;
          this.tail = null;
        }

        public void AddFirst(T data)
        {
            DNode<T> newNode = new DNode<T>(data, this.head);

            if (this.head != null)
            {
                this.head.Previous = newNode;
            }

            this.head = newNode;
            if(this.tail == null)
            {
                this.tail = this.head;
            }
        }

        public int Size() // Return the number of nodes in the linked list
        {
            int count = 0;
            var temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public T GetFirsr()  // Return the data of the first node in the linked list
        {
            return this.head.Data;
        }

        public DNode<T> GetLast() // Return the last node in the linked list
        {

            return this.tail;
        }

        public void Add(T data)
        {
            DNode<T> newNode = new DNode<T>(data);

            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.Previous = this.tail;
                this.tail.Next = newNode;
                this.tail = newNode;
            }
        }


        public void Travers() // Traverse the linked list and print the data of each node
        {
            var temb = this.head;
            while (temb != null)
            {
                Console.WriteLine(temb.Data);
                temb = temb.Next;
            }

        }

        public void RemoveFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            this.head = this.head.Next; // Remove the first node by updating the head to the next node
        }

        public DNode<T> GetAt(int index)
        {
            if (this.head == null)
            {
                Console.WriteLine("the list is empty");
                return null;
            }
            var temb = this.head;
            int Counter = 0;
            while (temb != null)
            {
                if (Counter == index)
                {
                    return temb;
                }
                Counter++;
                temb = temb.Next;
            }
            return null;
        }

        public void RemoveAt(int index)
        {
            if (this.head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            if (index == 0)
            {
               
                this.head = this.head.Next;
                return ;
            }

            var prev = this.GetAt(index-1);
            if (prev == null || prev.Next == null)
            {
                Console.WriteLine("Index out of bounds");
                return;
            }
           // prev.Next = prev.Next.Next;
           var next = prev.Next.Next;
            next.Previous = prev;
            prev.Next = next;




        }

        public void InsertAt(T data, int Index)
        {
            if (this.head == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            if (Index == 0)
            {
                this.head = new DNode<T>(data);
            }
            var prev = this.GetAt(Index - 1) == null ? this.GetLast() : this.GetAt(Index - 1);
            var next = prev.Next;

            var node = new DNode<T>(data, next);

            // head -> prev -> node -> next   ---------  tail

            //  1       3       6       8     7     4     3

            next.Previous = node;
            node.Previous = prev;
            prev.Next = node;

        }



        public void RemovLast()
        {

            if (this.head == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
          
            if (this.head.Next == null)
            {
                this.head = null;
                return;

            }
            var lastnode = GetLast();
            var pre = lastnode.Previous;
            pre.Next = null;
            this.tail = pre;    
        }

        public void Clear()
        {
            this.head = null; // Clear the linked list by setting the head to null
        }
    }
}

