using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //IPersonManager employeeManager = new EmployeeManager();

            //for the blank
            Console.WriteLine();
            //for the blank

            ProjectManager projectManager = new ProjectManager();
            {
                projectManager.Add(new CustomerManager());
                projectManager.Update(new CustomerManager());

                projectManager.Add(new EmployeeManager());
                projectManager.Update(new EmployeeManager());
            }
        }
    }

    //interface'ler new'lenemez!!!!
    interface IPersonManager
    {
        void Add();
        void Update();
    }

    //class -> inherits ---------- interface -> implements
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager iPersonManager)
        {
            iPersonManager.Add();
        }

        public void Update(IPersonManager iPersonManager)
        {
            iPersonManager.Update();
        }
    }
}
