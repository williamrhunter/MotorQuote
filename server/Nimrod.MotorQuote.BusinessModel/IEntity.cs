using System.ComponentModel.DataAnnotations;

namespace Nimrod.MotorQuote.BusinessModel
{
    public interface IEntity : IValidatableObject
    {
        int Id { get; set; }
    }
}