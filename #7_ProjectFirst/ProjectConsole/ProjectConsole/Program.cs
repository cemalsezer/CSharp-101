using System;

namespace ProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int dongu;
            int cevap;
            Console.Write("Döngü sayısını giriniz: ");
            dongu = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= dongu; i++)
            {
                Console.Write("{0}.Sayıyı Giriniz: ",i);
                 cevap = Convert.ToInt32(Console.ReadLine());
                kontrol(cevap);
                
            }
        }
        static void kontrol(int s)
        {
            if (s % 2 == 0)
            {
                Console.WriteLine("Girilen Sayı Çift");
            }
            else
            {
                Console.WriteLine("Girilen Sayı Tek");
            }
        }
    }
}
