namespace GetVincere.Candidate
{
    partial class UpdateCandidateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCandidateForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.prb = new System.Windows.Forms.ProgressBar();
            this.dgvCandidate = new System.Windows.Forms.DataGridView();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXAPIKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtController = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 930;
            this.label13.Text = "AUTHORIZE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(853, 21);
            this.textBox1.TabIndex = 929;
            this.textBox1.Text = "https://id.vincere.io/oauth2/authorize?client_id=5bbaed9b-3ed9-4cb1-a118-8db8c1a2" +
    "06f6&state=STATE&redirect_uri=https%3A%2F%2Fapi.vincere.io%2Foauth-receiver.html" +
    "&response_type=code";
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.ForeColor = System.Drawing.Color.Navy;
            this.lblProcessName.Location = new System.Drawing.Point(695, 283);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(93, 13);
            this.lblProcessName.TabIndex = 926;
            this.lblProcessName.Text = "Candidate Name :";
            this.lblProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prb
            // 
            this.prb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prb.Location = new System.Drawing.Point(0, 306);
            this.prb.Name = "prb";
            this.prb.Size = new System.Drawing.Size(1032, 8);
            this.prb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prb.TabIndex = 919;
            // 
            // dgvCandidate
            // 
            this.dgvCandidate.AllowUserToAddRows = false;
            this.dgvCandidate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCandidate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCandidate.BackgroundColor = System.Drawing.Color.White;
            this.dgvCandidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCandidate.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column12,
            this.Column13,
            this.Column1,
            this.Column3,
            this.Column4});
            this.dgvCandidate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCandidate.Location = new System.Drawing.Point(0, 314);
            this.dgvCandidate.Name = "dgvCandidate";
            this.dgvCandidate.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidate.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCandidate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvCandidate.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCandidate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidate.Size = new System.Drawing.Size(1032, 386);
            this.dgvCandidate.TabIndex = 916;
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(165, 59);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.ReadOnly = true;
            this.txtEndPoint.Size = new System.Drawing.Size(853, 21);
            this.txtEndPoint.TabIndex = 915;
            this.txtEndPoint.Text = "candidate/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 914;
            this.label7.Text = "CONTROLLER";
            // 
            // txtXAPIKey
            // 
            this.txtXAPIKey.Location = new System.Drawing.Point(165, 175);
            this.txtXAPIKey.Name = "txtXAPIKey";
            this.txtXAPIKey.ReadOnly = true;
            this.txtXAPIKey.Size = new System.Drawing.Size(853, 21);
            this.txtXAPIKey.TabIndex = 913;
            this.txtXAPIKey.Text = "7210a62c-f3b4-42ff-a3d4-4be67c62fc5a\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 912;
            this.label6.Text = "X-API-KEY";
            // 
            // txtIdToken
            // 
            this.txtIdToken.Location = new System.Drawing.Point(164, 82);
            this.txtIdToken.Multiline = true;
            this.txtIdToken.Name = "txtIdToken";
            this.txtIdToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIdToken.Size = new System.Drawing.Size(853, 87);
            this.txtIdToken.TabIndex = 911;
            this.txtIdToken.Text = resources.GetString("txtIdToken.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 910;
            this.label4.Text = "ID TOKEN";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(165, 337);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(853, 21);
            this.textBox2.TabIndex = 909;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 908;
            this.label3.Text = "GENERATED URL";
            // 
            // txtController
            // 
            this.txtController.Location = new System.Drawing.Point(164, 31);
            this.txtController.Name = "txtController";
            this.txtController.ReadOnly = true;
            this.txtController.Size = new System.Drawing.Size(853, 21);
            this.txtController.TabIndex = 905;
            this.txtController.Text = "https://zmgwardhowell.vincere.io/api/v2/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 904;
            this.label5.Text = "API ENDPOINT";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(164, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 51);
            this.button2.TabIndex = 903;
            this.button2.Text = "GET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(288, 202);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(106, 21);
            this.dtpTo.TabIndex = 933;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 932;
            this.label1.Text = "DATE CREATED";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(165, 202);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(106, 21);
            this.dtpFrom.TabIndex = 931;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(849, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 51);
            this.button1.TabIndex = 934;
            this.button1.Text = "PROCESS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(925, 208);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(92, 13);
            this.lblTotalRecords.TabIndex = 935;
            this.lblTotalRecords.Text = "No. of records : 0";
            this.lblTotalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column12
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column12.HeaderText = "Firstname";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 200;
            // 
            // Column13
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column13.HeaderText = "Lastname";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 250;
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Date encoded";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column3.HeaderText = "last updated";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // UpdateCandidateFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 700);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.prb);
            this.Controls.Add(this.dgvCandidate);
            this.Controls.Add(this.txtEndPoint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtXAPIKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtController);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateCandidateFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Candidate information";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.ProgressBar prb;
        internal System.Windows.Forms.DataGridView dgvCandidate;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtXAPIKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtController;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}