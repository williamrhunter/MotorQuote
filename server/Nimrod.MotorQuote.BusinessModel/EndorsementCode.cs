using System.ComponentModel.DataAnnotations;

namespace Nimrod.MotorQuote.BusinessModel
{
    public class EndorsementCode
    {
        [Key, StringLength(4)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Category { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public override string ToString()
        {
            return Code + " - " + Description;
        }
    }
}