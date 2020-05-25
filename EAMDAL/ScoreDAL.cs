using EAM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.DAL
{
    public class ScoreDAL
    {
        /// <summary>
        /// 获得教师所教授的学生成绩表的信息
        /// </summary>
        /// <param name="tid">教师ID</param>
        /// <param name="pageCount"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public DataTable GetScores(string tid,out string pageCount,out string recordCount,int pageIndex,int pageSize)
        {
            SqlParameter[] pms = new SqlParameter[]
           {
                new SqlParameter("@TID", SqlDbType.VarChar,11){Value=tid},
                new SqlParameter("@pageIndex", SqlDbType.Int){Value=pageIndex},
                new SqlParameter("@pageSize", SqlDbType.Int){Value=pageSize},
                new SqlParameter("@pageCount", SqlDbType.Int){Direction= ParameterDirection.Output},
                new SqlParameter("@recordCount", SqlDbType.Int){Direction= ParameterDirection.Output}
           };
            DataTable dt = SqlHelper.ExecuteDataTable("usp_getStudentScoreByPage", CommandType.StoredProcedure,pms);

            
            pageCount = pms[3].Value.ToString();
            recordCount = pms[4].Value.ToString();

            return dt;
        }

        /// <summary>
        /// 更新学生成绩
        /// </summary>
        /// <param name="score">成绩</param>
        /// <param name="sid">学生id</param>
        /// <returns></returns>
        public int UpdateScore(int score,string sid,string cid)
        {
            string sql = "update Student_Grade set Score=@score where SID=" + sid+" and CID ="+cid;

            SqlParameter pms = new SqlParameter("@score", score);
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pms);
        }


        /// <summary>
        /// 学生查看自己的成绩
        /// </summary>
        /// <param name="sid">学生学号</param>
        /// <returns></returns>
        public List<Score> getScores(string sid)
        {
            string sql = "select CName,Score,TName from Student_Grade inner join Course on Course.CID = Student_Grade.CID inner join Teacher on Course.Teacher = Teacher.TID where SID = "+sid;
            List<Score> list = new List<Score>();

            using(SqlDataReader reader=SqlHelper.ExecuteReader(sql, CommandType.Text))
            {
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Score score = new Score();
                        score.CID = reader.GetString(0);                        
                       score.Grade = reader.IsDBNull(1) ? null :(double?) reader.GetDouble(1);
                        score.SID = reader.GetString(2);
                        list.Add(score);
                    }
                }
            }
            return list;
        }


        

    }
}
