namespace CourseManageUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFrmMainClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.btnTeacherManage = new System.Windows.Forms.Button();
            this.btnCourseManage = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnFrmMainClose);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 66);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // btnFrmMainClose
            // 
            this.btnFrmMainClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btnFrmMainClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btnFrmMainClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmMainClose.ForeColor = System.Drawing.Color.White;
            this.btnFrmMainClose.Location = new System.Drawing.Point(888, 0);
            this.btnFrmMainClose.Name = "btnFrmMainClose";
            this.btnFrmMainClose.Size = new System.Drawing.Size(32, 23);
            this.btnFrmMainClose.TabIndex = 6;
            this.btnFrmMainClose.Text = "╳";
            this.btnFrmMainClose.UseVisualStyleBackColor = false;
            this.btnFrmMainClose.Click += new System.EventHandler(this.btnFrmMainClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(888, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = " ";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(122)))));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("lblCurrentUser.Image")));
            this.lblCurrentUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurrentUser.Location = new System.Drawing.Point(788, 27);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(57, 22);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "讲师";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.btnModifyPwd);
            this.panel2.Controls.Add(this.btnTeacherManage);
            this.panel2.Controls.Add(this.btnCourseManage);
            this.panel2.Controls.Add(this.btnAddCourse);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(4, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 468);
            this.panel2.TabIndex = 1;
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnModifyPwd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnModifyPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPwd.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModifyPwd.ForeColor = System.Drawing.Color.White;
            this.btnModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyPwd.Image")));
            this.btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPwd.Location = new System.Drawing.Point(24, 380);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(162, 26);
            this.btnModifyPwd.TabIndex = 1;
            this.btnModifyPwd.Text = "   修 改 登 录 密 码";
            this.btnModifyPwd.UseVisualStyleBackColor = false;
            // 
            // btnTeacherManage
            // 
            this.btnTeacherManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnTeacherManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnTeacherManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherManage.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTeacherManage.ForeColor = System.Drawing.Color.White;
            this.btnTeacherManage.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherManage.Image")));
            this.btnTeacherManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherManage.Location = new System.Drawing.Point(24, 296);
            this.btnTeacherManage.Name = "btnTeacherManage";
            this.btnTeacherManage.Size = new System.Drawing.Size(162, 26);
            this.btnTeacherManage.TabIndex = 1;
            this.btnTeacherManage.Text = "   讲 师 信 息 管 理";
            this.btnTeacherManage.UseVisualStyleBackColor = false;
            // 
            // btnCourseManage
            // 
            this.btnCourseManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCourseManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCourseManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseManage.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCourseManage.ForeColor = System.Drawing.Color.White;
            this.btnCourseManage.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseManage.Image")));
            this.btnCourseManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourseManage.Location = new System.Drawing.Point(24, 253);
            this.btnCourseManage.Name = "btnCourseManage";
            this.btnCourseManage.Size = new System.Drawing.Size(162, 26);
            this.btnCourseManage.TabIndex = 1;
            this.btnCourseManage.Text = "   课 程 信 息 管 理";
            this.btnCourseManage.UseVisualStyleBackColor = false;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Location = new System.Drawing.Point(24, 211);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(162, 26);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "   添 加 课 程 信 息";
            this.btnAddCourse.UseVisualStyleBackColor = false;

            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.panelRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRight.BackgroundImage")));
            this.panelRight.Location = new System.Drawing.Point(228, 72);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(690, 468);
            this.panelRight.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(184)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.Button btnTeacherManage;
        private System.Windows.Forms.Button btnCourseManage;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFrmMainClose;
    }
}