using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAM.BLL;
using EAM.Model;

namespace Educational_Administration_Management.UserControls
{
    public partial class UCS_Course : UserControl
    {
        private string sid;
        public UCS_Course(string sid)
        {
            InitializeComponent();
            this.sid = sid;
        }

        private void UCS_Course_Load(object sender, EventArgs e)
        {
            LoadCourse();

            LoadMyCourse();
           
        }

        private void LoadMyCourse()
        {
            CourseBLL bll = new CourseBLL();
            List<Course> list = bll.getMyCourse(sid);
            dataGridView2.DataSource = list;
        }



        private void LoadCourse()
        {
            CourseBLL bll = new CourseBLL();
            List<Course> list = bll.getCourse();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(true)
            {
                string cid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                CourseBLL bll = new CourseBLL();
                bool b = bll.AddStuCourse(sid, cid);
                if (b)
                {
                    MessageBox.Show("选课成功");
                    LoadMyCourse();
                }
                else
                {
                    MessageBox.Show("选课失败");
                }
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (true)
            {
                string cid = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                CourseBLL bll = new CourseBLL();
                bool b = bll.DeleteStuCourse(sid, cid);
                if (b)
                {
                    MessageBox.Show("退课成功");
                    LoadMyCourse();
                }
                else
                {
                    MessageBox.Show("退课失败");
                }
            }
        }
    }
}
