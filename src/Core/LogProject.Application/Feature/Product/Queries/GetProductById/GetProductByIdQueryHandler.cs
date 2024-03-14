using AutoMapper;
using CQRSProject.Application.Wrappers;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Text.Json;
using UnitOfWorkPattern.Application.Interfaces.UnitOfWork;

namespace CQRSProject.Application.Feature.Product.Queries.GetProductById;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ApiResponse<GetProductByIdQueryResponse>>
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;
    public GetProductByIdQueryHandler(IUnitOfWork uow, IMapper mapper, ILogger<GetProductByIdQueryHandler> logger)
    {
        _uow = uow;
        _mapper = mapper;
        _logger = logger;
    }
    public async Task<ApiResponse<GetProductByIdQueryResponse>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        _logger.LogInformation(
            "Request:" + JsonConvert.SerializeObject(request)
            );
        var result = await _uow.Products.GetByIdAsync(request.Id);

        var resulViewModelList = _mapper.Map<GetProductByIdQueryResponse>(result);

        _logger.LogInformation(
            "Response:" + JsonConvert.SerializeObject(resulViewModelList)
            );

        return new ApiResponse<GetProductByIdQueryResponse>(resulViewModelList);
    }
}
