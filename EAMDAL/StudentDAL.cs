using EAM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.DAL
{
   public  class StudentDAL
    {

        /// <summary>
        /// 获得所有学生信息
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAllStudents()
        {
            //string sql = "select StudentID,StudentName,StudentGender,Birthday,AdmissionTime,Departments,Class from Student";
            string sql = "select StudentID,StudentName,StudentGender,Birthday,AdmissionTime,college.COName,class.CLName from Student as student inner join Class as  class on student.Class=class.CLID inner join College as college on student.Departments=college.COID";
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text);
            List<Student> list = null ;
            if (dt.Rows.Count>0)
            {
                list = new List<Student>();
                foreach (DataRow item in dt.Rows)
                {
                    list.Add(RowToStudentInfo(item));
                }
            }
            return list;
        }

        /// <summary>
        /// 将行对象转换成学生对象
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private Student RowToStudentInfo(DataRow dr)
        {
            Student student = new Student();
            student.SID = dr["StudentID"].ToString();
            student.SName = dr["StudentName"].ToString();
            student.SGender = (Convert.ToBoolean(dr["StudentGender"])) ? "男" : "女";
            student.Birthday = Convert.ToDateTime(dr["Birthday"]);
            student.AdmissionTime = Convert.ToDateTime(dr["AdmissionTime"]);
            //student.Departments = dr.IsNull("COName")?dr["Departments"].ToString(): dr["COName"].ToString();
           
           // student.Class = dr.IsNull("CLName")?dr["Class"].ToString():dr["CLName"].ToString();
         


            try
            {
                student.Departments = dr["COName"].ToString();
                student.Class = dr["CLName"].ToString();
            }
            catch (Exception)
            {

                student.Departments = dr["Departments"].ToString();
                student.Class = dr["Class"].ToString();
            }

            //if (dr.Table.Columns.Count == 9)
            //{
            //    student.PassWord = dr["PassWord"].ToString();

            //    byte[] imageByte = (byte[])dr["Image"];
            //    MemoryStream stream = new MemoryStream(imageByte);
            //    student.Image = new Bitmap(stream);
            //}

            return student;

        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="student">学生对象</param>
        /// <returns>所影响的行数</returns>
        public int AddStudentInfo(Student student)
        {
            string sql = "insert into Student (StudentID,PassWord,StudentName,StudentGender,Birthday,AdmissionTime,Departments,Class,Image) values (@SID,@PWD,@SName,@SGender,@Birthday,@AdmissionTime,@Departments,@Class,@Image)";

            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@SID", SqlDbType.VarChar,11){ Value=student.SID},
                new SqlParameter("@PWD", SqlDbType.VarChar,50){ Value=student.PassWord},
                new SqlParameter("@SName", SqlDbType.NVarChar,10){ Value=student.SName},
                new SqlParameter("@SGender", SqlDbType.Bit){Value=student.SGender=="男"?true:false},
                new SqlParameter("@Birthday", SqlDbType.DateTime){Value=student.Birthday},
                new SqlParameter("@AdmissionTime", SqlDbType.DateTime){Value=student.AdmissionTime},
                new SqlParameter("@Departments", SqlDbType.VarChar,11){Value=student.Departments},
                new SqlParameter("@Class", SqlDbType.VarChar,11){ Value=student.Class},
                new SqlParameter("@Image", SqlDbType.Image){Value=DBNull.Value}
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
        /// 修改学生信息
        /// </summary>
        /// <param name="student">学生对象</param>
        /// <returns>所影响的行数</returns>
        public int UpdateStudentInfo(Student student)
        {
            string sql = "Update Student set StudentName=@SName,StudentGender=@SGender,Birthday=@Bir,AdmissionTime=@Admi,Departments=@Depart,Class=@Cla,Image=@Image Where StudentID=@SID";

            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@SID", SqlDbType.VarChar,11){ Value=student.SID},
                //new SqlParameter("@PWD", SqlDbType.VarChar,50){ Value=student.PassWord},
                new SqlParameter("@SName", SqlDbType.NVarChar,10){ Value=student.SName},
                new SqlParameter("@SGender", SqlDbType.Bit){Value=student.SGender=="男"?true:false},
                new SqlParameter("@Bir", SqlDbType.DateTime){Value=student.Birthday},
                new SqlParameter("@Admi", SqlDbType.DateTime){Value=student.AdmissionTime},
                new SqlParameter("@Depart", SqlDbType.VarChar,11){Value=student.Departments},
                new SqlParameter("@Cla", SqlDbType.VarChar,11){ Value=student.Class},
                new SqlParameter("@Image", SqlDbType.Image){Value=DBNull.Value}
            };
            //List<SqlParameter> list = new List<SqlParameter>();
            //list.AddRange(pms);

         
            if (student.Image!=null)
            {
                pms[7].Value = student.Image;
            }

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
        /// 根据学号，删除相应的学生
        /// </summary>
        /// <param name="sid">学号</param>
        /// <returns>所影响的行数</returns>
        public int DeleteStudentInfo(string sid)
        {
            string sql = "delete from Student Where StudentID=" + sid;
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text);
        }

        /// <summary>
        /// 根据学号查询学生信息
        /// </summary>
        /// <param name="sid">学号</param>
        /// <returns>学生对象</returns>
        public Student GetStudentBySid(string sid)
        {
            //string sql = "select StudentID,StudentName,StudentGender,Birthday,AdmissionTime,college.COName,class.CLName from Student as student inner join Class as  class on student.Class=class.CLID inner join College as college on student.Departments=college.COID Where student.StudentID="+ sid;

            string sql = "select StudentID,StudentName,StudentGender,Birthday,AdmissionTime,Departments,Class from Student where StudentID = " + sid;
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text);
            Student stu = new Student();
            if (dt.Rows.Count>0)
            {
                stu = RowToStudentInfo(dt.Rows[0]);
            }
            return stu;
        }


        /// <summary>
        /// 根据查询条件，查找相应的学生
        /// </summary>
        /// <param name="info">条件</param>
        /// <returns>查到的学生</returns>
        public List<Student> GetStudentsByInfo(string info)
        {
            List<Student> list = new List<Student>();
            string sql = " select StudentID, StudentName, StudentGender, Birthday, AdmissionTime, college.COName,class.CLName from Student as student inner join Class as  class on student.Class=class.CLID inner join College as college on student.Departments=college.COID Where student.StudentID like @SID or student.StudentName like @SName";

            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@SID","%"+info+"%"),
                new SqlParameter("@SName","%"+info+"%")
            };

            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text, pms);
            if (dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToStudentInfo(dr));
                }
            }
            return list;
        }


        /// <summary>
        /// 登录时，根据用户名查询相应的对象信息
        /// </summary>
        /// <param name="sid">用户名</param>
        /// <returns></returns>
        public Student getStudentInfoBySid(string sid)
        {
            string sql = "select * from Student where StudentID=@sid";
            SqlParameter pms = new SqlParameter("@sid", SqlDbType.VarChar, 11) { Value = sid };
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text, pms);
            Student student = null;
            if (dt.Rows.Count > 0)
            {
                student = RowToStudent(dt.Rows[0]);
            }
            return student;
        }

        private Student RowToStudent(DataRow dr)
        {
            Student student = new Student();
            student.SID = dr["StudentID"].ToString();
            student.PassWord = dr["PassWord"].ToString();
            student.SName = dr["StudentName"].ToString();
            student.SGender = (Convert.ToBoolean(dr["StudentGender"])) ? "男" : "女";
            student.Birthday = Convert.ToDateTime(dr["Birthday"]);
            student.AdmissionTime = Convert.ToDateTime(dr["AdmissionTime"]);
            student.Departments = dr["Departments"].ToString();
            student.Class = dr["Class"].ToString();

            if (!dr.IsNull("Image"))
            {
                byte[] imageByte = (byte[])dr["Image"];
                MemoryStream stream = new MemoryStream(imageByte);
                student.Image = new Bitmap(stream);
            }


            return student;
        }


        /// <summary>
        /// 学生修改个人信息
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int EditStudent(Student student)
        {
            string sql = "update Student set StudentName=@name,StudentGender=@gender,Birthday=@bir,AdmissionTime=@adm,Departments=@depart,Class=@class,Image=@image where StudentID=@ID";

            byte[] buffer;
            using (MemoryStream ms = new MemoryStream())
            {
                student.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                buffer = ms.GetBuffer();
            }

            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@ID",student.SID),
                new SqlParameter("@name",student.SName),
                new SqlParameter("@gender", SqlDbType.Bit){ Value=student.SGender=="男"?true:false},
                new SqlParameter("@bir",student.Birthday),
                new SqlParameter("@adm", student.AdmissionTime),
                new SqlParameter("@depart",student.Departments),
                new SqlParameter("@class",student.Class),
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
        /// 学生修改密码
        /// </summary>
        /// <param name="pwd"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int EditPwd(string pwd,string id)
        {
            string sql = "update Student set PassWord=@pwd where StudentID=" + id;
            SqlParameter pms = new SqlParameter("@pwd", pwd);
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pms);
        }
    }
}
