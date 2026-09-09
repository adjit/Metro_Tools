using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metro.Core;
using Metro.Core.Infrastructure;

namespace MetroTools
{
    internal static class InvoiceWrapper
    {
        internal static void Open(string invoiceNum, GeneralConfigOptions opts)
        {
			try
			{
				Invoices.Open(invoiceNum, opts);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
        }

        internal static void Open(string[] invoiceNums, GeneralConfigOptions opts)
        {
            try
            {
                Invoices.Open(invoiceNums, opts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
