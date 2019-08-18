using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextMessage.View.EventHandlers
{
    public class KeyEventHandlers
    {
        /// <summary>
        /// 禁止輸入空白字元
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyWithoutSpace(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// 只允許字母及數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyLetterDigitOnly(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 只允許字母及數字,並會轉換為小寫
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyLetterToLowerDigitOnly(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (char.IsLetter(e.KeyChar))
            {
                //將字元轉換為小寫字元;//
                e.KeyChar = Char.ToLower(e.KeyChar);

                e.Handled = false;
            }
            else
            {
                //不允許的輸入字元;//
                e.Handled = true;
            }


            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 只允許輸入數字及句號
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyDigitDotOnly(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)
                || e.KeyChar == 8
                || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 只允許輸入數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyNumOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// 只允許輸入16進制碼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyHexOnly(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'f')
                || (e.KeyChar >= 'A' && e.KeyChar <= 'F'))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                e.Handled = false;
                return;
            }

            if (!char.IsDigit(e.KeyChar)
                && !char.IsControl(e.KeyChar))
            {
                //不允許輸入;//
                e.Handled = true;
            }
        }

        /// <summary>
        /// 只允許輸入數字及一個句點符號
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyNumWithOneDot(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (sender is TextBox)
                {
                    TextBox TB = sender as TextBox;
                    string[] SubString = TB.Text.Split('.');
                    if (SubString.Count() <= 1)
                    {
                        e.Handled = false;
                        return;
                    }
                }
            }

            if (!char.IsDigit(e.KeyChar)
                && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
