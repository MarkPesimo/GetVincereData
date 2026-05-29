using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Model.CompanyModel
{
    public class VinCompany_Location_model
    {
        //public int MyProperty { get; set; }
        public int id { get; set; }        
        public string address { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string location_name { get; set; }
        public string address_line1 { get; set; }
        public string address_line2 { get; set; }
        public string post_code { get; set; }
        public string country_code { get; set; }
        public string country { get; set; }
        public string nearest_train_station { get; set; }
        public decimal? longitude { get; set; }
        public decimal? latitude { get; set; }
        public List<string> location_types { get; set; }
        public string billing_group_name { get; set; }
        public string trading_name { get; set; }
        public string general_po_number { get; set; }
        public bool? tax_exempt { get; set; }
        public string company_number { get; set; }
        public string company_payment_term { get; set; }
        public bool? primary_billing_address { get; set; }
        public string billing_account_code { get; set; }


    }

    public class VinCompany_Location_type
    {
        public string location_types { get; set; }
    }
}
