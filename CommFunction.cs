using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    //static的意思是这个类在访问的时候不需要实例化
    public static class CommFunction
    {
        /// <summary>
        ///   获取最大值的算法
        ///   2025年7月3日 15:30:00  
        ///   autho:tvbboy mail:ppu@cc.ecnu.edu.cn
        /// </summary>
        /// <param name="n1">第一个数</param>
        /// <param name="n2">第二个数</param>
        /// <param name="n3">第三个数</param>
        /// <returns>返回三个数中的最大值</returns>
        public static float  getMax(float n1, float n2, float n3)
        {
            return Math.Max(n1, Math.Max(n2, n3));
        }
        public static float getMin(float n1, float n2, float n3)
        {
            return Math.Min(n1, Math.Max(n2, n3));
        }
        /// <summary>
        /// 2024-7-2用来判断闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是/否</returns>
        public static bool isLeap(int year)
        {
            // 判断是否为闰年
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
