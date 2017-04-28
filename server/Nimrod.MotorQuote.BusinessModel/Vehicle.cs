using System;
using System.ComponentModel.DataAnnotations;

namespace Nimrod.MotorQuote.BusinessModel
{
    public class Vehicle : Entity
    {
        [StringLength(12)]
        public string RegistrationNumber { get; set; }

        public int ModelVariantId { get; set; }

        [StringLength(20)]
        public string Colour { get; set; }

        public DateTime DatePurchased { get; set; }

        public ModelVariant ModelVariant { get; set; }
    }
}