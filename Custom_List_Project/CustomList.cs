﻿using System;
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

        public void Add(T itemToAdd)
        {

        }
        public int count;
        public int Count
        {
            get => count;
            set => count = value;
        }
    }
}
