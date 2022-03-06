namespace CourseManageUI
{
    partial class FrmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminLogin));
            this.lableAccount = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textLoginAccount = new System.Windows.Forms.TextBox();
            this.textLoginPwd = new System.Windows.Forms.TextBox();
            this.ckbSavePwd = new System.Windows.Forms.CheckBox();
            this.btnLoginSys = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lableAccount
            // 
            this.lableAccount.AutoSize = true;
            this.lableAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.lableAccount.Location = new System.Drawing.Point(74, 146);
            this.lableAccount.Name = "lableAccount";
            this.lableAccount.Size = new System.Drawing.Size(77, 12);
            this.lableAccount.TabIndex = 0;
            this.lableAccount.Text = "管理员账号：";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.labelPwd.Location = new System.Drawing.Point(74, 182);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(77, 12);
            this.labelPwd.TabIndex = 0;
            this.labelPwd.Text = "管理员密码：";
            // 
            // textLoginAccount
            // 
            this.textLoginAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLoginAccount.Location = new System.Drawing.Point(166, 143);
            this.textLoginAccount.Name = "textLoginAccount";
            this.textLoginAccount.Size = new System.Drawing.Size(153, 21);
            this.textLoginAccount.TabIndex = 1;
            this.textLoginAccount.Text = "Admin";
            // 
            // textLoginPwd
            // 
            this.textLoginPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLoginPwd.Location = new System.Drawing.Point(166, 173);
            this.textLoginPwd.Name = "textLoginPwd";
            this.textLoginPwd.Size = new System.Drawing.Size(153, 21);
            this.textLoginPwd.TabIndex = 1;
            this.textLoginPwd.Text = "123456";
            this.textLoginPwd.UseSystemPasswordChar = true;
            this.textLoginPwd.UseWaitCursor = true;
            // 
            // ckbSavePwd
            // 
            this.ckbSavePwd.AutoSize = true;
            this.ckbSavePwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ckbSavePwd.Location = new System.Drawing.Point(76, 214);
            this.ckbSavePwd.Name = "ckbSavePwd";
            this.ckbSavePwd.Size = new System.Drawing.Size(72, 16);
            this.ckbSavePwd.TabIndex = 2;
            this.ckbSavePwd.Text = "记住密码";
            this.ckbSavePwd.UseVisualStyleBackColor = false;
            // 
            // btnLoginSys
            // 
            this.btnLoginSys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(193)))));
            this.btnLoginSys.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLoginSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginSys.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoginSys.Location = new System.Drawing.Point(244, 214);
            this.btnLoginSys.Name = "btnLoginSys";
            this.btnLoginSys.Size = new System.Drawing.Size(75, 23);
            this.btnLoginSys.TabIndex = 3;
            this.btnLoginSys.Text = "登录";
            this.btnLoginSys.UseVisualStyleBackColor = false;
            this.btnLoginSys.Click += new System.EventHandler(this.btnLoginSys_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(362, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "╳";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(393, 260);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoginSys);
            this.Controls.Add(this.ckbSavePwd);
            this.Controls.Add(this.textLoginPwd);
            this.Controls.Add(this.textLoginAccount);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.lableAccount);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员登陆";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableAccount;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox textLoginAccount;
        private System.Windows.Forms.TextBox textLoginPwd;
        private System.Windows.Forms.CheckBox ckbSavePwd;
        private System.Windows.Forms.Button btnLoginSys;
        private System.Windows.Forms.Button btnClose;
    }
}

