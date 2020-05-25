using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.Model
{
    public class Teacher
    {
        public string TID { get; set; }

        public string PassWord { get; set; }

        public string TName { get; set; }

        public string TGender { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime AdmissionTime { get; set; }

        public string Departments { get; set; }

        public decimal TSalary { get; set; }

        public Bitmap Image { get; set; }

        public string Address { get; set; }


    }
}
