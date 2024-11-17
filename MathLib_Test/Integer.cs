namespace MathLib_Test
{
    /// <summary>
    /// Integer class.
    /// </summary>
    public class Integer
    {
        /// <summary>
        /// Value.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// If negative is true, else is flase.
        /// </summary>
        public bool IsNegative => Value < 0;

        /// <summary>
        /// Constructor for integer.
        /// </summary>
        /// <param name="value">Value, default is 0.</param>
        public Integer(int value = 0)
        {
            Value = value;
        }

        public override string ToString() => Value.ToString();

        public Root ToRoot() => new Root(Value, 1);
        public RationalNumber ToRationalNumber() => new RationalNumber(Value);

        #region Conversions

        public static implicit operator Integer(int value)
        {
            return new Integer(value);
        }

        //public static implicit operator int(Integer value)
        //{
        //    return value;
        //}

        #endregion

        #region Operations

        public static Integer operator +(Integer a) => a;
        public static Integer operator -(Integer a) => new Integer(-a.Value);

        public static Integer operator +(Integer a, Integer b) => new Integer(a.Value + b.Value);
        public static Integer operator -(Integer a, Integer b) => new Integer(a.Value - b.Value);
        public static Integer operator *(Integer a, Integer b) => new Integer(a.Value * b.Value);
        public static Integer operator /(Integer a, Integer b)
        {
            if (b.Value == 0) throw new DivideByZeroException();
            return new Integer(a.Value / b.Value);
        }

        public static Integer operator %(Integer a, Integer b) => new Integer(a.Value % b.Value);

        #endregion

    }
}
