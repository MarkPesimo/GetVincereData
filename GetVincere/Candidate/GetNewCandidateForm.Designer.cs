namespace GetVincere.Candidate
{
    partial class GetNewCandidateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetNewCandidateForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.txtController = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReturnFiels = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXAPIKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFieldToQuery = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.prb = new System.Windows.Forms.ProgressBar();
            this.txtResultCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRecordFound = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.TextBox();
            this.lblProcessPageNo = new System.Windows.Forms.Label();
            this.txtStartAtPage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(165, 298);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(106, 21);
            this.dtpFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "DATE CREATED";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(288, 298);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(106, 21);
            this.dtpTo.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(400, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 51);
            this.button2.TabIndex = 13;
            this.button2.Text = "GET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtController
            // 
            this.txtController.Location = new System.Drawing.Point(164, 37);
            this.txtController.Name = "txtController";
            this.txtController.Size = new System.Drawing.Size(853, 21);
            this.txtController.TabIndex = 15;
            this.txtController.Text = "https://zmgwardhowell.vincere.io/api/v2/candidate/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "API ENDPOINT";
            // 
            // txtReturnFiels
            // 
            this.txtReturnFiels.Location = new System.Drawing.Point(164, 207);
            this.txtReturnFiels.Name = "txtReturnFiels";
            this.txtReturnFiels.Size = new System.Drawing.Size(853, 21);
            this.txtReturnFiels.TabIndex = 17;
            this.txtReturnFiels.Text = "fl=id,first_name, last_name, created_date, last_update; sort= created_date desc";
            this.txtReturnFiels.TextChanged += new System.EventHandler(this.txtReturnFiels_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "RETURN FIELDS";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(165, 343);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(853, 21);
            this.textBox2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "GENERATED URL";
            // 
            // txtIdToken
            // 
            this.txtIdToken.Location = new System.Drawing.Point(164, 88);
            this.txtIdToken.Multiline = true;
            this.txtIdToken.Name = "txtIdToken";
            this.txtIdToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIdToken.Size = new System.Drawing.Size(853, 87);
            this.txtIdToken.TabIndex = 21;
            this.txtIdToken.Text = resources.GetString("txtIdToken.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID TOKEN";
            // 
            // txtXAPIKey
            // 
            this.txtXAPIKey.Location = new System.Drawing.Point(165, 181);
            this.txtXAPIKey.Name = "txtXAPIKey";
            this.txtXAPIKey.Size = new System.Drawing.Size(853, 21);
            this.txtXAPIKey.TabIndex = 23;
            this.txtXAPIKey.Text = "7210a62c-f3b4-42ff-a3d4-4be67c62fc5a\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "X-API-KEY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "CONTROLLER";
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(165, 65);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(853, 21);
            this.txtEndPoint.TabIndex = 25;
            this.txtEndPoint.Text = "search/";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoice.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column12,
            this.Column13,
            this.Column1,
            this.Column3,
            this.Column4});
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 384);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvInvoice.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(1057, 357);
            this.dgvInvoice.TabIndex = 849;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
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
            this.Column4.HeaderText = "cnt";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtFieldToQuery
            // 
            this.txtFieldToQuery.Location = new System.Drawing.Point(165, 234);
            this.txtFieldToQuery.Name = "txtFieldToQuery";
            this.txtFieldToQuery.Size = new System.Drawing.Size(853, 21);
            this.txtFieldToQuery.TabIndex = 851;
            this.txtFieldToQuery.Text = "created_date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 850;
            this.label8.Text = "FIELD TO QUERY";
            // 
            // prb
            // 
            this.prb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prb.Location = new System.Drawing.Point(0, 376);
            this.prb.Name = "prb";
            this.prb.Size = new System.Drawing.Size(1057, 8);
            this.prb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prb.TabIndex = 888;
            // 
            // txtResultCount
            // 
            this.txtResultCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultCount.Location = new System.Drawing.Point(164, 261);
            this.txtResultCount.Name = "txtResultCount";
            this.txtResultCount.Size = new System.Drawing.Size(149, 21);
            this.txtResultCount.TabIndex = 890;
            this.txtResultCount.Text = "100";
            this.txtResultCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 889;
            this.label9.Text = "MAX RESULT PAGE COUNT";
            // 
            // lblRecordFound
            // 
            this.lblRecordFound.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordFound.Location = new System.Drawing.Point(899, 304);
            this.lblRecordFound.Name = "lblRecordFound";
            this.lblRecordFound.ReadOnly = true;
            this.lblRecordFound.Size = new System.Drawing.Size(118, 33);
            this.lblRecordFound.TabIndex = 891;
            this.lblRecordFound.Text = "0";
            this.lblRecordFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(914, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 892;
            this.label10.Text = "Record Found";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(790, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 894;
            this.label11.Text = "Pages";
            // 
            // lblPage
            // 
            this.lblPage.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(775, 304);
            this.lblPage.Name = "lblPage";
            this.lblPage.ReadOnly = true;
            this.lblPage.Size = new System.Drawing.Size(118, 33);
            this.lblPage.TabIndex = 893;
            this.lblPage.Text = "0";
            this.lblPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProcessPageNo
            // 
            this.lblProcessPageNo.AutoSize = true;
            this.lblProcessPageNo.Location = new System.Drawing.Point(642, 324);
            this.lblProcessPageNo.Name = "lblProcessPageNo";
            this.lblProcessPageNo.Size = new System.Drawing.Size(98, 13);
            this.lblProcessPageNo.TabIndex = 895;
            this.lblProcessPageNo.Text = "Process Page # : 0";
            // 
            // txtStartAtPage
            // 
            this.txtStartAtPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartAtPage.Location = new System.Drawing.Point(612, 261);
            this.txtStartAtPage.Name = "txtStartAtPage";
            this.txtStartAtPage.Size = new System.Drawing.Size(149, 21);
            this.txtStartAtPage.TabIndex = 897;
            this.txtStartAtPage.Text = "0";
            this.txtStartAtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(486, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 896;
            this.label12.Text = "START AT RECORD # :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 899;
            this.label13.Text = "AUTHORIZE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(853, 21);
            this.textBox1.TabIndex = 898;
            this.textBox1.Text = "https://id.vincere.io/oauth2/authorize?client_id=5bbaed9b-3ed9-4cb1-a118-8db8c1a2" +
    "06f6&state=STATE&redirect_uri=https%3A%2F%2Fapi.vincere.io%2Foauth-receiver.html" +
    "&response_type=code";
            // 
            // GetNewCandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 741);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtStartAtPage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblProcessPageNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRecordFound);
            this.Controls.Add(this.txtResultCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.prb);
            this.Controls.Add(this.txtFieldToQuery);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.txtEndPoint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtXAPIKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReturnFiels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtController);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFrom);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GetNewCandidateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get New Candidate";
            this.Load += new System.EventHandler(this.GetNewCandidateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtController;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReturnFiels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXAPIKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndPoint;
        internal System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.TextBox txtFieldToQuery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar prb;
        private System.Windows.Forms.TextBox txtResultCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lblRecordFound;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lblPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblProcessPageNo;
        private System.Windows.Forms.TextBox txtStartAtPage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
    }
}