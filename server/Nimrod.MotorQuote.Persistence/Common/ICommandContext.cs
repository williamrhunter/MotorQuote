namespace Nimrod.MotorQuote.Persistence.Common
{
    public interface ICommandContext
    {
        void Commit();
        void Revert();
    }
}
