namespace Tests
{
    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            Console.WriteLine("Set a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Set b:");
            int b = int.Parse(Console.ReadLine());

            //private int GreatestCommonDivisor(int a, int b)
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            Console.WriteLine(a);
        }

    }
}