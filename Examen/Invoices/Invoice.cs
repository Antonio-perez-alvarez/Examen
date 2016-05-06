using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Invoices
{
    public class Invoice:EntityBase
    {
        public Invoice()
        {
            InvoicesDetail = new HashSet<InvoiceDetail>();
        }
        [Required]
        public DateTime Date { get; set; }
        public virtual ICollection<InvoiceDetail> InvoicesDetail { get; set; }
    }
}
