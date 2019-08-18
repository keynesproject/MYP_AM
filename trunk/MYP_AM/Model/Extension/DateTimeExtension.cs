using System;

namespace MYPAM.Model.Extension
{
    public static class DateTimeExtension
    {
        public static string ConsoleMounth { get { return "MM-dd-yy"; } }
        public static string ConsoleTime { get { return "HH:mm:ss"; } }
        public static string ConsoleDateFormat { get { return ConsoleMounth + " " + ConsoleTime; } }
        
        /// <summary>
        /// 將時間轉換為timeStamp
        /// </summary>
        /// <param name="Dt"></param>
        /// <returns></returns>
        public static string ToStrTimeStamp(this DateTime Dt)
        {
            var dateTime = Dt;
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var unixDateTime = (dateTime.ToUniversalTime() - epoch).TotalSeconds;

            return unixDateTime.ToString();
        }

        /// <summary>
        /// 將時間轉換為timeStamp
        /// </summary>
        /// <param name="Dt"></param>
        /// <returns></returns>
        public static int ToIntTimeStamp(this DateTime Dt)
        {
            var dateTime = Dt;
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var unixDateTime = (dateTime.ToUniversalTime() - epoch).TotalSeconds;

            return unixDateTime.ToInt();
        }

        /// <summary>
        /// 將unix time轉換為Date time, UTC+0
        /// </summary>
        /// <param name="UnixTime"></param>
        /// <returns></returns>
        public static DateTime UnixTimestampToDateTime(this int UnixTime)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long UnixTimeStampInTicks = (long)(UnixTime * TimeSpan.TicksPerSecond);
            return new DateTime(unixStart.Ticks + UnixTimeStampInTicks, System.DateTimeKind.Utc);
        }

        /// <summary>
        /// 將unix time轉換為Date time, UTC+0
        /// </summary>
        /// <param name="UnixTime"></param>
        /// <returns></returns>
        public static DateTime UnixTimestampToDateTime(this int? UnixTime)
        {
            DateTime UnixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long UnixTimeStampInTicks = (long)(UnixTime * TimeSpan.TicksPerSecond);
            return new DateTime(UnixStart.Ticks + UnixTimeStampInTicks, System.DateTimeKind.Utc);
        }

        /// <summary>
        /// 將時間格式轉換成Console要使用的格式
        /// </summary>
        /// <param name="Dt"></param>
        /// <returns></returns>
        public static string ToConsoleFormat(this DateTime Dt)
        {
            //國際標準ISO 8601：yyyy - mm - dd，hr: mi: se（24小時制）
            //澳大利亞：dd / mm / yyyy；MMM dd, yyyy；hr: mi: se a.m./ p.m.（12 / 24小時制）
            //奧地利、德國、瑞士：dd.mm.yyyy；hr: mi: se Uhr（24小時制）
            //比利時：dd / mm / yyyy；hr: mi: se（24小時制）
            //巴西：dd / mm / yyyy；hrhmim；hr: mi: se（24小時制）
            //加拿大：yyyy - mm - dd；dd / mm / yyyy；hr: mi: se（英：12 / 24小時制；法：24小時制）
            //哥倫比亞：dd / mm(羅馬數字) / yyyy；hr: mi: se（12小時制）
            //捷克：d.m.yyyy；dd.mm.yyyy；yyyy - mm - dd；hr: mi: se（12 / 24小時制）
            //丹麥：d.m.yyyy；d / m - yyyy；hr: mi: se（24小時制）
            //中國：yyyy年m月d日；hr時mi分se秒；hr: mi: se（12 / 24小時制）
            //印度：dd - mm - yyyy；hr: mi: se（12 / 24小時制）
            //日本：yyyy年m月d日；hr時mi分（12 / 24小時制）
            //韓國：yyyy년 m월 d일 오전(上午)/ 오후(下午) hr시 mi분 se초（12 / 24小時制）
            //英國：dd mmmm yyyy，dd / mm / yy，hr: mi: se（12 / 24小時制）
            //美國：mm / dd / yyyy；mm / dd / yy；mmmm dd, yyyy；hr: mi: se（12小時制）
            //臺灣：yyyy - mm - dd；yyyy / mm / dd；mm / dd；時: 分: 秒（12 / 24小時制）

            return Dt.ToString(ConsoleDateFormat);
        }

        /// <summary>
        /// 將時間格式轉換成Console要使用的格式
        /// </summary>
        /// <param name="Dt"></param>
        /// <returns></returns>
        public static string ToConsoleFormat(this DateTimeOffset Dto)
        {
            return Dto.ToString(ConsoleDateFormat);
        }

        /// <summary>
        /// 將時間格式轉換成Console要使用的年月日格式
        /// </summary>
        /// <param name="Dt"></param>
        /// <returns></returns>
        public static string ToConsoleFormatMounth(this DateTime Dt)
        {
            return Dt.ToString(ConsoleMounth);
        }

        /// <summary>
        /// 取得Console日期格式的年月日字串長度，依照m_ConsoleMounth設定而修改
        /// </summary>
        /// <param name="Dt"></param>
        /// <returns></returns>
        public static int ToConsoleMounthStringLength(this DateTime Dt)
        {
            return ConsoleMounth.Length;
        }
    }
}
