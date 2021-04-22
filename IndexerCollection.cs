﻿using System;
using System.Collections.Generic;
using System.Text;

namespace List__Add__Famous_New_Mexico
{
    public class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
}
