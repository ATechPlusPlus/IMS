using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;

namespace IMS.Purchase
{
    public partial class Purchase_Invoice : Form
    {
        public Purchase_Invoice()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;

        Image B_Leave = IMS.Properties.Resources.B_click;
        Image B_Enter = IMS.Properties.Resources.B_on;
        private void ClearAll()
        {
            txtSupplierBillNo.Clear();
            txtShipmentNo.Clear();
            txtBillValue.Clear();
            txtTotalQTY.Clear();
            cmbSupplier.SelectedIndex = -1;

            txtSupplierBillNo.Focus();
        }

        private bool Validateform()
        {
            if (ObjUtil.IsControlTextEmpty(txtSupplierBillNo))
            {
                clsUtility.ShowInfoMessage("Enter Supplier Bill No           ", clsUtility.strProjectTitle);
                txtSupplierBillNo.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtShipmentNo))
            {
                clsUtility.ShowInfoMessage("Enter Shipment No           ", clsUtility.strProjectTitle);
                txtShipmentNo.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbSupplier))
            {
                clsUtility.ShowInfoMessage("Select Supplier for " + txtShipmentNo.Text, clsUtility.strProjectTitle);
                cmbSupplier.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtBillValue))
            {
                clsUtility.ShowInfoMessage("Enter Bill Value           ", clsUtility.strProjectTitle);
                txtBillValue.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtTotalQTY))
            {
                clsUtility.ShowInfoMessage("Enter Total Qty           ", clsUtility.strProjectTitle);
                txtTotalQTY.Focus();
                return false;
            }
            return true;
        }

        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.PurchaseInvoice", "SupplierID=" + cmbSupplier.SelectedValue + " AND SupplierBillNo='" + txtSupplierBillNo.Text + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.PurchaseInvoice", "SupplierID=" + cmbSupplier.SelectedValue + " AND SupplierBillNo='" + txtSupplierBillNo.Text + "'" +
                    " AND PurchaseInvoiceID !=" + i);
            }
            if (a > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LoadData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.PurchaseInvoice", "PurchaseInvoiceID,SupplierBillNo,SupplierID,ShipmentNo,BillDate,BillValue,TotalQTY", "BillDate");

            if (ObjUtil.ValidateTable(dt))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void FillSupplierData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.SupplierMaster", "SupplierID,SupplierName", "ISNULL(ActiveStatus,1)=1", "SupplierName ASC");
            cmbSupplier.DataSource = dt;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierID";

            cmbSupplier.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            grpPurchaseInvoice.Enabled = true;
            txtShipmentNo.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validateform())
            {
                if (DuplicateUser(0))
                {
                    ObjDAL.SetColumnData("SupplierBillNo", SqlDbType.NVarChar, txtSupplierBillNo.Text.Trim());
                    ObjDAL.SetColumnData("ShipmentNo", SqlDbType.NVarChar, txtShipmentNo.Text.Trim());
                    ObjDAL.SetColumnData("BillValue", SqlDbType.Decimal, txtBillValue.Text.Trim());
                    ObjDAL.SetColumnData("TotalQTY", SqlDbType.Int, txtTotalQTY.Text.Trim());
                    ObjDAL.SetColumnData("SupplierID", SqlDbType.Bit, cmbSupplier.SelectedValue);
                    ObjDAL.SetColumnData("BillDate", SqlDbType.Date, dtpBillDate.Value.ToString("yyyy-MM-dd"));
                    ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
                    if (ObjDAL.InsertData(clsUtility.DBName + ".dbo.PurchaseInvoice", true) > 0)
                    {
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                        clsUtility.ShowInfoMessage("Purchase Invoice for '" + cmbSupplier.SelectedItem + "' is Saved Successfully..", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        grpPurchaseInvoice.Enabled = false;
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("Purchase Invoice for '" + cmbSupplier.SelectedItem + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("Purchase Invoice for '" + cmbSupplier.SelectedItem + "' is already exist..", clsUtility.strProjectTitle);
                    ObjDAL.ResetData();
                    cmbSupplier.Focus();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
            grpPurchaseInvoice.Enabled = true;
            txtSupplierBillNo.Focus();
            txtSupplierBillNo.SelectionStart = txtSupplierBillNo.MaxLength;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validateform())
            {
                if (DuplicateUser(0))
                {
                    ObjDAL.UpdateColumnData("SupplierBillNo", SqlDbType.VarChar, txtSupplierBillNo.Text.Trim());
                    ObjDAL.UpdateColumnData("ShipmentNo", SqlDbType.VarChar, txtShipmentNo.Text.Trim());
                    ObjDAL.UpdateColumnData("BillValue", SqlDbType.Decimal, txtBillValue.Text.Trim());
                    ObjDAL.UpdateColumnData("TotalQTY", SqlDbType.Int, txtTotalQTY.Text.Trim());
                    ObjDAL.UpdateColumnData("SupplierID", SqlDbType.Bit, cmbSupplier.SelectedValue);
                    ObjDAL.UpdateColumnData("BillDate", SqlDbType.Date, dtpBillDate.Value.ToString("yyyy-MM-dd"));
                    ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test
                    ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now);

                    if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.PurchaseInvoice", "PurchaseInvoiceID = " + ID + "") > 0)
                    {
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);

                        clsUtility.ShowInfoMessage("Purchase Invoice for '" + cmbSupplier.SelectedItem + "' is not Updated", clsUtility.strProjectTitle);
                        LoadData();
                        ClearAll();
                        grpPurchaseInvoice.Enabled = false;
                        ObjDAL.ResetData();
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("Purchase Invoice for '" + cmbSupplier.SelectedItem + "' is not Updated", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("Purchase Invoice for '" + cmbSupplier.SelectedItem + "' is already exist..", clsUtility.strProjectTitle);
                    cmbSupplier.Focus();
                    ObjDAL.ResetData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure want to delete Supplier Bill No. '" + txtSupplierBillNo.Text + "'", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                if (ObjDAL.DeleteData(clsUtility.DBName + ".dbo.PurchaseInvoice", "PurchaseInvoiceID=" + ID + "") > 0)
                {
                    clsUtility.ShowInfoMessage("Supplier Bill No. '" + txtSupplierBillNo.Text + "' is deleted", clsUtility.strProjectTitle);
                    ClearAll();
                    LoadData();
                    grpPurchaseInvoice.Enabled = false;
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, clsUtility.IsAdmin);
                }
                else
                {
                    clsUtility.ShowInfoMessage("Supplier Bill No. '" + txtSupplierBillNo.Text + "' is not deleted", clsUtility.strProjectTitle);
                    ObjDAL.ResetData();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool b = clsUtility.ShowQuestionMessage(clsUtility.MsgActionCancel, clsUtility.strProjectTitle);
            if (b)
            {
                ClearAll();
                LoadData();
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel, clsUtility.IsAdmin);
                grpPurchaseInvoice.Enabled = false;
            }
        }

        private void txtSupplierBillNo_Enter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);
        }

        private void txtSupplierBillNo_Leave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick, clsUtility.IsAdmin);
                    ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PurchaseInvoiceID"].Value);
                    txtSupplierBillNo.Text = dataGridView1.SelectedRows[0].Cells["SupplierBillNo"].Value.ToString();
                    cmbSupplier.SelectedValue = dataGridView1.SelectedRows[0].Cells["SupplierID"].Value.ToString();
                    txtShipmentNo.Text = dataGridView1.SelectedRows[0].Cells["ShipmentNo"].Value.ToString();
                    txtBillValue.Text = dataGridView1.SelectedRows[0].Cells["BillValue"].Value.ToString();
                    txtTotalQTY.Text = dataGridView1.SelectedRows[0].Cells["TotalQTY"].Value.ToString();
                    dtpBillDate.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["BillDate"].Value);

                    grpPurchaseInvoice.Enabled = false;
                    txtSupplierBillNo.Focus();
                }
                catch { }
            }
        }

        private void txtSupplierBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtShipmentNo.Focus();
                return;
            }
        }

        private void txtShipmentNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cmbSupplier.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtShipmentNo.Focus();
                return;
            }
        }

        private void txtBillValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtTotalQTY.Focus();
                return;
            }
        }

        private void txtTotalQTY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtBillValue.Focus();
                return;
            }
        }

        private void Purchase_Invoice_Load(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = B_Leave;
            btnSave.BackgroundImage = B_Leave;
            btnEdit.BackgroundImage = B_Leave;
            btnUpdate.BackgroundImage = B_Leave;
            btnDelete.BackgroundImage = B_Leave;
            btnCancel.BackgroundImage = B_Leave;

            clsUtility.IsAdmin = true;//removed

            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning, clsUtility.IsAdmin);

            LoadData();
            FillSupplierData();
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

        private void rdSearchByShipment_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByShipment.Checked)
            {
                txtSearchByShipmentNo.Enabled = true;
                txtSearchByShipmentNo.Focus();
            }
            else
            {
                txtSearchByShipmentNo.Enabled = false;
                txtSearchByShipmentNo.Clear();
                rdShowAll.Checked = true;
            }
        }

        private void rdShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAll.Checked)
            {
                txtSearchByShipmentNo.Enabled = false;
                txtSearchByShipmentNo.Clear();
                LoadData();
            }
        }

        private void txtSearchByShipmentNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByShipmentNo.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.PurchaseInvoice", "PurchaseInvoiceID,SupplierBillNo,SupplierID,ShipmentNo,BillDate,BillValue,TotalQTY", "ShipmentNo LIKE '%" + txtSearchByShipmentNo.Text + "%'", "BillDate");
            if (ObjUtil.ValidateTable(dt))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["PurchaseInvoiceID"].Visible = false;
            //dataGridView1.Columns["SupplierID"].Visible = false;
            lblTotalRecords.Text = "Total Records : " + dataGridView1.Rows.Count;
        }
    }
}
