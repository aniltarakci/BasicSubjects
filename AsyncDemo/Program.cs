using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Thread no: {Thread.CurrentThread.ManagedThreadId}");

            //METHOD 1: Task new'lendiğinde start edilmesi gerekir.
            //Task task1 = new Task(Process1);
            //task1.Start();

            //METHOD 2: Direkt olarak Task'ı start eder.
            //Task task1 = Task.Factory.StartNew(Process1);

            //METHOD 3: Method 2 ile aynı işlevdedir.
            //Task task1 = Task.Run(Process1);

            //METHOD 4: On the air 
            //Task task1 = Task.Run(() =>
            //{
            //    Process1();
            //    Process2();
            //});

            //METHOD 5: Yukarıdaki tüm method'lar için geçerli.
            //Task task1 = Task.Run(Process1);
            //task1.Wait();

            Process2();

            Console.ReadKey();
        }

        static void Process1()
        {
            Console.WriteLine("1. İşlem başladı.");
            Console.WriteLine($"Thread no: {Thread.CurrentThread.ManagedThreadId}");
        }

        static void Process2()
        {
            Console.WriteLine("2. İşlem başladı.");
            Console.WriteLine($"Thread no: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
