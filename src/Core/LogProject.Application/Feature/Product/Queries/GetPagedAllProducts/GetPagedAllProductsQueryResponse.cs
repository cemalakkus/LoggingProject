namespace CQRSProject.Application.Feature.Product.Queries.GetPagedAllProducts;

public class GetPagedAllProductsQueryResponse
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
