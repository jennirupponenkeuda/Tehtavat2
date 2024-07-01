using System;

namespace Kerto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna X:lle arvo: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:lle arvo: ");
            int y = int.Parse(Console.ReadLine());

            int kerto = y * 5;
            Console.WriteLine("x = " + kerto);



        }   
    }
}