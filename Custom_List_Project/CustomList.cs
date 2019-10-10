using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList <T>
    {
        private T[] items;

        public CustomList()
        {
            items = new T[4];
            

        }

        
        public int count;
        public int Count
        {
            get => count;
            set => count = value;
        }
        public void Add(T item)
        {

            items[count] = item;
            count++;
            // need to put this in a If statement
            items = new T[4 * 2];

        }
    }
}
