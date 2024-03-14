using AutoMapper;
using CQRSProject.Application.Wrappers;
using MediatR;
using UnitOfWorkPattern.Application.Interfaces.UnitOfWork;

namespace CQRSProject.Application.Feature.Product.Queries.GetPagedAllProducts;

public class GetPagedAllProductsQueryHandler : IRequestHandler<GetPagedAllProductsQuery, PagedResponse<IEnumerable<GetPagedAllProductsQueryResponse>>>
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;
    public GetPagedAllProductsQueryHandler(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }
    public async Task<PagedResponse<IEnumerable<GetPagedAllProductsQueryResponse>>> Handle(GetPagedAllProductsQuery request, CancellationToken cancellationToken)
    {
        var result = await _uow.Products.GetAllPagedAsync(request.PageNumber, request.PageSize);

        var resulViewModelList = _mapper.Map<IEnumerable<GetPagedAllProductsQueryResponse>>(result);

        return new PagedResponse<IEnumerable<GetPagedAllProductsQueryResponse>>(resulViewModelList, request.PageNumber, request.PageSize);
    }
}
