using FluentValidation;

namespace Demo.Domain.Application.Commands.Validators
{
    public class CreateBookCommndValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommndValidator()
        {
            RuleFor(a => a.Title)
                .NotEmpty()
                .WithMessage("O Title é obrigatório");
        }
    }
}
