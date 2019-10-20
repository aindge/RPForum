using FluentValidation;
using FluentValidation.Results;

namespace RpForum.ViewModels
{
    public abstract class CommandViewModel
    {
        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid => ValidationResult?.IsValid ?? false;

        public void Validate(IValidator validator)
        {
            ValidationResult = validator.Validate(this);
        }
    }
}