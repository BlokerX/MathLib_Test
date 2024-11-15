namespace MathLib_Test
{
    public class Root
    {
        /// <summary>
        /// Root symbol.
        /// </summary>
        public static readonly char DefaultRootSymbol = '\u221A'; // '\u221A' = '√' to show: Console.OutputEncoding = System.Text.Encoding.UTF8;

        /// <summary>
        /// Radicand of root.
        /// </summary>
        public Integer Radicand { get; set; } = 1;
        //todo degre może być w postaci ujemnej

        /// <summary>
        /// Root's degree.
        /// </summary>
        public Integer Degree { get; set; } = 1;

        /// <summary>
        /// Root constructor.
        /// </summary>
        /// <param name="radicand">Radicand of root.</param>
        /// <param name="degree">Degree of root.</param>
        /// <exception cref="ArgumentException">Root.Radicant cannot be negative for even degrees.</exception>
        public Root(Integer radicand, Integer degree)
        {
            // todo degree must be RealNumber (particulary RealNumber->RationalNumber->Integer)
            Degree = degree;

            if (degree.Value % 2 == 0 && radicand.Value < 0)
                throw new ArgumentException("Root.Radicant cannot be negative.");
            Radicand = radicand;
        }

        // todo tymczasowe rozwiązanie:
        /// <summary>
        /// New ToString() method.
        /// </summary>
        /// <returns>Root.</returns>
        public override string ToString()
        {
            return $"({Degree}){DefaultRootSymbol}{Radicand}";
        }

        #region Conversions

        // Operator konwersji na double
        public static explicit operator double(Root root)
        {
            return NthRoot(root.Radicand.Value, root.Degree.Value);
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Nth root of a number.
        /// </summary>
        /// <param name="radicand">Radicand of root.</param>
        /// <param name="degree">Root's degree.</param>
        /// <returns></returns>
        static private double NthRoot(double radicand = 0, int degree = 1)
        {
            if (degree == 1)
            {
                return radicand; // Zwracamy po prostu liczbę, ponieważ pierwiastek pierwszego stopnia to liczba sama w sobie.
            }

            if (radicand < 0)
            {
                if (degree % 2 == 1)
                {
                    return -NthRoot(-radicand, degree); // Pierwiastek nieparzystego stopnia z liczby ujemnej
                }
                if (degree % 2 == -1)
                {
                    return -1 / NthRoot(-radicand, -degree); // Jeśli stopień pierwiastka jest ujemny
                }
            }
            return Math.Pow(radicand, 1.0 / degree); // Obliczanie pierwiastka ogólnego
        
            //todo dodać tolerancję dla liczb zmiennoprzecinkowych

        }

        #endregion

    }
}
