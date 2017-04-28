using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Nimrod.MotorQuote.BusinessModel
{
    public class Person : Entity
    {
        private string _sex;

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Forenames { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        public string Sex
        {
            get { return _sex; }
            set
            {
                if ("Male".StartsWith(value, StringComparison.CurrentCultureIgnoreCase))
                    _sex = "Male";
                else if ("Female".StartsWith(value, StringComparison.CurrentCultureIgnoreCase))
                    _sex = "Female";
                else
                    _sex = value;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = base.Validate(validationContext).ToList();
            if (Sex != "Male" && Sex != "Female")
                result.Add(new ValidationResult("Must be 'Male' or 'Female'"));
            return result;
        }
    }
}