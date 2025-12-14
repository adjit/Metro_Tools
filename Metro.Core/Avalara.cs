using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using Avalara.AvaTax.RestClient;
using Metro.Core.Infrastructure;

namespace Metro.Core
{
    public class Avalara
    {
        private static AvaTaxClient avClient;
        private static int METSALES = 196080;
        private static bool connectionStatus;

        public static DataTable ExemptionLookup(string customer, GeneralConfigOptions opts)
        {
            DataTable responseTable = new DataTable();

            //string serializedKey, username, login;
            //AvaTaxKey key = new AvaTaxKey();
            //try
            //{
            //    serializedKey = System.IO.File.ReadAllText(Properties.Settings.Default.AVALARA_KEY);
            //    key = JsonConvert.DeserializeObject<AvaTaxKey>(serializedKey);

            //    //var connections = connection.Split(';');
            //    //username = connections[0];
            //    //login = connections[1];
            //}
            //catch (Exception e)
            //{

            //}

            avClient = new AvaTaxClient("MetroTools", "1.0", Environment.MachineName, AvaTaxEnvironment.Production)
                .WithSecurity(opts.AvalaraAccountId, opts.AvalaraKey);
            //.WithSecurity(username, login);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var pingResult = avClient.Ping();

            connectionStatus = (bool)pingResult.authenticated;
            if (connectionStatus)
            {
                var customerResult = avClient.ListCertificatesForCustomer(METSALES, customer, null, null, null, null, null);

                responseTable.Columns.Add("Exposure Zone", typeof(string));
                responseTable.Columns.Add("Exempt Reason", typeof(string));
                responseTable.Columns.Add("Expires", typeof(DateTime));

                if (customerResult.count == 0)
                {
                    responseTable.Rows.Add("NO RESALE", "Not Exempt", DateTime.Now);
                }
                else
                {
                    for (int i = 0; i < customerResult.count; i++)
                    {
                        var thisVal = customerResult.value[i];
                        string exZone = thisVal.exposureZone.name;
                        string exReason = thisVal.exemptionReason.name;
                        bool validity = (bool)thisVal.valid;
                        DateTime signDate = thisVal.signedDate;
                        DateTime? expiryDate = thisVal.expirationDate;

                        responseTable.Rows.Add(exZone, exReason, expiryDate);
                    }
                }

            }
            else return null;

            return responseTable;
        }
    }
}
