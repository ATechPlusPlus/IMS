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
    public partial class Posting_Delivery : Form
    {
        public Posting_Delivery()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;
        int ProductID = 0;

        Image B_Leave = IMS.Properties.Resources.B_click;
        Image B_Enter = IMS.Properties.Resources.B_on;

        private bool validateform()
        {
            if (ObjUtil.IsControlTextEmpty(cmbEntryType))
            {
                clsUtility.ShowInfoMessage("Please Select Entry Type for Post..", clsUtility.strProjectTitle);
                cmbEntryType.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtSupplierBillNo))
            {
                clsUtility.ShowInfoMessage("Please Enter Supplier Bill Number for Post..", clsUtility.strProjectTitle);
                txtSupplierBillNo.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtTotalQTY))
            {
                clsUtility.ShowInfoMessage("QTY is not available for Post..", clsUtility.strProjectTitle);
                txtTotalQTY.Focus();
                return false;
            }
            return true;
        }

        private void ClearAll()
        {
            cmbEntryType.SelectedIndex = -1;
            cmbStore.SelectedIndex = -1;
            txtSupplierBillNo.Clear();
            txtTotalQTY.Clear();
            cmbEntryType.Focus();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (validateform())
            {
                bool b = clsUtility.ShowQuestionMessage("Are you sure want to post for " + txtSupplierBillNo.Text + " ?", clsUtility.strProjectTitle);
                if (b)
                {
                    DataTable dt = ObjDAL.ExecuteSelectStatement("EXEC Insert_Posting_Delivery " + ProductID + "," + cmbStore.SelectedValue + "," + txtTotalQTY.Text + "," + cmbEntryType.SelectedIndex + "," + txtSupplierBillNo.Text + "," + clsUtility.LoginID);
                    if (ObjUtil.ValidateTable(dt))
                    {
                        clsUtility.ShowInfoMessage("Posting Delivery Entry for '" + txtSupplierBillNo.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                        ClearAll();
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("Posting Delivery Entry for '" + txtSupplierBillNo.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                    }
                    #region below code for calling SP
                    //ObjDAL.SetColumnData("SupplierBillNo", SqlDbType.VarChar, txtSupplierBillNo.Text.Trim());
                    //ObjDAL.SetColumnData("EntryType", SqlDbType.Int, cmbEntryType.SelectedIndex);
                    //ObjDAL.SetColumnData("StoreID", SqlDbType.Int, cmbStore.SelectedValue);
                    //ObjDAL.SetColumnData("TotalQTY", SqlDbType.Int, txtTotalQTY.Text.Trim());
                    //if (ObjDAL.InsertData(clsUtility.DBName + ".dbo.PostingDeliveryEntry", true) > 0)
                    //{
                    //    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                    //    clsUtility.ShowInfoMessage("Posting Delivery Entry for '" + txtSupplierBillNo.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                    //    ClearAll();
                    //}
                    //else
                    //{
                    //    clsUtility.ShowInfoMessage("Posting Delivery Entry for '" + txtSupplierBillNo.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                    //    ObjDAL.ResetData();
                    //}
                    #endregion
                }
            }
        }

        private void FillStoreData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.StoreMaster", "StoreID,StoreName", "ISNULL(ActiveStatus,1)=1", "StoreName ASC");
            cmbStore.DataSource = dt;
            cmbStore.DisplayMember = "StoreName";
            cmbStore.ValueMember = "StoreID";

            cmbStore.SelectedIndex = -1;
        }

        private void txtSupplierBillNo_Enter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);
        }

        private void txtSupplierBillNo_Leave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
        }

        private void btnPost_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnPost_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }

        private void Posting_Delivery_Load(object sender, EventArgs e)
        {
            btnPost.BackgroundImage = B_Leave;
            btnCancel.BackgroundImage = B_Leave;

            FillStoreData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtSupplierBillNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierBillNo.Text.Length > 0) // if manual entry
                {
                    string query = "SELECT PurchaseInvoiceID, SupplierBillNo,ShipmentNo,BillDate,TotalQTY FROM " + clsUtility.DBName + ".dbo.PurchaseInvoice";
                    DataTable dt = ObjDAL.ExecuteSelectStatement(query + " WHERE ISNULL(IsInvoiceDone,0) = 0 AND SupplierBillNo Like '" + txtSupplierBillNo.Text + "%'");
                    if (ObjUtil.ValidateTable(dt))
                    {
                        ObjUtil.SetControlData(txtSupplierBillNo, "SupplierBillNo");
                        ObjUtil.SetControlData(txtPurchaseInvoiceID, "PurchaseInvoiceID");

                        ObjUtil.ShowDataPopup(dt, txtSupplierBillNo, this, this);

                        if (ObjUtil.GetDataPopup() != null && ObjUtil.GetDataPopup().DataSource != null)
                        {
                            // if there is only one column                
                            ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (ObjUtil.GetDataPopup().ColumnCount > 0)
                            {
                                ObjUtil.GetDataPopup().Columns["PurchaseInvoiceID"].Visible = false;
                                ObjUtil.SetDataPopupSize(300, 0);
                            }
                        }
                        ObjUtil.GetDataPopup().CellClick += Posting_Delivery_CellClick;
                        ObjUtil.GetDataPopup().KeyDown += Posting_Delivery_KeyDown;
                    }
                    else
                    {
                        ObjUtil.CloseAutoExtender();
                    }
                }
                else
                {
                    ObjUtil.CloseAutoExtender();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Posting_Delivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null)
            {
                //GetItemDetailsByProductID(txtPurchaseInvoiceID.Text);
            }
        }

        private void Posting_Delivery_KeyDown(object sender, KeyEventArgs e)
        {
            txtSupplierBillNo.SelectionStart = txtSupplierBillNo.MaxLength;
            txtSupplierBillNo.Focus();

            DataTable dt = ObjDAL.ExecuteSelectStatement("EXEC Get_Posting_Delivery_QTY " + txtPurchaseInvoiceID.Text);
            if (ObjUtil.ValidateTable(dt))
            {
                ProductID = Convert.ToInt32(dt.Rows[0]["ProductID"]);
                cmbStore.SelectedValue = dt.Rows[0]["StoreID"].ToString();
                txtTotalQTY.Text = dt.Rows[0]["Total"].ToString();
            }
        }
    }
}
