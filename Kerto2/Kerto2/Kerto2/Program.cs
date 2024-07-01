using System;

namespace Kerto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna x:lle arvo:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:lle arvo:");
            int y = int.Parse(Console.ReadLine());

            int kerto2 = x *= y * 5;


            Console.WriteLine("x = "+ kerto2);

        }
    }
}