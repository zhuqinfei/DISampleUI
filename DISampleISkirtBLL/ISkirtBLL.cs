using DISampleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISampleISkirtBLL
{
    /// <summary>
    /// 业务逻辑接口
    /// </summary>
    public interface ISkirtBLL
    {
        /// <summary>
        /// 获取所有的裙子
        /// </summary>
        /// <returns></returns>
        List<Skirt> GetSkirts();
        /// <summary>
        /// 根据关键字查询响应的裙子
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        List<Skirt> GetSkirts(string keys);
        /// <summary>
        /// 根据关键字统计多少条裙子
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        int CountByKeys(string keys);
    }
}
