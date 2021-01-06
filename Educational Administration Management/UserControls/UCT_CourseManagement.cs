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
using System.Threading;
using HZH_Controls.Forms;

namespace Educational_Administration_Management.UserControls
{
    public partial class UCT_CourseManagement : UserControl
    {
        private Teacher teacher;
        public UCT_CourseManagement(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        private void UCT_CourseManagement_Load(object sender, EventArgs e)
        {
            LoadCourseInfo();

            LoadScoreInfo();
           // StudentBLL bll = new StudentBLL();
            //dataGridView2.DataSource = bll.GetAllStudents();
        }

        int pageIndex = 1, pageSize = 16;
        string pageCount;
        string recordCount;
        //加载学生成绩信息
        private void LoadScoreInfo()
        {
            ScoreBLL bll = new ScoreBLL();
           
           
            dataGridView2.DataSource = bll.GetScores(teacher.TID,out pageCount,out recordCount,pageIndex,pageSize);

            label1.Text = "共有" + pageCount + "页，共有" + recordCount + "条记录";

        }

        //加载课程信息
        private void LoadCourseInfo()
        {
            CourseBLL bll = new CourseBLL();
            dataGridView1.DataSource = bll.GetCourses(teacher.TID);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }

        //删除课程
        private void ucBtnDelete_BtnClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                string sid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                CourseBLL bll = new CourseBLL();
                string msg = bll.DeleteCourse(sid) ? "删除成功" : "删除失败";
                MessageBox.Show(msg);
                LoadCourseInfo();
            }
            else
            {
                MessageBox.Show("请选中要删除的行");
            }
        }

        //添加课程
        private void ucBtnAdd_BtnClick(object sender, EventArgs e)
        {
            if (!Check.isCourse(textBox1.Text))
            {
                MessageBox.Show("课程号错误");
                return;
            }

            string cid = textBox1.Text;
            string cname = textBox2.Text;

            Course course = new Course()
            {
                CID=cid,
                CName=cname,
                Departments=teacher.Departments,
                CTeacher=teacher.TID
            };
            CourseBLL bll = new CourseBLL();
           if (bll.AddCourse(course))
            {
                MessageBox.Show("添加成功");
                LoadCourseInfo();
                textBox1.Text = "";
                textBox2.Text = "";
            }
           else
            {
                MessageBox.Show("添加失败");
            }

        }

        //上一页
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            pageIndex--;
            if (pageIndex<1)
            {
                pageIndex = 1;
            }
            label2.Text = "当前为第" + pageIndex + "页";
            LoadScoreInfo();
        }

        //下一页
        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            pageIndex++;
            if (pageIndex>Convert.ToInt32(pageCount))
            {
                pageIndex = Convert.ToInt32(pageCount);
            }
            label2.Text = "当前为第" + pageIndex + "页";
            LoadScoreInfo();
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("格式不正确,请输入整数");
            dataGridView2.CancelEdit();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            string sid="";
            string cid="";
            int score=0;
            try
            {
                 sid = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                 cid = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                 score = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("录入失败");
                return;
            }

            //这个判断看起来，有些智障，不过 就先这样吧
            if (score < 0 || score > 100)
            {
                MessageBox.Show("输入错误");
                return;
            }

            ScoreBLL bll = new ScoreBLL();
            if (!bll.UpdateScore(score,sid,cid))
            {

                MessageBox.Show("录入失败");
            }
        }
    }
}
