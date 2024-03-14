using FluentValidation;

namespace CQRSProject.Application.Feature.Product.Commands.UpdateProduct
{
    public class UpdateProductCommandValidation : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidation()
        {
            RuleFor(p => p.Id).NotEmpty().NotNull();
            RuleFor(p => p.Name).NotEmpty().NotNull();
            RuleFor(p => p.Price).NotEmpty().NotNull();
            RuleFor(p => p.Quantity).NotEmpty().NotNull();
        }
    }
}
