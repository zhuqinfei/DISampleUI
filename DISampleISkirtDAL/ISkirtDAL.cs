using DISampleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISampleISkirtDAL
{
        /// <summary>
        /// 数据访问层接口
        /// </summary>
        public interface ISkirtDAL
        {
            /// <summary>
            /// 获取所有裙子
            /// </summary>
            /// <returns></returns>
            List<Skirt> GetSkirts();
            /// <summary>
            /// 根据关键字查询响应的裙子
            /// </summary>
            /// <param name="keys"></param>
            /// <returns></returns>
            List<Skirt> GetSkirts(string keys);
            int CountByKeys(string keys);
        }
}
