using CQRSProject.Application.Parameters;

namespace CQRSProject.Application.Feature.Product.Queries.GetAllProducts;

public class GetAllProductsQueryResponse
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
