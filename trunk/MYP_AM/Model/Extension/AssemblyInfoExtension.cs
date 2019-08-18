using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MYPAM.Model.Extension
{
    public static class AssemblyInfoExtension
    {
        /// <summary>
        /// 取得執行檔編譯建立時間，
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static DateTime GetLinkerTime(this Assembly assembly, TimeZoneInfo target = null)
        {
            var FilePath = assembly.Location;
            const int PeHeaderOffset = 60;
            const int LinkerTimestampOffset = 8;

            var Buffer = new byte[2048];

            using (var Stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                Stream.Read(Buffer, 0, 2048);

            var Offset = BitConverter.ToInt32(Buffer, PeHeaderOffset);
            var SecondsSince1970 = BitConverter.ToInt32(Buffer, Offset + LinkerTimestampOffset);
            var Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var LinkTimeUtc = Epoch.AddSeconds(SecondsSince1970);

            var TimeZone = target ?? TimeZoneInfo.Local;
            var LocalTime = TimeZoneInfo.ConvertTimeFromUtc(LinkTimeUtc, TimeZone);

            return LocalTime;
        }
    }
}
