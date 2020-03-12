using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MYPAM.Model.DataAccessObject;
using MYPAM.Model.Extension;
using TextMessage.View.EventHandlers;

namespace MYPAM.View.Component
{
    public partial class EmployeeSettings : UserControl
    {
        private bool _isEditMode = false;

        private int _ID = 0;
               

        public EmployeeSettings()
        {
            InitializeComponent();

            tbUserID.KeyPress += KeyEventHandlers.KeyNumOnly;
            tbCardNum.KeyPress += KeyEventHandlers.KeyNumOnly;

            cbPrivilege.SelectedIndex = 0;
            cbEnable.SelectedIndex = 0;
        }

        /// <summary>
        /// 檢查Control元件是否有輸入數值
        /// </summary>
        /// <param name="Tb"></param>
        /// <param name="Lbl"></param>
        /// <returns></returns>
        private bool CheckControl(Control Com, Label Lbl)
        {
            if (string.IsNullOrEmpty(Com.Text))
            {
                MessageBoxEx.Show(this, string.Format("請輸入 [{0}] 欄位資訊.", Lbl.Text), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Com.Focus();
                return false;
            }

            return true;
        }
        
        private void DataLengthFill()
        {
            tbUserID.Text = tbUserID.Text.PadLeft(6, '0');
            tbCardNum.Text = tbCardNum.Text.PadLeft(10, '0');
        }

        public void Setup(int ID)
        {
            if (DataLayout == false)
                return;

            DataTable dt = DaoSQL.Instance.GetEmployee(ID);
            _ID = ID;
            tbUserID.Text = dt.Rows[0]["UserID"].ToString();
            tbName.Text = dt.Rows[0]["Name"].ToString();
            tbCardNum.Text = dt.Rows[0]["CardNum"].ToString();
            cbPrivilege.SelectedIndex = dt.Rows[0]["Privilege"].ToInt();

            DataLengthFill();

            tbUserID.Focus();
        }

        public void Setup(int EmployeeID, int MachineID)
        {
            if (DataLayout == false)
                return;

            DataTable dt = DaoSQL.Instance.GetEmployee(EmployeeID);
            _ID = EmployeeID;
            tbUserID.Text = dt.Rows[0]["UserID"].ToString();
            tbName.Text = dt.Rows[0]["Name"].ToString();
            tbCardNum.Text = dt.Rows[0]["CardNum"].ToString();
            cbPrivilege.SelectedIndex = dt.Rows[0]["Privilege"].ToInt();

            DataLengthFill();

            bool Enable = DaoSQL.Instance.GetRtbMachineEmployee(MachineID, EmployeeID );
            cbEnable.SelectedIndex = Enable == true ? 0 : 1;

            tbUserID.Focus();
        }

        public void Clear()
        {
            tbUserID.Text = string.Empty;
            tbName.Text = string.Empty;
            tbCardNum.Text = string.Empty;
            cbPrivilege.SelectedIndex = 0;
        }

        public void SetEditMode(bool isEdit)
        {
            _isEditMode = isEdit;
            if (isEdit)
            {
                tbUserID.Enabled = true;
                tbName.Enabled = true;
                tbCardNum.Enabled = true;
                cbPrivilege.Enabled = true;
                lblEnable.Visible = false;
                cbEnable.Visible = false;
            }
            else
            {
                tbUserID.Enabled = false;
                tbName.Enabled = false;
                tbCardNum.Enabled = false;
                cbPrivilege.Enabled = false;
                lblEnable.Visible = true;
                cbEnable.Visible = true;
            }
        }

        public bool SaveEmployee(int ID)
        {
            if (   CheckControl(tbUserID, lblUserID) == false
                || CheckControl(tbName, lblName) == false
                || CheckControl(tbCardNum, lblCardNum) == false)
            {
                return false;
            }

            DataLengthFill();
            
            //先檢查此ID是否存在,存在就用更新的，不存在就用插入的;//
            if (DaoSQL.Instance.CheckExistEmployeesID(ID) == true)
            {
                //檢查ID與UserID是否在同一列資料裡，不同的話要再額外檢查UserID是否有使用過;//               
                if (DaoSQL.Instance.CheckEmployeesIdAndUserID(ID, tbUserID.Text) == false)
                {
                    if (DaoSQL.Instance.CheckExistUserID(tbUserID.Text) == true)
                    {
                        MessageBoxEx.Show(this, string.Format("員工編號 [{0}] 已存在.", tbUserID.Text), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbUserID.Focus();
                        return false;
                    }
                }

                //更新員工資料;//
                DaoSQL.Instance.UpdateEmployee(ID, tbUserID.Text.PadLeft(6, '0'), tbName.Text, tbCardNum.Text.PadLeft(10, '0'), cbPrivilege.SelectedIndex);

                return true;
            }
            else
            {
                //檢查員工編號是否存在;//
                if (DaoSQL.Instance.CheckExistUserID(tbUserID.Text) == true)
                {
                    MessageBoxEx.Show(this, string.Format("員工編號 [{0}] 已存在.", tbUserID.Text), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbUserID.Focus();
                    return false;
                }

                //插入一筆員工資料;//
                DaoSQL.Instance.InsertEmployee(tbUserID.Text.PadLeft(6, '0'), tbName.Text, tbCardNum.Text.PadLeft(10, '0'), cbPrivilege.SelectedIndex);
            }

            return true;
        }
        
        internal void UpdateEnable(int employeeID, int machineID)
        {
            DaoSQL.Instance.UpdateRtbMachineEmployee(employeeID, machineID, cbEnable.SelectedIndex == 0 ? true : false);
        }

        /// <summary>
        /// 新增員工
        /// </summary>
        /// <returns>序號(ID)非UserID</returns>
        public int NewEmployee()
        {
            DataTable dt = DaoSQL.Instance.NewEmployee();
            tbUserID.Text = "";//dt.Rows[0]["UserID"].ToString();
            tbName.Text = dt.Rows[0]["Name"].ToString();
            tbCardNum.Text = dt.Rows[0]["CardNum"].ToString();
            cbPrivilege.SelectedIndex = dt.Rows[0]["Privilege"].ToInt();

            _ID = dt.Rows[0]["ID"].ToInt();
            return _ID;
        }
        
        /// <summary>
        /// 取消新增員工
        /// </summary>
        public void CancelNewEmployee()
        {
            DaoSQL.Instance.DeleteEmployees(_ID);
        }

        public void DelEmployee(int ID)
        {
            DaoSQL.Instance.DeleteEmployees(ID);
        }

        private bool _dataLayout = true;
        public bool DataLayout
        {
            get { return _dataLayout; }
            set { _dataLayout = value; }
        }

        private void CbPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
