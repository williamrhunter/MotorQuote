using System;
using System.ComponentModel.DataAnnotations;

namespace Nimrod.MotorQuote.BusinessModel
{
    public class Endorsement : Entity
    {
        public int QuoteId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
        public DateTime Date { get; set; }

        [StringLength(4)]
        public string Code { get; set; }

        public int PenaltyPoints { get; set; }

        public Quote Quote { get; set; }

        public override string ToString()
        {
            return $"{Date:d} {Code}";
        }
    }
}