using System.Collections.Generic;

namespace Nimrod.MotorQuote.BusinessModel
{
    public partial class Quote : Entity
    {
        public int ProspectId { get; set; }
        public int VehicleId { get; set; }

        public virtual Prospect Client { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<Accident> Accidents { get; set; }
        public virtual ICollection<Endorsement> Endorsements { get; set; }
    }
}
