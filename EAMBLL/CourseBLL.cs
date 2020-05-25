using EAM.DAL;
using EAM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.BLL
{
    public class CourseBLL
    {
        CourseDAL dal = new CourseDAL();

        /// <summary>
        /// 根据教师ID，查询教师开的课程
        /// </summary>
        /// <param name="TID">教师ID</param>
        /// <returns></returns>
        public List<Course> GetCourses(string TID)
        {
            return dal.GetCourses(TID);
        }



        /// <summary>
        /// 根据课程号，删除课程
        /// </summary>
        /// <param name="CID">课程号</param>
        /// <returns></returns>
        public bool DeleteCourse(string CID)
        {
            return dal.DeleteCourse(CID) > 0;
        }


        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="course">课程对象</param>
        /// <returns></returns>
        public bool AddCourse(Course course)
        {
            return dal.AddCourse(course) > 0;
        }

        /// <summary>
        /// 学生选课时，获得所有课程
        /// </summary>
        /// <returns></returns>
        public List<Course> getCourse()
        {
            return dal.getCourse();
        }

        /// <summary>
        /// 根据学生学号，查询学生的课程
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public List<Course> getMyCourse(string sid)
        {
            return dal.getMyCourse(sid);
        }

        /// <summary>
        /// 学生选课
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public bool AddStuCourse(string sid, string cid)
        {
            return dal.AddStuCourse(sid, cid) > 0;
        }

        /// <summary>
        /// 学生删除课程
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public bool DeleteStuCourse(string sid, string cid)
        {
            return dal.DeleteStuCourse(sid, cid) > 0;
        }
    }
}
