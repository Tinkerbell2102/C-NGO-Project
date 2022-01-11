
namespace _6955_PRG521_FA2
{
    partial class AdminProfile
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
            this.pnlPMain = new System.Windows.Forms.Panel();
            this.lblLB = new System.Windows.Forms.Label();
            this.btnPClose = new System.Windows.Forms.Button();
            this.btnPLogout = new System.Windows.Forms.Button();
            this.tbProfileCtrl = new System.Windows.Forms.TabControl();
            this.tbUsers = new System.Windows.Forms.TabPage();
            this.rtxtUserInfo = new System.Windows.Forms.RichTextBox();
            this.btnDonorInfo = new System.Windows.Forms.Button();
            this.btnNGOInfo = new System.Windows.Forms.Button();
            this.btnAdminInfo = new System.Windows.Forms.Button();
            this.tbANGORequests = new System.Windows.Forms.TabPage();
            this.btnNGOLoad = new System.Windows.Forms.Button();
            this.cboNGOStatus = new System.Windows.Forms.ComboBox();
            this.btnNGOUpdateStatus = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNGOEventDate = new System.Windows.Forms.TextBox();
            this.txtNGOEventDetail = new System.Windows.Forms.TextBox();
            this.txtNGOEventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbADonationRequest = new System.Windows.Forms.TabPage();
            this.btnDonorLoad = new System.Windows.Forms.Button();
            this.txtDonorEvent = new System.Windows.Forms.TextBox();
            this.txtDonorDate = new System.Windows.Forms.TextBox();
            this.txtDonationAmm = new System.Windows.Forms.TextBox();
            this.txtDonationType = new System.Windows.Forms.TextBox();
            this.txtDonorName = new System.Windows.Forms.TextBox();
            this.cmbDonorStatus = new System.Windows.Forms.ComboBox();
            this.btnDonorStatus = new System.Windows.Forms.Button();
            this.btnDonNext = new System.Windows.Forms.Button();
            this.btnDonPrev = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblAdminDetails = new System.Windows.Forms.Label();
            this.lblAProfile = new System.Windows.Forms.Label();
            this.pnlPMain.SuspendLayout();
            this.tbProfileCtrl.SuspendLayout();
            this.tbUsers.SuspendLayout();
            this.tbANGORequests.SuspendLayout();
            this.tbADonationRequest.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPMain
            // 
            this.pnlPMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlPMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPMain.Controls.Add(this.lblLB);
            this.pnlPMain.Controls.Add(this.btnPClose);
            this.pnlPMain.Controls.Add(this.btnPLogout);
            this.pnlPMain.Controls.Add(this.tbProfileCtrl);
            this.pnlPMain.Controls.Add(this.pnlProfile);
            this.pnlPMain.Location = new System.Drawing.Point(12, 12);
            this.pnlPMain.Name = "pnlPMain";
            this.pnlPMain.Size = new System.Drawing.Size(392, 458);
            this.pnlPMain.TabIndex = 0;
            this.pnlPMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPMain_Paint);
            // 
            // lblLB
            // 
            this.lblLB.AutoSize = true;
            this.lblLB.Location = new System.Drawing.Point(319, 442);
            this.lblLB.Name = "lblLB";
            this.lblLB.Size = new System.Drawing.Size(72, 15);
            this.lblLB.TabIndex = 6;
            this.lblLB.Text = "LaikinB 6955";
            // 
            // btnPClose
            // 
            this.btnPClose.Location = new System.Drawing.Point(109, 425);
            this.btnPClose.Name = "btnPClose";
            this.btnPClose.Size = new System.Drawing.Size(75, 23);
            this.btnPClose.TabIndex = 3;
            this.btnPClose.Text = "Close";
            this.btnPClose.UseVisualStyleBackColor = true;
            this.btnPClose.Click += new System.EventHandler(this.btnPClose_Click);
            // 
            // btnPLogout
            // 
            this.btnPLogout.Location = new System.Drawing.Point(12, 425);
            this.btnPLogout.Name = "btnPLogout";
            this.btnPLogout.Size = new System.Drawing.Size(75, 23);
            this.btnPLogout.TabIndex = 2;
            this.btnPLogout.Text = "Logout";
            this.btnPLogout.UseVisualStyleBackColor = true;
            this.btnPLogout.Click += new System.EventHandler(this.btnPLogout_Click);
            // 
            // tbProfileCtrl
            // 
            this.tbProfileCtrl.Controls.Add(this.tbUsers);
            this.tbProfileCtrl.Controls.Add(this.tbANGORequests);
            this.tbProfileCtrl.Controls.Add(this.tbADonationRequest);
            this.tbProfileCtrl.Location = new System.Drawing.Point(12, 100);
            this.tbProfileCtrl.Name = "tbProfileCtrl";
            this.tbProfileCtrl.SelectedIndex = 0;
            this.tbProfileCtrl.Size = new System.Drawing.Size(367, 307);
            this.tbProfileCtrl.TabIndex = 1;
            this.tbProfileCtrl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbUsers
            // 
            this.tbUsers.Controls.Add(this.rtxtUserInfo);
            this.tbUsers.Controls.Add(this.btnDonorInfo);
            this.tbUsers.Controls.Add(this.btnNGOInfo);
            this.tbUsers.Controls.Add(this.btnAdminInfo);
            this.tbUsers.Location = new System.Drawing.Point(4, 24);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Size = new System.Drawing.Size(359, 279);
            this.tbUsers.TabIndex = 4;
            this.tbUsers.Text = "User Information";
            this.tbUsers.UseVisualStyleBackColor = true;
            // 
            // rtxtUserInfo
            // 
            this.rtxtUserInfo.Location = new System.Drawing.Point(16, 14);
            this.rtxtUserInfo.Name = "rtxtUserInfo";
            this.rtxtUserInfo.ReadOnly = true;
            this.rtxtUserInfo.Size = new System.Drawing.Size(327, 218);
            this.rtxtUserInfo.TabIndex = 3;
            this.rtxtUserInfo.Text = "";
            this.rtxtUserInfo.WordWrap = false;
            // 
            // btnDonorInfo
            // 
            this.btnDonorInfo.Location = new System.Drawing.Point(239, 249);
            this.btnDonorInfo.Name = "btnDonorInfo";
            this.btnDonorInfo.Size = new System.Drawing.Size(117, 23);
            this.btnDonorInfo.TabIndex = 2;
            this.btnDonorInfo.Text = "View Donor Details";
            this.btnDonorInfo.UseVisualStyleBackColor = true;
            this.btnDonorInfo.Click += new System.EventHandler(this.btnDonorInfo_Click);
            // 
            // btnNGOInfo
            // 
            this.btnNGOInfo.Location = new System.Drawing.Point(126, 249);
            this.btnNGOInfo.Name = "btnNGOInfo";
            this.btnNGOInfo.Size = new System.Drawing.Size(110, 23);
            this.btnNGOInfo.TabIndex = 1;
            this.btnNGOInfo.Text = "View NGO Details";
            this.btnNGOInfo.UseVisualStyleBackColor = true;
            this.btnNGOInfo.Click += new System.EventHandler(this.btnNGOInfo_Click);
            // 
            // btnAdminInfo
            // 
            this.btnAdminInfo.Location = new System.Drawing.Point(3, 249);
            this.btnAdminInfo.Name = "btnAdminInfo";
            this.btnAdminInfo.Size = new System.Drawing.Size(117, 23);
            this.btnAdminInfo.TabIndex = 0;
            this.btnAdminInfo.Text = "View Admin Details";
            this.btnAdminInfo.UseVisualStyleBackColor = true;
            this.btnAdminInfo.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbANGORequests
            // 
            this.tbANGORequests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbANGORequests.Controls.Add(this.btnNGOLoad);
            this.tbANGORequests.Controls.Add(this.cboNGOStatus);
            this.tbANGORequests.Controls.Add(this.btnNGOUpdateStatus);
            this.tbANGORequests.Controls.Add(this.btnNext);
            this.tbANGORequests.Controls.Add(this.btnPrev);
            this.tbANGORequests.Controls.Add(this.label4);
            this.tbANGORequests.Controls.Add(this.txtNGOEventDate);
            this.tbANGORequests.Controls.Add(this.txtNGOEventDetail);
            this.tbANGORequests.Controls.Add(this.txtNGOEventName);
            this.tbANGORequests.Controls.Add(this.label3);
            this.tbANGORequests.Controls.Add(this.label2);
            this.tbANGORequests.Controls.Add(this.label1);
            this.tbANGORequests.Location = new System.Drawing.Point(4, 24);
            this.tbANGORequests.Name = "tbANGORequests";
            this.tbANGORequests.Padding = new System.Windows.Forms.Padding(3);
            this.tbANGORequests.Size = new System.Drawing.Size(359, 279);
            this.tbANGORequests.TabIndex = 3;
            this.tbANGORequests.Text = "NGO Requests";
            this.tbANGORequests.UseVisualStyleBackColor = true;
            this.tbANGORequests.Click += new System.EventHandler(this.tbANGO_Click);
            // 
            // btnNGOLoad
            // 
            this.btnNGOLoad.Location = new System.Drawing.Point(133, 208);
            this.btnNGOLoad.Name = "btnNGOLoad";
            this.btnNGOLoad.Size = new System.Drawing.Size(75, 34);
            this.btnNGOLoad.TabIndex = 19;
            this.btnNGOLoad.Text = "Load List";
            this.btnNGOLoad.UseVisualStyleBackColor = true;
            this.btnNGOLoad.Click += new System.EventHandler(this.btnNGOLoad_Click);
            // 
            // cboNGOStatus
            // 
            this.cboNGOStatus.FormattingEnabled = true;
            this.cboNGOStatus.Items.AddRange(new object[] {
            "Approved",
            "Pending",
            "Declined"});
            this.cboNGOStatus.Location = new System.Drawing.Point(83, 171);
            this.cboNGOStatus.Name = "cboNGOStatus";
            this.cboNGOStatus.Size = new System.Drawing.Size(121, 23);
            this.cboNGOStatus.TabIndex = 18;
            // 
            // btnNGOUpdateStatus
            // 
            this.btnNGOUpdateStatus.Location = new System.Drawing.Point(215, 171);
            this.btnNGOUpdateStatus.Name = "btnNGOUpdateStatus";
            this.btnNGOUpdateStatus.Size = new System.Drawing.Size(126, 23);
            this.btnNGOUpdateStatus.TabIndex = 17;
            this.btnNGOUpdateStatus.Text = "Update Status";
            this.btnNGOUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(214, 208);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(61, 34);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = ">>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(59, 208);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(68, 35);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "<<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Event Status";
            // 
            // txtNGOEventDate
            // 
            this.txtNGOEventDate.Location = new System.Drawing.Point(87, 37);
            this.txtNGOEventDate.Name = "txtNGOEventDate";
            this.txtNGOEventDate.ReadOnly = true;
            this.txtNGOEventDate.Size = new System.Drawing.Size(121, 23);
            this.txtNGOEventDate.TabIndex = 12;
            // 
            // txtNGOEventDetail
            // 
            this.txtNGOEventDetail.Location = new System.Drawing.Point(5, 89);
            this.txtNGOEventDetail.Multiline = true;
            this.txtNGOEventDetail.Name = "txtNGOEventDetail";
            this.txtNGOEventDetail.ReadOnly = true;
            this.txtNGOEventDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNGOEventDetail.Size = new System.Drawing.Size(336, 76);
            this.txtNGOEventDetail.TabIndex = 11;
            // 
            // txtNGOEventName
            // 
            this.txtNGOEventName.Location = new System.Drawing.Point(87, 2);
            this.txtNGOEventName.Name = "txtNGOEventName";
            this.txtNGOEventName.ReadOnly = true;
            this.txtNGOEventName.Size = new System.Drawing.Size(259, 23);
            this.txtNGOEventName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Donation Requirement Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Event Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Event Name";
            // 
            // tbADonationRequest
            // 
            this.tbADonationRequest.Controls.Add(this.btnDonorLoad);
            this.tbADonationRequest.Controls.Add(this.txtDonorEvent);
            this.tbADonationRequest.Controls.Add(this.txtDonorDate);
            this.tbADonationRequest.Controls.Add(this.txtDonationAmm);
            this.tbADonationRequest.Controls.Add(this.txtDonationType);
            this.tbADonationRequest.Controls.Add(this.txtDonorName);
            this.tbADonationRequest.Controls.Add(this.cmbDonorStatus);
            this.tbADonationRequest.Controls.Add(this.btnDonorStatus);
            this.tbADonationRequest.Controls.Add(this.btnDonNext);
            this.tbADonationRequest.Controls.Add(this.btnDonPrev);
            this.tbADonationRequest.Controls.Add(this.label10);
            this.tbADonationRequest.Controls.Add(this.label5);
            this.tbADonationRequest.Controls.Add(this.label6);
            this.tbADonationRequest.Controls.Add(this.label7);
            this.tbADonationRequest.Controls.Add(this.label8);
            this.tbADonationRequest.Controls.Add(this.label9);
            this.tbADonationRequest.Location = new System.Drawing.Point(4, 24);
            this.tbADonationRequest.Name = "tbADonationRequest";
            this.tbADonationRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tbADonationRequest.Size = new System.Drawing.Size(359, 279);
            this.tbADonationRequest.TabIndex = 2;
            this.tbADonationRequest.Text = "Donation Approval ";
            this.tbADonationRequest.UseVisualStyleBackColor = true;
            this.tbADonationRequest.Click += new System.EventHandler(this.tbADonor_Click);
            // 
            // btnDonorLoad
            // 
            this.btnDonorLoad.Location = new System.Drawing.Point(135, 208);
            this.btnDonorLoad.Name = "btnDonorLoad";
            this.btnDonorLoad.Size = new System.Drawing.Size(75, 33);
            this.btnDonorLoad.TabIndex = 37;
            this.btnDonorLoad.Text = "Load List";
            this.btnDonorLoad.UseVisualStyleBackColor = true;
            this.btnDonorLoad.Click += new System.EventHandler(this.btnDonorLoad_Click);
            // 
            // txtDonorEvent
            // 
            this.txtDonorEvent.Location = new System.Drawing.Point(83, 49);
            this.txtDonorEvent.Name = "txtDonorEvent";
            this.txtDonorEvent.ReadOnly = true;
            this.txtDonorEvent.Size = new System.Drawing.Size(259, 23);
            this.txtDonorEvent.TabIndex = 36;
            // 
            // txtDonorDate
            // 
            this.txtDonorDate.Location = new System.Drawing.Point(83, 83);
            this.txtDonorDate.Name = "txtDonorDate";
            this.txtDonorDate.ReadOnly = true;
            this.txtDonorDate.Size = new System.Drawing.Size(259, 23);
            this.txtDonorDate.TabIndex = 35;
            // 
            // txtDonationAmm
            // 
            this.txtDonationAmm.Location = new System.Drawing.Point(129, 147);
            this.txtDonationAmm.Name = "txtDonationAmm";
            this.txtDonationAmm.ReadOnly = true;
            this.txtDonationAmm.Size = new System.Drawing.Size(117, 23);
            this.txtDonationAmm.TabIndex = 34;
            // 
            // txtDonationType
            // 
            this.txtDonationType.Location = new System.Drawing.Point(98, 115);
            this.txtDonationType.Name = "txtDonationType";
            this.txtDonationType.ReadOnly = true;
            this.txtDonationType.Size = new System.Drawing.Size(244, 23);
            this.txtDonationType.TabIndex = 33;
            // 
            // txtDonorName
            // 
            this.txtDonorName.Location = new System.Drawing.Point(83, 12);
            this.txtDonorName.Name = "txtDonorName";
            this.txtDonorName.ReadOnly = true;
            this.txtDonorName.Size = new System.Drawing.Size(259, 23);
            this.txtDonorName.TabIndex = 32;
            // 
            // cmbDonorStatus
            // 
            this.cmbDonorStatus.FormattingEnabled = true;
            this.cmbDonorStatus.Items.AddRange(new object[] {
            "Approved",
            "Pending",
            "Declined"});
            this.cmbDonorStatus.Location = new System.Drawing.Point(83, 176);
            this.cmbDonorStatus.Name = "cmbDonorStatus";
            this.cmbDonorStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbDonorStatus.TabIndex = 31;
            // 
            // btnDonorStatus
            // 
            this.btnDonorStatus.Location = new System.Drawing.Point(216, 176);
            this.btnDonorStatus.Name = "btnDonorStatus";
            this.btnDonorStatus.Size = new System.Drawing.Size(126, 23);
            this.btnDonorStatus.TabIndex = 30;
            this.btnDonorStatus.Text = "Update Status";
            this.btnDonorStatus.UseVisualStyleBackColor = true;
            // 
            // btnDonNext
            // 
            this.btnDonNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDonNext.Location = new System.Drawing.Point(216, 208);
            this.btnDonNext.Name = "btnDonNext";
            this.btnDonNext.Size = new System.Drawing.Size(61, 34);
            this.btnDonNext.TabIndex = 29;
            this.btnDonNext.Text = ">>>";
            this.btnDonNext.UseVisualStyleBackColor = true;
            // 
            // btnDonPrev
            // 
            this.btnDonPrev.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDonPrev.Location = new System.Drawing.Point(66, 208);
            this.btnDonPrev.Name = "btnDonPrev";
            this.btnDonPrev.Size = new System.Drawing.Size(63, 35);
            this.btnDonPrev.TabIndex = 28;
            this.btnDonPrev.Text = "<<<";
            this.btnDonPrev.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Event Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Donation Ammount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Donation Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Event Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "NGO Event";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Donor Name";
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfile.Controls.Add(this.lblAdminDetails);
            this.pnlProfile.Controls.Add(this.lblAProfile);
            this.pnlProfile.Location = new System.Drawing.Point(12, 11);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(367, 83);
            this.pnlProfile.TabIndex = 0;
            // 
            // lblAdminDetails
            // 
            this.lblAdminDetails.AutoSize = true;
            this.lblAdminDetails.ForeColor = System.Drawing.Color.Red;
            this.lblAdminDetails.Location = new System.Drawing.Point(173, 8);
            this.lblAdminDetails.Name = "lblAdminDetails";
            this.lblAdminDetails.Size = new System.Drawing.Size(81, 15);
            this.lblAdminDetails.TabIndex = 1;
            this.lblAdminDetails.Text = "Admin Details";
            // 
            // lblAProfile
            // 
            this.lblAProfile.AutoSize = true;
            this.lblAProfile.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAProfile.Location = new System.Drawing.Point(-1, 23);
            this.lblAProfile.Name = "lblAProfile";
            this.lblAProfile.Size = new System.Drawing.Size(177, 37);
            this.lblAProfile.TabIndex = 0;
            this.lblAProfile.Text = "Admin Tasks";
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(416, 482);
            this.Controls.Add(this.pnlPMain);
            this.Name = "AdminProfile";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            this.pnlPMain.ResumeLayout(false);
            this.pnlPMain.PerformLayout();
            this.tbProfileCtrl.ResumeLayout(false);
            this.tbUsers.ResumeLayout(false);
            this.tbANGORequests.ResumeLayout(false);
            this.tbANGORequests.PerformLayout();
            this.tbADonationRequest.ResumeLayout(false);
            this.tbADonationRequest.PerformLayout();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPMain;
        private System.Windows.Forms.Button btnPClose;
        private System.Windows.Forms.Button btnPLogout;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblLB;
        private System.Windows.Forms.Label lblAProfile;
        private System.Windows.Forms.TabControl tbProfileCtrl;
        private System.Windows.Forms.TabPage tbADonationRequest;
        private System.Windows.Forms.TabPage tbANGORequests;
        private System.Windows.Forms.Label lblAdminDetails;
        private System.Windows.Forms.TabPage tbUsers;
        private System.Windows.Forms.Button btnDonorInfo;
        private System.Windows.Forms.Button btnNGOInfo;
        private System.Windows.Forms.Button btnAdminInfo;
        private System.Windows.Forms.ComboBox cboNGOStatus;
        private System.Windows.Forms.Button btnNGOUpdateStatus;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNGOEventDate;
        private System.Windows.Forms.TextBox txtNGOEventDetail;
        private System.Windows.Forms.TextBox txtNGOEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonorEvent;
        private System.Windows.Forms.TextBox txtDonorDate;
        private System.Windows.Forms.TextBox txtDonationAmm;
        private System.Windows.Forms.TextBox txtDonationType;
        private System.Windows.Forms.TextBox txtDonorName;
        private System.Windows.Forms.ComboBox cmbDonorStatus;
        private System.Windows.Forms.Button btnDonorStatus;
        private System.Windows.Forms.Button btnDonNext;
        private System.Windows.Forms.Button btnDonPrev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNGOLoad;
        private System.Windows.Forms.Button btnDonorLoad;
        private System.Windows.Forms.RichTextBox rtxtUserInfo;
    }
}