using MYPAM.Model.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MYPAM.Model.DataAccessObject
{
    public class DaoUserInfo
    {
        public int UserID { get; set; }

        public string sUserID
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

        private string m_UserName = "";
        public string Name
        {
            get { return m_UserName; }
            set
            {
                if (value.Length > 0)
                {
                    if (value.Contains('\0'))
                        m_UserName = value.Remove(value.IndexOf('\0'));
                    else
                        m_UserName = value;
                }
                else
                    m_UserName = "";
            }
        }


        public string CardNum { get; set; }

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
