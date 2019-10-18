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
        public T this[int index] 
        { 
           get 
           {
                if (count > index)
                    return items[index];
                else
                    throw new ArgumentOutOfRangeException();
                
           } 
           set 
           {
                if(count < index)
                items[index] = value;
                else
                    throw new ArgumentOutOfRangeException();
           } 
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
                //for loop is good tool for 
                for (int i = 0; i < items.Length; i++)
                {
                    temporary[i] = items[i];
                }
                items = temporary;

            }
            items[count] = item;
            //update items array with what we did with temporary array
            count++;
        }
        public bool Remove(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (item.Equals(items[i]))
                {
                    for (int j = i; j < items.Length; j++)
                    {
                        if(j != items.Length - 1)
                        {
                            items[j] = items[j + 1];

                        }

                    }
                    count--;
                    break;
                }
            }
            return true;
        }
        public override string ToString() 
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += items[i].ToString();
            }
            return result;
        }
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < list1.Count; i++)
            {
                result.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                result.Add(list2[i]);
            }
            return result;
        }
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();

            
            for (int i = 0; i < list1.Count; i++)
            {
                list1.Remove(list2[i]);     
            }
            return list1;
        }
    }
}

