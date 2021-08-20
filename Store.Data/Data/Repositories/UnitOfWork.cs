using Store.Core.Interfaces;
using Store.Infraestructura.Data;
using System.Threading.Tasks;

namespace Store.Infraestructura.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext _context;
        public IProductRepository ProductRepository => new ProductRepository(_context);

        public UnitOfWork(StoreContext context)
        {
            _context = context;
        }


        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
