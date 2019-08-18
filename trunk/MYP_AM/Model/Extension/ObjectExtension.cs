using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MYPAM.Model.Extension
{
    public static class ObjectExtension
    {
        //public static string ToName<T>(this Object Obj)
        //{
        //    if (Obj == null || Obj is DBNull)
        //        return string.Empty;

        //    IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();

        //    if (properties.Count > 0)          
        //        return properties[0].Name;

        //    return string.Empty;            
        //}

        /// <summary>
        /// 將數值轉換為int 32位元整數
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns>int整數,數值轉換錯誤會回傳0</returns>
        public static int ToInt(this Object Obj)
        {
            try
            {                
                if (Obj == null || Obj is DBNull)
                    return 0;

                return Convert.ToInt32(Obj);
            }
            catch(Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// 將數值轉換為unsigned int 32位元無正負號整數
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns>uint整數,數值轉換錯誤會回傳0</returns>
        public static UInt32 ToUInt(this Object Obj)
        {
            try
            {
                if (Obj == null || Obj is DBNull)
                    return 0;

                return Convert.ToUInt32(Obj);
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// 將數值轉換為unsigned short 16位元無正負號整數
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns>UShort整數,數值轉換錯誤會回傳0</returns>
        public static UInt16 ToUShort(this Object Obj)
        {
            try
            {
                if (Obj == null || Obj is DBNull)
                    return 0;

                return Convert.ToUInt16(Obj);
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// 將數值轉換為unsigned char(Byte) 8位元無號數
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns>unsigned char(Byte) 8位元無號數,數值轉換錯誤會回傳0</returns>
        public static Byte ToByte(this Object Obj)
        {
            try
            {
                if (Obj == null || Obj is DBNull)
                    return 0;

                return Convert.ToByte(Obj);
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// 將指定之數字，轉換為相等的單精確度浮點數。
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns>float單精確度浮點數,數值轉換錯誤會回傳0</returns>
        public static float ToFloat(this Object Obj)
        {
            try
            {
                if (Obj == null || Obj is DBNull)
                    return 0;

                return Convert.ToSingle(Obj);
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// 將指定之數字，轉換為相等的十進位數字。
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns>decimal十進位數字,數值轉換錯誤會回傳0</returns>
        public static decimal ToDecimal(this Object Obj)
        {
            try
            {
                if (Obj == null || Obj is DBNull)
                    return 0;

                return Convert.ToDecimal(Obj);
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// 將指定之數字的字串表示，轉換為相等的雙精確度浮點數。
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns>Double雙精確度浮點數,數值轉換錯誤會回傳0</returns>
        public static double ToDouble(this Object Obj)
        {
            try
            {
                if (Obj == null || Obj is DBNull)
                    return 0;

                return Convert.ToDouble(Obj);
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// 將指定之數字的字串表示，轉換為相等的 64 位元帶正負號的整數。
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns>long 64 位元帶正負號的整數,數值轉換錯誤會回傳0</returns>
        public static long ToLong(this Object Obj)
        {
            try
            {
                if (Obj == null || Obj is DBNull)
                    return 0;

                return Convert.ToInt64(Obj);
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex.Message);
                return 0;
            }
        }
    }
}
