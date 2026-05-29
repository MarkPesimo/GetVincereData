using GetVincere.Model;
using GetVincere.Model.Candidate;
using GetVincere.Model.InvoiceModel;
using GetVincere.Model.JobModel;
using GetVincere.Model.PlacementModel;
using GetVincere.Repository;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetVincere.JobOrder
{
    public partial class UpdateJobSubInformationForm : Form
    {
        public UpdateJobSubInformationForm()
        {
            InitializeComponent();
            
        }

        public void ClearTime()
        {
            lblTimeStart.Text = "Start Time : ";
            lblTimeFinished.Text = "Finished Time : ";
        }

        public void SetTimeStart()
        {
            lblTimeStart.Text = "Time Started : " + DateTime.Now.ToString();
        }

        public void SetTimeFinished()
        {
            lblTimeFinished.Text = "Time Finished : " + DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!chkDateCreated.Checked && !chkDateUpdated.Checked)
            {
                MessageBox.Show("Kindly select a date basis.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ConstantVincere.TokedId == "")
            {
                MessageBox.Show("Token-Id is not set. please check.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClearTime();
            lblProcessName.Text = "";
            CandidateRepository _repo = new CandidateRepository();
            dgvCandidate.RowCount = 0;
            int _n = 0;
            prb.Value = 0;

            try
            {
                if (chkDateCreated.Checked) { GetData("created_date", "fl=id, company, job_title, created_date, last_update; sort= created_date desc"); }
                if (chkDateUpdated.Checked) { GetData("last_update", "fl=id, company, job_title, created_date, last_update; sort= last_update desc"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //created_date
        public void GetData(string _param, string _returnfields)
        {
            int _max_record_return = 100;

            HttpClient client = new HttpClient();
            string _endpoint =    ConstantVincere.SearchJobEndpoint; //  txtEndPoint.Text;    

            client.BaseAddress = new Uri(ConstantVincere.apiURL + ConstantVincere.GetJobEndpoint); // new Uri(txtController.Text);
            client.DefaultRequestHeaders.Add("x-api-key", txtXAPIKey.Text + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

            string _date_range = "[" + dtpFrom.Value.Year.ToString() + "-" + dtpFrom.Value.Month.ToString() + "-" + dtpFrom.Value.Day + "T00:00:00.000Z" + " TO " +
            dtpTo.Value.Year.ToString() + "-" + dtpTo.Value.Month.ToString() + "-" + dtpTo.Value.Day + "T23:59:59.999Z]%23&";

        
            _endpoint = _endpoint + _returnfields + "?q=" + _param + ":" + _date_range;

            HttpResponseMessage _response = new HttpResponseMessage();
            _response = client.GetAsync(_endpoint).Result;

            int n = 0;

            var _value = "";
            if (_response.IsSuccessStatusCode)
            {
                _value = _response.Content.ReadAsStringAsync().Result.ToString();
                Job_model.Search_model _candidate = new Job_model.Search_model();

                _candidate = JsonConvert.DeserializeObject<Job_model.Search_model>(_value);
                lblRecordFound.Text = _candidate.result.total.ToString();
                int _remainder = _candidate.result.total % _max_record_return;

                int _page = _candidate.result.total / _max_record_return;
                if (_remainder > 0) { _page = _page + 1; }
                lblPage.Text = _page.ToString();

                prb.Maximum = _page;
                prb.Value = 0;
                int _row_cnt = 1;

                int _page_cnt_process = 0;

                int _limit_cnt = 100;


                while (_page_cnt_process < int.Parse(lblRecordFound.Text))
                {
                    if (_limit_cnt > int.Parse(lblRecordFound.Text))
                    {
                        _limit_cnt = int.Parse(lblRecordFound.Text);
                    }
                    lblProcessPageNo.Text = "Process counter : " + _limit_cnt.ToString();

                    string _data_limit = "[" + dtpFrom.Value.Year.ToString() + "-" + dtpFrom.Value.Month.ToString() + "-" + dtpFrom.Value.Day + "T00:00:00.000Z" + " TO " +
                    dtpTo.Value.Year.ToString() + "-" + dtpTo.Value.Month.ToString() + "-" + dtpTo.Value.Day + "T23:23:59.999Z]%23" +
                    "&start= " + _page_cnt_process.ToString() +
                    "&limit= 100";

                    string _endpoint_per_page = ConstantVincere.SearchJobEndpoint + _returnfields  +
                        "?q=" + _param + ":" + _data_limit;

                    
                    HttpResponseMessage _response_per_page = new HttpResponseMessage();
                    _response_per_page = client.GetAsync(_endpoint_per_page).Result;

                    var _value_per_page = "";
                    if (_response_per_page.IsSuccessStatusCode)
                    {
                        _value_per_page = _response_per_page.Content.ReadAsStringAsync().Result.ToString();
                        Job_model.Search_model _candidate_per_page = new Job_model.Search_model();

                        _candidate_per_page = JsonConvert.DeserializeObject<Job_model.Search_model>(_value_per_page);
                        foreach (Job_model.Search_model.item_model _item in _candidate_per_page.result.items)
                        {
                            InsertRow(_item, _param);
                            _row_cnt++;
                        }
                    }
                    else
                    {
                        MessageBox.Show(_response_per_page.StatusCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    _page_cnt_process = _page_cnt_process + _max_record_return;
                    _limit_cnt = _limit_cnt + _max_record_return;
                }
            }
            else
            {
                if (_response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Request Anauthorized, kindly update your ID-TOKEN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(_response.RequestMessage.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            MessageBox.Show(dgvCandidate.Rows.Count.ToString() + " records found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void InsertRow(Job_model.Search_model.item_model _item, string _basis)
        {
            try
            {
                int _n = dgvCandidate.Rows.Add();
                dgvCandidate.Rows[_n].Cells[0].Value = _item.id.ToString();
                dgvCandidate.Rows[_n].Cells[1].Value = _item.company.name;
                dgvCandidate.Rows[_n].Cells[2].Value = _item.job_title;
                dgvCandidate.Rows[_n].Cells[3].Value = _item.created_date.ToString();
                dgvCandidate.Rows[_n].Cells[4].Value = _item.last_update.ToString();
                dgvCandidate.Rows[_n].Cells[5].Value = _basis;
                dgvCandidate.Rows[_n].Cells[6].Value = "";

           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvCandidate.Rows.Count == 0)
            {
                MessageBox.Show("No record to process, please check.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Process may take a minute or more, proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            try
            {
            
                prb.Maximum = dgvCandidate.Rows.Count;
                prb.Value = 0;
                SetTimeStart();
                foreach (DataGridViewRow row in dgvCandidate.Rows)
                {
                    prb.Value = prb.Value + 1;
                    
                    //string _sub_endpoint = "";
                    //if (cboSubInfo.Text == "Education") { _sub_endpoint = "/educationdetails"; }
                    //else if (cboSubInfo.Text == "Work Experience") { _sub_endpoint = "/workexperiences"; }

                    int _joborder_id = int.Parse( row.Cells[0].Value.ToString());

                    string _data_result = "";
                    lblProcessName.Text = "Processing Job Order #: " + _joborder_id.ToString();

               
                    //JOB DETAILS
                    if (chkJobDetails.Checked) {
                        string _result = UpdateJobInformation(_joborder_id);
                        if (_result == "200") { _data_result = "|J-ok|"; }
                        else
                        {
                            _data_result = "|J-" + _result + "|";
                            row.Cells[6].Value = _data_result;
                            if (_result != "InternalServerError")
                            { 
                                MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }


                    //JOB APPLICATION
                    if (chkApplication.Checked)
                    {
                        bool _result = UpdateJobApplication(_joborder_id);
                        if (_result) { _data_result = _data_result + " |A-ok|"; }
                        else
                        {
                            _data_result = "|A-x|";
                            row.Cells[6].Value = _data_result;
                            MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    //PLACEMENT
                    if (chkPlacement.Checked)
                    {
                        bool _result = UpdateJobPlacement(_joborder_id);
                        if (_result) { _data_result = _data_result + " |P-ok|"; }
                        else
                        {
                            _data_result = "|P-x|";
                            row.Cells[6].Value = _data_result;
                            MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
 


                    row.Cells[6].Value = _data_result;

                }

                SetTimeFinished();
                MessageBox.Show("Job Order information successfully saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCandidateSubInformationForm_Load(object sender, EventArgs e)
        {

        }

        public bool UpdateCandidateDocument(int _candidateid)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

     
            try
            {
                string _endpoint_per_candidate = ConstantVincere.GetCandidateEndpoint + _candidateid.ToString() + @"/files";

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_candidate).Result;


                var _value = "";
                if (_response.IsSuccessStatusCode)
                {

                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    if (_value == "") { return true; }
                    List<VinCandidateDocument_model> _obj = new List<VinCandidateDocument_model>();
                    _obj = JsonConvert.DeserializeObject<List<VinCandidateDocument_model>>(_value);
                    foreach (VinCandidateDocument_model _edu in _obj)
                    {
                        CandidateRepository _repo = new CandidateRepository();
                        bool _result = _repo.ManageVinCandidateDocument(_candidateid, _edu);
                        if (!_result)
                        {
                            return false;
                        }
                    }

                    return true;
                }
                else
                {
                    if (_response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Request Anauthorized, kindly update your ID-TOKEN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    else if (_response.StatusCode == System.Net.HttpStatusCode.NotFound) { return true; }
                    else { return false; }
                }
                                
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateJobPlacement(int _joid)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

            try
            {
                string _endpoint_per_candidate = ConstantVincere.GetJobEndpoint + _joid.ToString() + @"/placements";

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_candidate).Result;


                var _value = "";
                if (_response.IsSuccessStatusCode)
                {

                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    if (_value == "") { return true; }
                    List<vinJob_placement_model> _obj = new List<vinJob_placement_model>();
                    _obj = JsonConvert.DeserializeObject<List<vinJob_placement_model>>(_value);
                    foreach (vinJob_placement_model _placement in _obj)
                    {
                        JobRepository _repo = new JobRepository();
                        bool _result = _repo.ManageJobPlacement(_placement);
                        if (_result)
                        {
                            int _placement_id = int.Parse(_placement.placement_id.ToString());
                            string _placement_endpoint = ConstantVincere.GetPlacementEndpoint + _placement_id.ToString();

                            HttpResponseMessage _placement_response = new HttpResponseMessage();
                            _placement_response = client.GetAsync(_placement_endpoint).Result;

                            if (_placement_response.IsSuccessStatusCode)
                            {
                                _value = _placement_response.Content.ReadAsStringAsync().Result.ToString();
                                PlacementRepository _placementRepository = new PlacementRepository();
                                bool _placement_result = _placementRepository.ManageVinPlacement(_value);

                                //return true;
                            }

                            //=====================cost of sales==================================
                            string _costofsales_endpoint = ConstantVincere.GetPlacementEndpoint + _placement_id.ToString() + "/costofsales";
                            HttpResponseMessage _costofsales_response = new HttpResponseMessage();
                            _costofsales_response = client.GetAsync(_costofsales_endpoint).Result;
                            if (_costofsales_response.IsSuccessStatusCode)
                            {
                                _value = _costofsales_response.Content.ReadAsStringAsync().Result.ToString();
                                List<CostOfSale> _costofsales = new List<CostOfSale>();
                                _costofsales = JsonConvert.DeserializeObject<List<CostOfSale>>(_value);
                                foreach (CostOfSale _x in _costofsales)
                                {
                                    PlacementRepository _placementRepository = new PlacementRepository();
                                    bool _costofcenter_result = _placementRepository.ManageVinPlacementCostOfSales(_placement_id, _x);
                                }
                            }
                            //=====================cost of sales==================================

                            //=====================other invoice item==================================
                            string _otherinvoiceitem_endpoint = ConstantVincere.GetPlacementEndpoint + _placement_id.ToString() + "/otherinvoiceitems";
                            HttpResponseMessage _otherinvoiceitem_response = new HttpResponseMessage();
                            _otherinvoiceitem_response = client.GetAsync(_otherinvoiceitem_endpoint).Result;
                            if (_otherinvoiceitem_response.IsSuccessStatusCode)
                            {
                                _value = _otherinvoiceitem_response.Content.ReadAsStringAsync().Result.ToString();
                                List<OtherInvoiceItem> _otherinvoiceitems = new List<OtherInvoiceItem>();
                                _otherinvoiceitems = JsonConvert.DeserializeObject<List<OtherInvoiceItem>>(_value);
                                foreach (OtherInvoiceItem _x in _otherinvoiceitems)
                                {
                                    PlacementRepository _placementRepository = new PlacementRepository();
                                    bool _otherinvoice_result = _placementRepository.ManageVinPlacementOtherInvoiceItem(_placement_id, _x);
                                }
                            }
                            //=====================other invoice item==================================

                            //=====================profit share==================================
                            string _profitshare_endpoint = ConstantVincere.GetPlacementEndpoint + _placement_id.ToString() + "/profitsplits";
                            HttpResponseMessage _profitshare_response = new HttpResponseMessage();
                            _profitshare_response = client.GetAsync(_profitshare_endpoint).Result;
                            if (_profitshare_response.IsSuccessStatusCode)
                            {
                                _value = _profitshare_response.Content.ReadAsStringAsync().Result.ToString();
                                List<ProfitSplit> profitsplits= new List<ProfitSplit>();
                                profitsplits = JsonConvert.DeserializeObject<List<ProfitSplit>>(_value);
                                foreach (ProfitSplit _x in profitsplits)
                                {
                                    PlacementRepository _placementRepository = new PlacementRepository();
                                    bool _profitshare_result = _placementRepository.ManageVinPlacementProfitSplit(_placement_id, _x);
                                }
                            }
                            //=====================profit share==================================


                            //=====================INVOICE==================================
                            string _invoice_endpoint = ConstantVincere.GetPlacementEndpoint + _placement_id.ToString() + "/invoices";
                            HttpResponseMessage _invoice_response = new HttpResponseMessage();
                            _invoice_response = client.GetAsync(_invoice_endpoint).Result;
                            if (_invoice_response.IsSuccessStatusCode)
                            {
                                _value = _invoice_response.Content.ReadAsStringAsync().Result.ToString();
                                PlacementInvoice_model _invoices = new PlacementInvoice_model();
                                _invoices = JsonConvert.DeserializeObject<PlacementInvoice_model>(_value);
                                foreach (PlacementInvoice _x in _invoices.content)
                                {
                                    PlacementRepository _placementRepository = new PlacementRepository();
                                    bool _invoice_result = _placementRepository.ManageVinPlacementInvoice(_placement_id, _x);

                                    string _inv_endpoint = ConstantVincere.GetInvoiceEndpoint + _x.id.ToString() + "/info";
                                    HttpResponseMessage _inv_response = new HttpResponseMessage();
                                    _inv_response = client.GetAsync(_inv_endpoint).Result;
                                    if (_inv_response.IsSuccessStatusCode)
                                    {
                                        _value = _inv_response.Content.ReadAsStringAsync().Result.ToString();
                                        vinInvoice_model _inv_model = new vinInvoice_model();
                                        _inv_model = JsonConvert.DeserializeObject<vinInvoice_model>(_value);
                                        if (_inv_model != null)
                                        {
                                            InvoiceRepository _invoiceRepository = new InvoiceRepository();
                                            bool _res_invoice = _invoiceRepository.ManageVinInvoice(_inv_model);
                                        }
                                    }
                                }
                            }
                            //=====================INVOICE==================================
                        }
                    }

                    return true;
                }
                else
                {
                    if (_response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Request Anauthorized, kindly update your ID-TOKEN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    else if (_response.StatusCode == System.Net.HttpStatusCode.NotFound) { return true; }
                    else { return false; }
                }


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateJobApplication(int _joid)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");


            //if (_joid == 41958)
            //{

            //}
            try
            {
                string _endpoint_per_candidate = ConstantVincere.GetJobEndpoint + _joid.ToString() + @"/applications?index=0";

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_candidate).Result;


                var _value = "";
                if (_response.IsSuccessStatusCode)
                {

                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    if (_value == "") { return true; }
                    JobApplication_Search_model _obj = new JobApplication_Search_model();
                    _obj = JsonConvert.DeserializeObject<JobApplication_Search_model>(_value);
                    if (_obj != null)
                    {
                        foreach (vinJob_application_model _app in _obj.content)
                        {
                            JobRepository _repo = new JobRepository();
                            bool _result = _repo.ManageJobApplication(_app);
                            if (!_result)
                            {
                                return false;
                            }
                        }
                    }
                    //foreach (JobApplication_Search_model _app in _obj)
                    //{
                    //    CandidateRepository _repo = new CandidateRepository();
                    //    //bool _result = _repo.ManageVinCandidateEducation(_candidateid, _edu);
                    //    //if (!_result)
                    //    //{
                    //    //    return false;
                    //    //}
                    //}

                    return true;
                }
                else
                {
                    if (_response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Request Anauthorized, kindly update your ID-TOKEN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    else if (_response.StatusCode == System.Net.HttpStatusCode.NotFound) { return true; }
                    else { return false; }
                }

                 
                 
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string UpdateJobInformation(int _jobid )
        {
            HttpClient client = new HttpClient();
      
            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

            try
            {
                string _endpoint_per_job = ConstantVincere.GetJobEndpoint + _jobid.ToString();

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_job).Result;


                var _value = "";
                if (_response.IsSuccessStatusCode)
                {
                    _value = _response.Content.ReadAsStringAsync().Result.ToString();                  
                    JobRepository _repo = new JobRepository();
                    _repo.ManageJob(_value);

                    return "200";
                }
                
                return _response.StatusCode.ToString();
               
            }
            catch (Exception ex)
            {
                return "ERR";
            }
        }
    }
}
