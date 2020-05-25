using EAM.BLL;
using EAM.Model;
using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Administration_Management
{
    public partial class FrmEditStudent : Form
    {
        public FrmEditStudent()
        {
            InitializeComponent();
        }

        private Student stu;
        public void SetTxt(object sender,EventArgs e)
        {
            FrmEventArgs fea = e as FrmEventArgs;
             stu = fea.Obj as Student;
          //  stu.Departments = "1";

            txtEdSID.Text = stu.SID;
            txtEdSname.Text = stu.SName;
            dtpEdAdm.Value = Convert.ToDateTime(stu.AdmissionTime);
            dtpEdBir.Value = Convert.ToDateTime(stu.Birthday);
            cmbEdGender.Text = stu.SGender;
            // cmbEdGender.SelectedItem = stu.SGender;
            //cmbEdCollege.SelectedValue = stu.Departments;
            //MessageBox.Show(cmbEdGender.SelectedIndex.ToString());
            //cmbEdClass.SelectedValue = stu.Class;
        }

        private void FrmEditStudent_Load(object sender, EventArgs e)
        {
            //加载下拉框的类别
            LoadClassInfo();
            LoadCollegeInfo();

            cmbEdGender.Items.Add("男");
            cmbEdGender.Items.Add("女");

            cmbEdCollege.SelectedValue = stu.Departments;
            cmbEdClass.SelectedValue = stu.Class;
        }
        //加载下拉框的类别
        private void LoadCollegeInfo()
        {
            CollegeBLL bll = new CollegeBLL();
            List<College> list = bll.GetColleges();
            list.Insert(0, new College() { COName = "请选择", COID = "" });
            cmbEdCollege.DataSource = list;
            cmbEdCollege.DisplayMember = "COName";
            cmbEdCollege.ValueMember = "COID";
        }

        //加载下拉框的类别
        private void LoadClassInfo()
        {
            ClassBLL bll = new ClassBLL();
            List<Class> list = bll.GetClasses();
            list.Insert(0, new Class() { CLName = "请选择", CLID = "" });
            cmbEdClass.DataSource = list;
            cmbEdClass.DisplayMember = "CLName";
            cmbEdClass.ValueMember = "CLID";
        }

        private void ucBtnClose_BtnClick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //保存按钮
        private void ucBtnSave_BtnClick(object sender, EventArgs e)
        {
            bool b;
            if (!Check.isStudentID(txtEdSID.Text))
            {
                b = false;
                FrmTips.ShowTipsWarning(this, "学号格式不正确");
                return;
            }

            try
            {
                Student stu = new Student();
                stu.SName = txtEdSname.Text;
                stu.SID = txtEdSID.Text;
                stu.SGender = cmbEdGender.Text;
                stu.Class = cmbEdClass.SelectedValue.ToString();
                stu.Departments = cmbEdCollege.SelectedValue.ToString();
                stu.Birthday = Convert.ToDateTime(dtpEdBir.Value.ToString("yyy/MM/dd"));
                stu.AdmissionTime = Convert.ToDateTime(dtpEdAdm.Value.ToString("yyy/MM/dd"));
                stu.Image = null;

                StudentBLL bll = new StudentBLL();
                b = bll.UpdateStudentInfo(stu);
            }
            catch (Exception)
            {
                b = false;
            }

            if (b)
            {
                FrmTips.ShowTipsSuccess(this, "修改成功");
            }
            else
            {
                FrmTips.ShowTipsError(this, "修改失败");
            }
          

        }
    }
}
