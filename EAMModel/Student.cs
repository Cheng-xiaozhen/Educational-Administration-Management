using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.Model
{
    public class Student
    {
        public string SID { get; set; }

        public string  PassWord { get; set; }

        public string SName { get; set; }

        public string SGender { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime AdmissionTime { get; set; }

        public string Departments { get; set; }

        public string Class { get; set; }

        public Bitmap Image { get; set; }
    }
}
