using CQRSProject.Application.Interfaces.Repositories;
using CQRSProject.Persistence.Context;
using CQRSProject.Persistence.Repositories;
using UnitOfWorkPattern.Application.Interfaces.UnitOfWork;

namespace UnitOfWorkPattern.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _dbContext;
    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        Products = new ProductRepository(_dbContext);
    }

    public IProductRepository Products { get; private set; }

    public Task Complete()
    {
        return _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}
