using DISampleDAL;
using DISampleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISampleBLL
{
    public class SkirtBLL
    {
        /// <summary>
        /// 数据访问
        /// </summary>
        private readonly SkirtDAL skirtDAL;
        public SkirtBLL()
        {
            skirtDAL = new SkirtDAL();
        }
        /// <summary>
        /// 获取所有的裙子
        /// </summary>
        /// <returns></returns>
        public List<Skirt> GetSkirts()
        {
            return skirtDAL.GetSkirts();
        }
        /// <summary>
        /// 根据关键字查询响应的裙子
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public List<Skirt> GetSkirts(string keys)
        {
            return skirtDAL.GetSkirts(keys);
        }
    }
}
