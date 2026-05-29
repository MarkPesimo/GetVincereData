using GetVincere.Candidate;
using GetVincere.Company;
using GetVincere.JobOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetVincere
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetNewCandidateForm _form = new GetNewCandidateForm();
            _form.BringToFront();
            _form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateCandidateForm _form = new UpdateCandidateForm();
            _form.BringToFront();
            _form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ConstantVincere.TokedId == "")
            {
                MessageBox.Show("Kindly set Token-Id first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UpdateCandidateSubInformationForm _form = new UpdateCandidateSubInformationForm();
            _form.BringToFront();
            _form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ConstantVincere.TokedId == "")
            {
                MessageBox.Show("Kindly set Token-Id first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UpdateJobSubInformationForm _form = new UpdateJobSubInformationForm();
            _form.BringToFront();
            _form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ConstantVincere.TokedId == "")
            {
                MessageBox.Show("Kindly set Token-Id first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UpdateCompanyInformationForm _form = new UpdateCompanyInformationForm();
            _form.BringToFront();
            _form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdToken.Text == "")
            {
                MessageBox.Show("Blank Token-Id is set. pleace check.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdToken.Focus();
                return;
            }

            ConstantVincere.TokedId = txtIdToken.Text;
            MessageBox.Show("Token-Id is successfully set.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
