using GetVincere.Model;
using GetVincere.Model.Candidate;
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

namespace GetVincere.Candidate
{
    public partial class UpdateCandidateSubInformationForm : Form
    {
        public UpdateCandidateSubInformationForm()
        {
            InitializeComponent();
            cboSubInfo.SelectedIndex = 0;
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

            ClearTime();
            lblProcessName.Text = "";
            CandidateRepository _repo = new CandidateRepository();
            dgvCandidate.RowCount = 0;
            int _n = 0;
            prb.Value = 0;

            try
            {
                if (chkDateCreated.Checked) { GetData("created_date", "fl=id,first_name, last_name, created_date, last_update; sort= created_date desc"); }
                if (chkDateUpdated.Checked) { GetData("last_update", "fl=id,first_name, last_name, created_date, last_update; sort= last_update desc"); }

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
            string _endpoint = ConstantVincere.SearchCandidateEndpoint; // + "search/"; //txtEndPoint.Text; //
            
            client.BaseAddress = new Uri(ConstantVincere.apiURL + ConstantVincere.GetCandidateEndpoint);  // new Uri(txtController.Text);
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
                Candidate_model.Search_model _candidate = new Candidate_model.Search_model();

                _candidate = JsonConvert.DeserializeObject<Candidate_model.Search_model>(_value);
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

                    string _endpoint_per_page = txtEndPoint.Text + txtReturnFiels.Text +
                        "?q=" + _param+ ":" + _data_limit;

                    //"?cursorMark=QW9KK3BwV0d0ZXNDUHdsc2IyTmhiR2h2YzNRdWRtbHVZMlZ5WldSbGRpNWpiMjBoWTJGdVpHbGtZWFJsWHpNMk5qTTU=" +

                    HttpResponseMessage _response_per_page = new HttpResponseMessage();
                    _response_per_page = client.GetAsync(_endpoint_per_page).Result;

                    var _value_per_page = "";
                    if (_response_per_page.IsSuccessStatusCode)
                    {
                        _value_per_page = _response_per_page.Content.ReadAsStringAsync().Result.ToString();
                        Candidate_model.Search_model _candidate_per_page = new Candidate_model.Search_model();

                        _candidate_per_page = JsonConvert.DeserializeObject<Candidate_model.Search_model>(_value_per_page);
                        foreach (Candidate_model.Search_model.item_model _item in _candidate_per_page.result.items)
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
             
        }

        public void InsertRow(Candidate_model.Search_model.item_model _item, string _basis)
        {
            try
            {
                int _n = dgvCandidate.Rows.Add();
                dgvCandidate.Rows[_n].Cells[0].Value = _item.id.ToString();
                dgvCandidate.Rows[_n].Cells[1].Value = _item.first_name;
                dgvCandidate.Rows[_n].Cells[2].Value = _item.last_name;
                dgvCandidate.Rows[_n].Cells[3].Value = _item.created_date.ToString();
                dgvCandidate.Rows[_n].Cells[4].Value = _item.last_update.ToString();
                dgvCandidate.Rows[_n].Cells[5].Value = _basis;
                dgvCandidate.Rows[_n].Cells[6].Value = "";

                CandidateRepository _repo = new CandidateRepository();
                Candidate_model.CandidateData_model _model = new Candidate_model.CandidateData_model
                {
                    Id = _item.id,
                    Lastname = _item.last_name,
                    Fistname = _item.first_name,
                    DateCreated = _item.created_date,
                    LastUpdated = _item.last_update
                };
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

                    int _candidat_id = int.Parse( row.Cells[0].Value.ToString());

                    string _data_result = "";
                    lblProcessName.Text = row.Cells[2].Value.ToString() + ", " + row.Cells[1].Value.ToString();

                    if (_candidat_id == 105334)
                    {


                    }

                    if (chkCandidateDetails.Checked) {
                        bool _result = UpdateCandidateInformation(_candidat_id);
                        if (_result) { _data_result = "|C-ok|"; }
                        else {
                            _data_result = "|C-x|";
                            row.Cells[6].Value = _data_result;
                            MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
 

                    //EDUCATION
                    if (chkEducation.Checked) {
                        bool _result = UpdateCandidateEducation(_candidat_id);
                        if (_result) { _data_result = _data_result + " |E-ok|"; }
                        else
                        {
                            _data_result = "|E-x|";
                            row.Cells[6].Value = _data_result;
                            MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    if (chkWorkExperience.Checked)
                    {
                        bool _result = UpdateCandidateWorkExperience(_candidat_id);
                        if (_result) { _data_result = _data_result + " |W-ok|"; }
                        else
                        {
                            _data_result = "|W-x|";
                            row.Cells[6].Value = _data_result;
                            MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    if (chkDocument.Checked) {
                        bool _result = UpdateCandidateDocument(_candidat_id);
                        if (_result) { _data_result = _data_result + " |D-ok|"; }
                        else
                        {
                            _data_result = "|D-x|";
                            row.Cells[6].Value = _data_result;
                            MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    row.Cells[6].Value = _data_result;

                    //return;
                }

                SetTimeFinished();
                MessageBox.Show("Candidate information successfully saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public bool UpdateCandidateWorkExperience(int _candidateid)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

            try
            {
                string _endpoint_per_candidate = ConstantVincere.GetCandidateEndpoint + _candidateid.ToString() + @"/workexperiences";

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_candidate).Result;


                var _value = "";
                if (_response.IsSuccessStatusCode)
                {

                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    if (_value == "") { return true; }
                    List<VinCandidateExperience_model> _obj = new List<VinCandidateExperience_model>();
                    _obj = JsonConvert.DeserializeObject<List<VinCandidateExperience_model>>(_value);
                    foreach (VinCandidateExperience_model _work in _obj)
                    {
                        CandidateRepository _repo = new CandidateRepository();
                        bool _result = _repo.ManageVinCandidateExperience(_candidateid, _work);
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

        public bool UpdateCandidateEducation(int _candidateid)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

            //if (_candidateid == 127125)
            //{

            //}

            try
            {
                string _endpoint_per_candidate = ConstantVincere.GetCandidateEndpoint + _candidateid.ToString() + @"/educationdetails";

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_candidate).Result;


                var _value = "";
                if (_response.IsSuccessStatusCode)
                {

                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    if (_value == "") { return true; }
                    List<VinCandidateEducation_model> _obj = new List<VinCandidateEducation_model>();
                    _obj = JsonConvert.DeserializeObject<List<VinCandidateEducation_model>>(_value);
                    foreach (VinCandidateEducation_model _edu in _obj)
                    {
                        CandidateRepository _repo = new CandidateRepository();
                        bool _result = _repo.ManageVinCandidateEducation(_candidateid, _edu);
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

        public bool UpdateCandidateInformation(int _candidateid )
        {
            HttpClient client = new HttpClient();
      
            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

            try
            {
                string _endpoint_per_candidate = ConstantVincere.GetCandidateEndpoint + _candidateid.ToString();

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_candidate).Result;


                var _value = "";
                if (_response.IsSuccessStatusCode)
                {
                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    VinCandidate_model _candidate = new VinCandidate_model();
                    _candidate = JsonConvert.DeserializeObject<VinCandidate_model>(_value);

                    CandidateRepository _repo = new CandidateRepository();
                    _repo.ManageVinCandidate(_value);

                    return true;
                }
                
                return false;
               
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
