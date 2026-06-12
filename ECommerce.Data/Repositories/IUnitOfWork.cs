using ECommerce.Data.Entities;

namespace ECommerce.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<User> Users { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<OrderItem> OrderItems { get; }

        Task<int> SaveChangesAsync();
    }
}