using CQRSProject.Application.Wrappers;
using MediatR;

namespace CQRSProject.Application.Feature.Product.Commands.DeleteProduct;

public class DeleteProductCommand : IRequest<ApiResponse<string>>
{
    public Guid Id { get; set; }
}
