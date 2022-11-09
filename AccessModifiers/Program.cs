using System;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                    //access modifiers - erişim bildirgeçleri

                                                    // ----> public, internal, private, protected <-----

            //Public = Genel/tüm .cs dosyalarında kullanılabilir.
            //Internal = Sadece ilgili namespace alanında kullanılabilir.
            //Private = Sadece ilgili class'ta kullanılabilir.
            //Protected = Sadece ilgili class'ta ve inheritance eden class'ta kullanilabilir....
        }
    }

    internal class Customer //Class'ların default'u "internal"dır..
    {
        int Id { get; set; } //Erişim belirtilmediği taktirde "Private"tır.
    }

    interface CustomerManager
    {
        void Add(); //interface'lerin default'u "public"tir.
    }
}
