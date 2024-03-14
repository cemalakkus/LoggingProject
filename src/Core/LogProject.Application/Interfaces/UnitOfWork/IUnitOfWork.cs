using CQRSProject.Application.Interfaces.Repositories;

namespace UnitOfWorkPattern.Application.Interfaces.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IProductRepository Products { get; }
    Task Complete();
}
