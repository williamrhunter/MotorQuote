using System.Data.Entity;

namespace Nimrod.MotorQuote.Persistence.Common
{
    public class QueryContext<TDbContext> : IQueryContext
        where TDbContext : DbContext, new()
    {
        protected TDbContext _context;

        public QueryContext()
        {
            _context = new TDbContext();
        }
    }
}