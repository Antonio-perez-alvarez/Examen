using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
    public interface IRepositoryProducts
    {
        IEnumerable<Product> GetAll();
    }
}
