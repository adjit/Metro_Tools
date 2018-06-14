using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MetroTools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MetroToolsForm());
            }
            else if (args.Length > 0)
            {
                if(args.Length == 1 && HelpRequired(args[0]))
                {
                    MessageBox.Show("Help Me");
                    DisplayHelp();
                }

                switch (args[(int)exportParams.flag])
                {
                    case "-exp":
                        if(args.Length == 3)
                            RunExportOn(args);
                        break;
                    case "-expf":
                        if (args.Length == 4)
                        {
                            Properties.Settings.Default._exportAutosave = true;
                            Properties.Settings.Default._exportSavePath = args[(int)exportParams.savePath];
                            RunExportOn(args);
                        }
                        break;
                    default:
                        break;
                }
            }
            Application.Exit();
        }

        private static void RunExportOn(string[] args)
        {
            string custNum = args[(int)exportParams.custNum];
            int range = Convert.ToInt32(args[(int)exportParams.range]);

            DateTime now = DateTime.Now;
            DateTime startDate = now.AddDays(-range);
            DateTime endDate = now.AddDays(-1);

            CustExport.ExportCustomer(custNum, startDate, endDate);
        }

        private static bool HelpRequired(string param)
        {
            return param == "-h" || param == "--help" || param == "/?";
        }

        private static void DisplayHelp()
        {
            Debug.WriteLine("Help requested");
        }

        private enum exportParams
        {
            flag,
            custNum,
            range,
            savePath
        }

        public enum exportRange
        {
            day = 1,
            week = 7,
            month = 30
        }
    }
}
