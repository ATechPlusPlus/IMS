using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;


namespace IMS.Masters
{
    public partial class Employee_Details : Form
    {
        public Employee_Details()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int EmployeeID = 0;
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicEmployee.Image = Image.FromFile(openFileDialog.FileName);
            }

        }


        Image B_Leave = IMS.Properties.Resources.B_click;
        Image B_Enter = IMS.Properties.Resources.B_on;
        private void Employee_Details_Load(object sender, EventArgs e)
        {

            clsUtility.IsAdmin = true;

            btnAdd.BackgroundImage = B_Leave;
            btnSave.BackgroundImage = B_Leave;
            btnEdit.BackgroundImage = B_Leave;
            btnUpdate.BackgroundImage = B_Leave;
            btnDelete.BackgroundImage = B_Leave;
            btnCancel.BackgroundImage = B_Leave;


            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning, clsUtility.IsAdmin);
            BindStoreDetails();
            LoadData();
        }
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            grpEmployee.Enabled = true;
            txtEmployeeCode.Focus();

        }
        private void BindStoreDetails()
        {
            DataTable dt = null;
            dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.StoreMaster", "StoreID,StoreName", "ISNULL(ActiveStatus,1)=1", " StoreID");
            cmbShop.DataSource = dt;
            cmbShop.DisplayMember = "StoreName";
            cmbShop.ValueMember = "StoreID";

            cmbShop.SelectedIndex = -1;
        }
        private void ClearAll()
        {
            txtName.Clear();
            txtPass.Clear();
            txtUsername.Clear();
            txtEmployeeCode.Clear();
            radMale.Checked = false;
            radFemale.Checked = false;
            txtAdd.Clear();
            PicEmployee.Image = null;
            cmbShop.SelectedIndex = -1;
            EmployeeID = 0;

            txtEmail.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateEmployee())
            {
                SaveEmployee();

            }
        }
        private void CreateNewUser(int EmployeeID)
        {

            ObjDAL.SetColumnData("UserName", SqlDbType.NVarChar, txtUsername.Text.Trim());
            ObjDAL.SetColumnData("Password", SqlDbType.NVarChar, ObjUtil.Encrypt(txtPass.Text.Trim(), true));
            ObjDAL.SetColumnData("EmailID", SqlDbType.NVarChar, txtEmail.Text.Trim());
            ObjDAL.SetColumnData("IsAdmin", SqlDbType.Bit, false);
            ObjDAL.SetColumnData("IsBlock", SqlDbType.Bit, false);
            ObjDAL.SetColumnData("EmployeeID", SqlDbType.Int, EmployeeID);

            if (ObjDAL.InsertData(clsUtility.DBName + ".dbo.UserManagement", true) > 0)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                clsUtility.ShowInfoMessage("User has been added Successfully.", clsUtility.strProjectTitle);
                ClearAll();
                LoadData();
                grpEmployee.Enabled = false;
            }
            else
            {
                clsUtility.ShowInfoMessage("Failed to add the User.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }


        }

        private bool ValidateEmployee()
        {
            if (txtEmployeeCode.Text.Trim().Length == 0)
            {
                clsUtility.ShowInfoMessage("Please Enter Employee Code.", clsUtility.strProjectTitle);
                txtEmployeeCode.Focus();
                return false;
            }

            if (txtName.Text.Trim().Length == 0)
            {
                clsUtility.ShowInfoMessage("Please Enter Employee Name.", clsUtility.strProjectTitle);
                txtName.Focus();
                return false;
            }
            if (cmbShop.Text.Trim().Length == 0)
            {
                clsUtility.ShowInfoMessage("Please Select Shop.", clsUtility.strProjectTitle);
                cmbShop.Focus();
                return false;
            }

            int result = ObjDAL.ExecuteScalarInt("select count(1) from "+clsUtility.DBName+".dbo.EmployeeDetails where EmployeeCode='" + txtEmployeeCode.Text + "' and EMPID<>" + EmployeeID);
            if (result > 0)
            {
                clsUtility.ShowInfoMessage("The Employee already exist with the given employee code. Please Enter different employee code.", clsUtility.strProjectTitle);
                txtEmployeeCode.Focus();
                return false;

            }

            if (txtUsername.Text.Trim().Length > 0) // if user name is entered
            {

                if (txtPass.Text.Trim().Length == 0)
                {
                    clsUtility.ShowInfoMessage("Please Enter Password.", clsUtility.strProjectTitle);
                    txtPass.Focus();
                    return false;
                }

                int countuser = ObjDAL.ExecuteScalarInt("select count(1) from "+clsUtility.DBName+".dbo.UserManagement where UserName='" + txtUsername.Text + "' and EmployeeID<>" + EmployeeID);
                if (countuser > 0)
                {
                    clsUtility.ShowInfoMessage("The user name already exist.Please enter different user name.", clsUtility.strProjectTitle);
                    txtUsername.Focus();
                    return false;
                }
            }
            return true;
        }

        private void SaveEmployee()
        {
            ObjDAL.SetColumnData("EmployeeCode", SqlDbType.NVarChar, txtEmployeeCode.Text.Trim());
            ObjDAL.SetColumnData("Name", SqlDbType.NVarChar, txtName.Text.Trim());
            ObjDAL.SetColumnData("ShopID", SqlDbType.Int, cmbShop.SelectedValue);
            if (radMale.Checked)
            {
                ObjDAL.SetColumnData("Gender", SqlDbType.Bit, true);
            }
            else if (radFemale.Checked)
            {
                ObjDAL.SetColumnData("Gender", SqlDbType.Bit, true);
            }
            ObjDAL.SetColumnData("DOB", SqlDbType.DateTime, dtpDOB.Value.ToString("yyyy-MM-dd"));
            ObjDAL.SetColumnData("Address", SqlDbType.NVarChar, txtAdd.Text.Trim());

            if (PicEmployee.Image != null)
            {
                ObjDAL.SetColumnData("Photo", SqlDbType.VarBinary, ObjUtil.GetImageBytes(PicEmployee.Image));
            }
            ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
            EmployeeID = ObjDAL.InsertData(clsUtility.DBName + ".dbo.EmployeeDetails", true);

            if (EmployeeID > 0)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                clsUtility.ShowInfoMessage("Employee has been added Successfully.", clsUtility.strProjectTitle);

                if (txtUsername.Text.Trim().Length != 0 && txtPass.Text.Trim().Length != 0)
                {
                    CreateNewUser(EmployeeID);
                }

                ClearAll();
                LoadData();
                grpEmployee.Enabled = false;
            }
            else
            {
                clsUtility.ShowInfoMessage("Failed to add the employee.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void LoadData()
        {

            string q = " select e1.EmpID,EmployeeCode,Name,ShopID,Gender,DOB,[Address],Photo, s1.StoreName from " + clsUtility.DBName + ".dbo.EmployeeDetails e1 join " + clsUtility.DBName + ".dbo.StoreMaster s1" +
                        " on e1.ShopID=s1.StoreID order by EmpID desc";
            DataTable dataTable = ObjDAL.ExecuteSelectStatement(q);
            if (dataTable.Rows.Count > 0)
            {
                dgvEmployee.DataSource = dataTable;
                lblTotalRecords.Text = "Total Employee Count : " + dgvEmployee.Rows.Count.ToString();
            }
            else
            {
                dgvEmployee.DataSource = null;
                lblTotalRecords.Text = "Total Employee Count : 0";

            }
        }

        private void dgvEmployee_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvEmployee);
            ObjUtil.SetDataGridProperty(dgvEmployee, DataGridViewAutoSizeColumnsMode.Fill);
            dgvEmployee.Columns["ShopID"].Visible = false;

            dgvEmployee.Columns["Gender"].Visible = false;
            dgvEmployee.Columns["Photo"].Visible = false;
            dgvEmployee.Columns["EmpID"].Visible = false;
            lblTotalRecords.Text = "Total Records : " + dgvEmployee.Rows.Count;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PicEmployee.Image = null;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void txtPass_MouseDown(object sender, MouseEventArgs e)
        {}

        private void txtPass_MouseUp(object sender, MouseEventArgs e)
        {}

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool b = clsUtility.ShowQuestionMessage(clsUtility.MsgActionCancel, clsUtility.strProjectTitle);
            if (b)
            {
                ClearAll();
                LoadData();
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel, clsUtility.IsAdmin);
                grpEmployee.Enabled = false;
            }
        }

        private void BindUserDetails()
        {
            DataTable dt = ObjDAL.ExecuteSelectStatement("select * from " + clsUtility.DBName + ".[dbo].[UserManagement] where EmployeeID=" + EmployeeID);
            if (ObjUtil.ValidateTable(dt))
            {
                txtUsername.Text = dt.Rows[0]["UserName"].ToString();
                txtPass.Text = ObjUtil.Decrypt(dt.Rows[0]["Password"].ToString(), true);
                txtEmail.Text = dt.Rows[0]["EmailID"].ToString();
            }
        }
        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ClearAll();
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick, clsUtility.IsAdmin);
                    EmployeeID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["EmpID"].Value);
                    txtEmployeeCode.Text = dgvEmployee.SelectedRows[0].Cells["EmployeeCode"].Value.ToString();
                    txtName.Text = dgvEmployee.SelectedRows[0].Cells["Name"].Value.ToString();
                    cmbShop.SelectedValue = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["ShopID"].Value);

                    if (dgvEmployee.SelectedRows[0].Cells["Gender"].Value != DBNull.Value && Convert.ToBoolean(dgvEmployee.SelectedRows[0].Cells["Gender"].Value))
                    {
                        radMale.Checked = true;
                        radFemale.Checked = false;
                    }
                    else if (dgvEmployee.SelectedRows[0].Cells["Gender"].Value != DBNull.Value && !Convert.ToBoolean(dgvEmployee.SelectedRows[0].Cells["Gender"].Value))
                    {
                        radFemale.Checked = true;
                        radMale.Checked = false;
                    }
                    else
                    {
                        radMale.Checked = false;
                        radFemale.Checked = false;
                    }

                    if (dgvEmployee.SelectedRows[0].Cells["DOB"].Value != DBNull.Value)
                    {
                        dtpDOB.Value = Convert.ToDateTime(dgvEmployee.SelectedRows[0].Cells["DOB"].Value);
                    }

                    if (dgvEmployee.SelectedRows[0].Cells["Address"].Value != DBNull.Value)
                    {
                        txtAdd.Text = dgvEmployee.SelectedRows[0].Cells["Address"].Value.ToString();
                    }

                    if (dgvEmployee.SelectedRows[0].Cells["Photo"].Value != DBNull.Value)
                    {
                        PicEmployee.Image = ObjUtil.GetImage((byte[])dgvEmployee.SelectedRows[0].Cells["Photo"].Value);
                    }

                    grpEmployee.Enabled = false;
                    BindUserDetails();
                }
                catch { }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
            grpEmployee.Enabled = true;
            txtEmployeeCode.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateEmployee())
            {
                UpdateEmployee();
            }
        }
        private void UpdateEmployee()
        {
            ObjDAL.UpdateColumnData("EmployeeCode", SqlDbType.NVarChar, txtEmployeeCode.Text.Trim());
            ObjDAL.UpdateColumnData("Name", SqlDbType.NVarChar, txtName.Text.Trim());
            ObjDAL.UpdateColumnData("ShopID", SqlDbType.Int, cmbShop.SelectedValue);
            if (radMale.Checked)
            {
                ObjDAL.UpdateColumnData("Gender", SqlDbType.Bit, true);
            }
            else if (radFemale.Checked)
            {
                ObjDAL.UpdateColumnData("Gender", SqlDbType.Bit, true);
            }
            ObjDAL.UpdateColumnData("DOB", SqlDbType.DateTime, dtpDOB.Value.ToString("yyyy-MM-dd"));
            ObjDAL.UpdateColumnData("Address", SqlDbType.NVarChar, txtAdd.Text.Trim());

            if (PicEmployee.Image != null)
            {
                ObjDAL.UpdateColumnData("Photo", SqlDbType.VarBinary, ObjUtil.GetImageBytes(PicEmployee.Image));
            }

            ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
            ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now);


            if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.EmployeeDetails", "EMPID = " + EmployeeID + "") > 0)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);
                clsUtility.ShowInfoMessage("Employee Record has been updated.", clsUtility.strProjectTitle);

                if (txtUsername.Text.Trim().Length != 0 && txtPass.Text.Trim().Length != 0)
                {
                    UpdateUserDetails();
                }

                LoadData();
                ClearAll();
                grpEmployee.Enabled = false;
                ObjDAL.ResetData();
            }
            else
            {
                clsUtility.ShowErrorMessage("Failed to update the employee data.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void UpdateUserDetails()
        {
            ObjDAL.UpdateColumnData("UserName", SqlDbType.NVarChar, txtUsername.Text.Trim());
            ObjDAL.UpdateColumnData("Password", SqlDbType.NVarChar, ObjUtil.Encrypt(txtPass.Text.Trim(), true));
            ObjDAL.UpdateColumnData("EmailID", SqlDbType.NVarChar, txtEmail.Text.Trim());
            ObjDAL.UpdateColumnData("IsAdmin", SqlDbType.Bit, false);
            ObjDAL.UpdateColumnData("IsBlock", SqlDbType.Bit, false);

            if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.UserManagement", "EmployeeID = " + EmployeeID + "") > 0)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);
                clsUtility.ShowInfoMessage("User Login Record has been updated.", clsUtility.strProjectTitle);
                LoadData();
                ClearAll();
                grpEmployee.Enabled = false;
                ObjDAL.ResetData();
            }
            else
            {
                clsUtility.ShowErrorMessage("Failed to update the User Login Data.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtName.Text + "' ? ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                if (ObjDAL.DeleteData(clsUtility.DBName + ".dbo.EmployeeDetails", "EmpID='" + EmployeeID + "'") > 0)
                {
                    clsUtility.ShowInfoMessage("'" + txtName.Text + "' Employee has been deleted.  ", clsUtility.strProjectTitle);
                    ClearAll();
                    LoadData();
                    grpEmployee.Enabled = false;
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, clsUtility.IsAdmin);
                }
                else
                {
                    clsUtility.ShowErrorMessage("Failed to delete the employee. ", clsUtility.strProjectTitle);
                    ObjDAL.ResetData();
                }
            }
        }

        private void txtEmployeeCode_Enter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);
        }

        private void txtEmployeeCode_Leave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
        }
    }
}
