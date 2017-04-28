using System.Data.Entity;
using Nimrod.MotorQuote.BusinessModel;
using Nimrod.MotorQuote.Persistence.Common;

namespace Nimrod.MotorQuote.Persistence
{
    public interface IMotorQuoteCommandContext : ICommandContext
    {
        DbSet<Accident> Accidents { get; }
        DbSet<Driver> Drivers { get; }
        DbSet<Model> Models { get; }
        DbSet<ModelVariant> ModelVariants { get; }
        DbSet<Prospect> Prospects { get; }
        DbSet<Quote> Quotes { get; }
        DbSet<Style> Styles { get; }
        DbSet<Vehicle> Vehicles { get; }
    }
}