using EAM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.DAL
{
    public class ClassDAL
    {

        /// <summary>
        /// 获得课表中的数据
        /// </summary>
        /// <returns></returns>
        public List<Class> GetClasses()
        {
            string sql = "select * from Class";
            List<Class> list = null;
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text);
            if (dt.Rows.Count>0)
            {
                list = new List<Class>();
                foreach (DataRow dr   in dt.Rows)
                {
                    list.Add(RowToClassInfo(dr));
                }
            }
            return list;
        }

        /// <summary>
        /// 将行对象转换成class对象
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private Class RowToClassInfo(DataRow dr)
        {
            Class cla = new Class();
            cla.CLID = dr["CLID"].ToString();
            cla.CLName = dr["CLName"].ToString();
            return cla;
        }
    }
}
