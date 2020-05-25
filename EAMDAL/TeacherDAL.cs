using EAM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace EAM.DAL
{
    public class TeacherDAL
    {

        /// <summary>
        /// 根据输入的用户名查询 用户
        /// </summary>
        /// <param name="ID">用户名</param>
        /// <returns>用户对象</returns>
        public Teacher GetTeacherInfo(string ID)
        {
            string sql = "select * from Teacher where TID=@Id";
            SqlParameter pms = new SqlParameter("@Id", SqlDbType.VarChar, 11) { Value = ID };
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text, pms);
            Teacher teacher = null;
            if (dt.Rows.Count>0)
            {
                teacher = RowToTeacherInfo(dt.Rows[0]);
            }
            return teacher;
        }

        //将查到的一行数据 转换为一个对象
        private Teacher RowToTeacherInfo(DataRow dr)
        {
            Teacher tea = new Teacher();
            tea.TID = dr["TID"].ToString();
            tea.PassWord = dr["PassWord"].ToString();
            tea.TName = dr["TName"].ToString();
            tea.TGender = (Convert.ToBoolean(dr["TGender"])) ? "男" : "女";
            tea.Birthday = Convert.ToDateTime(dr["Birthday"]);
            tea.AdmissionTime = Convert.ToDateTime(dr["AdmissionTime"]);
            tea.Departments = dr["Departments"].ToString();
            tea.TSalary = Convert.ToDecimal(dr["TSalary"]);
            tea.Address = dr["Address"].ToString();

            if (!dr.IsNull("Image"))
            {
                byte[] imageByte = (byte[])dr["Image"];
                MemoryStream stream = new MemoryStream(imageByte);
                tea.Image = new Bitmap(stream);
            }


            return tea;
        }

        /// <summary>
        /// 修改教师信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int EditTeacher(Teacher t)
        {
            string sql = "update Teacher set TName=@name,TGender=@gender,Birthday=@bir,AdmissionTime=@adm,Departments=@depart,TSalary=@salary,Image=@image,Address=@add where TID=@ID";
            byte[] buffer;
            using(MemoryStream ms=new MemoryStream())
            {
                t.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                buffer = ms.GetBuffer();
            }
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@ID",t.TID),
                new SqlParameter("@name",t.TName),
                new SqlParameter("@gender", SqlDbType.Bit){Value=t.TGender=="男"?true:false},
                new SqlParameter("@bir", SqlDbType.DateTime){Value=t.Birthday},
                new SqlParameter("@adm", SqlDbType.Date){Value=t.AdmissionTime},
                new SqlParameter("@depart", t.Departments),
                new SqlParameter("@salary",t.TSalary),
                new SqlParameter("@add",t.Address),
                new SqlParameter("@image", SqlDbType.Image){Value=buffer}
            };

            try
            {
                return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pms);
            }
            catch (Exception)
            {

                return 0;
            }
        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="pwd">新密码</param>
        /// <param name="id">教师ID</param>
        /// <returns></returns>
        public int EditPwd(string pwd,string id)
        {
            string sql = "update Teacher set PassWord=@pwd where TID=" + id;
            SqlParameter pms = new SqlParameter("@pwd", pwd);
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pms);
        }
    }
}
