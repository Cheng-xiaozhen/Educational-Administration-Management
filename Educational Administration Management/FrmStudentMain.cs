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
    public partial class FrmStudentMain : Form
    {
        private Student student;

        public FrmStudentMain(Student student)
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            this.student = student;
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            // this.Dispose();
            Application.Exit();
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FrmStudentMain_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome : " + student.SName;
            lblID.Text = student.SID;
            lblName.Text = student.SName;
            lblGender.Text = student.SGender;
            lblBir.Text = student.Birthday.ToString("yyy/MM/dd");
            lblAdm.Text = student.AdmissionTime.ToString("yyy/MM/dd");
            lblDep.Text = student.Departments;
            lblClass.Text = student.Class;
            lblAge.Text = (DateTime.Now.Year - student.Birthday.Year).ToString();

            List<College> colList = new CollegeBLL().GetColleges();
            foreach (var item in colList)
            {
                if (item.COID==lblDep.Text)
                {
                    lblDep.Text = item.COName;
                    break;
                }
            }

            List<Class> claList = new ClassBLL().GetClasses();
            foreach (var item in claList)
            {
                if (item.CLID==lblClass.Text)
                {
                    lblClass.Text = item.CLName;
                    break;
                }
            }

            if (student.Image!=null)
            {
                UserImage.Image = student.Image;
            }
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSetting);
            UCT_Setting setting = new UCT_Setting();
            AddControlsToPanel(setting);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UCS_Home home = new UCS_Home(student);
            AddControlsToPanel(home);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnEdit);
            UCS_Edit edit = new UCS_Edit(student);
            AddControlsToPanel(edit);
        }

        private void btnScoreManagement_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnScoreManagement);
            UCS_Score score = new UCS_Score(student.SID);
            AddControlsToPanel(score);
        }

        private void btnCourseManagement_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCourseManagement);
            UCS_Course course = new UCS_Course(student.SID);
            AddControlsToPanel(course);
        }

    }
}
