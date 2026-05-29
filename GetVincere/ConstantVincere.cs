using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere
{
    public class ConstantVincere
    {
        public static string apiURL = ConfigurationManager.AppSettings["ApiURL"];
        public static string TenantId = ConfigurationManager.AppSettings["TenantId"];
        public static string ApiKEY = ConfigurationManager.AppSettings["ApiKEY"];

        public static string GetCandidateEndpoint = ConfigurationManager.AppSettings["GetCandidateEndpoint"];
        public static string GetJobEndpoint = ConfigurationManager.AppSettings["GetJobEndpoint"];
        public static string GetCompanyEndpoint = ConfigurationManager.AppSettings["GetCompanyEndpoint"];
        public static string GetPlacementEndpoint = ConfigurationManager.AppSettings["GetPlacementEndpoint"];
        public static string GetInvoiceEndpoint = ConfigurationManager.AppSettings["GetInvoiceEndpoint"];


        public static string SearchCandidateEndpoint = ConfigurationManager.AppSettings["SearchCandidateEndpoint"];
        public static string SearchJobEndpoint = ConfigurationManager.AppSettings["SearchJobEndpoint"];
        public static string SearchCompanyEndpoint = ConfigurationManager.AppSettings["SearchCompanyEndpoint"];

        public static string TokedId = "";
    }
}
