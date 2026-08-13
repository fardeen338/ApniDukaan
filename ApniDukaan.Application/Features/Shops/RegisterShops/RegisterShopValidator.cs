using FluentValidation;

namespace ApniDukaan.Application.Features.Shops.RegisterShops
{
    public class RegisterShopValidator : AbstractValidator<RegisterShopRequest>
    {
        public RegisterShopValidator()
        {
            RuleFor(x => x.ShopName)
                .NotEmpty().WithMessage("Shop name is required.")
                .MaximumLength(80).WithMessage("Shop name cannot exceed 100 characters.");
            RuleFor(x => x.MobileNumber)
                .NotEmpty().WithMessage("Mobile number is required.")
                .Matches(@"^\d{10}$").WithMessage("Mobile number must be a valid 10-digit number.");
            RuleFor(x => x.GSTNUmber).MaximumLength(15).WithMessage("GST number cannot exceed 15 characters.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name cannot exceed 50 characters.");
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long.");
        }
    }
}
