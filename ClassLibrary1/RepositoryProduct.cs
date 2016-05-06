using Core;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProducts
    {
        public RepositoryProduct(IDbBase ctx)
            : base(ctx)
        {

        }
        public IEnumerable<Product> GetAll()
        {
            return Entity.Select(c => c);
        }
    }
}
