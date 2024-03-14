using CQRSProject.Application.Wrappers;
using MediatR;

namespace CQRSProject.Application.Feature.Product.Commands.UpdateProduct;

public class UpdateProductCommand : IRequest<ApiResponse<string>>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
