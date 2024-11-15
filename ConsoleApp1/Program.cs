using MathLib_Test;

namespace ConsoleApp1
{
    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Start:\n");

            while (true)
            {

                Console.Write("Set a:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Set b:");
                int b = int.Parse(Console.ReadLine());

                var n = new RationalNumber(a, b);

                Console.WriteLine(n + " (i, n/d)");
                Console.WriteLine((double)n + " (double)");
                Console.WriteLine((float)n + " (float)");
                Console.WriteLine((decimal)n + " (decimal)");
                Console.WriteLine();
            }
        }

    }
}