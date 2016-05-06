using Core;
using Domain.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class RepositoryInvoice:RepositoryBase<Invoice>,IRepositoryInvoices
    {
        public RepositoryInvoice(IDbBase ctx)
            :base(ctx)
        {

        }

        public Invoice Add(Invoice invoice)
        {
            Entity.Add(invoice);
            return invoice;
        }

        public Invoice Get(int id)
        {
            return Entity.Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Invoice> GetAll()
        {
            return Entity.Select(c => c);
        }
    }
}
