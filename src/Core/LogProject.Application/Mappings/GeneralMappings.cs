using AutoMapper;
using CQRSProject.Application.Feature.Product.Commands.CreateProduct;
using CQRSProject.Application.Feature.Product.Queries.GetAllProducts;
using CQRSProject.Application.Feature.Product.Queries.GetPagedAllProducts;
using CQRSProject.Application.Feature.Product.Queries.GetProductById;
using CQRSProject.Domain.Entities;

namespace CQRSProject.Application.Mappings;

public class GeneralMappings : Profile
{
    public GeneralMappings()
    {
        CreateMap<Product, GetPagedAllProductsQueryResponse>();
        CreateMap<Product, GetAllProductsQueryResponse>();
        CreateMap<Product, GetProductByIdQueryResponse>();
        CreateMap<Product, GetProductByIdQueryResponse>();
        CreateMap<CreateProductCommand, Product>();
    }
}
