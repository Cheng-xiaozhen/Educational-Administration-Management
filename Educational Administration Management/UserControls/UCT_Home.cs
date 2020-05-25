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

namespace Educational_Administration_Management.UserControls
{
    public partial class UCT_Home : UserControl
    {
        private Teacher teacher;
        public UCT_Home(Teacher t)
        {
            InitializeComponent();
            teacher = t;
        }

        private void UCT_Home_Load(object sender, EventArgs e)
        {
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
    }
}
