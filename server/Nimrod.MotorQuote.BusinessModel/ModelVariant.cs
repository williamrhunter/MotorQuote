using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Nimrod.MotorQuote.BusinessModel
{
    public class ModelVariant : Entity
    {
        [StringLength(12)]
        public string Year { get; set; }
        public int Group { get; set; }
        public int StyleId { get; set; }

        public virtual Style Style { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = base.Validate(validationContext).ToList();
            dynamic value = validationContext.ObjectInstance;
            switch (validationContext.MemberName)
            {
                case nameof(Group):
                    if (value < 1 || value > 50)
                        results.Add(new ValidationResult("Invalid group code", new[] { nameof(Group) }));
                    break;
                case nameof(Year):
                    if (value < 1900 || value > DateTime.Now.Year + 1)
                        results.Add(new ValidationResult("Invalid year", new[] { nameof(Year) }));
                    break;
            }
            return results;
        }
    }
}