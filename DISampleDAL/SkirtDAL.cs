using DISampleISkirtDAL;
using DISampleModel;
using System.Collections.Generic;
using System.Linq;


namespace DISampleDAL
{
    /// <summary>
    /// 数据访问
    /// </summary>
    public class SkirtDAL:ISkirtDAL
    {
        private readonly List<Skirt> skirts;
        /// <summary>
        /// 构造函数
        /// </summary>
        public SkirtDAL() 
        {
            skirts = new List<Skirt> 
            { 
                new Skirt { Id = 1, Name = "短裙", Description = "漂亮又好看" },
                new Skirt { Id = 2, Name = "中短裙", Description = "漂亮又好看" },
                new Skirt { Id = 3, Name = "超短裙", Description = "漂亮又好看" },
            };
        }
        /// <summary>
        /// 根据关键字统计多少条裙子
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public int CountByKeys(string keys)
        {
            if (skirts==null)
            {
                return 0;
            }
            return skirts.Where(s => s.Name.Contains(keys)).Count();
        }

        /// <summary>
        /// 获取所有裙子
        /// </summary>
        /// <returns></returns>
        public List<Skirt> GetSkirts()
        {
            return skirts;
        }
        /// <summary>
        /// 根据关键字查询响应的裙子
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public List<Skirt> GetSkirts(string keys)
        {
            if (skirts==null)
            {
                return null;
            }
            //在 skirts 列表中查找所有 Skirt 对象的 Name 属性包含 keys 字符串的项。
            //然后，它会将找到的项转换为列表并返回。
            return skirts.Where(s => s.Name.Contains(keys)).ToList();
            
        }

    }
}
