using EAM.DAL;
using EAM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.BLL
{
   public  class StudentBLL
    {
        StudentDAL dal = new StudentDAL();

        /// <summary>
        /// 获得所有学生信息
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAllStudents()
        {
            return dal.GetAllStudents();
        }


        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="student">学生对象</param>
        /// <returns>成功与否</returns>
        public bool AddStudentInfo(Student student)
        {
            return dal.AddStudentInfo(student)>0;
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="student">学生对象</param>
        /// <returns>成功与否</returns>
        public bool UpdateStudentInfo(Student student)
        {
            return dal.UpdateStudentInfo(student) > 0;
        }

        /// <summary>
        /// 根据学号，删除相应的学生
        /// </summary>
        /// <param name="sid">学号</param>
        /// <returns>所影响的行数</returns>
        public bool DeleteStudentInfo(string sid)
        {
            return dal.DeleteStudentInfo(sid) > 0;
        }

        /// <summary>
        /// 根据学号查询学生信息
        /// </summary>
        /// <param name="sid">学号</param>
        /// <returns>学生对象</returns>
        public Student GetStudentBySid(string sid)
        {
            return dal.GetStudentBySid(sid);
        }


        /// <summary>
        /// 根据查询条件，查找相应的学生
        /// </summary>
        /// <param name="info">条件</param>
        /// <returns>查到的学生</returns>
        public List<Student> GetStudentsByInfo(string info)
        {
            return dal.GetStudentsByInfo(info);
        }



        /// <summary>
        /// 登录时，根据用户名查询相应的对象信息
        /// </summary>
        /// <param name="sid">用户名</param>
        /// <returns></returns>
        public bool getStudentInfoBySid(string sid, string pwd, out string msg,out Student stu)
        {
             stu = dal.getStudentInfoBySid(sid);
            if (stu != null)
            {
                if (stu.PassWord == MD5Encode.GetMd5(pwd))
                {
                    msg = "登录成功";
                    return true;
                }
                else
                {
                    msg = "密码错误";
                    return false;

                }
            }
            else
            {
                msg = "该用户不存在";
                return false;
            }
        }


        /// <summary>
        /// 登录时，根据学号获得相应的对象
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public Student getStudent(string sid)
        {
            return dal.getStudentInfoBySid(sid);
        }


        /// <summary>
        /// 学生修改个人信息
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool EditStudent(Student student)
        {
            return dal.EditStudent(student) > 0;
        }


        /// <summary>
        /// 学生修改密码
        /// </summary>
        /// <param name="pwd"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool EditPwd(string pwd, string id)
        {
            return dal.EditPwd(pwd, id) > 0;
        }
    }
}
