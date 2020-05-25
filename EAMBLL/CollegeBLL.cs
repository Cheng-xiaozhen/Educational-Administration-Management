using EAM.DAL;
using EAM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.BLL
{
   public  class CollegeBLL
    {

        CollegeDAL dal = new CollegeDAL();
        /// <summary>
        /// 获得学院表中的数据
        /// </summary>
        /// <returns></returns>
        public List<College> GetColleges()
        {
            return dal.GetColleges();
        }
    }
}
