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
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            ucSwitch1.Texts = new string[] { "教师", "学生" };
            ucSwitch1.Font = new Font("微软雅黑", 10, FontStyle.Bold);

            ucSwitch1.FalseColor = Color.DarkBlue;
        }

        #region 使窗体可以移动
        private bool formMove = false; //窗体是否移动
        private Point formPoint; //记录窗体的位置


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point();
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                formPoint = new Point(xOffset, yOffset);
                formMove = true; //开始移动
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  //如果按下的是鼠标左键
            {
                formMove = false; //停止移动
            }
        }
        #endregion


        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// 弹出FrmAuthor窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
           try
            {
                using (FrmAuthor frmAuthor = new FrmAuthor())
                {
                    frmAuthor.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        public event EventHandler evtFt;
        FrmEventArgs fea = new FrmEventArgs();

        
        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||string.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }
            string msg;
            string id = textBox1.Text.Trim();
            string pwd = textBox2.Text.Trim();

            if (ucSwitch1.Checked)
            {
               
                TeacherBLL bll = new TeacherBLL();
                Boolean b = bll.GetTeacherInfo(id, pwd, out msg);
                if (b)
                {
                    //FrmTips.ShowTipsSuccess(this, msg);
                    //fea.Obj = bll.GetTeacher(id);
                    //FrmTeacherMain frmTeacher = new FrmTeacherMain();
                    //this.evtFt += new EventHandler(frmTeacher.SetTxt);
                    //if (this.evtFt!=null)
                    //{
                    //    this.evtFt(this, fea);

                    //    frmTeacher.ShowDialog();

                    //}
                    FrmTips.ShowTipsSuccess(this, msg);
                    this.Tag = bll.GetTeacher(id);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    FrmTips.ShowTipsError(this, msg);
                }
            }
            else
            {
                StudentBLL bll = new StudentBLL();
                Student stu = new Student();
                bool b = bll.getStudentInfoBySid(id, pwd, out msg,out stu);
                if (b)
                {
                    this.Tag = stu;
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    FrmTips.ShowTipsError(this, msg);
                }
            }
        }
    }
}
