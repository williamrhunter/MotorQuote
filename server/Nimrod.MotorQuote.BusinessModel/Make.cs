using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nimrod.MotorQuote.BusinessModel
{
    public class Make : Entity
    {
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}