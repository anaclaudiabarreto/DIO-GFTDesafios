using System;

namespace DesafioQuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {

                int a = inicio;
                int b = a * a;
                int c = a * b;
                Console.Write(a+" ");
                Console.Write(b+" ");
                Console.WriteLine(c+" ");
                inicio++;


            }
        }
    }
}
