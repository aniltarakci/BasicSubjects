using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reference types --> arrays, lists, class, interface...

            Person person1 = new Person();
            {
                person1.FirstName = "Akif";
            }

            Customer customer1 = new Customer();
            {
                customer1.FirstName = "Mehmet";
            }

            Employee employee1 = new Employee();
            {
                employee1.FirstName = "Salih";
            }

            PersonManager personManager = new PersonManager();
            {
                personManager.Add(employee1);
                personManager.Add(person1);
                personManager.Add(customer1);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public int CustomerNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
