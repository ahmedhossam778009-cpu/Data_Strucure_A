using Data_Struct.Data_Struct;
using Data_Struct.Data_Struct.HashTable;
using Data_Struct.Data_Struct.Linked_List;
using Data_Struct.Data_Struct.Stack___Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            MQueue<int> test = new MQueue<int>();

            test.Enqueue(1);
            test.Enqueue(2);
            test.Enqueue(3);
            test.Enqueue(4);
            Console.WriteLine(test.Length);
            test.peek();
            test.Dequeue();
            test.Dequeue();
            test.Dequeue();
            test.Dequeue();
            Console.WriteLine(test.Length);
            test.peek();
            test.Dequeue();




        }
    }
}
    

