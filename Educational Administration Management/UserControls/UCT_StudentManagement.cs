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
using HZH_Controls.Forms;
using System.Runtime.Remoting.Contexts;
using EAM.Model;

namespace Educational_Administration_Management.UserControls
{
    public partial class UCT_StudentManagement : UserControl
    {
        public UCT_StudentManagement()
        {
            InitializeComponent();
        }

        private void UCT_StudentManagement_Load(object sender, EventArgs e)
        {
            LoadStudentInfo();
        }
        StudentBLL bll = new StudentBLL();
        private void LoadStudentInfo()
        {

            dataGridView1.DataSource = bll.GetAllStudents();
            dataGridView1.AutoGenerateColumns = false;
             if (dataGridView1.Rows.Count>0)
            {
               
                dataGridView1.Rows[0].Selected = false;
            }
            for (int i = 8; i < dataGridView1.Columns.Count; i++)
            {
               
                dataGridView1.Columns[i].Visible = false;
            }
            dataGridView1.Columns[1].Visible = false;
        }

        //添加学生
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddStudent frmAdd = new FrmAddStudent();
            frmAdd.FormClosed += new FormClosedEventHandler(frmAdd_FormClosed);
            frmAdd.ShowDialog();
        }

        private void frmAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadStudentInfo();
        }

        //删除学生
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                string sid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                StudentBLL bll = new StudentBLL();
                string msg = bll.DeleteStudentInfo(sid)?"删除成功":"删除失败";
                MessageBox.Show(msg);
                LoadStudentInfo();
            }
            else
            {
                MessageBox.Show("请选择要删除的行");
            }

        }


        //修改学生
        public event EventHandler evtFes;
        FrmEventArgs fea = new FrmEventArgs();
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                string sid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                StudentBLL bll = new StudentBLL();
                fea.Obj = bll.GetStudentBySid(sid);

                FrmEditStudent frmEdit = new FrmEditStudent();
                this.evtFes += new EventHandler(frmEdit.SetTxt);
                if (this.evtFes!=null)
                {
                    this.evtFes(this, fea);
                    frmEdit.FormClosed += new FormClosedEventHandler(frmAdd_FormClosed);
                    frmEdit.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("请选中要修改的学生");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        //查询学生
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string info = textBox1.Text;
            StudentBLL bll = new StudentBLL();

            List<Student> list = bll.GetStudentsByInfo(info);
            if (list.Count>0)
            {
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("没有查询到相应的学生");
            }
        }
    }
}
