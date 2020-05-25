using EAM.DAL;
using EAM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.BLL
{
    public class ClassBLL
    {
        ClassDAL dal = new ClassDAL();

        /// <summary>
        /// 获得课表中的数据
        /// </summary>
        /// <returns></returns>
        public List<Class> GetClasses()
        {
            return dal.GetClasses();
        }
    }
}
