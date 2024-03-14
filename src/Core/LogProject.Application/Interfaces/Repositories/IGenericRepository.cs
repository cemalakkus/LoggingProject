using CQRSProject.Domain.Common;

namespace CQRSProject.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task<T> AddAsync(T entity);
    Task<List<T>> GetAllPagedAsync(int pageNumber, int pageSize);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
