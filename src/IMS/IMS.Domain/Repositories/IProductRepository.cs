using IMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
    }
}
