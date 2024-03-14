using CQRSProject.Application.Wrappers;
using MediatR;

namespace CQRSProject.Application.Feature.Product.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<ApiResponse<IEnumerable<GetAllProductsQueryResponse>>>
{
}
