using System;
using System.Collections.Generic;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            {
                personManager.Add();
                personManager.Update();
            }

            CustomerManager customerManager = new CustomerManager();
            {
                customerManager.BestCustomer();
            }

            EmployeeManager employeeManager = new EmployeeManager();
            {
                employeeManager.BestEmployee();
            }

            Person person1 = new Person() { Id = 1, NationalIdentity = 23121334, FirstName = "Mehmet", LastName = "Kasap" };

            Customer customer1 = new Customer() { Id = 2, NationalIdentity = 1289737134, FirstName = "Kıraç", LastName = "Ağaç", CustomerNumber = 241124 };

            Employee employee1 = new Employee() { Id = 3, NationalIdentity = 52325235, FirstName = "Ahmet", LastName = "Yasin", EmployeeNumber = 65836 };

            Console.WriteLine(person1.FirstName);
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(employee1.FirstName);
        }
    }

    class PersonManager
    {
        public void Add()
        {
            Console.WriteLine("Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Güncellendi.");
        }
    }

    class CustomerManager : PersonManager
    {
        public void BestCustomer()
        {
            Console.WriteLine("En iyi müşteri");
        }
    }

    class EmployeeManager : PersonManager
    {
        public void BestEmployee()
        {
            Console.WriteLine("En iyi çalışan");
        }
    }

    class Person
    {
        public int Id { get; set; }
        public int NationalIdentity { get; set; }
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
}
