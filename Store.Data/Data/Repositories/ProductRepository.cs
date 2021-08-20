using Store.Core.Entities;
using Store.Core.Interfaces;
using Store.Infraestructura.Data;

namespace Store.Infraestructura.Data.Repositories
{
    public class ProductRepository: BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StoreContext context) : base(context) { }
    }
}
