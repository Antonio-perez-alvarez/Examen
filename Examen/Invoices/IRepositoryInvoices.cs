using Domain.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Invoices
{
    public interface IRepositoryInvoices
    {
        Invoice Add(Invoice invoice);
        Invoice Get(int id);
        IEnumerable<Invoice> GetAll();
    }

}
