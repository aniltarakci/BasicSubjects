using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Divide(6, 7));
        }
    }

    class Math
    {
        public decimal Divide(decimal number1, decimal number2)
        {
            try
            {
                return number1 / number2;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("Payda sıfır olamaz.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw; //fırlatmak 
                // return 0; // döndürmek
            }
        }
    }
}
