using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSample
{
    internal class GenericList<T> where T : struct   //Generic class which excepts a Type(<T>)
    {
        private int index;
        //generic field:
        private T[] items;          //Defining array of that Type 

        public GenericList(int size)
        {
            items = new T[size]; //instantiate the array with the size  
        }

        //generic method
        public void Add(T item)
        {
            items[index] = item;
            index++;
        }

        //generic property:
        public T Current  //property
        {
            get { return items[index - 1]; }
        }

        // indexer -> Enabling the indexer to the class
        public T this[int index]
        {
            get 
            {
                return items[index];
            }
            set
            {
                items[index] = value; 
            }
        }
    }

    internal class GenericRerence<T> where T : class //here it can take only class reference
    {
        private int index;
        private T[] items;
        public GenericRerence(int size)
        {
            items = new T[size];
        }

        //generic method
        public void Add(T item)
        {
            items[index] = item;
            index++;
        }

        //generic property:
        public T Current  //property
        {
            get { return items[index - 1]; }
        }

        // indexer -> Enabling the indexer to the class
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
    }

    internal class GenericCombined<T>
    {
        private int index;
        private T[] items;
        public GenericCombined(int size)
        {
            items = new T[size];
        }

        //generic method
        public void Add(T item)
        {
            items[index] = item;
            index++;
        }

        //generic property:
        public T Current  //property
        {
            get { return items[index - 1]; }
        }

        // indexer -> Enabling the indexer to the class
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
    }
}
