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
using System.Security.Cryptography;

namespace Educational_Administration_Management.UserControls
{
    public partial class UCT_Edit : UserControl
    {
        private Teacher teacher;
        public UCT_Edit(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        private void UCT_Edit_Load(object sender, EventArgs e)
        {
            //加载下拉框类别
            LoadCollegeInfo();

            
            cmbGender.Items.Add("男");
            cmbGender.Items.Add("女");
            

            LoadTeacherInfo();
        }

        private void LoadTeacherInfo()
        {
           if (teacher.Image!=null)
            {
                pictureBox1.Image = teacher.Image; 
            }
            txtName.Text = teacher.TName;
            txtTID.Text = teacher.TID;
            txtTSalary.Text = teacher.TSalary.ToString();
            txtAddress.Text = teacher.Address;
            dtpBir.Value = teacher.Birthday;
            dtpAdmission.Value = teacher.AdmissionTime;
            //cmbGender.SelectedValue = teacher.TGender;

            cmbGender.Text = teacher.TGender;
            cmbDepart.SelectedValue = teacher.Departments;
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

        //上传图片
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
                 using(FileStream stream=new FileStream(ofdlgTest.FileName,FileMode.OpenOrCreate,FileAccess.Read))
                {
                    // buffer = new byte[stream.Length];
                    // stream.Read(buffer, 0, buffer.Length);

                    teacher.Image = new Bitmap(stream);
                    
                }
            }

        }


        //确定修改
        private void ucBtnSave_BtnClick(object sender, EventArgs e)
        {
            if (!Check.isTeacherID(txtTID.Text))
            {
                MessageBox.Show("工号不正确");
                return;
            }

            try
            {
                teacher.TID = txtTID.Text;
                teacher.TName = txtName.Text;
                teacher.Address = txtAddress.Text;
                teacher.TSalary = Convert.ToDecimal(txtTSalary.Text);
                teacher.TGender = cmbGender.Text;
                teacher.Departments = cmbDepart.SelectedValue.ToString();
                teacher.Birthday = Convert.ToDateTime(dtpBir.Value.ToString("yyy/MM/dd"));
                teacher.AdmissionTime = Convert.ToDateTime(dtpAdmission.Value.ToString("yyy/MM/dd"));

                teacher.Image = (Bitmap)pictureBox1.Image;
                TeacherBLL bll = new TeacherBLL();
                string msg = bll.EditTeacher(teacher) ? "修改成功" : "修改失败";
                MessageBox.Show(msg);

                LoadTeacherInfo();
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
            if (frm.DialogResult== DialogResult.OK)
            {
                string oldPwd = frm.Values[0];
                string newPwd = frm.Values[1];
                string comPwd = frm.Values[2];
                if (newPwd!=comPwd)
                {
                    MessageBox.Show("两次密码不一致");
                    return;
                }

               //if (!Check.isPwd(newPwd))
               // {
               //     MessageBox.Show("密码最少6位，包括至少1个大写字母，1个小写字母，1个数字，1个特殊字符");
               //     return;
               // }

                if (MD5Encode.GetMd5(oldPwd)==teacher.PassWord)
                {
                    TeacherBLL bll = new TeacherBLL();
                    string msg = bll.EditPwd(MD5Encode.GetMd5(newPwd), teacher.TID)?"修改成功":"修改失败";
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
