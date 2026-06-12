using ECommerce.Data.Context;
using ECommerce.Data.Entities;

namespace ECommerce.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context; 

        Products = new GenericRepository<Product>(_context);
        Categories = new GenericRepository<Category>(_context);
        Users = new GenericRepository<User>(_context);
        Orders = new GenericRepository<Order>(_context);
        OrderItems = new GenericRepository<OrderItem>(_context);

        }

       public IGenericRepository<Product> Products { get; private set; }
       public IGenericRepository<Category> Categories {get; private set; }
       public IGenericRepository<User> Users {get; private set; }
       public IGenericRepository<Order> Orders {get; private set; }
       public IGenericRepository<OrderItem> OrderItems {get; private set; }

      public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync(); 

        }

        public void Dispose()
        {
            _context.Dispose(); 
        }

    }
}