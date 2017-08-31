using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceInterface;

namespace Invoice
{
    public class clsInvoiceWithHeaders :IInvoice
    {
        public void print()
        {
            Console.WriteLine("with Headers");
        }
    }
}
