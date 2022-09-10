using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>()
             {
                 "Ankara", "İstanbul", "İzmir"
             };

            //listeye eleman ekleme
            cities.Add("Muğla");
            cities.Add("Aydın");

            //listeden eleman silme
            cities.Remove("Muğla");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //for the blank
            Console.WriteLine();
            Console.WriteLine();
            //boşluk için

            //listenin içinde İzmir var mı yok mu 
            bool result = cities.Contains("İzmir");
            Console.WriteLine("Listenin içinde 'İzmir' var mı = " + result);
        }
    }
}
