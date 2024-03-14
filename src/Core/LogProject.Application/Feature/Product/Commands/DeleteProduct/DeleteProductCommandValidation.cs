using FluentValidation;

namespace CQRSProject.Application.Feature.Product.Commands.DeleteProduct
{
    public class DeleteProductCommandValidation : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductCommandValidation()
        {
            RuleFor(p => p.Id).NotEmpty().NotNull();
        }
    }
}
