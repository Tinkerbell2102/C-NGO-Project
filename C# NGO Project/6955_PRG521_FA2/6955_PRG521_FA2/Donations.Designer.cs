
namespace _6955_PRG521_FA2
{
    partial class Donations
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
            this.pnlpiMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDonationHist = new System.Windows.Forms.TabPage();
            this.dtDonorFormHist = new System.Windows.Forms.DateTimePicker();
            this.btnDonationHist = new System.Windows.Forms.Button();
            this.tbDonationRequest = new System.Windows.Forms.TabPage();
            this.dtDonationEventDate = new System.Windows.Forms.DateTimePicker();
            this.btnDonationSubmit = new System.Windows.Forms.Button();
            this.txtDonationType = new System.Windows.Forms.TextBox();
            this.cmbNGOEventName = new System.Windows.Forms.ComboBox();
            this.nudDonationAmmount = new System.Windows.Forms.NumericUpDown();
            this.cmbNgoName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNDoName = new System.Windows.Forms.Label();
            this.lblLB = new System.Windows.Forms.Label();
            this.btnpiClose = new System.Windows.Forms.Button();
            this.btnpiLogout = new System.Windows.Forms.Button();
            this.pnlPI = new System.Windows.Forms.Panel();
            this.lblDonorDetails = new System.Windows.Forms.Label();
            this.lblDonation = new System.Windows.Forms.Label();
            this.rtxtDonationHist = new System.Windows.Forms.RichTextBox();
            this.pnlpiMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbDonationHist.SuspendLayout();
            this.tbDonationRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonationAmmount)).BeginInit();
            this.pnlPI.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlpiMain
            // 
            this.pnlpiMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlpiMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpiMain.Controls.Add(this.tabControl1);
            this.pnlpiMain.Controls.Add(this.lblLB);
            this.pnlpiMain.Controls.Add(this.btnpiClose);
            this.pnlpiMain.Controls.Add(this.btnpiLogout);
            this.pnlpiMain.Controls.Add(this.pnlPI);
            this.pnlpiMain.Location = new System.Drawing.Point(12, 12);
            this.pnlpiMain.Name = "pnlpiMain";
            this.pnlpiMain.Size = new System.Drawing.Size(380, 391);
            this.pnlpiMain.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDonationHist);
            this.tabControl1.Controls.Add(this.tbDonationRequest);
            this.tabControl1.Location = new System.Drawing.Point(12, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 253);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbDonationHist
            // 
            this.tbDonationHist.Controls.Add(this.rtxtDonationHist);
            this.tbDonationHist.Controls.Add(this.dtDonorFormHist);
            this.tbDonationHist.Controls.Add(this.btnDonationHist);
            this.tbDonationHist.Location = new System.Drawing.Point(4, 24);
            this.tbDonationHist.Name = "tbDonationHist";
            this.tbDonationHist.Padding = new System.Windows.Forms.Padding(3);
            this.tbDonationHist.Size = new System.Drawing.Size(347, 225);
            this.tbDonationHist.TabIndex = 1;
            this.tbDonationHist.Text = "Donation History";
            this.tbDonationHist.UseVisualStyleBackColor = true;
            // 
            // dtDonorFormHist
            // 
            this.dtDonorFormHist.CustomFormat = "\"yyyy-MM-dd\"";
            this.dtDonorFormHist.Location = new System.Drawing.Point(3, 3);
            this.dtDonorFormHist.Name = "dtDonorFormHist";
            this.dtDonorFormHist.Size = new System.Drawing.Size(200, 23);
            this.dtDonorFormHist.TabIndex = 2;
            this.dtDonorFormHist.Value = new System.DateTime(2021, 4, 18, 20, 14, 54, 0);
            // 
            // btnDonationHist
            // 
            this.btnDonationHist.Location = new System.Drawing.Point(91, 199);
            this.btnDonationHist.Name = "btnDonationHist";
            this.btnDonationHist.Size = new System.Drawing.Size(174, 23);
            this.btnDonationHist.TabIndex = 0;
            this.btnDonationHist.Text = "Get Donation History";
            this.btnDonationHist.UseVisualStyleBackColor = true;
            this.btnDonationHist.Click += new System.EventHandler(this.btnDonationHist_Click);
            // 
            // tbDonationRequest
            // 
            this.tbDonationRequest.Controls.Add(this.dtDonationEventDate);
            this.tbDonationRequest.Controls.Add(this.btnDonationSubmit);
            this.tbDonationRequest.Controls.Add(this.txtDonationType);
            this.tbDonationRequest.Controls.Add(this.cmbNGOEventName);
            this.tbDonationRequest.Controls.Add(this.nudDonationAmmount);
            this.tbDonationRequest.Controls.Add(this.cmbNgoName);
            this.tbDonationRequest.Controls.Add(this.label5);
            this.tbDonationRequest.Controls.Add(this.label4);
            this.tbDonationRequest.Controls.Add(this.label3);
            this.tbDonationRequest.Controls.Add(this.label2);
            this.tbDonationRequest.Controls.Add(this.label1);
            this.tbDonationRequest.Controls.Add(this.lblNDoName);
            this.tbDonationRequest.Location = new System.Drawing.Point(4, 24);
            this.tbDonationRequest.Name = "tbDonationRequest";
            this.tbDonationRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tbDonationRequest.Size = new System.Drawing.Size(347, 225);
            this.tbDonationRequest.TabIndex = 0;
            this.tbDonationRequest.Text = "New Donation Request";
            this.tbDonationRequest.UseVisualStyleBackColor = true;
            // 
            // dtDonationEventDate
            // 
            this.dtDonationEventDate.CustomFormat = "\"yyyy-MM-dd\"";
            this.dtDonationEventDate.Location = new System.Drawing.Point(106, 87);
            this.dtDonationEventDate.Name = "dtDonationEventDate";
            this.dtDonationEventDate.Size = new System.Drawing.Size(200, 23);
            this.dtDonationEventDate.TabIndex = 28;
            this.dtDonationEventDate.Value = new System.DateTime(2021, 4, 18, 20, 14, 54, 0);
            // 
            // btnDonationSubmit
            // 
            this.btnDonationSubmit.Location = new System.Drawing.Point(223, 199);
            this.btnDonationSubmit.Name = "btnDonationSubmit";
            this.btnDonationSubmit.Size = new System.Drawing.Size(109, 23);
            this.btnDonationSubmit.TabIndex = 27;
            this.btnDonationSubmit.Text = "Submit Request";
            this.btnDonationSubmit.UseVisualStyleBackColor = true;
            this.btnDonationSubmit.Click += new System.EventHandler(this.btnDonationSubmit_Click);
            // 
            // txtDonationType
            // 
            this.txtDonationType.Location = new System.Drawing.Point(106, 119);
            this.txtDonationType.Name = "txtDonationType";
            this.txtDonationType.Size = new System.Drawing.Size(226, 23);
            this.txtDonationType.TabIndex = 25;
            // 
            // cmbNGOEventName
            // 
            this.cmbNGOEventName.FormattingEnabled = true;
            this.cmbNGOEventName.Location = new System.Drawing.Point(106, 53);
            this.cmbNGOEventName.Name = "cmbNGOEventName";
            this.cmbNGOEventName.Size = new System.Drawing.Size(226, 23);
            this.cmbNGOEventName.TabIndex = 24;
            this.cmbNGOEventName.SelectedIndexChanged += new System.EventHandler(this.cmbNGOEventName_SelectedIndexChanged);
            // 
            // nudDonationAmmount
            // 
            this.nudDonationAmmount.Location = new System.Drawing.Point(137, 156);
            this.nudDonationAmmount.Name = "nudDonationAmmount";
            this.nudDonationAmmount.Size = new System.Drawing.Size(75, 23);
            this.nudDonationAmmount.TabIndex = 23;
            // 
            // cmbNgoName
            // 
            this.cmbNgoName.FormattingEnabled = true;
            this.cmbNgoName.Items.AddRange(new object[] {
            "GothamBikes",
            "Dads in Need",
            "Greenpeace",
            "Doctors Without Borders",
            "World Food Programme",
            "Action Against Hunger",
            "Autism-Europe",
            "World Wide Fund for Nature"});
            this.cmbNgoName.Location = new System.Drawing.Point(106, 16);
            this.cmbNgoName.Name = "cmbNgoName";
            this.cmbNgoName.Size = new System.Drawing.Size(226, 23);
            this.cmbNgoName.TabIndex = 22;
            this.cmbNgoName.SelectedIndexChanged += new System.EventHandler(this.cmbNgoName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Donation Ammount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Donation Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Event Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "NGO Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "NGO Name";
            // 
            // lblNDoName
            // 
            this.lblNDoName.AutoSize = true;
            this.lblNDoName.Location = new System.Drawing.Point(-89, 4);
            this.lblNDoName.Name = "lblNDoName";
            this.lblNDoName.Size = new System.Drawing.Size(0, 15);
            this.lblNDoName.TabIndex = 16;
            this.lblNDoName.Visible = false;
            // 
            // lblLB
            // 
            this.lblLB.AutoSize = true;
            this.lblLB.Location = new System.Drawing.Point(307, 375);
            this.lblLB.Name = "lblLB";
            this.lblLB.Size = new System.Drawing.Size(72, 15);
            this.lblLB.TabIndex = 6;
            this.lblLB.Text = "LaikinB 6955";
            // 
            // btnpiClose
            // 
            this.btnpiClose.Location = new System.Drawing.Point(93, 358);
            this.btnpiClose.Name = "btnpiClose";
            this.btnpiClose.Size = new System.Drawing.Size(75, 23);
            this.btnpiClose.TabIndex = 3;
            this.btnpiClose.Text = "Exit";
            this.btnpiClose.UseVisualStyleBackColor = true;
            this.btnpiClose.Click += new System.EventHandler(this.btnpiClose_Click);
            // 
            // btnpiLogout
            // 
            this.btnpiLogout.Location = new System.Drawing.Point(12, 358);
            this.btnpiLogout.Name = "btnpiLogout";
            this.btnpiLogout.Size = new System.Drawing.Size(75, 23);
            this.btnpiLogout.TabIndex = 2;
            this.btnpiLogout.Text = "Logout";
            this.btnpiLogout.UseVisualStyleBackColor = true;
            this.btnpiLogout.Click += new System.EventHandler(this.btnpiLogout_Click);
            // 
            // pnlPI
            // 
            this.pnlPI.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPI.Controls.Add(this.lblDonorDetails);
            this.pnlPI.Controls.Add(this.lblDonation);
            this.pnlPI.Location = new System.Drawing.Point(12, 11);
            this.pnlPI.Name = "pnlPI";
            this.pnlPI.Size = new System.Drawing.Size(355, 82);
            this.pnlPI.TabIndex = 0;
            // 
            // lblDonorDetails
            // 
            this.lblDonorDetails.AutoSize = true;
            this.lblDonorDetails.ForeColor = System.Drawing.Color.Red;
            this.lblDonorDetails.Location = new System.Drawing.Point(162, 8);
            this.lblDonorDetails.Name = "lblDonorDetails";
            this.lblDonorDetails.Size = new System.Drawing.Size(78, 15);
            this.lblDonorDetails.TabIndex = 1;
            this.lblDonorDetails.Text = "Donor Details";
            // 
            // lblDonation
            // 
            this.lblDonation.AutoSize = true;
            this.lblDonation.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDonation.Location = new System.Drawing.Point(6, 22);
            this.lblDonation.Name = "lblDonation";
            this.lblDonation.Size = new System.Drawing.Size(149, 37);
            this.lblDonation.TabIndex = 0;
            this.lblDonation.Text = "Donations";
            // 
            // rtxtDonationHist
            // 
            this.rtxtDonationHist.Location = new System.Drawing.Point(3, 33);
            this.rtxtDonationHist.Name = "rtxtDonationHist";
            this.rtxtDonationHist.ReadOnly = true;
            this.rtxtDonationHist.Size = new System.Drawing.Size(340, 160);
            this.rtxtDonationHist.TabIndex = 3;
            this.rtxtDonationHist.Text = "View Previous Event Details";
            // 
            // Donations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(401, 415);
            this.Controls.Add(this.pnlpiMain);
            this.Name = "Donations";
            this.Text = "Donation";
            this.Load += new System.EventHandler(this.Donations_Load);
            this.pnlpiMain.ResumeLayout(false);
            this.pnlpiMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbDonationHist.ResumeLayout(false);
            this.tbDonationRequest.ResumeLayout(false);
            this.tbDonationRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonationAmmount)).EndInit();
            this.pnlPI.ResumeLayout(false);
            this.pnlPI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlpiMain;
        private System.Windows.Forms.Label lblLB;
        private System.Windows.Forms.Button btnpiClose;
        private System.Windows.Forms.Button btnpiLogout;
        private System.Windows.Forms.Panel pnlPI;
        private System.Windows.Forms.Label lblDonation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDonationRequest;
        private System.Windows.Forms.Label lblNDoName;
        private System.Windows.Forms.TabPage tbDonationHist;
        private System.Windows.Forms.Label lblDonorDetails;
        private System.Windows.Forms.TextBox txtDonationType;
        private System.Windows.Forms.ComboBox cmbNGOEventName;
        private System.Windows.Forms.NumericUpDown nudDonationAmmount;
        private System.Windows.Forms.ComboBox cmbNgoName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDonationHist;
        private System.Windows.Forms.Button btnDonationSubmit;
        private System.Windows.Forms.DateTimePicker dtDonorFormHist;
        private System.Windows.Forms.DateTimePicker dtDonationEventDate;
        private System.Windows.Forms.RichTextBox rtxtDonationHist;
    }
}