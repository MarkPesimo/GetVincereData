namespace GetVincere.JobOrder
{
    partial class UpdateJobSubInformationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateJobSubInformationForm));
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.dgvCandidate = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXAPIKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblProcessPageNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDateCreated = new System.Windows.Forms.CheckBox();
            this.chkDateUpdated = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimeFinished = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRecordFound = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkPlacement = new System.Windows.Forms.CheckBox();
            this.chkApplication = new System.Windows.Forms.CheckBox();
            this.chkJobDetails = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.prb = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1050, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 930;
            this.label13.Text = "AUTHORIZE";
            this.label13.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1131, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(853, 21);
            this.textBox1.TabIndex = 929;
            this.textBox1.Text = "https://id.vincere.io/oauth2/authorize?client_id=5bbaed9b-3ed9-4cb1-a118-8db8c1a2" +
    "06f6&state=STATE&redirect_uri=https%3A%2F%2Fapi.vincere.io%2Foauth-receiver.html" +
    "&response_type=code";
            this.textBox1.Visible = false;
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.ForeColor = System.Drawing.Color.Navy;
            this.lblProcessName.Location = new System.Drawing.Point(379, 89);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(127, 13);
            this.lblProcessName.TabIndex = 926;
            this.lblProcessName.Text = "Processing Job Order #: ";
            this.lblProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Column5,
            this.Column4});
            this.dgvCandidate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCandidate.Location = new System.Drawing.Point(0, 35);
            this.dgvCandidate.Name = "dgvCandidate";
            this.dgvCandidate.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidate.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCandidate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvCandidate.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCandidate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidate.Size = new System.Drawing.Size(1032, 341);
            this.dgvCandidate.TabIndex = 916;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column12
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column12.HeaderText = "Company";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 200;
            // 
            // Column13
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column13.HeaderText = "Job Title";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 200;
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Date created";
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
            // Column5
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column5.HeaderText = "Basis";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column4
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1042, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 914;
            this.label7.Text = "CONTROLLER";
            this.label7.Visible = false;
            // 
            // txtXAPIKey
            // 
            this.txtXAPIKey.Location = new System.Drawing.Point(1131, 102);
            this.txtXAPIKey.Name = "txtXAPIKey";
            this.txtXAPIKey.ReadOnly = true;
            this.txtXAPIKey.Size = new System.Drawing.Size(853, 21);
            this.txtXAPIKey.TabIndex = 913;
            this.txtXAPIKey.Text = "7210a62c-f3b4-42ff-a3d4-4be67c62fc5a\r\n";
            this.txtXAPIKey.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1059, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 912;
            this.label6.Text = "X-API-KEY";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(978, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 910;
            this.label4.Text = "ID TOKEN";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1037, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 904;
            this.label5.Text = "API ENDPOINT";
            this.label5.Visible = false;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGet.ForeColor = System.Drawing.Color.Black;
            this.btnGet.Location = new System.Drawing.Point(364, 24);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(169, 33);
            this.btnGet.TabIndex = 903;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(252, 35);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(106, 21);
            this.dtpTo.TabIndex = 933;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 932;
            this.label1.Text = "DATE CREATED";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(129, 35);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(106, 21);
            this.dtpFrom.TabIndex = 931;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(129, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 33);
            this.button1.TabIndex = 934;
            this.button1.Text = "PROCESS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProcessPageNo
            // 
            this.lblProcessPageNo.AutoSize = true;
            this.lblProcessPageNo.Location = new System.Drawing.Point(556, 44);
            this.lblProcessPageNo.Name = "lblProcessPageNo";
            this.lblProcessPageNo.Size = new System.Drawing.Size(98, 13);
            this.lblProcessPageNo.TabIndex = 935;
            this.lblProcessPageNo.Text = "Process Page # : 0";
            this.lblProcessPageNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 938;
            this.label3.Text = "DATE BASED :";
            // 
            // chkDateCreated
            // 
            this.chkDateCreated.AutoSize = true;
            this.chkDateCreated.Location = new System.Drawing.Point(129, 12);
            this.chkDateCreated.Name = "chkDateCreated";
            this.chkDateCreated.Size = new System.Drawing.Size(91, 17);
            this.chkDateCreated.TabIndex = 939;
            this.chkDateCreated.Text = "Date Created";
            this.chkDateCreated.UseVisualStyleBackColor = true;
            // 
            // chkDateUpdated
            // 
            this.chkDateUpdated.AutoSize = true;
            this.chkDateUpdated.Location = new System.Drawing.Point(252, 12);
            this.chkDateUpdated.Name = "chkDateUpdated";
            this.chkDateUpdated.Size = new System.Drawing.Size(93, 17);
            this.chkDateUpdated.TabIndex = 940;
            this.chkDateUpdated.Text = "Date Updated";
            this.chkDateUpdated.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTimeFinished);
            this.panel1.Controls.Add(this.lblTimeStart);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblPage);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblRecordFound);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnGet);
            this.panel1.Controls.Add(this.lblProcessPageNo);
            this.panel1.Controls.Add(this.chkDateUpdated);
            this.panel1.Controls.Add(this.chkDateCreated);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtXAPIKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 72);
            this.panel1.TabIndex = 941;
            // 
            // lblTimeFinished
            // 
            this.lblTimeFinished.AutoSize = true;
            this.lblTimeFinished.Location = new System.Drawing.Point(556, 26);
            this.lblTimeFinished.Name = "lblTimeFinished";
            this.lblTimeFinished.Size = new System.Drawing.Size(76, 13);
            this.lblTimeFinished.TabIndex = 948;
            this.lblTimeFinished.Text = "Time Finshed :";
            this.lblTimeFinished.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Location = new System.Drawing.Point(556, 7);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(63, 13);
            this.lblTimeStart.TabIndex = 947;
            this.lblTimeStart.Text = "Time Start :";
            this.lblTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(790, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 946;
            this.label11.Text = "Pages";
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPage.Enabled = false;
            this.lblPage.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblPage.Location = new System.Drawing.Point(775, 23);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(118, 33);
            this.lblPage.TabIndex = 945;
            this.lblPage.Text = "0";
            this.lblPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(914, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 944;
            this.label12.Text = "Record Found";
            // 
            // lblRecordFound
            // 
            this.lblRecordFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordFound.Enabled = false;
            this.lblRecordFound.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordFound.ForeColor = System.Drawing.Color.Red;
            this.lblRecordFound.Location = new System.Drawing.Point(899, 23);
            this.lblRecordFound.Name = "lblRecordFound";
            this.lblRecordFound.Size = new System.Drawing.Size(118, 33);
            this.lblRecordFound.TabIndex = 943;
            this.lblRecordFound.Text = "0";
            this.lblRecordFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1031, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 941;
            this.label10.Text = "RETURN FIELDS";
            this.label10.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkPlacement);
            this.panel3.Controls.Add(this.chkApplication);
            this.panel3.Controls.Add(this.lblProcessName);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.chkJobDetails);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 116);
            this.panel3.TabIndex = 943;
            // 
            // chkPlacement
            // 
            this.chkPlacement.AutoSize = true;
            this.chkPlacement.Location = new System.Drawing.Point(382, 33);
            this.chkPlacement.Name = "chkPlacement";
            this.chkPlacement.Size = new System.Drawing.Size(75, 17);
            this.chkPlacement.TabIndex = 946;
            this.chkPlacement.Text = "Placement";
            this.chkPlacement.UseVisualStyleBackColor = true;
            // 
            // chkApplication
            // 
            this.chkApplication.AutoSize = true;
            this.chkApplication.Location = new System.Drawing.Point(130, 56);
            this.chkApplication.Name = "chkApplication";
            this.chkApplication.Size = new System.Drawing.Size(98, 17);
            this.chkApplication.TabIndex = 945;
            this.chkApplication.Text = "Job Application";
            this.chkApplication.UseVisualStyleBackColor = true;
            // 
            // chkJobDetails
            // 
            this.chkJobDetails.AutoSize = true;
            this.chkJobDetails.Checked = true;
            this.chkJobDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJobDetails.Enabled = false;
            this.chkJobDetails.Location = new System.Drawing.Point(130, 33);
            this.chkJobDetails.Name = "chkJobDetails";
            this.chkJobDetails.Size = new System.Drawing.Size(78, 17);
            this.chkJobDetails.TabIndex = 944;
            this.chkJobDetails.Text = "Job Details";
            this.chkJobDetails.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 27);
            this.panel2.TabIndex = 943;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 27);
            this.label8.TabIndex = 937;
            this.label8.Text = "Select Action";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvCandidate);
            this.panel4.Controls.Add(this.prb);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1032, 376);
            this.panel4.TabIndex = 944;
            // 
            // prb
            // 
            this.prb.Dock = System.Windows.Forms.DockStyle.Top;
            this.prb.Location = new System.Drawing.Point(0, 27);
            this.prb.Name = "prb";
            this.prb.Size = new System.Drawing.Size(1032, 8);
            this.prb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prb.TabIndex = 920;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1032, 27);
            this.panel5.TabIndex = 946;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 27);
            this.label9.TabIndex = 938;
            this.label9.Text = "Result/Details";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateJobSubInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 564);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "UpdateJobSubInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Job Inforamtion";
            this.Load += new System.EventHandler(this.UpdateCandidateSubInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblProcessName;
        internal System.Windows.Forms.DataGridView dgvCandidate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtXAPIKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblProcessPageNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDateCreated;
        private System.Windows.Forms.CheckBox chkDateUpdated;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkPlacement;
        private System.Windows.Forms.CheckBox chkApplication;
        private System.Windows.Forms.CheckBox chkJobDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar prb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lblPage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lblRecordFound;
        private System.Windows.Forms.Label lblTimeFinished;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}