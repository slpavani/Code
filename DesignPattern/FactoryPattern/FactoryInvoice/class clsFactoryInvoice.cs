using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryInvoice;
using InvoiceInterface;
using Invoice;

namespace FactoryInvoice
{
    public class clsFactoryInvoice
    {
         public static IInvoice getInvoice(int intInvoicetype)
         {
            IInvoice objInvoice;
            if (intInvoicetype == 1)
            {
                objInvoice = new clsInvoiceWithHeaders();
            }
            else if (intInvoicetype == 2)
            {
                objInvoice = new clsInvoiceWithOutHeaders();
            }
            else
            {
                return null;
            }
            return objInvoice;
        }
    }
}
