using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nimrod.MotorQuote.BusinessModel
{
    public  class Entity : IEntity
    {
        public int Id { get; set; }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return new List<ValidationResult>();
        }
    }
}