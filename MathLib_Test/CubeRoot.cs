using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib_Test
{
    public class CubeRoot : Root
    {
        /// <summary>
        /// Cube root symbol.
        /// </summary>
        public static readonly char CubeRootSymbol = '\u221B'; // '\u221B' = '∛' to show: Console.OutputEncoding = System.Text.Encoding.UTF8;

        /// <summary>
        /// CubeRoot constructor.
        /// </summary>
        /// <param name="radicand">Radicand of root.</param>
        public CubeRoot(Integer radicand) : base(radicand, 3) { }

        // todo tymczasowe rozwiązanie:
        public override string ToString()
        {
            return $"{CubeRootSymbol}{Radicand}";
        }

        #region Conversions

        // Operator konwersji na double
        public static explicit operator double(CubeRoot root)
        {
            return Math.Cbrt(root.Radicand.Value);
        }

        // Operator konwersji na float
        public static explicit operator float(CubeRoot root)
        {
            return MathF.Cbrt(root.Radicand.Value);
        }

        #endregion
    }
}
