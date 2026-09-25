using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Struct.Linked_List
{
    public class MLinkedList<T>  
    {
        MNode<T> head; // Head of the linked list

        public MLinkedList()
        {
            this.head = null; // Initialize the head of the list to null
        }

        public void AddFirst(T data) 
        {
            this.head = new MNode<T>(data, this.head); // Create a new node and set it as the head of the list
        }

        public int Size() // Return the number of nodes in the linked list
        {
            int count = 0;
            var temp = this.head;
            while(temp!=null)
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

        public MNode<T> GetLast() // Return the last node in the linked list
        {
            if (this.head == null)
                return null;

            var temb = head;

            while (temb.Next != null)
            {
                temb = temb.Next;
            }

            return temb;
        }

        public void Add(T data) // Add a new node with the given data to the end of the linked list
        {
            var LastNode = GetLast();
            if(LastNode==null)
            {
                this.head = new MNode<T>(data);
            }
            else
            {
                LastNode.Next = new MNode<T>(data);
            }
        }

        
        public void Travers() // Traverse the linked list and print the data of each node
        {
            var temb = this.head;
            while(temb !=null)
            {
                Console.WriteLine(temb.Data);
                temb = temb.Next;
            }
            
        }

        public void RemoveFirst()
        {
            if(this.head==null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            this.head = this.head.Next; // Remove the first node by updating the head to the next node
        }

        public MNode<T> GetAt(int index)
        {
            if (this.head == null)
            {
                Console.WriteLine("the list is empty");
                return null;
            }
            var temb = this.head;
            int Counter = 0;
            while (temb!=null)
            {
                if(Counter == index)
                {
                    return temb;
                }
                Counter++;
                temb = temb.Next;
            }
            return null;
        }

        public MNode<T> RemoveAt(int index)
        {
            if (this.head == null)
            {
                Console.WriteLine("The list is empty");
                return null;
            }

            if (index == 0)
            {
                var removedNode = this.head;
                this.head = this.head.Next;
                return removedNode;
            }

            var temb = this.head;
            int Counter = 0;

            while (temb != null)
            {
                if (Counter == index - 1)
                {
                    var removedNode = temb.Next;

                    if (removedNode == null)
                    {
                        return null;
                    }

                    temb.Next = removedNode.Next;
                    return removedNode;
                }

                Counter++;
                temb = temb.Next;
            }

            return null;
        }

        public void InsertAt(T data, int index)
        {
            if (index < 0)
            {
                Console.WriteLine("Index is out of bounds");
                return;
            }

            if (index == 0)
            {
                AddFirst(data);
                return;
            }

            var prev = this.GetAt(index - 1);

            if (prev == null)
            {
                Console.WriteLine("Index is out of bounds");
                return;
            }

            var node = new MNode<T>(data, prev.Next);
            prev.Next = node;
        }



        public void RemovLast()
        {
            
            if(this.head == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            var prev = this.head;
            var node=prev.Next;
            if(node==null)
            {
                this.head = null;
                return;

            }
            while(node.Next!=null)
            {
                prev = node;
                node= node.Next;
            }
            prev.Next = null;
        }

        public void Clear()
        {
            this.head = null; // Clear the linked list by setting the head to null
        }




        //-------------------Exercise-------------------//
        public void Reverse()
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            if(this.head.Next == null)
            {
                Console.WriteLine($"There is 1Node only in the LinkedList {this.head.Data}");
                return;
            }
            //[1,2,3,4,5] 

            var First = this.head;
            var Second = First.Next;
            while(Second!=null)
            {
                var temb = Second.Next;
                Second.Next = First;
                First = Second;
                Second = temb;
            }
            this.head.Next = null;
            this.head = First;
            this.Travers();

        }
    }
}
