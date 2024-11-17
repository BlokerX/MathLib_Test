namespace MathLib_Test
{
    public class TranscendentalNumber
    {
        public char Symbol { get; set; }

        public decimal Value { get; set; }

        public TranscendentalNumber(char symbol, decimal value)
        {
            Symbol = symbol;
            Value = value;
        }
    }
}
