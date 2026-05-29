using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Model.PlacementModel
{
    public class vinPlacement_model
    {         
        public decimal? contract_length { get; set; }
        public string currency { get; set; }
        public string formatted_pay_rate { get; set; }
        public string formatted_salary_from { get; set; }
        public string formatted_salary_to { get; set; }
        public int? id { get; set; }
        public decimal? pay_rate { get; set; }
        public decimal? salary_from { get; set; }
        public decimal? salary_to { get; set; }
        public string salary_type { get; set; }
        public bool? use_quick_fee_forecast { get; set; }
        public decimal? quick_fee { get; set; }
        public decimal? profit { get; set; }
        public decimal? profit_per_hour { get; set; }
        public decimal? profit_per_day { get; set; }
        public decimal? profit_per_week { get; set; }
        public decimal? profit_per_month { get; set; }
        public decimal? profit_per_year { get; set; }
        public string formatted_profit_per_hour { get; set; }
        public string formatted_profit_per_day { get; set; }
        public string formatted_profit_per_week { get; set; }
        public string formatted_profit_per_month { get; set; }
        public string formatted_profit_per_year { get; set; }
        public decimal? total_cost { get; set; }
        public string formatted_total_cost { get; set; }
        public bool? excluding_deduction { get; set; }
        public List<Deduction> deductions { get; set; }
        public List<Loading> loadings { get; set; }
        public List<AllowanceStatutory> allowance_statutory { get; set; }
        //public AllowanceStatutory allowance_statutory { get; set; }
        public string job_type { get; set; }
        public string employment_type { get; set; }
        public decimal? mths_year { get; set; }
        public decimal? salary_rate_per_month { get; set; }
        public string formatted_salary_rate_per_month { get; set; }
        public decimal? annual_salary { get; set; }
        public string formatted_annual_salary { get; set; }
        public decimal? gross_annual_salary { get; set; }
        public string formatted_gross_annual_salary { get; set; }
        public string formatted_profit { get; set; }
        public List<Incentive> incentives { get; set; }
        public List<ExemptIncentive> exempt_incentives { get; set; }
        public List<OptionalFactor> optional_factors { get; set; }
        public List<StatGovTaxis> stat_gov_taxes { get; set; }
        public decimal? annual_paid_holidays { get; set; }
        public decimal? working_hours_per_day { get; set; }
        public decimal? working_hours_per_week { get; set; }
        public decimal? working_days_per_month { get; set; }
        public decimal? annual_paid_sick_days { get; set; }
        public decimal? working_days_per_week { get; set; }
        public decimal? working_weeks_per_month { get; set; }
        public string fee_model_name { get; set; }
        public string fee_model_type { get; set; }
        public string fee_model_detail_job_type { get; set; }
        public decimal? fee_model_fee_rate { get; set; }
        public bool? fee_model_gross_annual_salary { get; set; }
        public bool? fee_model_incentives_guarantee { get; set; }
        public bool? fee_model_exempt_incentives { get; set; }
        public bool? fee_model_stat_gov_taxes { get; set; }
        public bool? fee_model_optional_factor { get; set; }
        public bool? fee_model_comment { get; set; }
        public string fee_model_contract_period { get; set; }
        public DateTime? fee_model_start_date { get; set; }
        public DateTime? fee_model_invoice_date { get; set; }
        public decimal? fee_model_invoice_payment_term { get; set; }
        public string fee_model_fixed_fee_currency { get; set; }
        public decimal? fee_model_fixed_fee_amount { get; set; }
        public string formatted_fee_model_fixed_fee_amount { get; set; }
        public string fee_model_fixed_fee_comment { get; set; }
        public string fee_model_retainer_currency { get; set; }
        public string fee_model_retainer_comment { get; set; }
        public List<FeeModelRetainerDetail> fee_model_retainer_details { get; set; }
        public decimal? fee_model_retainer_total_amount { get; set; }
        public string fee_model_no_fee_payable_description { get; set; }
        public decimal? interval_base_pay { get; set; }
        public string formatted_interval_base_pay { get; set; }
        public decimal? interval_base_charge { get; set; }
        public string formatted_interval_base_charge { get; set; }
        public decimal? interval_base_profit { get; set; }
        public string formatted_interval_base_profit { get; set; }
        public decimal? total_contract_pay { get; set; }
        public string formatted_total_contract_pay { get; set; }
        public decimal? total_contract_charge { get; set; }
        public string formatted_total_contract_charge { get; set; }
        public decimal? total_contract_profit { get; set; }
        public string formatted_total_contract_profit { get; set; }
        public string time_management { get; set; }
        public string pay_interval { get; set; }
        public string contract_length_type { get; set; }
        public decimal? pay_range_from { get; set; }
        public decimal? pay_range_to { get; set; }
        public string formatted_pay_range_from { get; set; }
        public string formatted_pay_range_to { get; set; }
        public decimal? base_pay_rate { get; set; }
        public string formatted_base_pay_rate { get; set; }
        public decimal? on_costs_number { get; set; }
        public string formatted_on_costs_number { get; set; }
        public decimal? on_costs_percentage_in_decimal { get; set; }
        public decimal? total_pay_rate { get; set; }
        public string formatted_total_pay_rate { get; set; }
        public decimal? margin_percentage_in_decimal { get; set; }
        public decimal? markup_percentage_in_decimal { get; set; }
        public decimal? profit_margin { get; set; }
        public string formatted_profit_margin { get; set; }
        public decimal? charge_rate { get; set; }
        public string formatted_charge_rate { get; set; }
        public string total_pay_calculation { get; set; }
        public string calculate_charge_using { get; set; }
        public string start_of_week { get; set; }
        public string pay_cycle { get; set; }
        public decimal? astute_pay_cycle_id { get; set; }
        public decimal? astute_rule_group_id { get; set; }
        public decimal? astute_rate_card_id { get; set; }
        public decimal? first_half_of_month { get; set; }
        public decimal? second_half_of_month { get; set; }
        public List<PayAndChargeInclOvertime> pay_and_charge_incl_overtimes { get; set; }
        public List<AllowancesSubjectToStatGovtTaxis> allowances_subject_to_stat_govt_taxes { get; set; }
        public List<AllowancesNotSubjectToStatGovtTaxis> allowances_not_subject_to_stat_govt_taxes { get; set; }
        public List<ContractBasedOptionalFactor> contract_based_optional_factors { get; set; }
        public List<PtoPaidTimeOffInHour> pto_paid_time_off_in_hours { get; set; }
        public List<TimesheetsPayRule> timesheets_pay_rules { get; set; }
        public List<TimesheetsPayRuleException> timesheets_pay_rule_exceptions { get; set; }
        public string fee_model_invoice_pay_interval { get; set; }
        public int? placement_status { get; set; }
        public int? application_source_id { get; set; }
        public int? position_id { get; set; }
        public int? application_id { get; set; }
        public int? placed_by { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public DateTime? effective_date { get; set; }
        public int? amendment_reason_id { get; set; }
        public int? is_latest { get; set; }     
    }

    public class TimesheetsPayRule
    {
        public string rules { get; set; }
        public decimal? hours { get; set; }
        public string hours_to { get; set; }
        public string hours_from { get; set; }
        public string period { get; set; }
        public string apply_pay_name { get; set; }
    }

    public class TimesheetsPayRuleException
    {
        public string rules { get; set; }
        public decimal? hours { get; set; }
        public string hours_to { get; set; }
        public string hours_from { get; set; }
        public string period { get; set; }
        public string apply_pay_name { get; set; }
    }
       
    public class StatGovTaxis
    {
        public string name { get; set; }
        public string type_of_taxes { get; set; }
        public decimal? employer_contribution_percentage { get; set; }
        public decimal? employee_contribution_percentage { get; set; }
        public decimal? employer_contribution_amount { get; set; }
        public decimal? employee_contribution_amount { get; set; }
    }

    public class AllowancesNotSubjectToStatGovtTaxis
    {
        public string name { get; set; }
        public string fixed_or_percentage { get; set; }
        public decimal? number_or_percentage { get; set; }
        public string description { get; set; }
    }

    public class AllowancesSubjectToStatGovtTaxis
    {
        public string name { get; set; }
        public decimal? percentage_in_decimal { get; set; }
        public string description { get; set; }
    }

    public class AllowanceStatutory
    {
        public string name { get; set; }
        public string fixed_or_percentagge { get; set; }
        public decimal? number_or_percentage { get; set; }
        public bool? add_to_margin { get; set; }
        public bool? add_to_charge_rate { get; set; }
        public bool? add_to_pay_rate { get; set; }
        public int? index { get; set; }
        public List<int> calc_links { get; set; }
        public bool? threshold { get; set; }
        public List<int> apply_to_pay { get; set; }
    }

    public class ContractBasedOptionalFactor
    {
        public string enter_item_here { get; set; }
        public decimal? percentage_in_decimal { get; set; }
        public string description { get; set; }
    }

    public class Deduction
    {
        public string name { get; set; }
        public string fixed_or_percentagge { get; set; }
        public decimal? number_or_percentage { get; set; }
    }

    public class ExemptIncentive
    {
        public string name { get; set; }
        public string fixed_or_percentage { get; set; }
        public decimal? number_or_percentage { get; set; }
        public string description { get; set; }
        public decimal? charge_rate { get; set; }
        public bool? threshold { get; set; }
        public string budget_by { get; set; }
    }

    public class FeeModelRetainerDetail
    {
        public decimal? amount { get; set; }
        public DateTime? invoice_date { get; set; }
        public string description { get; set; }
    }

    public class Incentive
    {
        public string name { get; set; }
        public string fixed_or_percentage { get; set; }
        public decimal? number_or_percentage { get; set; }
        public string description { get; set; }
    }

    public class Loading
    {
        public string name { get; set; }
        public string fixed_or_percentagge { get; set; }
        public decimal? number_or_percentage { get; set; }
        public List<int?> calc_links { get; set; }
        public List<int?> apply_to_pay { get; set; }
    }

    public class OptionalFactor
    {
        public string name { get; set; }
        public string fixed_or_percentage { get; set; }
        public decimal? number_or_percentage { get; set; }
        public bool? add_to_margin { get; set; }
        public bool? add_to_charge_rate { get; set; }
        public bool? add_to_pay_rate { get; set; }
        public int? index { get; set; }
        public List<int?> calc_links { get; set; }
        public bool? threshold { get; set; }
        public List<int?> apply_to_pay { get; set; }
    }

    public class PayAndChargeInclOvertime
    {
        public string pay_name { get; set; }
        public decimal? pay_rate { get; set; }
        public string formatted_pay_rate { get; set; }
        public decimal? on_costs_number { get; set; }
        public string formatted_on_costs_number { get; set; }
        public decimal? total_pay_rate { get; set; }
        public string formatted_total_pay_rate { get; set; }
        public decimal? charge_rate { get; set; }
        public string formatted_charge_rate { get; set; }
        public decimal? profit_margin { get; set; }
        public string formatted_profit_margin { get; set; }
        public decimal? pay_level { get; set; }
        public decimal? total_cost { get; set; }
        public string formatted_total_cost { get; set; }
        public decimal? deduction { get; set; }
        public string formatted_deduction { get; set; }
        public decimal? loadings { get; set; }
        public string formatted_loadings { get; set; }
        public decimal? multiplier_percent { get; set; }
        public string fixed_or_percentage { get; set; }
        public int? index { get; set; }
    }

    public class PtoPaidTimeOffInHour
    {
        public string code_name { get; set; }
        public string code_type { get; set; }
        public bool? accrual_tracking { get; set; }
        public bool? charge_to_client { get; set; }
        public decimal? paid_hours { get; set; }
    }

    public class CostOfSale
    {
        public string description { get; set; }
        public decimal? quantity { get; set; }
        public decimal? rate { get; set; }
        public decimal? amount { get; set; }
    }

    public class OtherInvoiceItem
    {
        public string description { get; set; }
        public decimal? quantity { get; set; }
        public decimal? charge { get; set; }
    }

    public class ProfitSplit
    {
        public string user_id { get; set; }
        public string name { get; set; }
        public decimal? share_percentage { get; set; }
        public decimal? amount { get; set; }
        public string astute_user_id { get; set; }
    }

    public class PlacementInvoice_model
    {
        public int? slice_index { get; set; }
        public decimal? num_of_elements { get; set; }
        public bool? last { get; set; }
        public List<PlacementInvoice> content { get; set; }
    }

    public class PlacementInvoice
    {
        public int id                           { get; set; }
        public string invoice_id                       { get; set; }
        public string invoice_type { get; set; }
        public string invoice_status { get; set; }
        public string payment_status { get; set; }
        public int? job_id                           { get; set; }
        public string job_name { get; set; }
        public int? contact_id                       { get; set; }
        public string contact_firstname { get; set; }
        public string contact_middlename               { get; set; }
        public string contact_lastname                 { get; set; }
        public string contact_firstname_kana           { get; set; }
        public string contact_lastname_kana            { get; set; }
        public string contact_name { get; set; }
        public int? candidate_id                     { get; set; }
        public string candidate_firstname              { get; set; }
        public string candidate_middlename             { get; set; }
        public string candidate_lastname               { get; set; }
        public string candidate_firstname_kana         { get; set; }
        public string candidate_lastname_kana          { get; set; }
        public string candidate_name { get; set; }
        public int? company_id                       { get; set; }
        public string company_name { get; set; }
        public DateTime? invoice_date                     { get; set; }
        public DateTime? service_delivery_date { get; set; }
        public DateTime? updated_date { get; set; }
        public string currency                         { get; set; }
        public decimal? amount_due                       { get; set; }
        public string formatted_amount_due             { get; set; }
        public DateTime? due_date                         { get; set; }
        public int? overdue_by                       { get; set; }
        public string po_number                        { get; set; }
        public string timesheet_id { get; set; }
    }
}
