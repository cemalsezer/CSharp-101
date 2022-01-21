using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen 1 ile 7 arasında bir rakam giriniz: ");
            int sayi = Int32.Parse(Console.ReadLine());
            switch (sayi)
            {

                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;

                default:
                    Console.WriteLine("Hata işlem yaptınız.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
