﻿using System;
namespace GenericksIntro
{
    class MyList<T>
    {
        T[] items;
        //constructer
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = tempArray[i];
            }
        }
    }
}
