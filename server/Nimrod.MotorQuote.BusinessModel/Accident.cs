using System;
using System.ComponentModel.DataAnnotations;
using Nimrod.MotorQuote.BusinessModel.Enums;

namespace Nimrod.MotorQuote.BusinessModel
{
    public class Accident : Entity
    {
        public int QuoteId { get; set; }
        public DateTime Date { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public int Claim { get; set; }

        public Fault Fault { get; set; }

        public Quote Quote { get; set; }
    }
}