using EAM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.DAL
{
    public class CollegeDAL
    {

        /// <summary>
        /// 获得学院表中的数据
        /// </summary>
        /// <returns></returns>
        public List<College> GetColleges()
        {
            string sql = "select * from College";
            List<College> list = null;
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text);

            if (dt.Rows.Count>0)
            {
                list = new List<College>();
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToCollge(dr));

                }
            }
            return list;
        }

        private College RowToCollge(DataRow dr)
        {
            College co = new College();
            co.COID = dr["COID"].ToString();
            co.COName = dr["COName"].ToString();
            return co;
        }
    }
}
