using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> cities = new MyList<string>();
            {
                cities.Add("Ankara");
                cities.Add("İstanbul");
                cities.Add("İzmir");

                cities[0] = "Muğla"; //set
            }

            Console.WriteLine("Kaç adet şehir var: " + cities.Count);

            foreach (var city in cities.Items)
            {
                Console.WriteLine(city);
            }
        }
    }

    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray; //Geçici array
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

        public T[] Items
        {
            get { return _array; }
        }

        public T this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

    }
}
