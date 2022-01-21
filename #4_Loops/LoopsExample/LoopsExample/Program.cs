using System;

namespace LoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, girilenSayi, girilenAdet;
            Console.Write("Kaç tane sayı girmek istiyorsunuz? ");
            girilenAdet = int.Parse(Console.ReadLine());

            for (int i = 1; i <= girilenAdet; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz: ", i);
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                toplam += girilenSayi;

            }
            Console.Write("{1} tane girilen sayının toplamı: {0}", toplam, girilenAdet);
            Console.ReadKey();
        }
    }
}
