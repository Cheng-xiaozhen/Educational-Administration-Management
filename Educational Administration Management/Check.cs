using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Educational_Administration_Management
{
    public static class Check
    { 
        public static bool isStudentID(string id)
        {
            return Regex.IsMatch(id, @"^2020[0-9]{4,7}$");
        }

        public static bool isTeacherID(string id)
        {
            return Regex.IsMatch(id, @"2018[0-9]{4,7}");
        }

        public static bool isScore(string score)
        {
            return Regex.IsMatch(score, @"^(100|[0-9]?[0-9]?)$");
        }

        public static bool isPwd(string pwd)
        {
            return Regex.IsMatch(pwd, @"^.*(?=.{6,11})(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$%^&*? ]).*$");
        }

        public static bool isCourse(string cid)
        {
            return Regex.IsMatch(cid, @"^10[0-9]{2}$");
        }
    }
}
