using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] credits = new string[5];
            credits[0] = "Hızlı credit";
            credits[1] = "Kamuya Özel credit";
            credits[2] = "İhtiyaç creditsi";
            credits[3] = "Taşıt creditsi";
            credits[4] = "Araç creditsi";

            for (int i = 0; i < credits.Length; i++)
            {
                Console.WriteLine(credits[i]);
            }
            Console.WriteLine("Sadece 5 tane credit bulunuyor. (For Loop)");

            //for the blank
            Console.WriteLine();
            Console.WriteLine();
            //for the blank

            foreach (var credit in credits)
            {
                Console.WriteLine(credit);
            }
            Console.WriteLine("Sadece 5 tane credit bulunuyor. (Foreach Loop)");

            //for the blank
            Console.WriteLine();
            Console.WriteLine();
            //for the blank

            int counter = 0;
            while (counter <= 4)
            {
                Console.WriteLine(credits[counter]);
                counter++;
            }
            Console.WriteLine("Sadece 5 tane credit bulunuyor. (While Loop)");

            //for the blank
            Console.WriteLine();
            Console.WriteLine();
            //for the blank

            int counter2 = 0;
            do
            {
                Console.WriteLine(credits[counter2]);
                counter2++;
            } while (counter2 <= 4);
            Console.WriteLine("Sadece 5 tane credit bulunuyor. (Do-While Loop)");
        }
    }
}
