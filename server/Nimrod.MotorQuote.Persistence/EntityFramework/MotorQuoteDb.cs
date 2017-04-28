using System.Data.Entity;
using Nimrod.MotorQuote.BusinessModel;

namespace Nimrod.MotorQuote.Persistence.EntityFramework
{
    public partial class MotorQuoteDb : DbContext
    {
        public MotorQuoteDb(): base("name=MotorQuoteCS") { }

        public virtual DbSet<Accident> Accidents { get; set; }
        public virtual DbSet<Prospect> Prospects { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Endorsement> Endorsements { get; set; }
        public virtual DbSet<EndorsementCode> EndorsementCodes { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Make> Makes { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Style> Styles { get; set; }
        public virtual DbSet<ModelVariant> ModelVariants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
