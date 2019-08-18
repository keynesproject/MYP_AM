using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace MYPAM.Model.MutiLanguage
{
    public class LanguageControl
    {
        #region Singleton物件宣告，Thread safe，並在使用時才會建立實體

        private static readonly LanguageControl m_instance = new LanguageControl();

        internal static LanguageControl Instance { get { return m_instance; } }

        #endregion

        Dictionary<CaltureDefine, System.Resources.ResourceManager> m_Language = new Dictionary<CaltureDefine, System.Resources.ResourceManager>();

        System.Resources.ResourceManager m_ResourceManager = LanguageEN.ResourceManager;

        /// <summary>
        /// 目前支援的語言列表定義
        /// </summary>
        public enum CaltureDefine
        {
            EN = 0,  //英文;//
            ZH_CHS,   //簡體中文;//
            ZH_CHT    //繁體中文;/
        }

        /// <summary>
        /// 建構式
        /// </summary>
        public LanguageControl()
        {
            m_Language.Add(CaltureDefine.EN, LanguageEN.ResourceManager);
            m_Language.Add(CaltureDefine.ZH_CHT, LanguageZH_CHT.ResourceManager);
        }

        /// <summary>
        /// 設定語言切換,切換後各字串須重新讀取才可正常作用
        /// </summary>
        /// <param name="Define"></param>
        public void SetLanguage(CaltureDefine Define)
        {
            if (m_Language.ContainsKey(Define) == true)
                m_ResourceManager = m_Language[Define];
            else
                m_ResourceManager = LanguageEN.ResourceManager;
        }

        /// <summary>
        /// 取得多國語言的字串
        /// </summary>
        /// <param name="Type">.resx定義的名稱</param>
        /// <returns></returns>
        public string Language(string Type)
        {
            try
            {
                return m_ResourceManager.GetString(Type).Replace("\\n", "\r\n");
            }
            catch(Exception)
            {
                //表示查無此定義名稱,使用英文預設值;//
                try
                {
                    return LanguageEN.ResourceManager.GetString(Type).Replace("\\n", "\r\n");
                }
                catch(Exception)
                {
                    return "";
                }
            }
        }
    }
}
