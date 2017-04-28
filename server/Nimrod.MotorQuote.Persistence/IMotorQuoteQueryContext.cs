using System.Linq;
using Nimrod.MotorQuote.BusinessModel;
using Nimrod.MotorQuote.Persistence.Common;

namespace Nimrod.MotorQuote.Persistence
{
    public interface IMotorQuoteQueryContext : IQueryContext
    {
        IQueryable<Accident> Accidents { get; }
        IQueryable<Driver> Drivers { get; }
        IQueryable<Make> Makes { get; }
        IQueryable<Model> Models { get; }
        IQueryable<ModelVariant> ModelVariants { get; }
        IQueryable<Prospect> Prospects { get; }
        IQueryable<Quote> Quotes { get; }
        IQueryable<Style> Styles { get; }
        IQueryable<Vehicle> Vehicles { get; }
    }
}