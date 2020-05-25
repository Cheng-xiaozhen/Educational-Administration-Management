using EAM.DAL;
using EAM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.BLL
{
    public class TeacherBLL
    {
        TeacherDAL dal = new TeacherDAL();

        /// <summary>
        /// 根据用户的账号密码，判断是否登录成功
        /// </summary>
        /// <param name="id">账号</param>
        /// <param name="pwd">密码</param>
        /// <param name="msg">提示信息</param>
        /// <returns>成功与否</returns>
        public bool GetTeacherInfo(string id,string pwd,out string msg)
        {
            Teacher teacher = dal.GetTeacherInfo(id);
            if (teacher!=null)
            {
                if (teacher.PassWord==MD5Encode.GetMd5(pwd))
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
        /// 根据id获得，教师对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>教师对象</returns>
        public Teacher GetTeacher(string id)
        {
            return dal.GetTeacherInfo(id);
        }


        /// <summary>
        /// 修改教师信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool EditTeacher(Teacher t)
        {
            return dal.EditTeacher(t)>0;
        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="pwd">新密码</param>
        /// <param name="id">教师ID</param>
        /// <returns></returns>
        public bool EditPwd(string pwd, string id)
        {
            return dal.EditPwd(pwd, id)>0;
        }
    }
}
