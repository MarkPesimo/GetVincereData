namespace GetVincere
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.txtIdToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(514, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Token";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(728, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "GET ALL CANDIDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(28, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "CANDIDATE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(481, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "JOB ORDER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button4.Location = new System.Drawing.Point(728, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 51);
            this.button4.TabIndex = 11;
            this.button4.Text = "GET NEWLY CREATED CANDIDATE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(912, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 51);
            this.button5.TabIndex = 12;
            this.button5.Text = "GET NEWLY UPDATED CANDIDATE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(728, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 51);
            this.button3.TabIndex = 13;
            this.button3.Text = "UPDATE CANDIDATE INFORMATION";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button6.Location = new System.Drawing.Point(23, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 51);
            this.button6.TabIndex = 14;
            this.button6.Text = "Fetch candidate information";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.Location = new System.Drawing.Point(485, 60);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(196, 51);
            this.button7.TabIndex = 15;
            this.button7.Text = "Fetch Job Order information";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(254, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 43);
            this.label2.TabIndex = 16;
            this.label2.Text = "COMPANY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.BurlyWood;
            this.button8.Location = new System.Drawing.Point(254, 60);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(196, 51);
            this.button8.TabIndex = 17;
            this.button8.Text = "Fetch company information\r\n";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtIdToken
            // 
            this.txtIdToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdToken.Location = new System.Drawing.Point(12, 25);
            this.txtIdToken.Multiline = true;
            this.txtIdToken.Name = "txtIdToken";
            this.txtIdToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIdToken.Size = new System.Drawing.Size(680, 87);
            this.txtIdToken.TabIndex = 913;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 912;
            this.label4.Text = "ID-TOKEN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 129);
            this.panel1.TabIndex = 914;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 298);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIdToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vincere data miner (ver 1.0.0.10)";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtIdToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}