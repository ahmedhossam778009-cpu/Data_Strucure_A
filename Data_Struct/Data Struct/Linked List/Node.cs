using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Struct.Linked_List
{
    public class MNode<T>
    {
        public T Data { get; set; }
        public MNode<T> Next { get; set; }

        public MNode(T data , MNode<T> Next =null) // Constructor to initialize the node with data and next node
        {
            this.Data = data;
            this.Next = Next;
        }

    }
}
