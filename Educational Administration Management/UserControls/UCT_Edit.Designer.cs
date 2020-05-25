namespace Educational_Administration_Management.UserControls
{
    partial class UCT_Edit
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCT_Edit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucBtnPost = new HZH_Controls.Controls.UCBtnExt();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucBtnSave = new HZH_Controls.Controls.UCBtnExt();
            this.dtpBir = new System.Windows.Forms.DateTimePicker();
            this.dtpAdmission = new System.Windows.Forms.DateTimePicker();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.ucBtnChangePwd = new HZH_Controls.Controls.UCBtnExt();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(261, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(361, 42);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 34);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(726, 42);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 34);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(626, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "籍贯：";
            // 
            // txtTID
            // 
            this.txtTID.Location = new System.Drawing.Point(361, 149);
            this.txtTID.MaxLength = 11;
            this.txtTID.Name = "txtTID";
            this.txtTID.ReadOnly = true;
            this.txtTID.Size = new System.Drawing.Size(200, 34);
            this.txtTID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(261, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "工号：";
            // 
            // txtTSalary
            // 
            this.txtTSalary.Location = new System.Drawing.Point(726, 149);
            this.txtTSalary.Name = "txtTSalary";
            this.txtTSalary.Size = new System.Drawing.Size(200, 34);
            this.txtTSalary.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(626, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "工资：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(261, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(626, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "系所：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(261, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "出生日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(626, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "入职时间：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucBtnPost);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 580);
            this.panel1.TabIndex = 17;
            // 
            // ucBtnPost
            // 
            this.ucBtnPost.BackColor = System.Drawing.Color.White;
            this.ucBtnPost.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnPost.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnPost.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnPost.BtnText = "上传图片";
            this.ucBtnPost.ConerRadius = 5;
            this.ucBtnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnPost.EnabledMouseEffect = true;
            this.ucBtnPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnPost.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnPost.IsRadius = true;
            this.ucBtnPost.IsShowRect = true;
            this.ucBtnPost.IsShowTips = false;
            this.ucBtnPost.Location = new System.Drawing.Point(23, 249);
            this.ucBtnPost.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnPost.Name = "ucBtnPost";
            this.ucBtnPost.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnPost.RectWidth = 1;
            this.ucBtnPost.Size = new System.Drawing.Size(164, 60);
            this.ucBtnPost.TabIndex = 19;
            this.ucBtnPost.TabStop = false;
            this.ucBtnPost.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnPost.TipsText = "";
            this.ucBtnPost.BtnClick += new System.EventHandler(this.ucBtnPost_BtnClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 580);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // ucBtnSave
            // 
            this.ucBtnSave.BackColor = System.Drawing.Color.White;
            this.ucBtnSave.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnSave.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnSave.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnSave.BtnText = "确定";
            this.ucBtnSave.ConerRadius = 5;
            this.ucBtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnSave.EnabledMouseEffect = true;
            this.ucBtnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.ucBtnSave.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnSave.IsRadius = true;
            this.ucBtnSave.IsShowRect = true;
            this.ucBtnSave.IsShowTips = false;
            this.ucBtnSave.Location = new System.Drawing.Point(487, 520);
            this.ucBtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnSave.Name = "ucBtnSave";
            this.ucBtnSave.RectColor = System.Drawing.Color.SeaGreen;
            this.ucBtnSave.RectWidth = 1;
            this.ucBtnSave.Size = new System.Drawing.Size(184, 60);
            this.ucBtnSave.TabIndex = 18;
            this.ucBtnSave.TabStop = false;
            this.ucBtnSave.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnSave.TipsText = "";
            this.ucBtnSave.BtnClick += new System.EventHandler(this.ucBtnSave_BtnClick);
            // 
            // dtpBir
            // 
            this.dtpBir.Location = new System.Drawing.Point(361, 349);
            this.dtpBir.Name = "dtpBir";
            this.dtpBir.Size = new System.Drawing.Size(200, 34);
            this.dtpBir.TabIndex = 19;
            // 
            // dtpAdmission
            // 
            this.dtpAdmission.Location = new System.Drawing.Point(726, 349);
            this.dtpAdmission.Name = "dtpAdmission";
            this.dtpAdmission.Size = new System.Drawing.Size(200, 34);
            this.dtpAdmission.TabIndex = 20;
            // 
            // cmbDepart
            // 
            this.cmbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(726, 249);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(200, 35);
            this.cmbDepart.TabIndex = 21;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(361, 249);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(200, 35);
            this.cmbGender.TabIndex = 22;
            // 
            // ucBtnChangePwd
            // 
            this.ucBtnChangePwd.BackColor = System.Drawing.Color.White;
            this.ucBtnChangePwd.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnChangePwd.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnChangePwd.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnChangePwd.BtnText = "修改密码";
            this.ucBtnChangePwd.ConerRadius = 5;
            this.ucBtnChangePwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnChangePwd.EnabledMouseEffect = true;
            this.ucBtnChangePwd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnChangePwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnChangePwd.IsRadius = true;
            this.ucBtnChangePwd.IsShowRect = true;
            this.ucBtnChangePwd.IsShowTips = false;
            this.ucBtnChangePwd.Location = new System.Drawing.Point(742, 520);
            this.ucBtnChangePwd.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnChangePwd.Name = "ucBtnChangePwd";
            this.ucBtnChangePwd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnChangePwd.RectWidth = 1;
            this.ucBtnChangePwd.Size = new System.Drawing.Size(184, 60);
            this.ucBtnChangePwd.TabIndex = 23;
            this.ucBtnChangePwd.TabStop = false;
            this.ucBtnChangePwd.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnChangePwd.TipsText = "";
            this.ucBtnChangePwd.BtnClick += new System.EventHandler(this.ucBtnChangePwd_BtnClick);
            // 
            // UCT_Edit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucBtnChangePwd);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.dtpAdmission);
            this.Controls.Add(this.dtpBir);
            this.Controls.Add(this.ucBtnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCT_Edit";
            this.Size = new System.Drawing.Size(981, 580);
            this.Load += new System.EventHandler(this.UCT_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.UCBtnExt ucBtnPost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private HZH_Controls.Controls.UCBtnExt ucBtnSave;
        private System.Windows.Forms.DateTimePicker dtpBir;
        private System.Windows.Forms.DateTimePicker dtpAdmission;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ComboBox cmbGender;
        private HZH_Controls.Controls.UCBtnExt ucBtnChangePwd;
    }
}
