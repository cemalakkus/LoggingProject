using CQRSProject.Application.Feature.Product.Queries.GetProductById;
using CQRSProject.Application.Wrappers;
using MediatR;

namespace CQRSProject.Application.Feature.Product.Queries.GetProductById;

public class GetProductByIdQuery : IRequest<ApiResponse<GetProductByIdQueryResponse>>
{
    public Guid Id { get; set; }
}
