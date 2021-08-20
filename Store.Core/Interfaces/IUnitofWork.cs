using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository ProductRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
