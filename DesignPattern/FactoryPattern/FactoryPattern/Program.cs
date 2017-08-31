using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FactoryInvoice;
using InvoiceInterface;


namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int intInvoiceType = 0;
            IInvoice objInvoice;
            Console.WriteLine("enter invoice type");
            intInvoiceType = Convert.ToInt16(Console.ReadLine());
            objInvoice = clsFactoryInvoice.getInvoice(intInvoiceType);
            objInvoice.print();
            Console.ReadLine();
        }
    }
}
