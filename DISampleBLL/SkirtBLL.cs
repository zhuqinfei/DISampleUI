using DISampleDAL;
using DISampleISkirtBLL;
using DISampleISkirtDAL;
using DISampleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISampleBLL
{
    public class SkirtBLL: ISkirtBLL
    {
        /// <summary>
        /// 数据访问
        /// </summary>
        private readonly ISkirtDAL skirtDAL;
        /// <summary>
        /// 构造函数
        /// </summary>
        public SkirtBLL()
        {
            skirtDAL = new SkirtDAL();
        }
        public SkirtBLL(ISkirtDAL _skirtDAL) 
        {
            skirtDAL = _skirtDAL;
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
        /// <summary>
        /// 根据关键字统计多少条裙子
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public int CountByKeys(string keys)
        {
            return skirtDAL.CountByKeys(keys);
        }
    }
}
