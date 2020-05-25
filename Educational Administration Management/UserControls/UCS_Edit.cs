using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAM.Model;
using EAM.BLL;
using System.IO;
using HZH_Controls.Forms;
using HZH_Controls.Controls;

namespace Educational_Administration_Management.UserControls
{
    public partial class UCS_Edit : UserControl
    {
        private Student student;

        public UCS_Edit(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        //加载下拉框的类别
        private void LoadCollegeInfo()
        {
            CollegeBLL bll = new CollegeBLL();
            List<College> list = bll.GetColleges();
            list.Insert(0, new College() { COName = "请选择", COID = "" });
            cmbDepart.DataSource = list;
            cmbDepart.DisplayMember = "COName";
            cmbDepart.ValueMember = "COID";
        }

        private void LoadClassInfo()
        {
            ClassBLL bll = new ClassBLL();
            List<Class> list = bll.GetClasses();
            list.Insert(0, new Class() { CLName = "请选择", CLID = "" });
            cmbClass.DataSource = list;
            cmbClass.DisplayMember = "CLName";
            cmbClass.ValueMember = "CLID";
        }

        private void UCS_Edit_Load(object sender, EventArgs e)
        {
            LoadClassInfo();
            LoadCollegeInfo();
            cmbGender.Items.Add("男");
            cmbGender.Items.Add("女");

            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            if (student.Image != null)
            {
                pictureBox1.Image = student.Image;
            }
            txtName.Text = student.SName;
            txtTID.Text = student.SID;
            txtAge.Text = (DateTime.Now.Year - student.Birthday.Year).ToString();

            dtpBir.Value = student.Birthday;
            dtpAdmission.Value = student.AdmissionTime;
            //cmbGender.SelectedValue = teacher.TGender;

            cmbGender.Text = student.SGender;
            cmbDepart.SelectedValue = student.Departments;
            cmbClass.SelectedValue = student.Class;
        }

        private void ucBtnPost_BtnClick(object sender, EventArgs e)
        {
            //初始化打开文件 对话框
            OpenFileDialog ofdlgTest = new OpenFileDialog();
            ofdlgTest.Filter = ".jpg文件|*.jpg;*.JPG|.png文件|*.png;*.PNG";   //文件过滤 筛选可以打开的文件
            ofdlgTest.Multiselect = false;    //设置不可以选择多个文件

            //显示文件打开对话框
            DialogResult result = ofdlgTest.ShowDialog();

            //
            if (result == DialogResult.OK)                   //判断是否打开文件
            {
                pictureBox1.Image = Image.FromFile(ofdlgTest.FileName);


                // byte[] buffer;
                using (FileStream stream = new FileStream(ofdlgTest.FileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    // buffer = new byte[stream.Length];
                    // stream.Read(buffer, 0, buffer.Length);

                    student.Image = new Bitmap(stream);

                }
            }
        }

        private void ucBtnSave_BtnClick(object sender, EventArgs e)
        {
            if (!Check.isStudentID(txtTID.Text))
            {
                MessageBox.Show("学号不正确");
                return;
            }

            try
            {
                student.SID = txtTID.Text;
                student.SName = txtName.Text;


                student.SGender = cmbGender.Text;
                student.Departments = cmbDepart.SelectedValue.ToString();
                student.Class = cmbClass.SelectedValue.ToString();
                student.Birthday = Convert.ToDateTime(dtpBir.Value.ToString("yyy/MM/dd"));
                student.AdmissionTime = Convert.ToDateTime(dtpAdmission.Value.ToString("yyy/MM/dd"));

                student.Image = (Bitmap)pictureBox1.Image;
                StudentBLL bll = new StudentBLL();
                string msg = bll.EditStudent(student) ? "修改成功" : "修改失败";
                MessageBox.Show(msg);

                LoadStudentInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败");
            }
        }

        private void ucBtnChangePwd_BtnClick(object sender, EventArgs e)
        {
            FrmInputs frm = new FrmInputs("修改密码",
                 new string[] { "旧密码", "新密码", "确定密码" },
                 new Dictionary<string, HZH_Controls.TextInputType>() { },
                new Dictionary<string, string>() { },
                new Dictionary<string, KeyBoardType>() { { "旧密码", KeyBoardType.UCKeyBorderAll_EN }, { "新密码", KeyBoardType.UCKeyBorderAll_EN } },
                new List<string>() { "旧密码", "新密码", "确定密码" });
            frm.ShowDialog(this);
            if (frm.DialogResult == DialogResult.OK)
            {
                string oldPwd = frm.Values[0];
                string newPwd = frm.Values[1];
                string comPwd = frm.Values[2];
                if (newPwd != comPwd)
                {
                    MessageBox.Show("两次密码不一致");
                    return;
                }
                if (MD5Encode.GetMd5(oldPwd) == student.PassWord)
                {
                    StudentBLL bll = new StudentBLL();
                    string msg = bll.EditPwd(MD5Encode.GetMd5(newPwd), student.SID) ? "修改成功" : "修改失败";
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show("原密码错误");
                }
            }
        }
    }
}
