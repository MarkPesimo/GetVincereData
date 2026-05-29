using GetVincere.Model;
using GetVincere.Model.Candidate;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GetVincere.Repository
{
    public class CandidateRepository
    {
        private VincereDBEntities _conn;

        public CandidateRepository()
        {
            if (_conn == null ) { _conn = new VincereDBEntities(); }
        }

        public void ManageCandidate(Candidate_model.CandidateData_model _model)
        {
            try
            {
                _conn.USP_MANAGE_CANDIDATE(_model.Id, _model.Lastname, _model.Fistname, _model.DateCreated, _model.LastUpdated);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<Candidate_model.CandidateData_model> GetCandidateByDateCreated(DateTime _from, DateTime _to)
        {
            List<Candidate_model.CandidateData_model> _model = (from d in _conn.USP_GET_CANDIDATE_BY_DATE_CREATED(_from, _to)
                                                      select d)
                       .AsEnumerable()
                       .Select(x => new Candidate_model.CandidateData_model()
                       {
                           Id = x.candidate_id,
                           Lastname = x.lastname,
                           Fistname = x.firstname,
                           DateCreated =  x.date_created.ToString() == "" ? null : x.date_created,
                           LastUpdated = x.last_update.ToString() == "" ? null : x.last_update
                       }).ToList();

            return _model;
        }

        public bool ManageVinCandidateDocument(int _candidateid, VinCandidateDocument_model _edu)
        {
            try
            {
                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_CANDIDATE_DOCUMENT( _edu.id, _edu.candidate_id, _edu.document_type_id, _edu.external_id, _edu.file_name,
                    _edu.original_cv, _edu.url, _edu.uploaded_date, _edu.compliance_status_id, _edu.compliance_condition_id, _edu.expiry_date, _edu.issued_date);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool ManageVinCandidateExperience(int _candidateid, VinCandidateExperience_model _work)
        {
            try
            {
                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_CANDIDATE_WORK_EXPERIENCE(0, _candidateid, _work.address, _work.company_name, _work.current_employer, _work.experience_in_company,
                    _work.functional_expertise_id, _work.industry_id, _work.sub_industry_id, _work.job_title, _work.sub_function_id, _work.work_from, _work.work_to,
                    _work.company_logo);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool ManageVinCandidateEducation(int _candidateid, VinCandidateEducation_model _edu)
        {
            try
            {
                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_CANDIDATE_EDUCATION(_candidateid, _edu.course, _edu.degree_name, _edu.department, _edu.description,
                    _edu.education_level, _edu.gpa, _edu.grade, 
                     _edu.graduation_date, 
                    _edu.honorific, _edu.honors,
                    _edu.institution_address, _edu.institution_name, _edu.major, _edu.minor, _edu.qualification, _edu.school_name,
                    _edu.school_address, 
                    _edu.start_date, _edu.thesis, _edu.training, _edu.school_logo);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool ManageVinCandidate(string _value)
        {

            try
            {
                VinCandidate_model _candidate = new VinCandidate_model();

                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                
                _candidate = JsonConvert.DeserializeObject<VinCandidate_model>(_value);
                //dynamic data = JsonConvert.DeserializeObject<dynamic>(_value);
                //var targetField = data.candidate_current_address;
                //if (_candidate.id == 126601) {
                //    string x = "";
                //}

                _conn.USP_MANAGE_VIN_CANDIDATE(_candidate.id, _candidate.affiliations, _candidate.availability, _candidate.availability_start, _candidate.candidate_source_id,
                    _candidate.candidate_source_name, _candidate.job_title, _candidate.company_count, _candidate.company_name, _candidate.company_number,
                    _candidate.contract_interval, _candidate.contract_rate, _candidate.country_of_domicile, _candidate.creator_id, _candidate.currency_type,
                    _candidate.current_bonus, _candidate.current_salary, _candidate.date_of_birth, _candidate.desired_bonus, _candidate.desired_contract_rate,
                    _candidate.desired_salary, _candidate.desired_salary_monthly, _candidate.driving_license_number, _candidate.driving_license_type, _candidate.education_summary,
                    _candidate.email,                    _candidate.employment_type,                    _candidate.experience,                    _candidate.external_id,                    _candidate.emergency_name,
                    _candidate.emergency_phone,                    _candidate.emergency_relationship,                    _candidate.emergency_email,                    _candidate.facebook,                    _candidate.first_name,                   
                    _candidate.first_name_kana,                    _candidate.gender,                    _candidate.gender_title,                    _candidate.highest_job_application_stage,                    _candidate.home_phone,

                    _candidate.ielts_score,                    _candidate.keyword,                    _candidate.last_name,                    _candidate.last_name_kana,                    _candidate.linked_contact_id,
                    _candidate.linked_in,                    _candidate.marital_status,                    _candidate.met_status,                    _candidate.middle_name,                    _candidate.middle_name_kana,
                    _candidate.mobile,                    _candidate.nationality,                    _candidate.nearest_train_station,                    _candidate.note,                    _candidate.note_by,
                    _candidate.note_on,                    _candidate.notice_days,                    _candidate.objective,                    _candidate.other_benefits,                    _candidate.payment_type,
                    _candidate.payslip_email,                    _candidate.passport_no,                    _candidate.personal_statements,                    _candidate.phone,                    _candidate.photo_url,
                    _candidate.place_of_birth,                    _candidate.preferred_language,                    _candidate.present_salary_rate,                    _candidate.publications,                    _candidate.reference,
                    _candidate.registration_date,                    _candidate.relocate,                    _candidate.salary_months_per_year,                    _candidate.salary_type,                    _candidate.skills,
                    _candidate.statements,                    _candidate.summary,                    _candidate.toeic_score,                    _candidate.total_gross,                    _candidate.twitter,
                    _candidate.variant,                    _candidate.visa_note,                    _candidate.visa_number,                    _candidate.visa_renewal_date,                    _candidate.visa_status,
                    _candidate.visa_type,                    _candidate.website,                    _candidate.work_email,                    _candidate.work_phone,                    _candidate.xing,
                    _candidate.updated_timestamp,                    _candidate.nickname,                    _candidate.email_subscribed,                    _candidate.status_id,                    _candidate.candidate_company_email,
                    _candidate.candidate_representative_name,                    _candidate.company_bank_name,                    _candidate.company_bank_branch,                    _candidate.company_bank_account_number,                    _candidate.company_bank_account_name,
                    _candidate.company_bank_account_swift_code,                    _candidate.company_bank_sort_code,                    _candidate.company_bsb_number,                    _candidate.company_default_sale_tax_id,                    _candidate.company_default_sale_tax_rate,
                    _candidate.company_default_sale_tax_number,                    _candidate.company_sale_tax_registered,                    _candidate.candidate_company_default_payment_terms,                    _candidate.umbrella_company_id,                    _candidate.availability_url,
                    _candidate.archived_timestamp,                    _candidate.archived_reason,                    _candidate.archived_by,                    _candidate.cv_exists,                    _candidate.cv_expiry_date,
                    _candidate.last_activity_date,                    _return_value);

                //r partialJsonString = JsonReader["candidate_current_address"].ToString();
                //List<VinCandidateCurrentAddress_model> _obj = JsonConvert.DeserializeObject<List<VinCandidateCurrentAddress_model>>(targetField);
//                foreach (VinCandidateCompanyAddress_model _company in _candidate.candidate_company_address)
                //{

                    //_conn.USP_MANAGE_VIN_CANDIDATE_COMPANY_ADDRESS(_company.Id, _candidate.id, _company.location_name, _company.address,
                    //    _company.address_line1, _company.address_line2, _company.district_suburb, _company.town_city, _company.zip_postal_code,
                    //    _company.country, _company.state, _company.nearest_train_stn, _company.types, _company.phone_number, _company.note,
                    //    _return_value);

                //}


                //foreach (VinCandidateCurrentAddress_model _address in _candidate.candidate_current_address)
                //{

                //    _conn.USP_MANAGE_VIN_CANDIDATE_CURRENT_ADDRESS(_address.Id, _candidate.id, _address.location_name, _address.address,
                //        _address.address_line1, _address.address_line2, _address.district_suburb, _address.town_city, _address.zip_postal_code,
                //        _address.country, _address.state, _address.nearest_train_stn, _address.types, _address.phone_number, _address.note,
                //        _return_value);

                //}

                //foreach (VinCandidateFastTrack_model _fasttrack in _candidate.ft_candidate)
                //{

                //    _conn.USP_MANAGE_VIN_CANDIDATE_FAST_TRACK(_candidate.id, _fasttrack.office_code, _fasttrack.status, _fasttrack.skill_group,
                //        _fasttrack.position, _return_value);
                //}

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
