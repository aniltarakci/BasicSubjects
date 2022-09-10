using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] credits = new string[4];
            credits[0] = "Hızlı Kredi";
            credits[1] = "Kamuya Özel Kredi";
            credits[2] = "İhtiyaç Kredisi";
            credits[3] = "Taşıt Kredisi";

            for (int i = 0; i < credits.Length; i++)
            {
                Console.WriteLine(credits[i]);
            }

            //for the blank
            Console.WriteLine();
            Console.WriteLine();
            //for the blank

            string[] credits2 = new string[] { "Hızlı Kredi", "Taşıt Kredisi", "İhtiyaç Kredisi" };

            foreach (var credit in credits2)
            {
                Console.WriteLine(credit);
            }
        }
    }
}
