using AutoMapper;
using CQRSProject.Application.Exceptions;
using CQRSProject.Application.Wrappers;
using MediatR;
using UnitOfWorkPattern.Application.Interfaces.UnitOfWork;

namespace CQRSProject.Application.Feature.Product.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ApiResponse<string>>
    {
        private readonly IUnitOfWork _uow;
        public UpdateProductCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<ApiResponse<string>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _uow.Products.GetByIdAsync(request.Id);

            if (product is null) throw new ApiException($"Product Not Found.");

            product.Name = request.Name;
            product.Price = request.Price;
            product.Quantity = request.Quantity;

            await _uow.Products.UpdateAsync(product);

            await _uow.Complete();

            return new ApiResponse<string>(string.Empty, "Success");
        }
    }
}
