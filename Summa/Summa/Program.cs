using System;

namespace Summa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna x:lle arvo:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:lle arvo:");
            int y = int.Parse(Console.ReadLine());

            int summa = y + 3;
            Console.WriteLine("x = "+ summa);
        }
    }
}
