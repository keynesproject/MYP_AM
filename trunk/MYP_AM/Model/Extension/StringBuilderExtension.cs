using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MYPAM.Model.Extension
{
    public static class StringBuilderExtension
    {
        /// <summary>
        /// 從這個字串中的最後一個指定之字串位置開始刪除所有字元，一直到最後一個位置為止。
        /// </summary>
        /// <param name="Sb"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static StringBuilder RemoveLast(this StringBuilder Sb, string Value)
        {
            if (Sb.Length < 1)
                return Sb;
            Sb.Remove(Sb.ToString().LastIndexOf(Value), Value.Length);
            return Sb;
        }

        /// <summary>
        /// 初始化輸入的數值
        /// </summary>
        /// <param name="Sb"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static void Init(this StringBuilder Sb)
        {
            Sb.Length = 0;
            Sb.Capacity = 0;
        }
    }
}
