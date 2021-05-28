using Microsoft.Xrm.Tooling.Connector;
using System;

namespace ConnectMSDataverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string msdataverseURL = "https://polearn.crm.dynamics.com;";
            string applicationID = "1676c3f0-be0b-498a-9186-425bded41fea";
            string appSecret = "5xQ-dM~lTjYkr-Saz64lfw99g2ytp.0WKW";
            string connectionString = "AuthType=ClientSecret; url=" + msdataverseURL + "ClientId=" + applicationID + ";" + "ClientSecret=" + appSecret;
            CrmServiceClient crmServiceClient = new CrmServiceClient(connectionString);
            try
            {
                if (crmServiceClient != null && crmServiceClient.IsReady)
                {
                    Console.WriteLine("\nConnection successfull.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nPlease make sure the Connection String is correct.");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}