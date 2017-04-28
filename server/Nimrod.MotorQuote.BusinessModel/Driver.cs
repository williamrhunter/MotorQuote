namespace Nimrod.MotorQuote.BusinessModel
{
    public class Driver : Person
    {
        public int QuoteId { get; set; }
        public bool HasFullLicence { get; set; }

        public Quote Quote { get; set; }

        public override string ToString()
        {
            return $"{Surname}, {Forenames}";
        }
    }
}