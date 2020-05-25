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
    public partial class UCS_Home : UserControl
    {
        private Student student;
        public UCS_Home(Student student)
        {

            InitializeComponent();
            this.student = student;
        }

        private void UCS_Home_Load(object sender, EventArgs e)
        {
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
                if (item.COID == lblDep.Text)
                {
                    lblDep.Text = item.COName;
                    break;
                }
            }

            List<Class> claList = new ClassBLL().GetClasses();
            foreach (var item in claList)
            {
                if (item.CLID == lblClass.Text)
                {
                    lblClass.Text = item.CLName;
                    break;
                }
            }

            if (student.Image != null)
            {
                UserImage.Image = student.Image;
            }
        }
    }
}
