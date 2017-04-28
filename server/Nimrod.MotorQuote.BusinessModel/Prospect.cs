namespace Nimrod.MotorQuote.BusinessModel
{
    public class Prospect : Person
    {
        public Address Address { get; set; }
        public int NoClaims { get; set; }
    }
}