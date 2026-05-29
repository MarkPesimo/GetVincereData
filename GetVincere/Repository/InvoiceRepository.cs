using GetVincere.Model;
using GetVincere.Model.InvoiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Repository
{
    public class InvoiceRepository
    {

        private VincereDBEntities _conn;


        public InvoiceRepository()
        {
            if (_conn == null) { _conn = new VincereDBEntities(); }
        }

        public bool ManageVinInvoice(vinInvoice_model _obj)
        {
            try
            {
                _conn.USP_MANAGE_VIN_INVOICE(_obj.id, _obj.invoice_id,
                    _obj.invoice_type, _obj.invoice_status, _obj.payment_status,  _obj.job_id, 
                    _obj.job_name, _obj.contact_id,
                    _obj.contact_firstname                ,                    _obj.contact_middlename               ,
                    _obj.contact_lastname                 ,                    _obj.contact_firstname_kana           ,
                    _obj.contact_lastname_kana            ,                    _obj.contact_name                     ,
                    _obj.candidate_id                     ,                    _obj.candidate_firstname              ,
                    _obj.candidate_middlename             ,                    _obj.candidate_lastname               ,
                    _obj.candidate_firstname_kana         ,                    _obj.candidate_lastname_kana          ,
                    _obj.candidate_name                   ,                    _obj.company_id                       ,
                    _obj.company_name                     ,                    _obj.invoice_date                     ,
                    _obj.updated_date                     ,                    _obj.currency                         ,
                    _obj.amount_due                       ,                    _obj.formatted_amount_due             ,
                    _obj.due_date                         ,                    _obj.overdue_by                       ,
                    _obj.po_number                        ,                    _obj.timesheet_id                     ,
                    _obj.offer_id                         ,                    _obj.reference                        ,
                    _obj.term                             ,                    _obj.tax_inclusive                    ,
                    _obj.discount_amount                  ,                    _obj.total_amount                     ,
                    _obj.sub_total_amount                 ,                    _obj.tax_amount                       ,
                    _obj.amount_paid                      ,                    _obj.parent_id                        ,
                    _obj.alloc_amount                     ,                    _obj.invoice_sub_type                 ,
                    _obj.home_currency                    ,                    _obj.bank_spot_rate ,
                    _obj.conversion_total);

                if (_obj.location != null)
                {
                    vinInvoice_location_model _loc = _obj.location;
                    _conn.USP_MANAGE_VIN_INVOICE_LOCATION(_obj.id,
                        _loc.address,                        _loc.district,
                        _loc.city,                        _loc.state,
                        _loc.location_name,                        _loc.address_line1,
                        _loc.address_line2,                        _loc.post_code,
                        _loc.country_code,                        _loc.country,
                        _loc.nearest_train_station,                        _loc.longitude,
                        _loc.latitude,                        "",
                        _loc.billing_group_name,                        _loc.trading_name,
                        _loc.general_po_number,                        _loc.tax_exempt,
                        _loc.company_number,                        _loc.business_number,
                        _loc.company_payment_term,                        _loc.primary_billing_address,
                        _loc.billing_account_code);
                }

                if (_obj.items != null)
                {

                
                foreach (vinInvoice_item_model _item in _obj.items)
                {
                    _conn.USP_MANAGE_VIN_INVOICE_ITEM(0, _obj.id,
                        _item.item_name, _item.quantity,
                        _item.rate, _item.discount,
                        _item.account_name, _item.tax_name,
                        _item.tax, _item.total_amount,
                        _item.invoice_no, _item.ref_id);
                }
                }


                if (_obj.documents != null)
                {

                
                foreach (vinInvoice_document_model _doc in _obj.documents)
                {
                    _conn.USP_MANAGE_VIN_INVOICE_DOCUMENT(_doc.id, _obj.id,
                        _doc.file_name,                        _doc.document_type_id,
                        _doc.url,                        _doc.original_cv,
                        _doc.verify_status,                        _doc.verify_comment,
                        _doc.verify_date,                        _doc.uploaded_date,
                        _doc.issued_date,                        _doc.expiry_date,
                        _doc.compliance_status_id,                        _doc.compliance_condition_id,
                        _doc.candidate_id,                        _doc.external_id); 
                }
                }

                if (_obj.profit_split != null)
                {

                
                foreach (vinInvoice_profit_split_model _prof in _obj.profit_split)
                {
                    _conn.USP_MANAGE_VIN_INVOICE_PROFIT_SPLIT(_obj.id,
                        _prof.user_id,                        _prof.user_firstname,
                        _prof.user_lastname,                        _prof.profit_value,
                        _prof.profit_amount,                        _prof.split_mode);
                }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
