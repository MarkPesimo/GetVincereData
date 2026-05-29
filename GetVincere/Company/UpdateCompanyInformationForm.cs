using GetVincere.Model;
using GetVincere.Model.Candidate;
using GetVincere.Model.CompanyModel;
using GetVincere.Model.JobModel;
using GetVincere.Repository;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetVincere.Company
{
    public partial class UpdateCompanyInformationForm : Form
    {
        public UpdateCompanyInformationForm()
        {
            InitializeComponent();
            //cboSubInfo.SelectedIndex = 0;
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
                if (chkDateCreated.Checked) { GetData("created_date", "fl=id, name, location, created_date, last_update; sort= created_date desc"); }
                if (chkDateUpdated.Checked) { GetData("last_update", "fl=id, name, location, created_date, last_update; sort= last_update desc"); }

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
            string _endpoint =    ConstantVincere.SearchCompanyEndpoint; //  txtEndPoint.Text;    

            client.BaseAddress = new Uri(ConstantVincere.apiURL + ConstantVincere.GetCompanyEndpoint); // new Uri(txtController.Text);
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
                Company_model.Search_model _obj = new Company_model.Search_model();

                _obj = JsonConvert.DeserializeObject<Company_model.Search_model>(_value);
                lblRecordFound.Text = _obj.result.total.ToString();
                int _remainder = _obj.result.total % _max_record_return;

                int _page = _obj.result.total / _max_record_return;
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

                    string _endpoint_per_page = ConstantVincere.SearchCompanyEndpoint + _returnfields +
                        "?q=" + _param + ":" + _data_limit;


                    HttpResponseMessage _response_per_page = new HttpResponseMessage();
                    _response_per_page = client.GetAsync(_endpoint_per_page).Result;

                    var _value_per_page = "";
                    if (_response_per_page.IsSuccessStatusCode)
                    {
                        _value_per_page = _response_per_page.Content.ReadAsStringAsync().Result.ToString();
                        Company_model.Search_model _candidate_per_page = new Company_model.Search_model();

                        _candidate_per_page = JsonConvert.DeserializeObject<Company_model.Search_model>(_value_per_page);
                        foreach (Company_model.Search_model.item_model _item in _candidate_per_page.result.items)
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
                    return;
                }
                else
                {
                    MessageBox.Show(_response.RequestMessage.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show(dgvCandidate.Rows.Count.ToString() + " records found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void InsertRow(Company_model.Search_model.item_model _item, string _basis)
        {
            try
            {
                int _n = dgvCandidate.Rows.Add();
                dgvCandidate.Rows[_n].Cells[0].Value = _item.id.ToString();
                dgvCandidate.Rows[_n].Cells[1].Value = _item.name;
                
                dgvCandidate.Rows[_n].Cells[2].Value = _item.created_date.ToString();
                dgvCandidate.Rows[_n].Cells[3].Value = _item.last_update.ToString();
                dgvCandidate.Rows[_n].Cells[4].Value = _basis;
                dgvCandidate.Rows[_n].Cells[5].Value = "";           
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
                                        
                    int _company_id = int.Parse( row.Cells[0].Value.ToString());

                    string _data_result = "";
                    lblProcessName.Text = "Company Id#: " + row.Cells[1].Value.ToString();

                    if (_company_id == 18316)
                    {

                    }

                    //JOB DETAILS
                    if (chkJobDetails.Checked) {
                        string _result = UpdateCompanyInformation(_company_id);
                        if (_result == "200") { _data_result = "|C-ok|"; }
                        else
                        {
                            _data_result = "|J-" + _result + "|";
                            row.Cells[5].Value = _data_result;
                            if (_result != "InternalServerError")
                            { 
                                MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }


                    //JOB APPLICATION
                    if (chkLocation.Checked)
                    {
                        bool _result = UpdateCompanyLocation (_company_id);
                        if (_result) { _data_result = _data_result + " |L-ok|"; }
                        else
                        {
                            _data_result = "|L-x|";
                            row.Cells[5].Value = _data_result;
                            MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    //BRANCHES
                    if (chkBranches.Checked)
                    {
                        bool _result = UpdateCompanybranch(_company_id);
                        if (_result) { _data_result = _data_result + " |B-ok|"; }
                        else
                        {
                            _data_result = "|B-x|";
                            row.Cells[5].Value = _data_result;
                            MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    //BRANDS
                    if (chkBrands.Checked)
                    {
                        bool _result = UpdateCompanybrands(_company_id);
                        if (_result) { _data_result = _data_result + " |BD-ok|"; }
                        else
                        {
                            _data_result = "|BD-x|";
                            row.Cells[5].Value = _data_result;
                            MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    if (chkFiles.Checked)
                    {
                        //UpdateCompanyFiles(_company_id);
                        //bool _result = await UpdateCompanyDocument2(_company_id);
                        //bool _result = true;
                        //UpdateCompanyDocument2(_company_id);
                        //if (_result) { _data_result = _data_result + " |D-ok|"; }
                        //else
                        //{
                        //    _data_result = "|D-x|";
                        //    row.Cells[5].Value = _data_result;
                        //    MessageBox.Show("An error occured, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}

                    }

                    row.Cells[5].Value = _data_result;

                    //return;
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

        public async Task UpdateCompanyFiles(int _companyid)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, "https://zmgwardhowell.vincere.io/api/v2/company/14571/files");
                request.Headers.Add("id-token", "eyJraWQiOiI5bHNyUXBsU1lXWDNXXC9CR0o1UjZWUzFKVmp3TjNMYUtyWjg5NTdMXC9UZlU9IiwiYWxnIjoiUlMyNTYifQ.eyJhdF9oYXNoIjoidlhvTnB2bVh3TXVmeWxkWGtDZldzQSIsInN1YiI6Ijk5NzhjZmI5LWI5MGMtNDNmYy1hOGEzLTQzYjkxNDVmMGNkZCIsImVtYWlsX3ZlcmlmaWVkIjpmYWxzZSwiaXNzIjoiaHR0cHM6XC9cL2NvZ25pdG8taWRwLnVzLWVhc3QtMS5hbWF6b25hd3MuY29tXC91cy1lYXN0LTFfREZzUXA3bTdEIiwiY29nbml0bzp1c2VybmFtZSI6IkFjY2Vzc1ZpbmNlcmUtQVBBQ19kOGE5OTk5Yi0xNWNkLTQ5MjktOTVkNi0xYTE3MTM5YzI2ZTgiLCJhdWQiOiI2Mmh1MmJzMnJsYzNsczFvbzZkbm80ZTExcSIsImlkZW50aXRpZXMiOlt7InVzZXJJZCI6ImQ4YTk5OTliLTE1Y2QtNDkyOS05NWQ2LTFhMTcxMzljMjZlOCIsInByb3ZpZGVyTmFtZSI6IkFjY2Vzc1ZpbmNlcmUtQVBBQyIsInByb3ZpZGVyVHlwZSI6Ik9JREMiLCJpc3N1ZXIiOm51bGwsInByaW1hcnkiOiJ0cnVlIiwiZGF0ZUNyZWF0ZWQiOiIxNzcxNDY5Njc3NDEzIn1dLCJ0b2tlbl91c2UiOiJpZCIsImF1dGhfdGltZSI6MTc3OTMxNTU2NCwiZXhwIjoxNzc5MzE5MTY0LCJpYXQiOjE3NzkzMTU1NjQsImVtYWlsIjoibXBlc2ltb0Bhc2lhcGVvcGxld29ya3MuY29tLnBoIn0.WwC2TqudyrL2OvQqpAKicAlR8Kq5Tsxjf-VzjPwDEcH7nEGNNdcQJIiK8pAUzdHeuMz-Bqj-gruanHJfp5wps6S_DA4SLI7VRs6egh8Ry0VUm_Rw8AiCK5VMnTP2N3K3uNDS70NzEhQyJGyEQiD0ibi0pJmcksers4Ksu0RZB_pLZy7vOZ4KQ5SY2x1b7WUWjkzOYwaU1Pdhs07G1_ljAGQvlcs_vZLOPku_p0o74SdSl2gL5FRAkzy7qEUlyud19EiOMPd2VUzPS7SiMZS_FrXWWUMS1LJqKSd_ZYhB1fhc2lYdyaTQ9FpVqukqNzFsGS5BE6D6cSuk34DBEG9vsQ");
                request.Headers.Add("x-api-key", "7210a62c-f3b4-42ff-a3d4-4be67c62fc5a");
                var content = new StringContent(string.Empty);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                request.Content = content;
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                //Console.WriteLine(await response.Content.ReadAsStringAsync());

            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        public async Task<bool> UpdateCompanyDocument2(int _companyid)
        {
            try
            {

                string _url = ConstantVincere.apiURL + ConstantVincere.GetCompanyEndpoint + _companyid.ToString() + "/files";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY);
                    client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId);

               
                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, _url);

                        request.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");

                        HttpResponseMessage _response = await client.SendAsync(request);

                        string _value = await _response.Content.ReadAsStringAsync();

                        if (_response.IsSuccessStatusCode)
                        {
                            if (string.IsNullOrEmpty(_value))
                            {
                                return true;
                            }

                            List<vinCompany_document_model> _obj =JsonConvert.DeserializeObject<List<vinCompany_document_model>>(_value);

                            CompanyRepository _repo = new CompanyRepository();

                            foreach (vinCompany_document_model _edu in _obj)
                            {
                                bool _result = _repo.ManageVinCompanyDocument(_companyid, _edu);

                                if (!_result) { return false; }
                            }

                            return true;
                        }
                        else
                        {
                            MessageBox.Show(_value);

                            if (_response.StatusCode == HttpStatusCode.Unauthorized)
                            {
                                MessageBox.Show("Request Unauthorized, kindly update your ID-TOKEN","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                return false;
                            }
                            else if (_response.StatusCode == HttpStatusCode.NotFound)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
               
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public  bool UpdateCompanyDocument(int _companyid)
        {
            
            HttpClient client = new HttpClient();
            string _url = ConstantVincere.apiURL + ConstantVincere.GetCompanyEndpoint + _companyid.ToString() + @"/files";

            
            client.BaseAddress = new Uri(_url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY);
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId);
            
            

            try
            {                             
                string _endpoint_per_candidate = ConstantVincere.GetCompanyEndpoint + _companyid.ToString() + @"/files";
                HttpResponseMessage _response = new HttpResponseMessage();
     

                _response = client.GetAsync(_url).Result;

                var _value = "";
                if (_response.IsSuccessStatusCode)
                {

                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    if (_value == "") { return true; }
                    List<vinCompany_document_model> _obj = new List<vinCompany_document_model>();
                    _obj = JsonConvert.DeserializeObject<List<vinCompany_document_model>>(_value);
                    foreach (vinCompany_document_model _edu in _obj)
                    {
                        CompanyRepository _repo = new CompanyRepository();
                        bool _result = _repo.ManageVinCompanyDocument(_companyid, _edu);
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

        public bool UpdateCompanyDocument4(int _companyid)
        {
            using (HttpClient client = new HttpClient())
            { 
            string _url = ConstantVincere.apiURL + ConstantVincere.GetCompanyEndpoint + _companyid.ToString() + @"/files";


            client.BaseAddress = new Uri(_url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY);
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string _endpoint_per_candidate = ConstantVincere.GetCompanyEndpoint + _companyid.ToString() + @"/files";
                HttpResponseMessage _response = new HttpResponseMessage();

                _response = client.GetAsync(_url).Result;

                var _value = "";
                if (_response.IsSuccessStatusCode)
                {

                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    if (_value == "") { return true; }
                    List<vinCompany_document_model> _obj = new List<vinCompany_document_model>();
                    _obj = JsonConvert.DeserializeObject<List<vinCompany_document_model>>(_value);
                    foreach (vinCompany_document_model _edu in _obj)
                    {
                        CompanyRepository _repo = new CompanyRepository();
                        bool _result = _repo.ManageVinCompanyDocument(_companyid, _edu);
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


        public bool UpdateCompanybranch(int _companyid)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

            try
            {
                string _endpoint_per_candidate = ConstantVincere.GetCompanyEndpoint + _companyid.ToString() + @"/branches";

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_candidate).Result;

                if (_companyid == 18316)
                {

                }

                var _value = "";
                if (_response.IsSuccessStatusCode)
                {

                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    if (_value == "") { return true; }
                    List<VinCompany_Branch_model> _obj = new List<VinCompany_Branch_model>();
                    _obj = JsonConvert.DeserializeObject<List<VinCompany_Branch_model>>(_value);
                    foreach (VinCompany_Branch_model _brn in _obj)
                    {
                        CompanyRepository _repo = new CompanyRepository();
                        bool _result = _repo.ManageVinCompanyBranch(_companyid, _brn);
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

        public bool UpdateCompanybrands(int _companyid)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

            try
            {
                string _endpoint_per_candidate = ConstantVincere.GetCompanyEndpoint + _companyid.ToString() + @"/brands";

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_candidate).Result;

                if (_companyid == 18316)
                {

                }

                var _value = "";
                if (_response.IsSuccessStatusCode)
                {

                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    if (_value == "") { return true; }
                    List<vinCompany_brand_model> _obj = new List<vinCompany_brand_model>();
                    _obj = JsonConvert.DeserializeObject<List<vinCompany_brand_model>>(_value);
                    foreach (vinCompany_brand_model _brand in _obj)
                    {
                        CompanyRepository _repo = new CompanyRepository();
                        bool _result = _repo.ManageVinCompanyBrand(_companyid, _brand);
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

        public bool UpdateCompanyLocation(int _companyid)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

            try
            {
                string _endpoint_per_candidate = ConstantVincere.GetCompanyEndpoint + _companyid.ToString() + @"/locations";

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_candidate).Result;

                if (_companyid == 18316)
                {
                    
                }

                var _value = "";
                if (_response.IsSuccessStatusCode)
                {

                    _value = _response.Content.ReadAsStringAsync().Result.ToString();
                    if (_value == "") { return true; }
                    List<VinCompany_Location_model> _obj = new List<VinCompany_Location_model>();
                    _obj = JsonConvert.DeserializeObject<List<VinCompany_Location_model>>(_value);
                    foreach (VinCompany_Location_model _edu in _obj)
                    {
                        CompanyRepository _repo = new CompanyRepository();
                        bool _result = _repo.ManageVinCompanyLocation(_companyid, _edu);
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

        public string UpdateCompanyInformation(int _companyid )
        {
            HttpClient client = new HttpClient();
      
            client.BaseAddress = new Uri(ConstantVincere.apiURL);
            client.DefaultRequestHeaders.Add("x-api-key", ConstantVincere.ApiKEY + " ");
            client.DefaultRequestHeaders.Add("id-token", ConstantVincere.TokedId + " ");

            try
            {
                string _endpoint_per_job = ConstantVincere.GetCompanyEndpoint + _companyid.ToString();

                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint_per_job).Result;


                var _value = "";
                if (_response.IsSuccessStatusCode)
                {
                    _value = _response.Content.ReadAsStringAsync().Result.ToString();                  
                    CompanyRepository _repo = new CompanyRepository();
                    _repo.ManageCompany(_value);

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
