using CQRSProject.Application.Interfaces.Repositories;
using CQRSProject.Domain.Entities;
using CQRSProject.Persistence.Context;

namespace CQRSProject.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext dbContext) : base(dbContext)
    {

    }
}
