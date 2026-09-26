using System;
using System.Collections;
using Data_Struct.Data_Struct.Linked_List;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Struct.Stack___Queue
{
    public class MQueue<T>
    {
        MNode<T> _Front;
        MNode<T> _Back;
        int _Length;
        public int Length { get => _Length;  }
        public MQueue()
        {
            _Front = _Back = null;
            _Length = 0;
        }

        public void peek()
        {
            if(_Length==0)
            { Console.WriteLine("Queueis Impty");
                return;
            }
            Console.WriteLine(_Front.Data);
        }

        public void Enqueue(T Value)
        {
            var newnode = new MNode<T>(Value);
            if (_Length == 0)
            {
                _Front = _Back = newnode;
                _Length++;
                return;
            }

            _Back.Next = newnode;
            _Back = newnode;
            _Length++;
        }

        public MNode<T> Dequeue()
        {
            if(_Length==0)
            {
                Console.WriteLine("Queue is Impty");
                return null;
            }
            var temb = _Front;
            Console.WriteLine(_Front.Data);
            _Front = _Front.Next;
            _Length--;
            return temb;

        }

    }
}
