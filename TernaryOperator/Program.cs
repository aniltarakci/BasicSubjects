using System;

namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adını gir: ");
            string username = Console.ReadLine();
            Console.Write("Şifreni gir: ");
            string pass = Console.ReadLine();
            string result = (username == "anil" && pass == "157359") ? "Giriş Başarılı" : "Kullanıcı adı ve ya Şifre hatalı!!!";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
