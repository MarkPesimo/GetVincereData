using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Model.JobModel
{
    public class JobApplication_Search_model
    {
        public int slice_index { get; set; }
        public int num_of_elements { get; set; }
        public bool last { get; set; }
        public List<vinJob_application_model> content { get; set; }
    }


    public class vinJob_application_model
    {
        public int? candidate_id { get; set; }
        public string candidate_first_name { get; set; }
        public string candidate_last_name { get; set; }
        public string candidate_middle_name { get; set; }
        public int? company_id { get; set; }
        public string company_name { get; set; }
        public int? creator_id { get; set; }
        public DateTime? cv_sent_stage_associated_date { get; set; }
        public string external_id { get; set; }
        public int id { get; set; }
        public DateTime? interview_1_stage_associated_date { get; set; }
        public DateTime? interview_2_plus_stage_associated_date { get; set; }
        public DateTime? invoice_stage_associated_date { get; set; }
        public int? job_id { get; set; }
        public string job_title { get; set; }
        public string job_type { get; set; }
        public string job_category { get; set; }
        public DateTime? offer_stage_associated_date { get; set; }
        public DateTime? placed_stage_associated_date { get; set; }
        public DateTime? work_start_date { get; set; }
        public DateTime? work_end_date { get; set; }
        public DateTime? registration_date { get; set; }
        public DateTime? shortlisted_stage_associated_date { get; set; }
        public DateTime? application_stage_associated_date { get; set; }
        public substatus_model substatus { get; set; }
        public string stage { get; set; }
        public string status { get; set; }
        public List<string> valid_move_forward_stages { get; set; }
        public int? customer_portal_document_count { get; set; }
        public DateTime? modified_date { get; set; }
        public string candidate_status { get; set; }
        public int? candidate_status_id { get; set; }
        public decimal? profit { get; set; }
        public string formatted_profit { get; set; }
        public string currency { get; set; }
        public int? placement_id { get; set; }

        public int? application_source_id { get; set; }
        public int? application_user_id { get; set; }
        public int? shortlisted_user_id { get; set; }
        public string offer_pdf_url { get; set; }
        public work_address_model work_address { get; set; }
        
        
        public DateTime? first_interview_date { get; set; }
        public DateTime? second_plus_interview_date { get; set; }
    }

    public class substatus_model
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string color_code { get; set; }

        public substatus_model()
        {
            id = 0;
            name = "";
            color_code = "";
        }
    }

    public class work_address_model
    {
        public int? id { get; set; }
        public string location_name { get; set; }
        public string address { get; set; }
        public string address_line1 { get; set; }
        public string address_line2 { get; set; }
        public string district_suburb { get; set; }
        public string town_city { get; set; }
        public string zip_postal_code { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string nearest_train_stn { get; set; }
        public string type { get; set; }
        public string types { get; set; }
        public string phone_number { get; set; }
        public string note { get; set; }

        public work_address_model()
        {
            id = 0;
            location_name = "";
            address = "";
            address_line1 = "";
            address_line2 = "";
            district_suburb = "";
            town_city = "";
            zip_postal_code = "";
            country = "";
            state = "";
            nearest_train_stn = "";
            type = "";
            types = "";
                phone_number = "";
            
            note = "";
        }
    }

}
