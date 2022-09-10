using System;

namespace InputAndIfElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            double number1, number2;
            Console.Write("Birinci Sayıyı Giriniz: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Girdiğiniz Sayılara Hangi İşlem Yapılsın: ");
            string process = Console.ReadLine();
            if (process == "toplama")
            {
                double result = number1 + number2;
                Console.WriteLine(result);
            }
            else if (process == "çıkarma")
            {
                double result = (number1 - number2);
                Console.WriteLine(result);
            }
            else if (process == "bölme")
            {
                double result = (number1 / number2);
                Console.WriteLine(result);
            }
            else if (process == "çarpma")
            {
                double result = (number1 * number2);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Hiçbir İşlem Yapmadınız.");
            }
        }
    }
}
