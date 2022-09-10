using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            {
                double resultPlus = math.Plus(3, 5);
                double resultMinus = math.Minus(3, 5);
                Console.WriteLine("Toplama işlemi sonucu: " + resultPlus);
                Console.WriteLine("Çıkarma işlemi sonucu: " + resultMinus);

                double resultPlusParams = math.PlusParams(3, 4, 5, 6, 7);
                double resultMinusParams = math.MinusParams(3, 4, 5, 6, 7);
                Console.WriteLine("Dizilerin toplama işlemi sonucu: " + resultPlusParams);
                Console.WriteLine("Dizilerin çıkarma işlemi sonucu: " + resultMinusParams);
            }
        }
    }

    class Math
    {
        public double Plus(double number1, double number2)
        {
            return number1 + number2;
        }

        public double PlusParams(params double[] numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;

            //return numbers.Sum();
        }

        public double Minus(double number1, double number2)
        {
            return number1 - number2;
        }

        public double MinusParams(params double[] numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                result -= number;
            }
            return result;
        }
    }
}
