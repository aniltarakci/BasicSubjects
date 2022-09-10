using System;
using System.Collections.Generic;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Anıl", LastName = "Tarakcı" };
            Customer customer2 = new Customer(2, "Mehmet", "Akif");

            Console.WriteLine(customer1.FirstName + " " + customer1.LastName);
            Console.WriteLine(customer2.FirstName + " " + customer2.LastName);
        }
    }

    class Customer
    {
        //ctor - default constructor
        public Customer()
        {

        }

        //ctor - parameter constructor
        public Customer(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
