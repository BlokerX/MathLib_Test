namespace MathLib_Test
{
    public class SquareRoot : Root
    {
        /// <summary>
        /// Square root symbol.
        /// </summary>
        public static readonly char SquareRootSymbol = '\u221A'; // '\u221A' = '√' to show: Console.OutputEncoding = System.Text.Encoding.UTF8;

        /// <summary>
        /// SquareRoot constructor.
        /// </summary>
        /// <param name="radicand">Radicand of root.</param>
        public SquareRoot(Integer radicand) : base(radicand, 2) { }

        // todo tymczasowe rozwiązanie:
        public override string ToString()
        {
            return $"{SquareRootSymbol}{Radicand}";
        }

        #region Conversions

        // Operator konwersji na double
        public static explicit operator double(SquareRoot root)
        {
            return Math.Sqrt(root.Radicand.Value);
        }

        // Operator konwersji na float
        public static explicit operator float(SquareRoot root)
        {
            return MathF.Sqrt(root.Radicand.Value);
        }

        #endregion
    }
}
