using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Struct
{
    public class MArrayList
    {
        object[] array;
        int max_size;
        int length;
        public int Length { get => length; }
        public bool IsFull()
        { 
        return length == max_size;  
        }  

        public MArrayList(int size)
        {
            max_size = size;
            length = 0;
            array = new object[max_size];
            
        }
        public MArrayList()
        { 
            max_size = 10;
            length = 0;
            array = new object[max_size];
        }

        public void PrintList()
        {
            for(int i =0; i<length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void Add(object value)
        {
            if (!IsFull())
            {
                array[length] = value;
                length++;
            }
            else
            {
                Console.WriteLine("Array is full");
            }
        }
        
        public void Insert(int Index , object Item)
        {
            if(!IsFull())
            { 
                if(Index < 0 || Index > length)
                {
                    Console.WriteLine("Index is out of range");
                }
                else
                {
                    for (int i = length; i > Index; i--)
                    {
                        array[i] = array[i - 1];
                        
                    }
                    array[Index] = Item;
                    length++;
                }
            }

        }
        public int IndexOf(object value)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;

        }
        public object RemoveAt(int Index)
        {
         if (length == 0)
         {
                Console.WriteLine("Array is empty");
                return null;

         }
            if (Index < 0 || Index >= length)
            {
                Console.WriteLine("Index is out of range");
                return null;
            }

            object removedItem = array[Index];

            for (int i = Index; i < length - 1; i++)
            {
                array[i] = array[i + 1];

            }
            Console.WriteLine("Removed item: " + removedItem);
            length--;
            array[length] = null;
            return removedItem;
        }
        public void Remove(object value)
        {
            int Index = this.IndexOf(value);
            if (Index == -1)
            {
                Console.WriteLine("Item not found");
                return;
            }

            for (int i = Index; i < length - 1; i++)
            {
                array[i] = array[i + 1];

            }
            length--;
            array[length] = null;
        }
        
        
    }
}
