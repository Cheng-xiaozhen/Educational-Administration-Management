using EAM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EAM.DAL
{
    public class CourseDAL
    {
        
        /// <summary>
        /// 根据教师ID，查询教师开的课程
        /// </summary>
        /// <param name="TID">教师ID</param>
        /// <returns></returns>
        public List<Course> GetCourses(string TID)
        {
            string sql = "select * from Course where Teacher=" + TID;
            List<Course> list = new List<Course>();
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text);
            if (dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    list.Add(RowToCourse(dr));
                }
            }
            return list;

        }

        private Course RowToCourse(DataRow dr)
        {
            Course course = new Course();
            course.CID = dr["CID"].ToString();
            course.CName = dr["CName"].ToString();
            course.Departments = dr["Departments"].ToString();
            course.CTeacher = dr["Teacher"].ToString();
            return course;
        }


        /// <summary>
        /// 根据课程号，删除课程
        /// </summary>
        /// <param name="CID">课程号</param>
        /// <returns></returns>
        public int DeleteCourse(string CID)
        {
            string sql = "delete from Course Where CID=" + CID;
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text);
        }

        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="course">课程对象</param>
        /// <returns></returns>
        public int AddCourse(Course course)
        {
            string sql = "insert into Course values(@CID,@CName,@Dep,@Teac)";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@CID", course.CID),
                new SqlParameter("@CName",course.CName),
                new SqlParameter("@Dep",course.Departments),
                new SqlParameter("@Teac",course.CTeacher)
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
        /// 学生选课时，获得所有课程
        /// </summary>
        /// <returns></returns>
        public List<Course> getCourse()
        {
            string sql = "select * from Course";
            List<Course> list = new List<Course>();

            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text);
            if (dt.Rows.Count>0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    list.Add(RowToCourse(item));
                }
            }
            return list;
        }

        /// <summary>
        /// 根据学生学号，查询学生的课程
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public List<Course> getMyCourse(string sid)
        {
            string sql = "select  c.CID,c.CName from Student_Grade as s inner join Course as c on s.CID = c.CID where s.SID = " + sid;
            List<Course> list = new List<Course>();
            using(SqlDataReader reader=SqlHelper.ExecuteReader(sql, CommandType.Text))
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Course course = new Course();
                        course.CID = reader.GetString(0);
                        course.CName = reader.GetString(1);
                        list.Add(course);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 学生选课
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public int AddStuCourse(string sid,string cid)
        {
            string sql = "insert into Student_Grade (SID,CID) values (@sid,@cid)";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@sid",sid),
                new SqlParameter("@cid",cid)
            };
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pms);
        }

        /// <summary>
        /// 学生删除课程
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public int DeleteStuCourse(string sid,string cid)
        {
            string sql = "delete from Student_Grade where SID=@sid and CID=@cid";
            SqlParameter[] pms = new SqlParameter[]
           {
                new SqlParameter("@sid",sid),
                new SqlParameter("@cid",cid)
           };
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pms);
        }
    }
}
