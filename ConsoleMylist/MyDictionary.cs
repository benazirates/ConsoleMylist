using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMylist
{
    class MyDictionary<B>
    {
        B[] items;
        
        public MyDictionary()
        {
            items = new B[0];

        }
        public void Add(B item)
        {
            B[] tempArray = items;
            items = new B[items.Length+1];
            
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                
            }
            items[items.Length - 1] = item;
        }
        public int Lenght
        {
            get { return items.Length; }
        }
        public B[] Items
        {
            get { return items; }
        }
    }
}
