
namespace _6955_PRG521_FA2
{
    partial class Login
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
            this.btnLogCancel = new System.Windows.Forms.Button();
            this.lblLogUsername = new System.Windows.Forms.Label();
            this.lblLogPass = new System.Windows.Forms.Label();
            this.txtLogUsername = new System.Windows.Forms.TextBox();
            this.pnlLMain = new System.Windows.Forms.Panel();
            this.btnLogRegister = new System.Windows.Forms.Button();
            this.txtLogPass = new System.Windows.Forms.TextBox();
            this.btnLogLogin = new System.Windows.Forms.Button();
            this.lblLB = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlLMain.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogCancel
            // 
            this.btnLogCancel.Location = new System.Drawing.Point(95, 210);
            this.btnLogCancel.Name = "btnLogCancel";
            this.btnLogCancel.Size = new System.Drawing.Size(85, 23);
            this.btnLogCancel.TabIndex = 1;
            this.btnLogCancel.Text = "Exit";
            this.btnLogCancel.UseVisualStyleBackColor = true;
            this.btnLogCancel.Click += new System.EventHandler(this.btnLogCancel_Click);
            // 
            // lblLogUsername
            // 
            this.lblLogUsername.AutoSize = true;
            this.lblLogUsername.Location = new System.Drawing.Point(28, 80);
            this.lblLogUsername.Name = "lblLogUsername";
            this.lblLogUsername.Size = new System.Drawing.Size(60, 15);
            this.lblLogUsername.TabIndex = 3;
            this.lblLogUsername.Text = "Username";
            // 
            // lblLogPass
            // 
            this.lblLogPass.AutoSize = true;
            this.lblLogPass.Location = new System.Drawing.Point(28, 123);
            this.lblLogPass.Name = "lblLogPass";
            this.lblLogPass.Size = new System.Drawing.Size(57, 15);
            this.lblLogPass.TabIndex = 4;
            this.lblLogPass.Text = "Password";
            // 
            // txtLogUsername
            // 
            this.txtLogUsername.Location = new System.Drawing.Point(94, 72);
            this.txtLogUsername.Name = "txtLogUsername";
            this.txtLogUsername.Size = new System.Drawing.Size(141, 23);
            this.txtLogUsername.TabIndex = 1;
            this.txtLogUsername.TextChanged += new System.EventHandler(this.txtLogUsername_TextChanged);
            // 
            // pnlLMain
            // 
            this.pnlLMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlLMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLMain.Controls.Add(this.btnLogRegister);
            this.pnlLMain.Controls.Add(this.txtLogPass);
            this.pnlLMain.Controls.Add(this.btnLogLogin);
            this.pnlLMain.Controls.Add(this.lblLB);
            this.pnlLMain.Controls.Add(this.pnlLogin);
            this.pnlLMain.Controls.Add(this.btnLogCancel);
            this.pnlLMain.Controls.Add(this.txtLogUsername);
            this.pnlLMain.Controls.Add(this.lblLogPass);
            this.pnlLMain.Controls.Add(this.lblLogUsername);
            this.pnlLMain.Location = new System.Drawing.Point(12, 12);
            this.pnlLMain.Name = "pnlLMain";
            this.pnlLMain.Size = new System.Drawing.Size(276, 259);
            this.pnlLMain.TabIndex = 7;
            // 
            // btnLogRegister
            // 
            this.btnLogRegister.Location = new System.Drawing.Point(160, 172);
            this.btnLogRegister.Name = "btnLogRegister";
            this.btnLogRegister.Size = new System.Drawing.Size(75, 23);
            this.btnLogRegister.TabIndex = 11;
            this.btnLogRegister.Text = "Register";
            this.btnLogRegister.UseVisualStyleBackColor = true;
            this.btnLogRegister.Click += new System.EventHandler(this.btnLogRegister_Click);
            // 
            // txtLogPass
            // 
            this.txtLogPass.Location = new System.Drawing.Point(94, 114);
            this.txtLogPass.Name = "txtLogPass";
            this.txtLogPass.PasswordChar = '*';
            this.txtLogPass.Size = new System.Drawing.Size(141, 23);
            this.txtLogPass.TabIndex = 2;
            this.txtLogPass.TextChanged += new System.EventHandler(this.txtLogPass_TextChanged);
            // 
            // btnLogLogin
            // 
            this.btnLogLogin.Location = new System.Drawing.Point(45, 172);
            this.btnLogLogin.Name = "btnLogLogin";
            this.btnLogLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogLogin.TabIndex = 9;
            this.btnLogLogin.Text = "Login";
            this.btnLogLogin.UseVisualStyleBackColor = true;
            this.btnLogLogin.Click += new System.EventHandler(this.btnLogLogin_Click);
            // 
            // lblLB
            // 
            this.lblLB.AutoSize = true;
            this.lblLB.Location = new System.Drawing.Point(204, 244);
            this.lblLB.Name = "lblLB";
            this.lblLB.Size = new System.Drawing.Size(72, 15);
            this.lblLB.TabIndex = 8;
            this.lblLB.Text = "LaikinB 6955";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Location = new System.Drawing.Point(12, 14);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(254, 38);
            this.pnlLogin.TabIndex = 7;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(82, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(99, 37);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "LOGIN";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(300, 284);
            this.Controls.Add(this.pnlLMain);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlLMain.ResumeLayout(false);
            this.pnlLMain.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogCancel;
        private System.Windows.Forms.Label lblLogUsername;
        private System.Windows.Forms.Label lblLogPass;
        private System.Windows.Forms.TextBox txtLogUsername;
        private System.Windows.Forms.Panel pnlLMain;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblLB;
        private System.Windows.Forms.Button btnLogLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogPass;
        private System.Windows.Forms.Button btnLogRegister;
    }
}