using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Struct.HashTable
{
    public class HashMap
    {
        object[] data;
        public HashMap(int size)
        { 
          data =new object[size];
        }
       
        public int HashFunction(string E)
        {
            int hash = 0;
            char[] s = E.ToCharArray();
            for(int i=0; i<s.Length;i++)
            {
                hash = (hash + s[i].GetHashCode() * (i+1)) % this.data.Length;
            }
            return hash;
        }

        public object[] Set(string key, object value)
        {
            int index = HashFunction(key);
            object[] keyvalue;
            ArrayList arr;

            if (this.data[index] == null)
            {
                keyvalue = new object[2] { key, value };

                arr = new ArrayList();
                arr.Add(keyvalue);

                this.data[index] = arr;

                return this.data;
            }

            arr = (ArrayList)this.data[index];

            foreach (var item in arr)
            {
                keyvalue = (object[])item;

                if (keyvalue[0].ToString() == key)
                {
                    keyvalue[1] = value;
                    return this.data;
                }
            }

            keyvalue = new object[2] { key, value };
            arr.Add(keyvalue);

            return this.data;
        }

        public object Get(string key)
        {
            int index = HashFunction(key);

            if (this.data[index] == null)
            {
                return null;
            }

            ArrayList list = (ArrayList)this.data[index];

            foreach (var item in list)
            {
                object[] keyvalue = (object[])item;

                if (keyvalue[0].ToString() == key)
                {
                    Console.WriteLine("key : " + keyvalue[0] + " value : " + keyvalue[1]);
                    return keyvalue[1];
                }
            }

            return null;
        }

    }
}
