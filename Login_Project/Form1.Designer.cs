namespace Login_Project
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_User = new System.Windows.Forms.TextBox();
            this.txtB_Pass = new System.Windows.Forms.TextBox();
            this.but_Login = new System.Windows.Forms.Button();
            this.but_Exit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txtB_User
            // 
            this.txtB_User.Location = new System.Drawing.Point(87, 14);
            this.txtB_User.Name = "txtB_User";
            this.txtB_User.Size = new System.Drawing.Size(193, 20);
            this.txtB_User.TabIndex = 1;
            // 
            // txtB_Pass
            // 
            this.txtB_Pass.Location = new System.Drawing.Point(87, 47);
            this.txtB_Pass.Name = "txtB_Pass";
            this.txtB_Pass.Size = new System.Drawing.Size(193, 20);
            this.txtB_Pass.TabIndex = 1;
            // 
            // but_Login
            // 
            this.but_Login.Location = new System.Drawing.Point(87, 103);
            this.but_Login.Name = "but_Login";
            this.but_Login.Size = new System.Drawing.Size(78, 23);
            this.but_Login.TabIndex = 2;
            this.but_Login.Text = "Đăng nhập";
            this.but_Login.UseVisualStyleBackColor = true;
            this.but_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_Exit
            // 
            this.but_Exit.Location = new System.Drawing.Point(202, 103);
            this.but_Exit.Name = "but_Exit";
            this.but_Exit.Size = new System.Drawing.Size(78, 23);
            this.but_Exit.TabIndex = 2;
            this.but_Exit.Text = "Thoát";
            this.but_Exit.UseVisualStyleBackColor = true;
            this.but_Exit.Click += new System.EventHandler(this.but_Exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 133);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(343, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(22, 82);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 155);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.but_Exit);
            this.Controls.Add(this.but_Login);
            this.Controls.Add(this.txtB_Pass);
            this.Controls.Add(this.txtB_User);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_User;
        private System.Windows.Forms.TextBox txtB_Pass;
        private System.Windows.Forms.Button but_Login;
        private System.Windows.Forms.Button but_Exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.Label labelStatus;
    }
}

