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
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        //窗体加载
        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            //加载下拉框的类别
            LoadClassInfo();
            LoadCollegeInfo();

            cmbGender.Items.Add("男");
            cmbGender.Items.Add("女");
        }

        //加载下拉框的类别
        private void LoadCollegeInfo()
        {
            CollegeBLL bll = new CollegeBLL();
            List<College> list = bll.GetColleges();
            list.Insert(0, new College() { COName = "请选择", COID ="" });
            cmbCollege.DataSource = list;
            cmbCollege.DisplayMember = "COName";
            cmbCollege.ValueMember = "COID";
        }

        //加载下拉框的类别
        private void LoadClassInfo()
        {
            ClassBLL bll = new ClassBLL();
            List<Class> list = bll.GetClasses();
            list.Insert(0, new Class() { CLName = "请选择", CLID = "" });
            cmbClass.DataSource = list;
            cmbClass.DisplayMember = "CLName";
            cmbClass.ValueMember = "CLID";
        }

        //添加学生
        private void ucBtnSave_BtnClick(object sender, EventArgs e)
        {
            bool b;
            if (!Check.isStudentID(txtSID.Text))
            {
                FrmTips.ShowTipsWarning(this, "学号格式不正确");
                return;
            }

            try
            {
                Student stu = new Student();
                stu.SID = txtSID.Text;
                stu.SName = txtSname.Text;
                stu.PassWord = MD5Encode.GetMd5("123456");    //学生默认密码123456
                stu.SGender = cmbGender.SelectedIndex % 2 == 0 ? "男" : "女";
                stu.Class = cmbClass.SelectedValue.ToString();
                stu.Departments = cmbCollege.SelectedValue.ToString();
                stu.Birthday = Convert.ToDateTime(dtpBir.Value.ToString("yyy/MM/dd"));
                stu.AdmissionTime = Convert.ToDateTime(dtpAdm.Value.ToString("yyy/MM/dd"));
                stu.Image = null;
                StudentBLL bll = new StudentBLL();
                b = bll.AddStudentInfo(stu);
            }
            catch (Exception)
            {
                b = false;
            }

            if (b)
            {
                FrmTips.ShowTipsSuccess(this, "添加成功");
                txtSID.Clear();
                txtSname.Clear();
                txtSID.Focus();
            }
            else
            {
                FrmTips.ShowTipsError(this, "添加失败");
            }

            //MessageBox.Show(cmbGender.SelectedValue.ToString());
            //MessageBox.Show(cmbClass.SelectedValue.ToString());
        }
        //关闭
        private void ucBtnClose_BtnClick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
