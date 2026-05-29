using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Model.InvoiceModel
{
    public class vinInvoice_model
    {
        public int id { get; set; }
        public string invoice_id { get; set; }
        public string invoice_type { get; set; }
        public string invoice_status { get; set; }
        public string payment_status { get; set; }
        public int? job_id { get; set; }
        public string job_name { get; set; }
        public int? contact_id { get; set; }
        public string contact_firstname { get; set; }
        public string contact_middlename { get; set; }
        public string contact_lastname { get; set; }
        public string contact_firstname_kana { get; set; }
        public string contact_lastname_kana { get; set; }
        public string contact_name { get; set; }
        public int? candidate_id { get; set; }
        public string candidate_firstname { get; set; }
        public string candidate_middlename { get; set; }
        public string candidate_lastname { get; set; }
        public string candidate_firstname_kana { get; set; }
        public string candidate_lastname_kana { get; set; }
        public string candidate_name { get; set; }
        public int? company_id { get; set; }
        public string company_name { get; set; }
        public DateTime? invoice_date { get; set; }
        public DateTime? updated_date { get; set; }
        public string currency { get; set; }
        public decimal? amount_due { get; set; }
        public string formatted_amount_due { get; set; }
        public DateTime? due_date { get; set; }
        public int? overdue_by { get; set; }
        public string po_number { get; set; }
        public string timesheet_id { get; set; }
        public int? offer_id { get; set; }
        public string reference { get; set; }
        public int? term { get; set; }
        public string tax_inclusive { get; set; }
        public decimal? discount_amount { get; set; }
        public decimal? total_amount { get; set; }
        public decimal? sub_total_amount { get; set; }
        public decimal? tax_amount { get; set; }
        public decimal? amount_paid { get; set; }
        public int? parent_id { get; set; }
        public decimal? alloc_amount { get; set; }
        public vinInvoice_location_model location { get; set; }
        public string invoice_sub_type { get; set; }
        public string home_currency { get; set; }
        public decimal? bank_spot_rate { get; set; }
        public decimal? conversion_total { get; set; }
        public List<vinInvoice_profit_split_model> profit_split { get; set; }
        public List<vinInvoice_document_model> documents { get; set; }
        public List<vinInvoice_item_model > items { get; set; }
    }

    public class vinInvoice_location_model
    {
        public int? id { get; set; }
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
        public string business_number { get; set; }
        public string company_payment_term { get; set; }
        public bool? primary_billing_address { get; set; }
        public string billing_account_code { get; set; }
    }

    public class vinInvoice_profit_split_model
    {
        public int? user_id { get; set; }
        public string user_firstname { get; set; }
        public string user_lastname { get; set; }
        public decimal? profit_value { get; set; }
        public decimal? profit_amount { get; set; }
        public string split_mode { get; set; }
    }

    public class vinInvoice_document_model
    {
        public string file_name { get; set; }
        public string document_type_id { get; set; }
        public string url { get; set; }
        public bool? original_cv { get; set; }
        public string verify_status { get; set; }
        public string verify_comment { get; set; }
        public DateTime? verify_date { get; set; }
        public DateTime? uploaded_date { get; set; }
        public DateTime? issued_date { get; set; }
        public DateTime? expiry_date { get; set; }
        public int? compliance_status_id { get; set; }
        public int? compliance_condition_id { get; set; }
        public int? candidate_id { get; set; }
        public int? id { get; set; }
        public string external_id { get; set; }

    }

    public class vinInvoice_item_model
    {
        
        public string item_name { get; set; }
        public decimal? quantity { get; set; }
        public decimal? rate { get; set; }
        public decimal? discount { get; set; }
        public string account_name { get; set; }
        public string tax_name { get; set; }
        public decimal? tax { get; set; }
        public decimal? total_amount { get; set; }
        public string invoice_no { get; set; }
        public int? ref_id { get; set; }
    }

}
