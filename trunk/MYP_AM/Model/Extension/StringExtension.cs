using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using MYPAM.Model.MutiLanguage;

namespace MYPAM.Model.Extension
{
    public static class StringExtension
    {
        /// <summary>
        /// 從這個字串中的最後一個指定之字元位置開始刪除所有字元，一直到最後一個位置為止。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="Letter">指定的字元</param>
        /// <returns>刪除後的字串</returns>
        public static string RemoveLastIndexof(this string s, char Letter)
        {
            int LastIndex = s.LastIndexOf(Letter);
            
            if (LastIndex == -1)
            {
                return s;
            }

            s = s.Remove(LastIndex);

            return s;
        }

        /// <summary>
        /// 從這個字串中的最後一個指定之字串位置開始刪除所有字元，一直到最後一個位置為止。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="Str">指定的字元</param>
        /// <returns>刪除後的字串</returns>
        public static string RemoveLastIndexof(this string s, string Str )
        {
            int LastIndex = s.LastIndexOf(Str);

            if (LastIndex == -1)
            {
                return s;
            }

            s = s.Remove(LastIndex);

            return s;
        }

        /// <summary>
        /// 移除字串中最後一次出現的指定字元
        /// </summary>
        /// <param name="s"></param>
        /// <param name="Letter">指定的字元</param>
        /// <returns>刪除後的字串</returns>
        public static string RemoveLastAssignChar(this string s, char Letter)
        {
            int LastIndex = s.LastIndexOf(Letter);

            if (LastIndex == -1)
            {
                return s;
            }

            s = s.Remove(LastIndex,1);

            return s;
        }

        /// <summary>
        /// 覆蓋字串中第一次出現的指定字串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="OldStr">舊的指定的字元</param>
        /// <param name="NewStr">新的指定的字元</param>
        /// <returns>刪除後的字串</returns>
        public static string ReplaceFirstAssignString(this string s, string OldStr, string NewStr)
        {
            int FirstIndex = s.IndexOf(OldStr);
            
            if (FirstIndex == -1)
            {
                return s;
            }

            s = s.Remove(FirstIndex, OldStr.Length).Insert(FirstIndex, NewStr);

            return s;
        }

        /// <summary>
        /// 將字串轉換為int整數
        /// </summary>
        /// <param name="s"></param>
        /// <returns>int整數,數值轉換錯誤會回傳0</returns>
        public static int ToInt( this string s )
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex.Message);
                return 0;
            }
        }
        
        /// <summary>
        /// 將指定之數字的字串表示，轉換為相等的單精確度浮點數。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static float ToFloat(this string s)
        {
            try
            {
                return Convert.ToSingle(s);
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex.Message);
                return 0.0f;
            }
        }

        /// <summary>
        /// 計算指定字串出現次數。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="Value">指定的字串。</param>
        /// <returns>指定字串出現次數。</returns>
        public static int CountChar(this string s, char Value)
        {
            int CharCount = 0;

            // 此作法只適用單一字元
            foreach (char charValue in s)
            {
                if (charValue == Value)
                {
                    CharCount++;
                }
            }

            return CharCount;
        }

        /// <summary>
        /// 將字串轉為指定單位數值
        /// </summary>
        /// <param name="s"></param>
        /// <param name="Unit">單位字節，只能為 K,M,G,T,P,E </param>
        /// <param name="WithUnit">回傳字串是否標註上單位</param>
        /// <returns></returns>
        public static string ToUnitString(this string s, string Unit, bool WithUnit=false)
        {            
            long byteCount = 0;

            Unit = Unit.ToUpper();
            try
            {
                byteCount = Convert.ToInt64(s);
            }
            catch
            {
                return s;
            }

            int Decimals = 0;
            switch(Unit)
            {
                case "K":
                    Decimals = 3;
                    break;
                case "M":
                    Decimals = 6;
                    break;
                case "G":
                    Decimals = 9;
                    break;
                case "T":
                    Decimals = 12;
                    break;
                case "P":
                    Decimals = 16;
                    break;
                case "E":
                    Decimals = 18;
                    break;
                default:
                    return s;
            }

            //Longs run out around EB
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; 

            if (byteCount == 0)
                return "0" + suf[0];

            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1000)));
            double num = Math.Round(bytes / Math.Pow(10, Decimals), 10);

            if (WithUnit)
                return (Math.Sign(byteCount) * num).ToString() + suf[place];
            else
                return (Math.Sign(byteCount) * num).ToString();
        }

        /// <summary>
        /// 將指定字串轉為Byte Array格式
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(this string s)
        {
            return Encoding.ASCII.GetBytes(s);
        }

        /// <summary>
        /// 驗證字串格式是否為IP格式
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsIPAddress(this string s)
        {
            string validatedIP = string.Empty;
            IPAddress Ip;
            if (IPAddress.TryParse(s, out Ip))
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// 取得多國語言字串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToLanguage(this string s)
        {
            if (s.Length <= 0)
                return "";

            string MultiLanguage = LanguageControl.Instance.Language(s);

            if (MultiLanguage.Length <= 0)
                return s;

            return MultiLanguage;
        }
    }
}
