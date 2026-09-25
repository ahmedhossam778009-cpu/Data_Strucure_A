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
            MStack<int> test = new MStack<int>();
            test.push(1);
            test.push(2);
            test.push(3);
            test.push(4);
            test.push(5);
            test.peek();
            test.pop();
            test.peek();
        }
    }
}
    

