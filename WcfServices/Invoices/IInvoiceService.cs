using Domain.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WcfServices.Invoices
{

    [ServiceContract]
    public interface IInvoiceService
    {

        [OperationContract]
        Invoice Add(Invoice invoice);

        [OperationContract]
        IEnumerable<Invoice> GetAll();

        [OperationContract]
        Invoice Get(int id);

    }
}