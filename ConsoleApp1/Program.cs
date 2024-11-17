using MathLib_Test;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //RationalNumberTest();
            RootTest();
            //SquareRootTest();
            //CubeRootTest();
        }

        private static void RationalNumberTest()
        {
            Console.WriteLine("Start Rational Number Test:\n");

            while (true)
            {

                Console.Write("Set a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Set b: ");
                int b = int.Parse(Console.ReadLine());

                var n = new RationalNumber(a, b);

                Console.WriteLine(n + " (i, n/d)");
                Console.WriteLine((double)n + " (double)");
                Console.WriteLine((float)n + " (float)");
                Console.WriteLine((decimal)n + " (decimal)");
                Console.WriteLine();
            }
        }

        private static void RootTest()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Start Root Test:\n");

            while (true)
            {
                Console.Write("Set a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Set x: ");
                int x = int.Parse(Console.ReadLine());

                var n = new Root(x, a);

                Console.WriteLine(n);
                Console.WriteLine((double)n + " (double)");
                Console.WriteLine();
            }
        }

        private static void SquareRootTest()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Start Square Root Test:\n");

            while (true)
            {
                Console.Write("Set a: ");
                int a = int.Parse(Console.ReadLine());

                var n = new SquareRoot(a);

                Console.WriteLine(n);
                Console.WriteLine((double)n + " (double)");
                Console.WriteLine((float)n + " (float)");
                Console.WriteLine();
            }
        }
        
        private static void CubeRootTest()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Start Cube Root Test:\n");

            while (true)
            {
                Console.Write("Set a: ");
                int a = int.Parse(Console.ReadLine());

                var n = new CubeRoot(a);

                Console.WriteLine(n);
                Console.WriteLine((double)n + " (double)");
                Console.WriteLine((float)n + " (float)");
                Console.WriteLine();
            }
        }

    }
}