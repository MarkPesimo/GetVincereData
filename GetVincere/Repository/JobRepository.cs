using GetVincere.Model;
using GetVincere.Model.JobModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Repository
{
    public class JobRepository
    {
        private VincereDBEntities _conn;

        public JobRepository()
        {
            if (_conn == null) { _conn = new VincereDBEntities(); }
        }

        public bool ManageJob(string _value)
        {
            try
            {
                VinJob_model _model = new VinJob_model();
                _model = JsonConvert.DeserializeObject<VinJob_model>(_value);


                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_JOB(_model.id, _model.external_id, _model.job_title, _model.job_type, _model.category,
                    _model.employment_type, _model.head_count, _model.open_date, _model.close_date, _model.published_date,
                    _model.public_description, _model.internal_description, _model.contact_id, _model.company_id, _model.note, _model.industry_id,
                    _model.hot_end_date, _model.company_location_id, _model.floated_job, _model.auto_submit_candidate, _model.visible_to_all,
                    _model.sourcing_difficulty, _model.registration_date, _model.indeed_published_date, _model.updated_timestamp,
                    _model.update_user_id, _model.creator_id, _model.percentage_placement, _model.forecast_annual_fee, 
                    _model.forecast_annual_fee_currency, _model.projected_placement_date, _model.difficulty_level, _model.reason_for_difficulty,
                    _model.hiring_line_manager, _model.internal_recruiter_contact_id, _model.site_manager_contact_id, _model.skill_keywords,
                    _model.private_job, _model.live_list_url, _model.max_stage, _model.active_candidate_count, _model.status_id,
                    _model.from_job_lead_converted, _model.deal_id, _return_value);

                _conn.USP_MANAGE_VIN_JOB_COMPENSATION(_model.compensation.id, _model.id, _model.compensation.contract_length, _model.compensation.contract_length_type, _model.compensation.currency,
                    _model.compensation.salary_type, _model.compensation.pay_rate, _model.compensation.formatted_pay_rate, _model.compensation.salary_from, _model.compensation.salary_to,
                    _model.compensation.formatted_salary_from, _model.compensation.formatted_salary_to, _model.compensation.use_quick_fee_forecast, _model.compensation.quick_fee, _model.compensation.profit);

                return true;
            }
            catch (Exception ex)
            {

                return false;   
            }

        }

        public bool ManageJobPlacement(vinJob_placement_model _model)
        {
            try
            {
              
                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_JOB_PLACEMENT(_model.placement_id, _model.candidate_id, _model.placed_date, _model.placed_by, _model.offer_date,
                    _model.placement_date, _model.start_date, _model.end_date, _model.status, _model.application_id);

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public bool ManageJobApplication(vinJob_application_model _model)
        {
            try
            {
                if (_model.substatus == null)
                {
                    _model.substatus = new substatus_model();
                    
                }

                if (_model.work_address == null)
                {
                    _model.work_address = new work_address_model();
                    //_model.work_address.id = 0;
                    //_model.work_address.location_name = "";
                    //_model.work_address.address = "";
                    //_model.work_address.address_line1 = "";
                    //_model.work_address.address_line2 = "";
                    //_model.work_address.district_suburb = "";
                    //_model.work_address.town_city = "";
                    //_model.work_address.zip_postal_code = "";
                    //_model.work_address.country = "";
                    //_model.work_address.state = "";
                    //_model.work_address.nearest_train_stn = "";
                    //_model.work_address.type = "";
                    //_model.work_address.types = "";
                    //_model.work_address.phone_number = "";                    
                    //_model.work_address.note = "";
                }

                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_JOB_APPLICATION(_model.id, _model.external_id, _model.candidate_id, _model.candidate_first_name,
                    _model.candidate_last_name, _model.candidate_middle_name, _model.job_id, _model.job_title,
                    _model.job_type, _model.job_category, _model.company_name, _model.company_id, _model.stage, _model.status,
                    _model.registration_date, _model.application_stage_associated_date, _model.shortlisted_stage_associated_date,
                    _model.cv_sent_stage_associated_date, _model.interview_1_stage_associated_date, _model.interview_2_plus_stage_associated_date,
                    _model.offer_stage_associated_date, _model.placed_stage_associated_date, _model.work_start_date, _model.work_end_date,
                    _model.invoice_stage_associated_date, _model.registration_date, _model.creator_id, _model.substatus.id, _model.substatus.name,
                    _model.substatus.color_code, 
                    "", 
                    _model.customer_portal_document_count, _model.modified_date,
                    _model.candidate_status, _model.candidate_status_id, _model.profit, _model.formatted_profit, _model.currency,
                    _model.placement_id, _model.application_source_id, _model.application_user_id, _model.shortlisted_user_id,
                    _model.offer_pdf_url, _model.work_address.id, _model.work_address.location_name, _model.work_address.address,
                    _model.work_address.address_line1, _model.work_address.address_line2, _model.work_address.district_suburb,
                    _model.work_address.town_city, _model.work_address.zip_postal_code, _model.work_address.country, _model.work_address.state,
                    _model.work_address.nearest_train_stn, _model.work_address.type, _model.work_address.phone_number, _model.work_address.note,
                    _model.first_interview_date, _model.second_plus_interview_date);

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

    }
}
