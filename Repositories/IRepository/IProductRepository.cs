using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IProductRepository : IEFRepository<ProductEntity, ProductEntity>
    {
        Task<List<ProductEntity>> GetAllWithDetail(CancellationToken cancellationToken);
    }
}
