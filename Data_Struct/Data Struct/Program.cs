using Data_Struct.Data_Struct;
using Data_Struct.Data_Struct.HashTable;
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

            HashMap test = new HashMap(7);

            test.Set("Ahmed", 77);
            test.Set("omar", 90);
            test.Set("omar", 23);
            test.Set("Iyad", 7);
            test.Set("popy", 56);

            Console.WriteLine(test.Get("omar"));
        }
    }
}
    

