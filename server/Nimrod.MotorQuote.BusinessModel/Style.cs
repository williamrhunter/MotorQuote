using System.ComponentModel.DataAnnotations;

namespace Nimrod.MotorQuote.BusinessModel
{
    public class Style : Entity
    {
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Cc { get; set; }

        public int Group { get; set; }

        [StringLength(50)]
        public string ModelStyle { get; set; }

        public int ModelId { get; set; }

        public virtual Model Model { get; set; }
    }
}