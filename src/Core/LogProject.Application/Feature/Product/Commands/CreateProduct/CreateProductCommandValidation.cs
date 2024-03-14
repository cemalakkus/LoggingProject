using FluentValidation;

namespace CQRSProject.Application.Feature.Product.Commands.CreateProduct
{
    public class CreateProductCommandValidation : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidation()
        {
            RuleFor(p => p.Name).NotEmpty().NotNull();
            RuleFor(p => p.Price).NotEmpty().NotNull();
            RuleFor(p => p.Quantity).NotEmpty().NotNull();
        }
    }
}
