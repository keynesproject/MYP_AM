using MYPAM.Model.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MYPAM.Model.DataAccessObject
{
    public class DaoUserInfo
    {
        public Int64 ID { get; set; }

        public Int64 UserID { get; set; }

        private string sUserID
        {
            get
            {
                string ID = UserID.ToString();
                if (ID.Length < 1)
                    return "";

                int HeadLength = ID.Length > 6 ? 2 : 1;
                string sIndex = ID.Substring(0, HeadLength);
                string sHead = NunberToChar(sIndex.ToInt());
                return sHead + ID.Substring(HeadLength);

                //上面的程式碼是由下面這串簡化而來
                //if (ID.Length > 6)
                //{
                //    string sIndex = ID.Substring(0, 2);
                //    string sHead = NunberToChar(sIndex.ToInt());
                //    return sHead + ID.Substring(2);
                //}
                //else
                //{
                //    string sIndex = ID.Substring(0, 1);
                //    string sHead = NunberToChar(sIndex.ToInt());
                //    return sHead + ID.Substring(1);
                //}     
            }
        }

        private string _UserName = "";

        public string Name
        {
            get { return _UserName; }
            set
            {
                if (value.Length > 0)
                {
                    if (value.Contains('\0'))
                        _UserName = value.Remove(value.IndexOf('\0'));
                    else
                        _UserName = value;
                }
                else
                    _UserName = "";
            }
        }
        
        /// <summary>
        /// 卡號或指紋號
        /// </summary>
        public string CardNum { get; set; }

        /// <summary>
        /// 0 indicates commonuser, 
        /// 1 registrar, 
        /// 2 administrator, 
        /// 3 super administrator
        /// </summary>
        public int Privilege { get; set; }

        /// <summary>
        /// 是否啟用
        /// </summary>
        public bool Enable { get; set; }

        private string NunberToChar(int number)
        {
            if (1 <= number && 36 >= number)
            {
                int num = number + 64;
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                byte[] btNumber = new byte[] { (byte)num };
                return asciiEncoding.GetString(btNumber);
            }

            return "";
        }
    }
}
