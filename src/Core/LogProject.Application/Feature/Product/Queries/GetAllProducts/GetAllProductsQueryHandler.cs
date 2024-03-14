using AutoMapper;
using CQRSProject.Application.Wrappers;
using MediatR;
using UnitOfWorkPattern.Application.Interfaces.UnitOfWork;

namespace CQRSProject.Application.Feature.Product.Queries.GetAllProducts;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ApiResponse<IEnumerable<GetAllProductsQueryResponse>>>
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;
    public GetAllProductsQueryHandler(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }
    public async Task<ApiResponse<IEnumerable<GetAllProductsQueryResponse>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var result = await _uow.Products.GetAllAsync();

        var resulViewModelList = _mapper.Map<IEnumerable<GetAllProductsQueryResponse>>(result);

        return new ApiResponse<IEnumerable<GetAllProductsQueryResponse>>(resulViewModelList);
    }
}
