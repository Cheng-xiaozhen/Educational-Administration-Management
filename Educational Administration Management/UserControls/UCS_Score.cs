using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls.Controls;
using EAM.BLL;
using EAM.Model;

namespace Educational_Administration_Management.UserControls
{
    public partial class UCS_Score : UserControl
    {
        private string sid;
        public UCS_Score(string sid)
        {
            InitializeComponent();
            this.sid = sid;
        }

        private void UCS_Score_Load(object sender, EventArgs e)
        {
            LoadScore();

            LoadChart();
        }

        private void LoadChart()
        {
            ScoreBLL bll = new ScoreBLL();
            List<Score> list = bll.getScores(sid);

            List<string> courseList = new List<string>();
            List<double> scoreList = new List<double>();

            foreach (var item in list)
            {
               
                if (item.Grade!=null)
                {
                    scoreList.Add(Convert.ToDouble(item.Grade));
                    courseList.Add(item.CID);
                }               
            }
            chart1.ChartAreas[0].AxisX.Title = "课程";
            chart1.ChartAreas[0].AxisY.Title = "成绩";

            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
            chart1.Series[0].Points.DataBindXY(courseList, scoreList);
           
        }

        private void LoadScore()
        {
            List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "CID", HeadText = "课程名", Width = 70, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Grade", HeadText = "分数", Width = 70, WidthType = SizeType.Percent, Format = (a) => { return ((double?)a) == null ? "暂无成绩" : a.ToString(); } });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "SID", HeadText = "教师", Width = 50, WidthType = SizeType.Percent });
            this.ucDataGridView1.Columns = lstCulumns;
            this.ucDataGridView1.IsShowCheckBox = true;
            this.ucDataGridView1.DataSource = new ScoreBLL().getScores(sid);
            this.ucDataGridView1.First();
        }
    }
}
