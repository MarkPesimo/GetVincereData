using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Model.JobModel
{
    public class VinJob_model
    {
        public string summary { get; set; }
        public int  id { get; set; }
        public string  external_id { get; set; }
        public string  job_title { get; set; }
        public string  job_type { get; set; }
        public string  job_sub_type { get; set; }
        public string  category { get; set; }
        public string  employment_type { get; set; }
        public int  head_count { get; set; }
        public DateTime? open_date { get; set; }
        public DateTime? close_date { get; set; }
        public DateTime? published_date { get; set; }
        public string public_description { get; set; }
        public string internal_description { get; set; }
        public int?    contact_id { get; set; }
        public int?    company_id { get; set; }
        public string  note { get; set; }
        public int?  industry_id { get; set; }
        public DateTime?  hot_end_date { get; set; }
        public VinJobCompensation_model compensation { get; set; }
        public int? company_location_id { get; set; }
        public bool? floated_job { get; set; }
        public bool? auto_submit_candidate { get; set; }
        public bool? visible_to_all { get; set; }
        public int ? sourcing_difficulty { get; set; }
        public DateTime? registration_date { get; set; }
        public DateTime? indeed_published_date { get; set; }
        public DateTime? updated_timestamp { get; set; }
        public int? update_user_id { get; set; }
        public int? creator_id { get; set; }
        public decimal? percentage_placement { get; set; }
        public decimal? forecast_annual_fee { get; set; }
        public string forecast_annual_fee_currency { get; set; }
        public DateTime? projected_placement_date { get; set; }
        public int? difficulty_level { get; set; }
        public string reason_for_difficulty { get; set; }
        public string hiring_line_manager { get; set; }
        public int? internal_recruiter_contact_id { get; set; }
        public int? site_manager_contact_id { get; set; }
        public string skill_keywords { get; set; }
        public bool? private_job { get; set; }
        public string live_list_url { get; set; }
        public string max_stage { get; set; }
        public int? active_candidate_count { get; set; }
        public int? status_id { get; set; }
        public bool? from_job_lead_converted { get; set; }
        public int? deal_id { get; set; }

    }

    public class VinJobCompensation_model
    {
        public int? id { get; set; }
        public decimal? contract_length { get; set; }
        public string contract_length_type { get; set; }
        public string currency { get; set; }
        public string salary_type { get; set; }
        public decimal? pay_rate { get; set; }
        public string formatted_pay_rate { get; set; }
        public decimal? salary_from { get; set; }
        public decimal? salary_to { get; set; }
        public string formatted_salary_from { get; set; }
        public string formatted_salary_to { get; set; }
        public bool? use_quick_fee_forecast { get; set; }
        public decimal? quick_fee { get; set; }
        public decimal? profit { get; set; }
    }

    public class VinJob_Team
    {
        public int? job_teams { get; set; }
        public int JobId { get; set; }
    }
    public class VinJob_Compensation
    {
        
        //"compensation": {
        //"id": 132576,
        //"contract_length": 1,
        //"contract_length_type": "HOUR",
        //"currency": "vnd",
        //"salary_type": "HOURLY",
        //"pay_rate": 0,
        //"formatted_pay_rate": "&#8363;0 VND",
        //"salary_from": 0,
        //"salary_to": 0,
        //"formatted_salary_from": "&#8363;0 VND",
        //"formatted_salary_to": "&#8363;0 VND",
        //"use_quick_fee_forecast": null
        //"quick_fee": null
        //"profit": null
        //},
    }
}
