namespace Bloaters
{
    public class Money
    {
        public double Amount { get; set; }
        public string Unit { get; set; }

        public static Money operator +(Money m1, Money m2)
        {
            return new Money { Amount = m1.Amount + m2.Amount };
        }

        public static Money operator -(Money m1, Money m2)
        {
            return new Money { Amount = m1.Amount - m2.Amount };
        }
    }
}
