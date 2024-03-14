using CQRSProject.Application.Parameters;
using CQRSProject.Application.Wrappers;
using MediatR;

namespace CQRSProject.Application.Feature.Product.Queries.GetPagedAllProducts;

public class GetPagedAllProductsQuery : RequestParameters, IRequest<PagedResponse<IEnumerable<GetPagedAllProductsQueryResponse>>>
{
}
