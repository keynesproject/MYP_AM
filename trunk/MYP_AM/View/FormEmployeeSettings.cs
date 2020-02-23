using MYPAM.Model.DataAccessObject;
using MYPAM.Model.Device;
using MYPAM.Model.Extension;
using MYPAM.View.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYPAM.View
{
    public partial class FormEmployeeSettings : Form
    {
        private enum selectType
        {
            eEMPLOYEE= 0,
            eDEVICE,
        }

        private selectType _laseType = new selectType();

        private List<MYP2000> _ConnectDevice = null;

        public FormEmployeeSettings()
        {
            InitializeComponent();
        }

        public void Setup(List<MYP2000> Device)
        {
            _ConnectDevice = Device;

            LoadDevice();

            LoadEmployee();

            SelectType(selectType.eEMPLOYEE);
        }

        private void LoadDevice()
        {
            dgvDevice.DataSource = DaoSQL.Instance.GetMachineInfo();            
        }

        private void LoadEmployee()
        {
            dgvEmployee.DataSource = DaoSQL.Instance.GetEmployees();
            foreach (DataGridViewColumn column in dgvEmployee.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;// DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvEmployee.Columns[dgvEmployee.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DgvDevice_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDevice.ClearSelection();            
        }

        private void DgvEmployee_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEmployee.ClearSelection();
            
            if(dgvEmployee.Columns.Contains("序號"))
            {
                dgvEmployee.Columns["序號"].Visible = false;
            }

            if (dgvEmployee.Columns.Contains("Enable"))
            {
                dgvEmployee.Columns["Enable"].Visible = false;
            }
        }

        private void SelectType(selectType type)
        {
            _laseType = type;
            switch (type)
            {
                case selectType.eEMPLOYEE:
                    
                    tsBtnAddEmployee.Enabled = true;
                    tsBtnDelEmployee.Enabled = true;
                    tsBtnCancelAddEmployee.Enabled = false;
                    tsBtnUpload.Enabled = false;
                    tsBtnDownload.Enabled = false;
                    dgvDevice.ClearSelection();
                    employeeSettings1.SetEditMode(true);
                    break;

                case selectType.eDEVICE:
                    cbAllEmployee.Checked = false;                    
                    tsBtnAddEmployee.Enabled = false;
                    tsBtnDelEmployee.Enabled = false;
                    tsBtnCancelAddEmployee.Enabled = false;
                    tsBtnUpload.Enabled = true;
                    tsBtnDownload.Enabled = true;
                    employeeSettings1.SetEditMode(false);
                    DgvEmployee_SelectionChanged(this, new EventArgs());
                    break;
            }
        }

        private void CbAllEmployee_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbAllEmployee.Checked == true)
                SelectType(selectType.eEMPLOYEE);
            
            if(    cbAllEmployee.Checked == false
                && dgvDevice.Rows.Count > 0)
            {
                dgvDevice.Rows[0].Selected = true;
                DgvDevice_CellClick(sender, new DataGridViewCellEventArgs(0, 0));                
            }
        }

        private void DgvDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDevice.CurrentRow == null || dgvDevice.CurrentRow.Index < 0)
            {
                return;
            }
            SelectType(selectType.eDEVICE);
        }

        private void TsBtnAddEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            employeeSettings1.NewEmployee();
            LoadEmployee();
            dgvEmployee.Rows[dgvEmployee.Rows.Count - 1].Selected = true;
            tsBtnCancelAddEmployee.Enabled = true;
            tsBtnAddEmployee.Enabled = false;
        }
        
        private void TsBtnCancelAddEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            int Index = dgvEmployee.SelectedRows[0].Index;

            employeeSettings1.CancelNewEmployee();
            LoadEmployee();
            if (dgvEmployee.Rows.Count != 0)
            {
                if (Index >= dgvEmployee.Rows.Count)
                {
                    dgvEmployee.Rows[dgvEmployee.Rows.Count - 1].Selected = true;
                }
                else
                {
                    dgvEmployee.Rows[Index].Selected = true;
                }
            }
            else
            {
                employeeSettings1.Clear();
            }

            tsBtnAddEmployee.Enabled = true;
            tsBtnCancelAddEmployee.Enabled = false;
        }

        private void TsBtnDelEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            if( dgvEmployee.SelectedRows.Count <= 0 )
            {
                employeeSettings1.Clear();
                return;
            }

            string Name = dgvEmployee.SelectedRows[0].Cells["姓名"].Value.ToString();
            DialogResult ret = MessageBoxEx.Show(this, string.Format("確定要刪除員工資訊 [{0}]?", Name), "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                int Index = dgvEmployee.SelectedRows[0].Index;

                int ID = dgvEmployee.SelectedRows[0].Cells["序號"].Value.ToInt();
                employeeSettings1.DelEmployee(ID);

                LoadEmployee();

                if (dgvEmployee.Rows.Count != 0)
                {
                    if (Index >= dgvEmployee.Rows.Count)
                    {
                        dgvEmployee.Rows[dgvEmployee.Rows.Count - 1].Selected = true;
                    }
                    else
                    {
                        dgvEmployee.Rows[Index].Selected = true;
                    }
                }
                else
                {
                    employeeSettings1.Clear();
                }

                tsBtnAddEmployee.Enabled = true;
                tsBtnCancelAddEmployee.Enabled = false;
            }
        }

        private void TsBtnUpload_MouseUp(object sender, MouseEventArgs e)
        {
            MYP2000 selectDevice = null;
            int MachineID = dgvDevice.SelectedRows[0].Cells["columnID"].Value.ToInt();
            foreach (MYP2000 device in _ConnectDevice)
            {
                if (device.DeviceInfo.ID == MachineID)
                {
                    selectDevice = device;
                    break;
                }
            }

            if(selectDevice == null)
            {
                MessageBoxEx.Show(this, "請先選擇考勤設備!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //檢查是被是否有連線;//
            if (selectDevice.isConnected() == false)
            {
                MessageBoxEx.Show(this, "請先連接考勤設備!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //先取得所有人員資料;//
            DataTable dtEmployee = DaoSQL.Instance.GetAllEmployees();
            List< DaoUserInfo > allUserInfo = dtEmployee.ToList<DaoUserInfo>().ToList();

            //設定啟用或不啟用;//
            foreach(DaoUserInfo user in allUserInfo)
            {
                user.Enable = DaoSQL.Instance.GetRtbMachineEmployee(selectDevice.DeviceInfo.ID.ToInt(), user.ID.ToInt());                 
            }

            //更新到設備;//
            if( selectDevice.UploadUserInfo(allUserInfo) == true )
            {
                MessageBoxEx.Show(this, "員工資訊上傳成功!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBoxEx.Show(this, "員工資訊上傳失敗!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsBtnDownload_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        private void DgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count <= 0)
            {
                employeeSettings1.Clear();
                return;
            }

            int EmployeeID = dgvEmployee.SelectedRows[0].Cells["序號"].Value.ToInt();
            if (_laseType == selectType.eEMPLOYEE)
            {
                employeeSettings1.Setup(EmployeeID);
            }
            else
            {
                int MachineID = dgvDevice.SelectedRows[0].Cells["columnID"].Value.ToInt();
                employeeSettings1.Setup(EmployeeID, MachineID);
            }
        }

        private void EmployeeSettings1_Leave(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count <= 0)
                return;

            employeeSettings1.DataLayout = false;

            //紀錄現在選取的Index;//
            int SelectIndex = dgvEmployee.SelectedRows[0].Index;

            //儲存現有資訊;//
            int EmployeeID = dgvEmployee.SelectedRows[0].Cells["序號"].Value.ToInt();
            if (_laseType == selectType.eEMPLOYEE)
            {
                if (employeeSettings1.SaveEmployee(EmployeeID) == true)
                {
                    //重新讀取員工資料;//
                    LoadEmployee();

                    SelectType(_laseType);
                }
            }
            else
            {
                employeeSettings1.DataLayout = true;

                int MachineID = dgvDevice.SelectedRows[0].Cells["columnID"].Value.ToInt();
                employeeSettings1.UpdateEnable(EmployeeID, MachineID);
            }

            employeeSettings1.DataLayout = true;

            dgvEmployee.Rows[SelectIndex].Selected = true;
        }
    }
}