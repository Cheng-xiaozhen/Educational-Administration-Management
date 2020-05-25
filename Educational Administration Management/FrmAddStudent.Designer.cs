namespace Educational_Administration_Management
{
    partial class FrmAddStudent
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
            this.txtSID = new HZH_Controls.Controls.TextBoxEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSname = new HZH_Controls.Controls.TextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.dtpBir = new System.Windows.Forms.DateTimePicker();
            this.dtpAdm = new System.Windows.Forms.DateTimePicker();
            this.ucBtnSave = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnClose = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // txtSID
            // 
            this.txtSID.DecLength = 2;
            this.txtSID.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtSID.Location = new System.Drawing.Point(199, 44);
            this.txtSID.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtSID.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtSID.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtSID.Name = "txtSID";
            this.txtSID.OldText = "";
            this.txtSID.PromptColor = System.Drawing.Color.Gray;
            this.txtSID.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSID.PromptText = "";
            this.txtSID.RegexPattern = "";
            this.txtSID.Size = new System.Drawing.Size(202, 34);
            this.txtSID.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 14);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 586);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(486, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 586);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(14, 586);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 14);
            this.panel4.TabIndex = 5;
            // 
            // txtSname
            // 
            this.txtSname.DecLength = 2;
            this.txtSname.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtSname.Location = new System.Drawing.Point(199, 111);
            this.txtSname.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtSname.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtSname.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtSname.Name = "txtSname";
            this.txtSname.OldText = "";
            this.txtSname.PromptColor = System.Drawing.Color.Gray;
            this.txtSname.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSname.PromptText = "";
            this.txtSname.RegexPattern = "";
            this.txtSname.Size = new System.Drawing.Size(202, 34);
            this.txtSname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "性别：";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(199, 178);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(202, 35);
            this.cmbGender.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "出生日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "系所：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "班级：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "入学日期：";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(199, 246);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(202, 35);
            this.cmbClass.TabIndex = 14;
            // 
            // cmbCollege
            // 
            this.cmbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(199, 314);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(202, 35);
            this.cmbCollege.TabIndex = 15;
            // 
            // dtpBir
            // 
            this.dtpBir.Location = new System.Drawing.Point(199, 382);
            this.dtpBir.Name = "dtpBir";
            this.dtpBir.Size = new System.Drawing.Size(200, 34);
            this.dtpBir.TabIndex = 16;
            // 
            // dtpAdm
            // 
            this.dtpAdm.Location = new System.Drawing.Point(199, 449);
            this.dtpAdm.Name = "dtpAdm";
            this.dtpAdm.Size = new System.Drawing.Size(200, 34);
            this.dtpAdm.TabIndex = 17;
            // 
            // ucBtnSave
            // 
            this.ucBtnSave.BackColor = System.Drawing.Color.White;
            this.ucBtnSave.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnSave.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnSave.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnSave.BtnText = "保存";
            this.ucBtnSave.ConerRadius = 5;
            this.ucBtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnSave.EnabledMouseEffect = true;
            this.ucBtnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnSave.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnSave.IsRadius = true;
            this.ucBtnSave.IsShowRect = true;
            this.ucBtnSave.IsShowTips = false;
            this.ucBtnSave.Location = new System.Drawing.Point(92, 519);
            this.ucBtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnSave.Name = "ucBtnSave";
            this.ucBtnSave.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnSave.RectWidth = 1;
            this.ucBtnSave.Size = new System.Drawing.Size(149, 47);
            this.ucBtnSave.TabIndex = 18;
            this.ucBtnSave.TabStop = false;
            this.ucBtnSave.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnSave.TipsText = "";
            this.ucBtnSave.BtnClick += new System.EventHandler(this.ucBtnSave_BtnClick);
            // 
            // ucBtnClose
            // 
            this.ucBtnClose.BackColor = System.Drawing.Color.White;
            this.ucBtnClose.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnClose.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnClose.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnClose.BtnText = "取消";
            this.ucBtnClose.ConerRadius = 5;
            this.ucBtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnClose.EnabledMouseEffect = true;
            this.ucBtnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnClose.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnClose.IsRadius = true;
            this.ucBtnClose.IsShowRect = true;
            this.ucBtnClose.IsShowTips = false;
            this.ucBtnClose.Location = new System.Drawing.Point(310, 519);
            this.ucBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnClose.Name = "ucBtnClose";
            this.ucBtnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnClose.RectWidth = 1;
            this.ucBtnClose.Size = new System.Drawing.Size(149, 47);
            this.ucBtnClose.TabIndex = 19;
            this.ucBtnClose.TabStop = false;
            this.ucBtnClose.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnClose.TipsText = "";
            this.ucBtnClose.BtnClick += new System.EventHandler(this.ucBtnClose_BtnClick);
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.ucBtnClose);
            this.Controls.Add(this.ucBtnSave);
            this.Controls.Add(this.dtpAdm);
            this.Controls.Add(this.dtpBir);
            this.Controls.Add(this.cmbCollege);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddStudent";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.TextBoxEx txtSID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private HZH_Controls.Controls.TextBoxEx txtSname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.DateTimePicker dtpBir;
        private System.Windows.Forms.DateTimePicker dtpAdm;
        private HZH_Controls.Controls.UCBtnExt ucBtnSave;
        private HZH_Controls.Controls.UCBtnExt ucBtnClose;
    }
}