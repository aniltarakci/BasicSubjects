using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "anil";
            int pass = 157359;

            Console.Write("Kullanıcı Adınızı Giriniz: ");
            string usernameCheck = Console.ReadLine();
            Console.Write("Şifrenizi Giriniz: ");
            int passCheck = Convert.ToInt32(Console.ReadLine());

            if (usernameCheck == username && passCheck == pass)
            {
                Console.WriteLine("Başarıyla giriş yaptınız.");
            }
            else if (usernameCheck != username && passCheck == pass)
            {
                Console.WriteLine("Hatalı Kullanıcı Adı!!!");
            }
            else if (usernameCheck == username && passCheck != pass)
            {
                Console.WriteLine("Hatalı Şifre!!!");
            }
            else if (usernameCheck != username && passCheck != pass)
            {
                Console.WriteLine("Hatalı Kullanıcı Adı ve Şifre!!!");
            }
        }
    }
}
