using GetVincere.Model;
using GetVincere.Model.CompanyModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Repository
{
   public  class CompanyRepository
    {
        private VincereDBEntities _conn;

        public CompanyRepository()
        {
            if (_conn == null) { _conn = new VincereDBEntities(); }
        }

        public bool ManageCompany(string _value)
        {
            try
            {
                VinCompany_model _model = new VinCompany_model();
                _model = JsonConvert.DeserializeObject<VinCompany_model>(_value);


                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_COMPANY(_model.billing_group_name, _model.business_number, _model.careersite_url, _model.company_name,
                    _model.company_number, _model.contact_in_company, _model.creator_id, _model.employees_number, _model.external_id,
                    _model.facebook_url, _model.fax, _model.general_PO_number, _model.head_quarter, _model.id, _model.linkedin_url,
                    _model.note, _model.parent_id, _model.phone, _model.registration_date, _model.rss_urls, _model.switch_board,
                    _model.tax_exempt, _model.trading_name, _model.website, _model.updated_timestamp, _model.stage,
                    _model.stage_status, _model.status_id, _return_value);

                //_conn.USP_MANAGE_VIN_JOB_COMPENSATION(_model.compensation.id, _model.id, _model.compensation.contract_length, _model.compensation.contract_length_type, _model.compensation.currency,
                //    _model.compensation.salary_type, _model.compensation.pay_rate, _model.compensation.formatted_pay_rate, _model.compensation.salary_from, _model.compensation.salary_to,
                //    _model.compensation.formatted_salary_from, _model.compensation.formatted_salary_to, _model.compensation.use_quick_fee_forecast, _model.compensation.quick_fee, _model.compensation.profit);

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public bool ManageVinCompanyDocument(int _companyid, vinCompany_document_model _doc)
        {
            try
            {
                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_COMPANY_DOCUMENT(_doc.id, _doc.company_id, _doc.document_type_id, _doc.file_name, _doc.url, _doc.uploaded_date);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool ManageVinCompanyLocation(int _companyid, VinCompany_Location_model _loca)
        {
            try
            {
                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_COMPANY_LOCATION(_loca.id, _companyid, _loca.address, _loca.district, _loca.city, _loca.state,
                    _loca.location_name, _loca.address_line1, _loca.address_line2, _loca.post_code, _loca.country_code, _loca.country,
                    _loca.nearest_train_station, _loca.longitude, _loca.latitude, "", _loca.billing_group_name,
                    _loca.trading_name, _loca.general_po_number, _loca.tax_exempt, _loca.company_number, _loca.company_payment_term,
                    _loca.primary_billing_address, _loca.billing_account_code, _return_value);


                foreach (string _loctype in _loca.location_types)
                {
                    _conn.USP_MANAGE_VIN_COMPANY_LOCATION_TYPE(_companyid, _loctype );
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool ManageVinCompanyBranch(int _companyid, VinCompany_Branch_model _brnch)
        {
            try
            {
                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_COMPANY_BRANCH(_brnch.id, _companyid, _brnch.name);

 
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool ManageVinCompanyBrand(int _companyid, vinCompany_brand_model _brand)
        {
            try
            {
                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_COMPANY_BRAND(_brand.id, _companyid, _brand.name);


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
