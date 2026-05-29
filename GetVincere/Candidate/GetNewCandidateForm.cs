using GetVincere.Model;
using GetVincere.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GetVincere.Candidate
{
    public partial class GetNewCandidateForm : Form
    {
        public GetNewCandidateForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int _max_record_return = int.Parse(txtResultCount.Text);


            try
            {
                HttpClient client = new HttpClient();
                string _endpoint = txtEndPoint.Text;
                
                client.BaseAddress = new Uri(txtController.Text);
                client.DefaultRequestHeaders.Add("x-api-key", txtXAPIKey.Text + " ");
                client.DefaultRequestHeaders.Add("id-token", txtIdToken.Text + " ");

                string _date_range = "[" + dtpFrom.Value.Year.ToString() + "-" + dtpFrom.Value.Month.ToString() + "-" + dtpFrom.Value.Day + "T00:00:00.000Z" + " TO " +
                dtpTo.Value.Year.ToString() + "-" + dtpTo.Value.Month.ToString() + "-" + dtpTo.Value.Day + "T23:59:59.999Z]%23&";


 
                _endpoint = _endpoint + txtReturnFiels.Text + "?q=" + txtFieldToQuery.Text + ":" + _date_range;
               
                HttpResponseMessage _response = new HttpResponseMessage();
                _response = client.GetAsync(_endpoint).Result;

                dgvInvoice.RowCount = 0;
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

                    int _page_cnt_process = 1;

                    if (txtStartAtPage.Text != "1") { _page_cnt_process = int.Parse(txtStartAtPage.Text); }

                    int _limit_cnt =  int.Parse(txtResultCount.Text);


                    while (_page_cnt_process < int.Parse(lblRecordFound.Text))
                    {

                        if (_limit_cnt > int.Parse(lblRecordFound.Text))
                        {
                            _limit_cnt = int.Parse(lblRecordFound.Text);
                        }
                        lblProcessPageNo.Text = "Process counter : " + _limit_cnt.ToString();

                        //string _data_limit = "[" + dtpFrom.Value.Year.ToString() + "-" + dtpFrom.Value.Month.ToString() + "-" + dtpFrom.Value.Day + "T10:20:35.327Z" + " TO " +
                        //    dtpTo.Value.Year.ToString() + "-" + dtpTo.Value.Month.ToString() + "-" + dtpTo.Value.Day + "T23:59:59.000Z]%23" +
                        //    "&start= " + _page_cnt_process.ToString() +
                        //    "&limit= " + _limit_cnt.ToString() + "";

                        string _data_limit = "[" + dtpFrom.Value.Year.ToString() + "-" + dtpFrom.Value.Month.ToString() + "-" + dtpFrom.Value.Day + "T00:00:00.000Z" + " TO " +
                            dtpTo.Value.Year.ToString() + "-" + dtpTo.Value.Month.ToString() + "-" + dtpTo.Value.Day + "T23:23:59.999Z]%23" +
                            "&start= " + _page_cnt_process.ToString() +
                            "&limit= " + txtResultCount.Text + "";

                        string _endpoint_per_page = txtEndPoint.Text + txtReturnFiels.Text +
                            "?q=" + txtFieldToQuery.Text + ":" + _data_limit;

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
                                //prb.Value = prb.Value + 1;

                                InsertRow(n, _item, _row_cnt);

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

                        prb.Value = prb.Value + 1;
                    }

                    MessageBox.Show("Candidate created on the selected date range is successfully fetched and saved on the Database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvInvoice.Refresh();
                }
                else {
                    if (_response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Request Anauthorized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { 
                        MessageBox.Show(_response.RequestMessage.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void InsertRow(int _n, Candidate_model.Search_model.item_model _item, int _cnt)
        {
            try
            {
                _n = dgvInvoice.Rows.Add();
                dgvInvoice.Rows[_n].Cells[0].Value = _item.id.ToString();
                dgvInvoice.Rows[_n].Cells[1].Value = _item.first_name;
                dgvInvoice.Rows[_n].Cells[2].Value = _item.last_name;
                dgvInvoice.Rows[_n].Cells[3].Value = _item.created_date.ToString();
                dgvInvoice.Rows[_n].Cells[4].Value = _item.last_update.ToString();
                dgvInvoice.Rows[_n].Cells[5].Value = _cnt.ToString();

                CandidateRepository _repo = new CandidateRepository();
                Candidate_model.CandidateData_model _model = new Candidate_model.CandidateData_model
                {
                    Id = _item.id,
                    Lastname = _item.last_name,
                    Fistname = _item.first_name,
                    DateCreated = _item.created_date,
                    LastUpdated = _item.last_update
                };
                _repo.ManageCandidate(_model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtReturnFiels_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetNewCandidateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
