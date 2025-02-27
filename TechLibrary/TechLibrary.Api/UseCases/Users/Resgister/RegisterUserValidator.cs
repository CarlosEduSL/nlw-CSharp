using FluentValidation;
using TechLibrary.Communication.Requests;

namespace TechLibrary.Api.UseCases.Users.Resgister
{
    public class RegisterUserValidator : AbstractValidator<RequestUserJson>
    {
        public RegisterUserValidator()
        {
            RuleFor(request => request.Name).NotEmpty().WithMessage("O preenchimento do Nome é obrigatório.");
            RuleFor(request => request.Email).EmailAddress().WithMessage("O seu e-mail nao é valido");
            RuleFor(request => request.Password).NotEmpty().WithMessage("Preencha a senha!");
            When(request => string.IsNullOrEmpty(request.Password) == false, () =>
            {
                RuleFor(request => request.Password.Length).GreaterThanOrEqualTo(6).WithMessage("Sua senha precisa conter mais que 6 caracteres.");
            });
        }
    }
}
