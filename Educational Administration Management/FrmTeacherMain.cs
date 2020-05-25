using EAM.BLL;
using EAM.Model;
using Educational_Administration_Management.UserControls;
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
    public partial class FrmTeacherMain : Form
    {
        private Teacher teacher;

        public FrmTeacherMain(ref Teacher t)
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;

            teacher = t;
        }

        #region 移动窗体
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;


        private void panelControls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        private void FrmTeacherMain_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome : " + teacher.TName;
            lblAddress.Text = teacher.Address;
            lblBir.Text = teacher.Birthday.ToString("yyy/MM/dd");
            lblAdm.Text = teacher.AdmissionTime.ToString("yyy/MM/dd");
           
            lblGender.Text = teacher.TGender;
            lblID.Text = teacher.TID;
            lblMoney.Text = teacher.TSalary.ToString();
            lblName.Text = teacher.TName;

            lblDep.Text = teacher.Departments.ToString();
            CollegeBLL bll = new CollegeBLL();
            List<College> list = bll.GetColleges();
            foreach (var item in list)
            {
                if (item.COID==lblDep.Text)
                {
                    lblDep.Text = item.COName;
                    break;
                }
            }


            if (teacher.Image!=null)
            {
                UserImage.Image = teacher.Image;
            }
        }

        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            Application.Exit();
        }

        #region 面板移动
        private int PanelWidth;
        private bool isCollapsed;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 20;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 20;
                if (panelLeft.Width <= 65)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        #endregion

        /// <summary>
        /// 菜单按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        #region 按钮事件
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UCT_Home home = new UCT_Home(teacher);
            AddControlsToPanel(home);
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnStudentManagement);
            UCT_StudentManagement stuMa = new UCT_StudentManagement();
            AddControlsToPanel(stuMa);
        }

        private void btnCourseManagement_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCourseManagement);
            UCT_CourseManagement uCT_CourseManagement = new UCT_CourseManagement(teacher);
            AddControlsToPanel(uCT_CourseManagement);
        }

        private void btnScoreManagement_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnScoreManagement);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnEdit);
            UCT_Edit edit = new UCT_Edit(teacher);
            AddControlsToPanel(edit);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSetting);
            UCT_Setting setting = new UCT_Setting();
            AddControlsToPanel(setting);
        }
        #endregion

       


        public void SetTxt(object sender,EventArgs e)
        {
            FrmEventArgs fea = e as FrmEventArgs;

             teacher = fea.Obj as Teacher;

        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
    }
}
