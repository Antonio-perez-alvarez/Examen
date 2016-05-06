using Core;
using Domain.Invoices;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServices.Invoices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class InvoiceService : ServiceBase, IInvoiceService
       {
        readonly IRepositoryInvoices _repository;
        readonly IUnitOfWork _unitOfWork;
        public InvoiceService(IRepositoryInvoices repository, IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {            
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Invoice Add(Invoice invoice)
        {
            foreach (var item in invoice.InvoicesDetail)
            {
                item.Price = item.Product.Price;
            }

            var customerNew = _repository.Add(invoice);
            SaveChanges();
            return customerNew;
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public Invoice Get(int id)
        {
            return _repository.Get(id);
        }
    }
}
