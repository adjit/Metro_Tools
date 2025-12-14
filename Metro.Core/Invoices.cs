using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Metro.Core.Infrastructure;

namespace Metro.Core
{
    public class Invoices
    {
        public static void Open(string invoiceNum, GeneralConfigOptions opts)
        {
            openInvoice(invoiceNum, opts);
        }

        public static void Open(string[] invoiceNums, GeneralConfigOptions opts)
        {
            for (int i = 0; i < invoiceNums.Length; i++)
            {
                openInvoice(invoiceNums[i], opts);
            }
        }

        private static void openInvoice(string invoiceNum, GeneralConfigOptions opts)
        {
            //string[] _dirs = Directory.GetDirectories(Properties.Settings.Default.INVOICE_FILEPATH, "20*Invoices");

            Queue<string> dirsToSearch = new Queue<string>();

            string primaryPath = opts.InvoiceArchive;
            string primaryHistoricalPath = opts.InvoiceFilePath;
            DirectoryInfo primaryDInfo = new DirectoryInfo(primaryPath);

            dirsToSearch.Enqueue(primaryPath);

            string[] primaryHistoricalDirs = Directory.GetDirectories(primaryHistoricalPath, "20*Invoices");

            foreach (string dir in primaryHistoricalDirs)
            {
                dirsToSearch.Enqueue(dir);
            }

            //string secondaryPath = $"{opts.InvoiceFallback}Archive";
            //string secondaryHistoricalPath = $"{opts.InvoiceFallback}";
            //DirectoryInfo secondaryDInfo = new DirectoryInfo(primaryPath);

            //dirsToSearch.Enqueue(secondaryPath);

            //string[] secondaryHistoricalDirs = Directory.GetDirectories(secondaryHistoricalPath, "20*Invoices");

            //foreach (string dir in secondaryHistoricalDirs)
            //{
            //    dirsToSearch.Enqueue(dir);
            //}

            IEnumerable<FileInfo> files = new List<FileInfo>();
            string searchPattern = $"in-*-{invoiceNum}-{invoiceNum}-*";

            while (dirsToSearch.Count > 0 && files.Count() == 0)
            {
                string dir = dirsToSearch.Dequeue();
                var dInfo = new DirectoryInfo(dir);
                files = dInfo.GetFiles(searchPattern);
            }

            //FileInfo[] filesInDir = _dInfo.GetFiles("in-*" + "-" + invoiceNum + "-" + invoiceNum + "-" + "*");

            //int iCounter = _dirs.Length - 1;

            //while(filesInDir.Length == 0)
            //{
            //    if (iCounter < 0) break;

            //    DirectoryInfo dInfo = new DirectoryInfo(_dirs[iCounter]);
            //    filesInDir = dInfo.GetFiles("in-*" + "-" + invoiceNum + "-" + invoiceNum + "-" + "*");

            //    iCounter--;
            //}

            try
            {
                System.Diagnostics.Process.Start(files.First().FullName);
            }
            catch (Exception)
            {
                throw new FileNotFoundException($"Error Finding and Opening Invoice in {primaryDInfo.FullName}. Please use Liason.\nInvoice Number: {invoiceNum}");
            }
        }
    }
}
