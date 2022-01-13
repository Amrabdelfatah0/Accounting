using Accounting.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.Models
{
    public class Invoices : BaseWithDate
    {
        public string customerInvoice { get; set; }
        public int batchReferenceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime dueDate { get; set; }

    }
}
