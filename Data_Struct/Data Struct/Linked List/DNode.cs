using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Struct.Linked_List
{
    public class DNode<T>
    {
        public T Data { get; set; }
        public DNode<T> Next { get; set; }

        public DNode<T> Previous { get; set; }

        public DNode(T data, DNode<T> Next = null , DNode<T> Previous = null) 
        {
            this.Data = data;
            this.Next = Next;
            this.Previous = Previous;
        }
    }
}
