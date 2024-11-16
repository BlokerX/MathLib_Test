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
        public int Value
        {
            get;
            set;
        }

        /// <summary>
        /// If negative is true, else is flase.
        /// </summary>
        //public bool? IsNegative { get; set; }

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

        // todo constructors with:

        // - uint

        // - long
        // - ulong
        // - byte
        // - short
        // - ushort

    }
}
