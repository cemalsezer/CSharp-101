using System;

namespace ControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci Sayıyı Giriniz: ");
            int birinciSayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            int ikinciSayi = int.Parse(Console.ReadLine());

            if (birinciSayi > ikinciSayi)
            {
                Console.WriteLine("İlk girdiğiniz sayi, ikinci girdiğiniz sayıdan büyüktür.");
            }
            else if(ikinciSayi>birinciSayi)
            {
                Console.WriteLine("ikinci girdiğiniz sayi, İlk girdiğiniz sayıdan büyüktür.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayılar eşittir.");
            }
            Console.ReadKey();
        }
    }
}
