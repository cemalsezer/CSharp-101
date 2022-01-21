using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y += 2;
            y *= 3;
            Console.WriteLine(y); //15

            //Mantıksal Operatörler

            bool isSucess = true;
            bool isCompleted = false;

            if (isSucess && isCompleted)
                Console.WriteLine("Perfect");


            //İlişkisel operatörler
            //< , > , <= ,>= , == , !=
        }
    }
}
