using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");
            Process1();
            Process1Async();
            Process2();
            Process2Async();
        }

        static void Process1()
        {
            Console.WriteLine($"Senkron işlem 1 başladı. {Thread.CurrentThread.ManagedThreadId}");
        }

        static async Task Process1Async()
        {
            await Task.Run(() =>
             {
                 Console.WriteLine($"Asenkron işlem 1 başladı. {Thread.CurrentThread.ManagedThreadId}");
             });
        }

        static void Process2()
        {
            Console.WriteLine($"Senkron işlem 2 başladı. {Thread.CurrentThread.ManagedThreadId}");
        }

        static async Task Process2Async()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Asenkron işlem 2 başladı. {Thread.CurrentThread.ManagedThreadId}");
            });
        }
    }
}
