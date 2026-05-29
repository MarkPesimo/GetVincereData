using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Model.Candidate
{
    public class VinCandidate_model
    {
        public string affiliations { get; set; }
        public string availability { get; set; }
        public DateTime? availability_start { get; set; }
        public int? candidate_source_id { get; set; }
        public string candidate_source_name { get; set; }
        public string job_title { get; set; }
        public int? company_count { get; set; }
        public string company_name { get; set; }
        public string company_number { get; set; }
        public string contract_interval { get; set; }
        public decimal? contract_rate { get; set; }
        public string country_of_domicile { get; set; }
        public int? creator_id { get; set; }
        public string currency_type { get; set; }
        public decimal? current_bonus { get; set; }
        public decimal? current_salary { get; set; }
        public DateTime? date_of_birth { get; set; }
        public decimal? desired_bonus { get; set; }
        public decimal? desired_contract_rate { get; set; }
        public decimal? desired_salary { get; set; }
        public decimal? desired_salary_monthly { get; set; }
        public string driving_license_number { get; set; }
        public string driving_license_type { get; set; }
        public string education_summary { get; set; }
        public string email { get; set; }
        public string employment_type { get; set; }
        public string experience { get; set; }
        public string external_id { get; set; }
        public string emergency_name { get; set; }
        public string emergency_phone { get; set; }
        public string emergency_relationship { get; set; }
        public string emergency_email { get; set; }
        public string facebook { get; set; }
        public string first_name { get; set; }
        public string first_name_kana { get; set; }
        public string gender { get; set; }
        public string gender_title { get; set; }
        public string highest_job_application_stage { get; set; }
        public string home_phone { get; set; }
        public int id { get; set; }
        public int? ielts_score { get; set; }
        public string keyword { get; set; }
        public string last_name { get; set; }
        public string last_name_kana { get; set; }
        public int? linked_contact_id { get; set; }
        public string linked_in { get; set; }
        public string marital_status { get; set; }
        public string met_status { get; set; }
        public string middle_name { get; set; }
        public string middle_name_kana { get; set; }
        public string mobile { get; set; }
        public string nationality { get; set; }
        public string nearest_train_station { get; set; }
        public string note { get; set; }
        public int? note_by { get; set; }
        public DateTime? note_on { get; set; }
        public int? notice_days { get; set; }
        public string objective { get; set; }
        public string other_benefits { get; set; }
        public string payment_type { get; set; }
        public string payslip_email { get; set; }
        public string passport_no { get; set; }
        public string personal_statements { get; set; }
        public string phone { get; set; }
        public string photo_url { get; set; }
        public string place_of_birth { get; set; }
        public string preferred_language { get; set; }
        public decimal? present_salary_rate { get; set; }
        public string publications { get; set; }
        public string reference { get; set; }
        public DateTime? registration_date { get; set; }
        public bool relocate { get; set; }
        public int? salary_months_per_year { get; set; }
        public string salary_type { get; set; }
        public string skills { get; set; }
        public string statements { get; set; }
        public string summary { get; set; }
        public int? toeic_score { get; set; }
        public int? total_gross { get; set; }
        public string twitter { get; set; }
        public string variant { get; set; }
        public string visa_note { get; set; }
        public string visa_number { get; set; }
        public DateTime? visa_renewal_date { get; set; }
        public string visa_status { get; set; }
        public string visa_type { get; set; }
        public string website { get; set; }
        public string work_email { get; set; }
        public string work_phone { get; set; }
        public string xing { get; set; }
        public DateTime? updated_timestamp { get; set; }
        public string nickname { get; set; }
        public bool email_subscribed { get; set; }
        public int? status_id { get; set; }
        public string candidate_company_email { get; set; }
        public string candidate_representative_name { get; set; }
        public string company_bank_name { get; set; }
        public string company_bank_branch { get; set; }
        public string company_bank_account_number { get; set; }
        public string company_bank_account_name { get; set; }
        public string company_bank_account_swift_code { get; set; }
        public string company_bank_sort_code { get; set; }
        public string company_bsb_number { get; set; }
        public int? company_default_sale_tax_id { get; set; }
        public string company_default_sale_tax_rate { get; set; }
        public string company_default_sale_tax_number { get; set; }
        public int? company_sale_tax_registered { get; set; }
        public int? candidate_company_default_payment_terms { get; set; }
        public int? umbrella_company_id { get; set; }
        public string availability_url { get; set; }
        public DateTime? archived_timestamp { get; set; }
        public string archived_reason { get; set; }
        public int? archived_by { get; set; }
        public bool cv_exists { get; set; }
        public DateTime? cv_expiry_date { get; set; }
        public DateTime? last_activity_date { get; set; }

        //public string candidate_company_address { get; set; }
        //public string candidate_current_address { get; set; }
        //public VinCandidateCompanyAddress_model[] candidate_company_address { get; set; }
        //public VinCandidateCompanyAddress_model[] candidate_current_address { get; set; }
        //public List<VinCandidateFastTrack_model> ft_candidate { get; set; }


        //public VinCandidate_model()
        //{
        //    candidate_company_address = new List<VinCandidateCompanyAddress_model>();
        //    candidate_current_address = new List<VinCandidateCurrentAddress_model>();
        //    ft_candidate = new List<VinCandidateFastTrack_model>();
        //}
    }

    public class VinCandidateCompanyAddress_model
    {
        public int id { get; set; }
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
        public string types { get; set; }
        public string phone_number { get; set; }
        public string note { get; set; }

    }

    public class VinCandidateCurrentAddress_model
    {
        public int id { get; set; }
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
        public string types { get; set; }
        public string phone_number { get; set; }
        public string note { get; set; }

    }

    public class VinCandidateFastTrack_model
    {
        public string office_code { get; set; }
        public string status { get; set; }
        public string skill_group { get; set; }
        public string position { get; set; }
    }



    public class VinCandidateEducation_model
    {
        public string course { get; set; }
        public string degree_name { get; set; }
        public string department { get; set; }
        public string description { get; set; }

        public string education_level { get; set; }
        public string gpa { get; set; }
        public string grade { get; set; }
        public string graduation_date { get; set; }

        public string honorific { get; set; }
        public string honors { get; set; }
        public string institution_address { get; set; }
        public string institution_name { get; set; }
        public string major { get; set; }
        public string minor { get; set; }
        public string qualification { get; set; }
        public string school_name { get; set; }
        public string school_address { get; set; }
        public string start_date { get; set; }

        public string thesis { get; set; }
        public string training { get; set; }
        public string school_logo { get; set; }

    }

    public class VinCandidateDocument_model
    {
        public int?  document_type_id { get; set; }
        public string external_id { get; set; }
        public string file_name { get; set; }
        public int id { get; set; }
        public bool original_cv { get; set; }
        public string url { get; set; }
        public DateTime? uploaded_date { get; set; }
        public int? compliance_status_id { get; set; }
        public int? compliance_condition_id { get; set; }
        public DateTime? expiry_date { get; set; }
        public DateTime? issued_date { get; set; }
        public int candidate_id { get; set; }
    }

    public class VinCandidateExperience_model
    {
        public string address { get; set; }
        public string company_name { get; set; }
        public bool? current_employer { get; set; }
        public string experience_in_company { get; set; }
        public int? functional_expertise_id { get; set; }
        public int? industry_id { get; set; }
        public int? sub_industry_id { get; set; }
        public string job_title { get; set; }
        public int? sub_function_id { get; set; }
        public DateTime? work_from { get; set; }
        public DateTime? work_to { get; set; }
        public string company_logo { get; set; }


    }
}
