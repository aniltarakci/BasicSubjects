using System;

namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dolar'ın dünkü fiyatı: ");
            double dollarYesterday = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dolar'ın bugünkü fiyatı: ");
            double dollarToday = Convert.ToInt32(Console.ReadLine());
            string messageIncrease = "Dolar düne nazaran artış gösterdi.";
            string messageDecrease = "Dolar düne nazaran azalış gösterdi.";
            string messageSame = "Dün ve bugün dolar kuru eşittir.";

            if (dollarYesterday < dollarToday)
            {
                Console.WriteLine(messageIncrease);
            }
            else if (dollarYesterday > dollarToday)
            {
                Console.WriteLine(messageDecrease);
            }
            else if (dollarYesterday == dollarToday)
            {
                Console.WriteLine(messageSame);
            }
        }
    }
}
