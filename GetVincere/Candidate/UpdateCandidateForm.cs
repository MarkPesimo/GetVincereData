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
    public partial class UpdateCandidateForm : Form
    {
        public UpdateCandidateForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CandidateRepository _repo = new CandidateRepository();
            dgvCandidate.RowCount = 0;
            int _n = 0;
            prb.Value = 0;
            try
            {
                List<Candidate_model.CandidateData_model> _data = _repo.GetCandidateByDateCreated(dtpFrom.Value.Date, dtpTo.Value.Date);
                prb.Maximum = _data.Count();
                lblTotalRecords.Text = "No. of records : " + _data.Count().ToString();

                foreach (Candidate_model.CandidateData_model _item in _data)
                {
                    _n = dgvCandidate.Rows.Add();
                    prb.Value = prb.Value + 1;
                    

                    dgvCandidate.Rows[_n].Cells[0].Value = _item.Id.ToString();
                    dgvCandidate.Rows[_n].Cells[1].Value = _item.Fistname;
                    dgvCandidate.Rows[_n].Cells[2].Value = _item.Lastname;
                    dgvCandidate.Rows[_n].Cells[3].Value = _item.DateCreated.ToString();
                    dgvCandidate.Rows[_n].Cells[4].Value = _item.LastUpdated.ToString();                    
                }
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

            try
            {
                HttpClient client = new HttpClient();
                string _endpoint = txtEndPoint.Text;

                client.BaseAddress = new Uri(txtController.Text);
                client.DefaultRequestHeaders.Add("x-api-key", txtXAPIKey.Text + " ");
                client.DefaultRequestHeaders.Add("id-token", txtIdToken.Text + " ");

                prb.Maximum = dgvCandidate.Rows.Count;
                prb.Value = 0;
                foreach (DataGridViewRow row in dgvCandidate.Rows)
                {
                    prb.Value = prb.Value + 1;

                    string _candidat_id = row.Cells[0].Value.ToString();
                    string _endpoint_per_candidate = _endpoint+ _candidat_id.ToString();

                    lblProcessName.Text = row.Cells[2].Value.ToString() + ", " + row.Cells[1].Value.ToString();

                    //More code here
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

                        row.Cells[5].Value = "Get";
                    }
                    else {
                        if (_response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        {
                            row.Cells[5].Value = "Anauthorized";
                            return;
                        }
                        else
                        {
                            row.Cells[5].Value = _response.RequestMessage.ToString();                            
                        }

                        
                    }
                }

                MessageBox.Show("Candidate information successfully saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
