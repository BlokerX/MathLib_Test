namespace MathLib_Test
{
    public static class Extensions
    {
        public static bool TryParseToInteger(this RationalNumber rationalNumber, out Integer result)
        {
            if (rationalNumber.Numerator.Value % rationalNumber.Denominator.Value != 0)
            {
                result = 0;
                return false;
            }
            result = rationalNumber.Numerator / rationalNumber.Denominator;
            return true;
        }
    }
}
