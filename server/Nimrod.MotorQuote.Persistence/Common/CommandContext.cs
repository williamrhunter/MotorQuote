using System.Data.Entity;

namespace Nimrod.MotorQuote.Persistence.Common
{
    public class CommandContext<TDbContext> : ICommandContext
        where TDbContext: DbContext, new()
    {
        protected TDbContext _context;

        public CommandContext()
        {
            Init();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Revert()
        {
            Init();
        }

        private void Init()
        {
            _context = new TDbContext();
        }
    }
}