using GetVincere.Model;
using GetVincere.Model.PlacementModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Repository
{
   public  class PlacementRepository
    {
        private VincereDBEntities _conn;

        public PlacementRepository()
        {
            if (_conn == null) { _conn = new VincereDBEntities(); }
        }

        public bool ManageVinPlacement(string _value)
        {

            try
            {
                vinPlacement_model _placement = new vinPlacement_model();
                //              
                if (_value == "") { return true; }

                _placement = JsonConvert.DeserializeObject<vinPlacement_model>(_value);

                //--------------------------------PLACEMENT DETAILS-------------------------------
                System.Data.Entity.Core.Objects.ObjectParameter _return_value = new System.Data.Entity.Core.Objects.ObjectParameter("RET_ID", typeof(int));
                _conn.USP_MANAGE_VIN_PLACEMENT(_placement.contract_length, _placement.currency, _placement.formatted_pay_rate, _placement.formatted_salary_from,
                    _placement.formatted_salary_to, _placement.id, _placement.pay_rate, _placement.salary_from, _placement.salary_to, _placement.salary_type,
                    _placement.use_quick_fee_forecast, _placement.quick_fee, _placement.profit, _placement.profit_per_hour, _placement.profit_per_day,
                    _placement.profit_per_week, _placement.profit_per_month, _placement.profit_per_year, _placement.formatted_profit_per_hour,
                    _placement.formatted_profit_per_day, _placement.formatted_profit_per_week, _placement.formatted_profit_per_month,
                    _placement.formatted_profit_per_year, _placement.total_cost, _placement.formatted_total_cost, _placement.excluding_deduction, _placement.job_type,
                    _placement.employment_type, _placement.mths_year, _placement.salary_rate_per_month, _placement.formatted_salary_rate_per_month, 
                    _placement.annual_salary, _placement.formatted_annual_salary, _placement.gross_annual_salary, _placement.formatted_gross_annual_salary,
                    _placement.formatted_profit, _placement.annual_paid_holidays, _placement.working_hours_per_day, _placement.working_hours_per_week,
                    _placement.working_days_per_month, _placement.annual_paid_sick_days, _placement.working_days_per_week, _placement.working_weeks_per_month,
                    _placement.fee_model_name, _placement.fee_model_type, _placement.fee_model_detail_job_type, _placement.fee_model_fee_rate,

                    _placement.fee_model_gross_annual_salary                                  ,
                    _placement.fee_model_incentives_guarantee                                 ,
                    _placement.fee_model_exempt_incentives                                    ,
                    _placement.fee_model_stat_gov_taxes                                       ,
                    _placement.fee_model_optional_factor                                      ,
                    _placement.fee_model_comment                                              ,
                    _placement.fee_model_contract_period                                      ,
                    _placement.fee_model_start_date                                           ,
                    _placement.fee_model_invoice_date                                         ,
                    _placement.fee_model_invoice_payment_term                                 ,
                    _placement.fee_model_fixed_fee_currency                                   ,
                    _placement.fee_model_fixed_fee_amount                                     ,
                    _placement.formatted_fee_model_fixed_fee_amount                           ,
                    _placement.fee_model_fixed_fee_comment                                    ,
                    _placement.fee_model_retainer_currency                                    ,
                    _placement.fee_model_retainer_comment                                     ,
                    _placement.fee_model_retainer_total_amount                                ,
                    _placement.fee_model_no_fee_payable_description                           ,
                    _placement.interval_base_pay                                              ,
                    _placement.formatted_interval_base_pay                                    ,
                    _placement.interval_base_charge                                           ,
                    _placement.formatted_interval_base_charge                                 ,
                    _placement.interval_base_profit                                           ,
                    _placement.formatted_interval_base_profit                                 ,
                    _placement.total_contract_pay                                             ,
                    _placement.formatted_total_contract_pay                                   ,
                    _placement.total_contract_charge                                          ,
                    _placement.formatted_total_contract_charge                                ,
                    _placement.total_contract_profit                                          ,
                    _placement.formatted_total_contract_profit                                ,
                    _placement.time_management                                                ,
                    _placement.pay_interval                                                   ,
                    _placement.contract_length_type                                           ,
                    _placement.pay_range_from                                                 ,
                    _placement.pay_range_to                                                   ,
                    _placement.formatted_pay_range_from                                       ,
                    _placement.formatted_pay_range_to                                         ,
                    _placement.base_pay_rate                                                  ,
                    _placement.formatted_base_pay_rate                                        ,
                    _placement.on_costs_number                                                ,
                    _placement.formatted_on_costs_number                                      ,
                    _placement.on_costs_percentage_in_decimal                                 ,
                    _placement.total_pay_rate                                                 ,
                    _placement.formatted_total_pay_rate                                       ,
                    _placement.margin_percentage_in_decimal                                   ,
                    _placement.markup_percentage_in_decimal                                   ,
                    _placement.profit_margin                                                  ,
                    _placement.formatted_profit_margin                                        ,
                    _placement.charge_rate                                                    ,
                    _placement.formatted_charge_rate                                          ,
                    _placement.total_pay_calculation                                          ,
                    _placement.calculate_charge_using                                         ,
                    _placement.start_of_week                                                  ,
                    _placement.pay_cycle                                                      ,
                    _placement.astute_pay_cycle_id                                            ,
                    _placement.astute_rule_group_id                                           ,
                    _placement.astute_rate_card_id                                            ,
                    _placement.first_half_of_month                                            ,
                    _placement.second_half_of_month                                           ,
                    _placement.fee_model_invoice_pay_interval                                 ,
                    _placement.placement_status                                               ,
                    _placement.application_source_id                                          ,
                    _placement.position_id                                                    ,
                    _placement.application_id                                                 ,
                    _placement.placed_by                                                      ,
                    _placement.start_date                                                     ,
                    _placement.end_date                                                       ,
                    _placement.effective_date                                                 ,
                    _placement.amendment_reason_id                                            ,
                    _placement.is_latest                                                      
                    );

                //--------------------------------DEDUCTION-------------------------------
                foreach (Deduction _ded in _placement.deductions)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_DEDUCTION(_placement.id, _ded.name, _ded.fixed_or_percentagge, _ded.number_or_percentage);
                }

                //--------------------------------LOADINGS-------------------------------
                foreach (Loading _lod in _placement.loadings)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_LOADING(_placement.id, _lod.name, _lod.fixed_or_percentagge, _lod.number_or_percentage);
                }

                //--------------------------------ALLOWANCE STATUTORY-------------------------------
                foreach (AllowanceStatutory _all in _placement.allowance_statutory)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_ALLOWANCE_STATUTORY(0, _placement.id, _all.name,
                       _all.fixed_or_percentagge, _all.number_or_percentage,
                       _all.add_to_margin, _all.add_to_charge_rate, _all.add_to_pay_rate,
                       _all.index, _all.threshold);

                }

                //--------------------------------INCENTIVES-------------------------------
                foreach (Incentive _inc in _placement.incentives)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_INCENTIVE(_placement.id, _inc.name, _inc.fixed_or_percentage, _inc.number_or_percentage, _inc.description);
                }

                //--------------------------------EXEMPT INCENTIVES-------------------------------
                foreach (ExemptIncentive _inc in _placement.exempt_incentives)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_EXEMPT_INCENTIVE(_placement.id, _inc.name, _inc.fixed_or_percentage, _inc.number_or_percentage, _inc.description,
                        _inc.charge_rate, _inc.threshold, _inc.budget_by);
                }

                //--------------------------------OPTIONAL FACTORS-------------------------------
                foreach (OptionalFactor _opt in _placement.optional_factors)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_OPTIONAL_FACTOR(_placement.id, _opt.name, _opt.fixed_or_percentage,
                        _opt.number_or_percentage, _opt.add_to_margin, _opt.add_to_charge_rate, 
                        _opt.add_to_pay_rate, _opt.index, _opt.threshold);
                }

                //--------------------------------STAT GOV TAXES-------------------------------
                foreach (StatGovTaxis _stat in _placement.stat_gov_taxes)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_STAT_GOV_TAX(_placement.id, _stat.name, _stat.type_of_taxes,
                        _stat.employer_contribution_percentage, _stat.employee_contribution_percentage,
                        _stat.employer_contribution_amount, _stat.employee_contribution_amount);
                }

                //--------------------------------FEE MODEL RETAINER DETAILS-------------------------------
                foreach (FeeModelRetainerDetail _fee in _placement.fee_model_retainer_details)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_FEE_MODEL_RETAINER_DETAIL(_placement.id, _fee.amount,
                        _fee.invoice_date, _fee.description);
                }

                //--------------------------------PAY AND CHARGE INCL OVERTIME-------------------------------
                foreach (PayAndChargeInclOvertime _pay in _placement.pay_and_charge_incl_overtimes)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_PAY_AND_CHARGE_INCL_OVERTIME(_placement.id, _pay.pay_name,
                        _pay.pay_rate, _pay.formatted_pay_rate, _pay.on_costs_number, _pay.formatted_on_costs_number,
                        _pay.total_pay_rate, _pay.formatted_total_pay_rate, _pay.charge_rate, _pay.formatted_charge_rate,
                        _pay.profit_margin, _pay.formatted_profit_margin, _pay.pay_level, _pay.total_cost, _pay.formatted_total_cost,
                        _pay.deduction, _pay.formatted_deduction, _pay.loadings, _pay.formatted_loadings, _pay.multiplier_percent,
                        _pay.fixed_or_percentage, _pay.index);
                }

                //--------------------------------ALLOWANCE SUBJECT TO STAT GOVT TAXES-------------------------------
                foreach (AllowancesSubjectToStatGovtTaxis _all in _placement.allowances_subject_to_stat_govt_taxes)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_ALLOWANCES_SUBJECT_TO_STAT_GOV_TAX(_placement.id, _all.name,
                        _all.percentage_in_decimal, _all.description);
                }

                //--------------------------------ALLOWANCE NOT SUBJECT TO STAT GOVT TAXES-------------------------------
                foreach (AllowancesNotSubjectToStatGovtTaxis _all in _placement.allowances_not_subject_to_stat_govt_taxes)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_ALLOWANCES_NOT_SUBJECT_TO_STAT_GOV_TAX(_placement.id, _all.name,
                        _all.fixed_or_percentage, _all.number_or_percentage, _all.description);
                }

                //--------------------------------CONTRACT BASED OPTIONAL FACTORS-------------------------------
                foreach (ContractBasedOptionalFactor _obj in _placement.contract_based_optional_factors)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_CONTRACT_BASED_OPTIONAL_FACTOR(_placement.id, _obj.enter_item_here,
                        _obj.percentage_in_decimal, _obj.description);
                }

                //--------------------------------PTO PAID TIME OFF IN HOURS-------------------------------
                foreach (PtoPaidTimeOffInHour _obj in _placement.pto_paid_time_off_in_hours)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_PTO_PAID_TIME_OFF_IN_HOURS(_placement.id, _obj.code_name,
                        _obj.code_type, _obj.accrual_tracking, _obj.charge_to_client, _obj.paid_hours);
                }

                //--------------------------------TIMESHEETS PAY RULES-------------------------------
                foreach (TimesheetsPayRule _obj in _placement.timesheets_pay_rules)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_TIMESHEETS_PAY_RULE(_placement.id, _obj.rules,
                        _obj.hours, _obj.hours_to,
                        _obj.hours_from, _obj.period, _obj.apply_pay_name);
                }

                //--------------------------------TIMESHEETS PAY RULES EXCEPTIONS------------------------------
                foreach (TimesheetsPayRuleException _obj in _placement.timesheets_pay_rule_exceptions)
                {
                    _conn.USP_MANAGE_VIN_PLACEMENT_TIMESHEETS_PAY_RULE_EXCEPTION(_placement.id, _obj.rules,
                        _obj.hours, _obj.hours_to,
                        _obj.hours_from, _obj.period, _obj.apply_pay_name);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ManageVinPlacementCostOfSales(int _placementid, CostOfSale _obj)
        {
            try
            {
                _conn.USP_MANAGE_VIN_PLACEMENT_COST_OF_SALES(_placementid, _obj.description, _obj.quantity, _obj.rate, _obj.amount);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ManageVinPlacementOtherInvoiceItem(int _placementid, OtherInvoiceItem _obj)
        {
            try
            {
                _conn.USP_MANAGE_VIN_PLACEMENT_OTHER_INVOICE_ITEM(_placementid, _obj.description, _obj.quantity, _obj.charge);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ManageVinPlacementProfitSplit(int _placementid, ProfitSplit _obj)
        {
            try
            {
                _conn.USP_MANAGE_VIN_PLACEMENT_PROFIT_SPLIT(_placementid, _obj.user_id, _obj.name, _obj.share_percentage, _obj.amount,
                    _obj.astute_user_id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ManageVinPlacementInvoice(int _placementid, PlacementInvoice _obj)
        {
            try
            {
                _conn.USP_MANAGE_VIN_PLACEMENT_INVOICE(_obj.id, _placementid, _obj.invoice_id, _obj.invoice_type, _obj.invoice_status,
                    _obj.payment_status, _obj.job_id, _obj.job_name, _obj.contact_id, _obj.contact_firstname, _obj.contact_middlename,
                    _obj.contact_lastname, _obj.contact_firstname_kana, _obj.contact_lastname_kana, _obj.contact_name,
                    _obj.candidate_id, _obj.candidate_firstname, _obj.candidate_middlename, _obj.candidate_lastname,
                    _obj.candidate_firstname_kana, _obj.candidate_lastname_kana, _obj.candidate_name, _obj.company_id, _obj.company_name,
                    _obj.invoice_date, _obj.updated_date, _obj.currency, _obj.amount_due, _obj.formatted_amount_due,
                    _obj.due_date, _obj.overdue_by, _obj.po_number, _obj.timesheet_id);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
