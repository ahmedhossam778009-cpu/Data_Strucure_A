using Data_Struct.Data_Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create MArrayList
            MArrayList list = new MArrayList(5);

            // =========================
            // Add
            // =========================

            list.Add(10);
            list.Add(20);
            list.Add(30);

            Console.WriteLine("After Add:");
            list.PrintList();


            // =========================
            // Length
            // =========================

            Console.WriteLine("\nLength: " + list.Length);


            // =========================
            // IndexOf
            // =========================

            Console.WriteLine("\nIndex of 20: " + list.IndexOf(20));


            // =========================
            // Insert
            // =========================

            list.Insert(1, 15);

            Console.WriteLine("\nAfter Insert(1, 15):");
            list.PrintList();


            // =========================
            // RemoveAt
            // =========================

            object removedItem = list.RemoveAt(2);

            Console.WriteLine("\nAfter RemoveAt(2):");
            list.PrintList();

            Console.WriteLine("Removed: " + removedItem);


            // =========================
            // Remove
            // =========================

            list.Remove(15);

            Console.WriteLine("\nAfter Remove(15):");
            list.PrintList();


            // =========================
            // IsFull
            // =========================

            Console.WriteLine("\nIs Full: " + list.IsFull());


            // =========================
            // Final Length
            // =========================

            Console.WriteLine("Final Length: " + list.Length);
        }
    }
}
    

