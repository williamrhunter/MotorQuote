using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nimrod.MotorQuote.BusinessModel
{
    [ComplexType]
    public class Address
    {
        [Column("Address", TypeName = "ntext")]
        public string Lines { get; set; }
        [Column("Town")]
        [StringLength(50)]
        public string Town { get; set; }
        [Column("PostCode")]
        [StringLength(12)]
        public string PostCode { get; set; }
    }
}