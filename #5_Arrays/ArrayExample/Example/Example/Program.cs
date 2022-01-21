using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç boyutlu dizi olsun: ");
            int cevap = int.Parse(Console.ReadLine());
            var rnd = new Random();

            int[] dizi = new int[cevap];

            for (int i = 0; i < dizi.Length; i++)
                dizi[i] = rnd.Next(1, 59);

            foreach (var cikti in dizi)
            {
                Console.WriteLine(cikti);
            }
        }
    }
}
