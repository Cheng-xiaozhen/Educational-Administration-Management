using EAM.DAL;
using EAM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.BLL
{
    public  class ScoreBLL
    {
        ScoreDAL dal = new ScoreDAL();
        /// <summary>
        /// 获得教师所教授的学生的成绩
        /// </summary>
        /// <param name="tid"></param>
        /// <param name="pageCount"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public DataTable GetScores(string tid, out string pageCount, out string recordCount,int pageIndex,int pageSize)
        {
            return dal.GetScores(tid, out pageCount, out recordCount,pageIndex,pageSize);
        }

        /// <summary>
        /// 更新学生成绩
        /// </summary>
        /// <param name="score">成绩</param>
        /// <param name="sid">学生id</param>
        /// <returns></returns>
        public bool UpdateScore(int score, string sid,string cid)
        {
            return dal.UpdateScore(score, sid,cid) > 0;
        }


        /// <summary>
        /// 学生查看自己的成绩
        /// </summary>
        /// <param name="sid">学生学号</param>
        /// <returns></returns>
        public List<Score> getScores(string sid)
        {
            return dal.getScores(sid);
        }
     }
}
