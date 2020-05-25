namespace Educational_Administration_Management
{
    partial class FrmEditStudent
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
            this.ucBtnClose = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnSave = new HZH_Controls.Controls.UCBtnExt();
            this.dtpEdAdm = new System.Windows.Forms.DateTimePicker();
            this.dtpEdBir = new System.Windows.Forms.DateTimePicker();
            this.cmbEdCollege = new System.Windows.Forms.ComboBox();
            this.cmbEdClass = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEdGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdSname = new HZH_Controls.Controls.TextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEdSID = new HZH_Controls.Controls.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.ucBtnClose.TabIndex = 39;
            this.ucBtnClose.TabStop = false;
            this.ucBtnClose.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnClose.TipsText = "";
            this.ucBtnClose.BtnClick += new System.EventHandler(this.ucBtnClose_BtnClick);
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
            this.ucBtnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.ucBtnSave.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnSave.IsRadius = true;
            this.ucBtnSave.IsShowRect = true;
            this.ucBtnSave.IsShowTips = false;
            this.ucBtnSave.Location = new System.Drawing.Point(92, 519);
            this.ucBtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnSave.Name = "ucBtnSave";
            this.ucBtnSave.RectColor = System.Drawing.Color.SeaGreen;
            this.ucBtnSave.RectWidth = 1;
            this.ucBtnSave.Size = new System.Drawing.Size(149, 47);
            this.ucBtnSave.TabIndex = 38;
            this.ucBtnSave.TabStop = false;
            this.ucBtnSave.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnSave.TipsText = "";
            this.ucBtnSave.BtnClick += new System.EventHandler(this.ucBtnSave_BtnClick);
            // 
            // dtpEdAdm
            // 
            this.dtpEdAdm.Location = new System.Drawing.Point(199, 449);
            this.dtpEdAdm.Name = "dtpEdAdm";
            this.dtpEdAdm.Size = new System.Drawing.Size(200, 34);
            this.dtpEdAdm.TabIndex = 37;
            // 
            // dtpEdBir
            // 
            this.dtpEdBir.Location = new System.Drawing.Point(199, 382);
            this.dtpEdBir.Name = "dtpEdBir";
            this.dtpEdBir.Size = new System.Drawing.Size(200, 34);
            this.dtpEdBir.TabIndex = 36;
            // 
            // cmbEdCollege
            // 
            this.cmbEdCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdCollege.FormattingEnabled = true;
            this.cmbEdCollege.Location = new System.Drawing.Point(199, 314);
            this.cmbEdCollege.MaxLength = 11;
            this.cmbEdCollege.Name = "cmbEdCollege";
            this.cmbEdCollege.Size = new System.Drawing.Size(202, 35);
            this.cmbEdCollege.TabIndex = 35;
            // 
            // cmbEdClass
            // 
            this.cmbEdClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdClass.FormattingEnabled = true;
            this.cmbEdClass.Location = new System.Drawing.Point(199, 246);
            this.cmbEdClass.Name = "cmbEdClass";
            this.cmbEdClass.Size = new System.Drawing.Size(202, 35);
            this.cmbEdClass.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "入学日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "出生日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "系所：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 30;
            this.label6.Text = "班级：";
            // 
            // cmbEdGender
            // 
            this.cmbEdGender.FormattingEnabled = true;
            this.cmbEdGender.Location = new System.Drawing.Point(199, 178);
            this.cmbEdGender.MaxLength = 1;
            this.cmbEdGender.Name = "cmbEdGender";
            this.cmbEdGender.Size = new System.Drawing.Size(202, 35);
            this.cmbEdGender.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "性别：";
            // 
            // txtEdSname
            // 
            this.txtEdSname.DecLength = 2;
            this.txtEdSname.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtEdSname.Location = new System.Drawing.Point(199, 111);
            this.txtEdSname.MaxLength = 10;
            this.txtEdSname.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtEdSname.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtEdSname.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtEdSname.Name = "txtEdSname";
            this.txtEdSname.OldText = "";
            this.txtEdSname.PromptColor = System.Drawing.Color.Gray;
            this.txtEdSname.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEdSname.PromptText = "";
            this.txtEdSname.RegexPattern = "";
            this.txtEdSname.Size = new System.Drawing.Size(202, 34);
            this.txtEdSname.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "姓名：";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(14, 586);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 14);
            this.panel4.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(486, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 586);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 586);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 14);
            this.panel1.TabIndex = 22;
            // 
            // txtEdSID
            // 
            this.txtEdSID.DecLength = 2;
            this.txtEdSID.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtEdSID.Location = new System.Drawing.Point(199, 44);
            this.txtEdSID.MaxLength = 11;
            this.txtEdSID.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtEdSID.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtEdSID.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtEdSID.Name = "txtEdSID";
            this.txtEdSID.OldText = "";
            this.txtEdSID.PromptColor = System.Drawing.Color.Gray;
            this.txtEdSID.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEdSID.PromptText = "";
            this.txtEdSID.RegexPattern = "";
            this.txtEdSID.Size = new System.Drawing.Size(202, 34);
            this.txtEdSID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "学号：";
            // 
            // FrmEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.ucBtnClose);
            this.Controls.Add(this.ucBtnSave);
            this.Controls.Add(this.dtpEdAdm);
            this.Controls.Add(this.dtpEdBir);
            this.Controls.Add(this.cmbEdCollege);
            this.Controls.Add(this.cmbEdClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEdGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdSname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEdSID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditStudent";
            this.Load += new System.EventHandler(this.FrmEditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCBtnExt ucBtnClose;
        private HZH_Controls.Controls.UCBtnExt ucBtnSave;
        private System.Windows.Forms.DateTimePicker dtpEdAdm;
        private System.Windows.Forms.DateTimePicker dtpEdBir;
        private System.Windows.Forms.ComboBox cmbEdCollege;
        private System.Windows.Forms.ComboBox cmbEdClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEdGender;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.TextBoxEx txtEdSname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.TextBoxEx txtEdSID;
        private System.Windows.Forms.Label label1;
    }
}