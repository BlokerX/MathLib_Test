namespace MathLib_Test
{
    public class RationalNumber
    {
        public Integer Numerator { get; set; } = new Integer(0);
        public Integer Denominator { get; set; } = new Integer(1);

        public RationalNumber(Integer numerator, Integer denominator)
        {
            Numerator = numerator;
            Denominator = denominator;

            if (!(Numerator == Denominator))
                Simplify();
        }

        public RationalNumber(double doubleNumber)
        {
            const double tolerance = 1E-10;

            int sign = doubleNumber < 0 ? -1 : 1;
            doubleNumber = Math.Abs(doubleNumber);

            int wholePart = (int)Math.Floor(doubleNumber);
            double fractionalPart = doubleNumber - wholePart;

            if (Math.Abs(fractionalPart) < tolerance)
            {
                Numerator.Value = sign * wholePart;
                Denominator.Value = 1;
                return;
            }

            int numerator = 1, denominator = 0, prevNumerator = 0, prevDenominator = 1;

            while (true)
            {
                int integerPart = (int)Math.Floor(fractionalPart);
                double tempFractionalPart = fractionalPart - integerPart;

                int tempNumerator = numerator;
                int tempDenominator = denominator;

                numerator = integerPart * numerator + prevNumerator;
                denominator = integerPart * denominator + prevDenominator;

                prevNumerator = tempNumerator;
                prevDenominator = tempDenominator;

                fractionalPart = 1.0 / tempFractionalPart;

                if (Math.Abs((double)numerator / denominator - doubleNumber) < tolerance)
                {
                    Numerator.Value = sign * (wholePart * denominator + numerator);
                    Denominator.Value = denominator;
                    Simplify();
                    break;
                }
            }
        }

        /// <summary>
        /// Simplifies rational numeber to minimals.
        /// </summary>
        private void Simplify()
        {
            int gcd = GreatestCommonDivisor(Math.Abs(Numerator.Value), Math.Abs(Denominator.Value));
            Numerator.Value /= gcd;
            Denominator.Value /= gcd;

            if (Denominator.Value < 0)
            {
                Numerator.Value = -Numerator.Value;
                Denominator.Value = -Denominator.Value;
            }
        }

        public (Integer WholePart, RationalNumber? FractionalPart) ToMixedPair()
        {
            int wholePart = Numerator.Value / Denominator.Value;
            int remainingNumerator = Numerator.Value % Denominator.Value;

            if (remainingNumerator == 0)
            {
                return (wholePart, null);
            }
            else
            {
                if (remainingNumerator == Numerator.Value && wholePart == 0)
                    return (0, this);

                RationalNumber fractionPart = new RationalNumber(remainingNumerator, Denominator);
                return (wholePart, fractionPart);
            }
        }

        /// <summary>
        /// New ToString() method.
        /// </summary>
        /// <returns>Returns "[Numerator]/[Denominator]".</returns>
        public override string ToString()
        {
            // without whole part:
            // return Denominator.Value == 1 ? $"{Numerator}" : $"{Numerator}/{Denominator}";

            // with whole part:
            if (Math.Abs(Numerator.Value) % Math.Abs(Denominator.Value) == 0)
                return ToMixedPair().WholePart.ToString();
            else
                return Math.Abs(Numerator.Value) / Math.Abs(Denominator.Value) > 0 ? ToMixedPair().ToString() : $"{Numerator}/{Denominator}";
        }

        #region Conversions

        // Operator konwersji na float
        public static explicit operator float(RationalNumber rational)
        {
            return rational.Numerator.Value / ((float)rational.Denominator.Value);
        }

        // Operator konwersji na double
        public static explicit operator double(RationalNumber rational)
        {
            return rational.Numerator.Value / ((double)rational.Denominator.Value);
        }

        // Operator konwersji na decimal
        public static explicit operator decimal(RationalNumber rational)
        {
            return rational.Numerator.Value / ((decimal)rational.Denominator.Value);
        }

        #endregion

        #region Helpers

        private int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        #endregion
    }
}
