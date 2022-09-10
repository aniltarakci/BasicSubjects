using System;

namespace BooleanDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci Sayıyı gir: ");
            double  number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Sayıyı gir: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            bool result = number1 < number2;
            string messageSmall = "Birinci sayı, ikinci sayıdan küçük.";
            string messageBig = "Birinci sayı, ikinci sayıdan büyük.";

            if (result == true)
            {
                Console.WriteLine(messageSmall);
            }
            else
            {
                Console.WriteLine(messageBig);
            }
        }
    }
}
