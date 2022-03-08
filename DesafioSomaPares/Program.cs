using System;

namespace DesafioSomaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    x = (x + 4) * 5;
                    Console.WriteLine(x);
                    x = int.Parse(Console.ReadLine());
                }

                else
                {
                    x = x + 1;
                    x = (x + 4) * 5;
                    Console.WriteLine(x);
                    x = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
