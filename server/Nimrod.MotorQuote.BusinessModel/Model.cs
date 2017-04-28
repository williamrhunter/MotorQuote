using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nimrod.MotorQuote.BusinessModel
{
    public class Model : Entity
    {
        [StringLength(50)]
        public string Name { get; set; }
        public int MakeId { get; set; }

        public virtual ICollection<Style> Styles { get; set; }
        public virtual Make Make { get; set; }
    }
}