using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Struct.Data_Struct.Linked_List;

namespace Data_Struct.Data_Struct.Stack___Queue
{
    public class MStack<T> 
    {
        MNode<T> _top;
        MNode<T> _bottom;
        int _length;
        public MStack()
        {
            _top = _bottom = null;
            _length = 0;
        }

        public void push(T value)
        {
            var newnode = new MNode<T>(value);
            if (_length == 0)
            {
                _top = _bottom = newnode;
                _length++;
                return;
            }
            var temb = _top;
            _top = newnode;
            _top.Next = temb;
            _length++;
        }


        public void peek()
        {
            Console.WriteLine(_top.Data);
        }


        public MNode<T> pop()
        {
            if (_top == null)
            {
                Console.WriteLine("Stack is Empty");
                return null;
            }

            var temb = _top;
            _top = _top.Next;
            _length--;

            if (_top == null)
            {
                _bottom = null;
            }

            Console.WriteLine(temb.Data);
            return temb;
        }


    }
}
