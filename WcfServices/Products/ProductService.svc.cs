using Core;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServices.Products
{
    public class ProductService :ServiceBase, IProductService
    {
        readonly IRepositoryProducts _repository;
        readonly IUnitOfWork _unitOfWork;
        public ProductService(IRepositoryProducts repository, IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            if (null == unitOfWork)
            {
                throw new ArgumentNullException("unitOfWork");
            }
            _unitOfWork = unitOfWork;

            if (null == repository)
            {
                throw new ArgumentNullException("repository");
            }
            _repository = repository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
