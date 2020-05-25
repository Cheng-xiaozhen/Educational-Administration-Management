using EAM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Administration_Management
{
    public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 frm = new Form1();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Teacher t = frm.Tag as Teacher;

                Application.Run(new FrmTeacherMain(ref t));
            }
            else if (frm.DialogResult == DialogResult.Yes)
            {
                Student s = frm.Tag as Student;
                Application.Run(new FrmStudentMain(s));
            }

            // Application.Run(new Form1());
        }
    }
}
