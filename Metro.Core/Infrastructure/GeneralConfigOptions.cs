using System;
using System.Collections.Generic;
using System.Text;

namespace Metro.Core.Infrastructure
{
    public class GeneralConfigOptions
    {
        public string DBConnectionString { get; set; }
        public string InvoiceArchive { get; set; }
        public string InvoiceFilePath { get; set; }
        public string InvoiceFallback { get; set; }
        public string AvalaraKey { get; set; }
        public string AvalaraAccountId { get; set; }
        public string AvalaraAccountName { get; set; }
    }
}
