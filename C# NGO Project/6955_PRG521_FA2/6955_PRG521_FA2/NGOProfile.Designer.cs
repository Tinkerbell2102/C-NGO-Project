
namespace _6955_PRG521_FA2
{
    partial class NGOProfile
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
            this.tbNGO = new System.Windows.Forms.TabControl();
            this.tbNGOCurEvent = new System.Windows.Forms.TabPage();
            this.btnNNGOGetCurEvents = new System.Windows.Forms.Button();
            this.rtxtNGOCurrentEvents = new System.Windows.Forms.RichTextBox();
            this.lblNDoName = new System.Windows.Forms.Label();
            this.tbNGOHist = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtNGOFromHist = new System.Windows.Forms.DateTimePicker();
            this.rtxtNGOHist = new System.Windows.Forms.RichTextBox();
            this.tbNGONewEvent = new System.Windows.Forms.TabPage();
            this.btnNGODocs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNGONewEventDetail = new System.Windows.Forms.TextBox();
            this.dtNGONewEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtNGONewEventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDonations = new System.Windows.Forms.TabPage();
            this.btnDonationReport = new System.Windows.Forms.Button();
            this.rtxtNGODonationReport = new System.Windows.Forms.RichTextBox();
            this.lblLB = new System.Windows.Forms.Label();
            this.btnNGOClose = new System.Windows.Forms.Button();
            this.btnNGOLogout = new System.Windows.Forms.Button();
            this.pnlPI = new System.Windows.Forms.Panel();
            this.lblNGODetail = new System.Windows.Forms.Label();
            this.lblNGOProfile = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlpiMain.SuspendLayout();
            this.tbNGO.SuspendLayout();
            this.tbNGOCurEvent.SuspendLayout();
            this.tbNGOHist.SuspendLayout();
            this.tbNGONewEvent.SuspendLayout();
            this.tbDonations.SuspendLayout();
            this.pnlPI.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlpiMain
            // 
            this.pnlpiMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlpiMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpiMain.Controls.Add(this.tbNGO);
            this.pnlpiMain.Controls.Add(this.lblLB);
            this.pnlpiMain.Controls.Add(this.btnNGOClose);
            this.pnlpiMain.Controls.Add(this.btnNGOLogout);
            this.pnlpiMain.Controls.Add(this.pnlPI);
            this.pnlpiMain.Location = new System.Drawing.Point(12, 12);
            this.pnlpiMain.Name = "pnlpiMain";
            this.pnlpiMain.Size = new System.Drawing.Size(380, 422);
            this.pnlpiMain.TabIndex = 3;
            // 
            // tbNGO
            // 
            this.tbNGO.Controls.Add(this.tbNGOCurEvent);
            this.tbNGO.Controls.Add(this.tbNGOHist);
            this.tbNGO.Controls.Add(this.tbNGONewEvent);
            this.tbNGO.Controls.Add(this.tbDonations);
            this.tbNGO.Location = new System.Drawing.Point(13, 105);
            this.tbNGO.Name = "tbNGO";
            this.tbNGO.SelectedIndex = 0;
            this.tbNGO.Size = new System.Drawing.Size(355, 279);
            this.tbNGO.TabIndex = 19;
            // 
            // tbNGOCurEvent
            // 
            this.tbNGOCurEvent.Controls.Add(this.btnNNGOGetCurEvents);
            this.tbNGOCurEvent.Controls.Add(this.rtxtNGOCurrentEvents);
            this.tbNGOCurEvent.Controls.Add(this.lblNDoName);
            this.tbNGOCurEvent.Location = new System.Drawing.Point(4, 24);
            this.tbNGOCurEvent.Name = "tbNGOCurEvent";
            this.tbNGOCurEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tbNGOCurEvent.Size = new System.Drawing.Size(347, 251);
            this.tbNGOCurEvent.TabIndex = 0;
            this.tbNGOCurEvent.Text = "Current Events";
            this.tbNGOCurEvent.UseVisualStyleBackColor = true;
            // 
            // btnNNGOGetCurEvents
            // 
            this.btnNNGOGetCurEvents.Location = new System.Drawing.Point(104, 225);
            this.btnNNGOGetCurEvents.Name = "btnNNGOGetCurEvents";
            this.btnNNGOGetCurEvents.Size = new System.Drawing.Size(139, 23);
            this.btnNNGOGetCurEvents.TabIndex = 18;
            this.btnNNGOGetCurEvents.Text = "Get Current Events";
            this.btnNNGOGetCurEvents.UseVisualStyleBackColor = true;
            this.btnNNGOGetCurEvents.Click += new System.EventHandler(this.btnNNGOGetCurEvents_Click);
            // 
            // rtxtNGOCurrentEvents
            // 
            this.rtxtNGOCurrentEvents.Location = new System.Drawing.Point(4, 4);
            this.rtxtNGOCurrentEvents.Name = "rtxtNGOCurrentEvents";
            this.rtxtNGOCurrentEvents.ReadOnly = true;
            this.rtxtNGOCurrentEvents.Size = new System.Drawing.Size(340, 219);
            this.rtxtNGOCurrentEvents.TabIndex = 17;
            this.rtxtNGOCurrentEvents.Text = "Current List of Approved Events";
            this.rtxtNGOCurrentEvents.WordWrap = false;
            // 
            // lblNDoName
            // 
            this.lblNDoName.AutoSize = true;
            this.lblNDoName.Location = new System.Drawing.Point(-86, 7);
            this.lblNDoName.Name = "lblNDoName";
            this.lblNDoName.Size = new System.Drawing.Size(71, 15);
            this.lblNDoName.TabIndex = 16;
            this.lblNDoName.Text = "NGO Name:";
            this.lblNDoName.Visible = false;
            // 
            // tbNGOHist
            // 
            this.tbNGOHist.Controls.Add(this.button1);
            this.tbNGOHist.Controls.Add(this.dtNGOFromHist);
            this.tbNGOHist.Controls.Add(this.rtxtNGOHist);
            this.tbNGOHist.Location = new System.Drawing.Point(4, 24);
            this.tbNGOHist.Name = "tbNGOHist";
            this.tbNGOHist.Padding = new System.Windows.Forms.Padding(3);
            this.tbNGOHist.Size = new System.Drawing.Size(347, 251);
            this.tbNGOHist.TabIndex = 1;
            this.tbNGOHist.Text = "Event History";
            this.tbNGOHist.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Historic Events";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtNGOFromHist
            // 
            this.dtNGOFromHist.CustomFormat = "\"yyyy-MM-dd\"";
            this.dtNGOFromHist.Location = new System.Drawing.Point(4, 4);
            this.dtNGOFromHist.Name = "dtNGOFromHist";
            this.dtNGOFromHist.Size = new System.Drawing.Size(200, 23);
            this.dtNGOFromHist.TabIndex = 1;
            this.dtNGOFromHist.Value = new System.DateTime(2021, 4, 18, 20, 14, 54, 0);
            // 
            // rtxtNGOHist
            // 
            this.rtxtNGOHist.Location = new System.Drawing.Point(4, 31);
            this.rtxtNGOHist.Name = "rtxtNGOHist";
            this.rtxtNGOHist.ReadOnly = true;
            this.rtxtNGOHist.Size = new System.Drawing.Size(340, 187);
            this.rtxtNGOHist.TabIndex = 0;
            this.rtxtNGOHist.Text = "View Previous Event Details";
            // 
            // tbNGONewEvent
            // 
            this.tbNGONewEvent.Controls.Add(this.btnNGODocs);
            this.tbNGONewEvent.Controls.Add(this.button2);
            this.tbNGONewEvent.Controls.Add(this.txtNGONewEventDetail);
            this.tbNGONewEvent.Controls.Add(this.dtNGONewEventDate);
            this.tbNGONewEvent.Controls.Add(this.txtNGONewEventName);
            this.tbNGONewEvent.Controls.Add(this.label3);
            this.tbNGONewEvent.Controls.Add(this.label2);
            this.tbNGONewEvent.Controls.Add(this.label1);
            this.tbNGONewEvent.Location = new System.Drawing.Point(4, 24);
            this.tbNGONewEvent.Name = "tbNGONewEvent";
            this.tbNGONewEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tbNGONewEvent.Size = new System.Drawing.Size(347, 251);
            this.tbNGONewEvent.TabIndex = 2;
            this.tbNGONewEvent.Text = "New Events";
            this.tbNGONewEvent.UseVisualStyleBackColor = true;
            // 
            // btnNGODocs
            // 
            this.btnNGODocs.Location = new System.Drawing.Point(4, 193);
            this.btnNGODocs.Name = "btnNGODocs";
            this.btnNGODocs.Size = new System.Drawing.Size(104, 23);
            this.btnNGODocs.TabIndex = 7;
            this.btnNGODocs.Text = "Attach Docs";
            this.btnNGODocs.UseVisualStyleBackColor = true;
            this.btnNGODocs.Click += new System.EventHandler(this.btnNGODocs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Create Event";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNGONewEventDetail
            // 
            this.txtNGONewEventDetail.Location = new System.Drawing.Point(3, 93);
            this.txtNGONewEventDetail.Multiline = true;
            this.txtNGONewEventDetail.Name = "txtNGONewEventDetail";
            this.txtNGONewEventDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNGONewEventDetail.Size = new System.Drawing.Size(336, 93);
            this.txtNGONewEventDetail.TabIndex = 5;
            // 
            // dtNGONewEventDate
            // 
            this.dtNGONewEventDate.Location = new System.Drawing.Point(85, 35);
            this.dtNGONewEventDate.Name = "dtNGONewEventDate";
            this.dtNGONewEventDate.Size = new System.Drawing.Size(200, 23);
            this.dtNGONewEventDate.TabIndex = 4;
            // 
            // txtNGONewEventName
            // 
            this.txtNGONewEventName.Location = new System.Drawing.Point(85, 6);
            this.txtNGONewEventName.Name = "txtNGONewEventName";
            this.txtNGONewEventName.Size = new System.Drawing.Size(259, 23);
            this.txtNGONewEventName.TabIndex = 3;
            this.txtNGONewEventName.TextChanged += new System.EventHandler(this.txtNGONewEventName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Donation Requirement Details";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbDonations
            // 
            this.tbDonations.Controls.Add(this.btnDonationReport);
            this.tbDonations.Controls.Add(this.rtxtNGODonationReport);
            this.tbDonations.Location = new System.Drawing.Point(4, 24);
            this.tbDonations.Name = "tbDonations";
            this.tbDonations.Size = new System.Drawing.Size(347, 251);
            this.tbDonations.TabIndex = 3;
            this.tbDonations.Text = "Donation Report";
            this.tbDonations.UseVisualStyleBackColor = true;
            // 
            // btnDonationReport
            // 
            this.btnDonationReport.Location = new System.Drawing.Point(90, 225);
            this.btnDonationReport.Name = "btnDonationReport";
            this.btnDonationReport.Size = new System.Drawing.Size(162, 23);
            this.btnDonationReport.TabIndex = 1;
            this.btnDonationReport.Text = "Get Donation Report";
            this.btnDonationReport.UseVisualStyleBackColor = true;
            this.btnDonationReport.Click += new System.EventHandler(this.btnDonationReport_Click);
            // 
            // rtxtNGODonationReport
            // 
            this.rtxtNGODonationReport.Location = new System.Drawing.Point(4, 4);
            this.rtxtNGODonationReport.Name = "rtxtNGODonationReport";
            this.rtxtNGODonationReport.ReadOnly = true;
            this.rtxtNGODonationReport.Size = new System.Drawing.Size(340, 215);
            this.rtxtNGODonationReport.TabIndex = 0;
            this.rtxtNGODonationReport.Text = "View Donation Report.";
            this.rtxtNGODonationReport.WordWrap = false;
            // 
            // lblLB
            // 
            this.lblLB.AutoSize = true;
            this.lblLB.Location = new System.Drawing.Point(307, 406);
            this.lblLB.Name = "lblLB";
            this.lblLB.Size = new System.Drawing.Size(72, 15);
            this.lblLB.TabIndex = 6;
            this.lblLB.Text = "LaikinB 6955";
            // 
            // btnNGOClose
            // 
            this.btnNGOClose.Location = new System.Drawing.Point(94, 390);
            this.btnNGOClose.Name = "btnNGOClose";
            this.btnNGOClose.Size = new System.Drawing.Size(75, 23);
            this.btnNGOClose.TabIndex = 3;
            this.btnNGOClose.Text = "Exit";
            this.btnNGOClose.UseVisualStyleBackColor = true;
            this.btnNGOClose.Click += new System.EventHandler(this.btnNGOClose_Click);
            // 
            // btnNGOLogout
            // 
            this.btnNGOLogout.Location = new System.Drawing.Point(13, 390);
            this.btnNGOLogout.Name = "btnNGOLogout";
            this.btnNGOLogout.Size = new System.Drawing.Size(75, 23);
            this.btnNGOLogout.TabIndex = 2;
            this.btnNGOLogout.Text = "Logout";
            this.btnNGOLogout.UseVisualStyleBackColor = true;
            this.btnNGOLogout.Click += new System.EventHandler(this.btnNGOLogout_Click);
            // 
            // pnlPI
            // 
            this.pnlPI.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPI.Controls.Add(this.lblNGODetail);
            this.pnlPI.Controls.Add(this.lblNGOProfile);
            this.pnlPI.Location = new System.Drawing.Point(13, 8);
            this.pnlPI.Name = "pnlPI";
            this.pnlPI.Size = new System.Drawing.Size(355, 91);
            this.pnlPI.TabIndex = 0;
            // 
            // lblNGODetail
            // 
            this.lblNGODetail.AutoSize = true;
            this.lblNGODetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNGODetail.ForeColor = System.Drawing.Color.Red;
            this.lblNGODetail.Location = new System.Drawing.Point(175, 8);
            this.lblNGODetail.Name = "lblNGODetail";
            this.lblNGODetail.Size = new System.Drawing.Size(80, 17);
            this.lblNGODetail.TabIndex = 1;
            this.lblNGODetail.Text = "NGO Details";
            // 
            // lblNGOProfile
            // 
            this.lblNGOProfile.AutoSize = true;
            this.lblNGOProfile.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNGOProfile.Location = new System.Drawing.Point(-1, 25);
            this.lblNGOProfile.Name = "lblNGOProfile";
            this.lblNGOProfile.Size = new System.Drawing.Size(170, 37);
            this.lblNGOProfile.TabIndex = 0;
            this.lblNGOProfile.Text = "NGO Profile";
            this.lblNGOProfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NGOProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(403, 446);
            this.Controls.Add(this.pnlpiMain);
            this.Name = "NGOProfile";
            this.Text = "NGO Profile";
            this.Load += new System.EventHandler(this.NGOProfile_Load);
            this.pnlpiMain.ResumeLayout(false);
            this.pnlpiMain.PerformLayout();
            this.tbNGO.ResumeLayout(false);
            this.tbNGOCurEvent.ResumeLayout(false);
            this.tbNGOCurEvent.PerformLayout();
            this.tbNGOHist.ResumeLayout(false);
            this.tbNGONewEvent.ResumeLayout(false);
            this.tbNGONewEvent.PerformLayout();
            this.tbDonations.ResumeLayout(false);
            this.pnlPI.ResumeLayout(false);
            this.pnlPI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlpiMain;
        private System.Windows.Forms.TabControl tbNGO;
        private System.Windows.Forms.TabPage tbNGOCurEvent;
        private System.Windows.Forms.Label lblNDoName;
        private System.Windows.Forms.TabPage tbNGOHist;
        private System.Windows.Forms.Label lblLB;
        private System.Windows.Forms.Button btnNGOClose;
        private System.Windows.Forms.Button btnNGOLogout;
        private System.Windows.Forms.Panel pnlPI;
        private System.Windows.Forms.Label lblNGOProfile;
        private System.Windows.Forms.Label lblNGODetail;
        private System.Windows.Forms.RichTextBox rtxtNGOCurrentEvents;
        private System.Windows.Forms.DateTimePicker dtNGOFromHist;
        private System.Windows.Forms.RichTextBox rtxtNGOHist;
        private System.Windows.Forms.Button btnNNGOGetCurEvents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tbNGONewEvent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNGONewEventDetail;
        private System.Windows.Forms.DateTimePicker dtNGONewEventDate;
        private System.Windows.Forms.TextBox txtNGONewEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNGODocs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tbDonations;
        private System.Windows.Forms.Button btnDonationReport;
        private System.Windows.Forms.RichTextBox rtxtNGODonationReport;
    }
}