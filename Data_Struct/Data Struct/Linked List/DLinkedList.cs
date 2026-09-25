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
                Console.WriteLine("The list is empty");
                return;
            }

            this.head = this.head.Next;

            if (this.head == null)
            {
                this.tail = null;
            }
            else
            {
                this.head.Previous = null;
            }
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

            if (index < 0)
            {
                Console.WriteLine("Index is out of bounds");
                return;
            }

            if (index == 0)
            {
                RemoveFirst();
                return;
            }

            var prev = this.GetAt(index - 1);

            if (prev == null || prev.Next == null)
            {
                Console.WriteLine("Index is out of bounds");
                return;
            }

            var removedNode = prev.Next;
            var next = removedNode.Next;

            prev.Next = next;

            if (next != null)
            {
                next.Previous = prev;
            }
            else
            {
                this.tail = prev;
            }
        }






        public void InsertAt(T data, int Index)
        {
            if (Index < 0)
            {
                Console.WriteLine("Index is out of bounds");
                return;
            }

            if (Index == 0)
            {
                AddFirst(data);
                return;
            }

            var prev = this.GetAt(Index - 1);

            if (prev == null)
            {
                Console.WriteLine("Index is out of bounds");
                return;
            }

            var next = prev.Next;

            var node = new DNode<T>(data, next);

            node.Previous = prev;
            prev.Next = node;

            if (next != null)
            {
                next.Previous = node;
            }
            else
            {
                this.tail = node;
            }
        }


        public void RemovLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            if (this.head.Next == null)
            {
                this.head = null;
                this.tail = null;
                return;
            }

            this.tail = this.tail.Previous;
            this.tail.Next = null;
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
        }
    }
}

