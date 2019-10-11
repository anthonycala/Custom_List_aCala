using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T>
    {
        private T[] items;

        public CustomList()
        // member variables
        //store values in an array
        {
            items = new T[4];
            

        }

        //get number of items in my list
        private int count;
        public int Count { get { return count; } }

        //tells us the length of the array
        private int capacity = 4;
        public int Capacity { get { return capacity; } set { capacity = value; } }
        
        public void Add(T item)
        {
            T[] temporary;
            if (capacity == count)
            {
                //increase array size (need to make new array)
                temporary = new T[capacity *= 2];

                //copy values from "old array" to "new array" one at a time
                //for loop is goo tool for 
                for (int i = 0; i < temporary.Length; i++);
                

            }
            items[count] = item;
            //update items array with what we did with temporaty array
            count++;
        }
        public void Remove(T item)
        {


        }
    }
}
