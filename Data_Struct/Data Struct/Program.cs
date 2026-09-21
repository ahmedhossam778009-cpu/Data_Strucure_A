using Data_Struct.Data_Struct;
using Data_Struct.Data_Struct.Linked_List;
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
            MLinkedList<object> test1 = new MLinkedList<object>(); // Create a new linked list of type object
            DLinkedList<object> test2 = new DLinkedList<object>(); // Create a new doubly linked list of type object


            test1.Add(101);
            test1.Add(102);
            test1.Add(103);
            test1.Add("Ahmed");

            test1.Travers();
            Console.WriteLine("Last Node: {0}", test1.GetLast().Data);

            test1.Reverse();
            Console.WriteLine("Last Node: {0}", test1.GetLast().Data);

            //test2.Add(101);

            //test2.Add(102);
            //test2.Add(103);
            //test2.Add("Ahmed");
            //test2.Travers();
            //test2.RemoveAt(1); 

            //test2.InsertAt(22, 1);
            //test2.Travers(); 
            //test2.RemovLast();
            //test2.Travers();
            //Console.WriteLine("Last Node: {0}", test2.GetLast().Data);

        }
    }
}
    

