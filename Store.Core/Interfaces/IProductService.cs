using Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> Find();

        Task<Product> FindOne(int id);

        Task Add(Product product);

        Task<bool> Update(int id, Product product);

        Task<bool> Delete(int id);
    }
}
