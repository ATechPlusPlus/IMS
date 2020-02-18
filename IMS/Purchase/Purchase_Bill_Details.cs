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
    public partial class Purchase_Bill_Details : Form
    {
        public Purchase_Bill_Details()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        DataTable dtPurchaseInvoice = new DataTable();

        int ID = 0;
        int pTotalQTY = 0;
        double pTotalAmt = 0;
        int PurchaseInvoiceID = 0;
        int _ProductID = 0;
        int _QTY = 0;

        Image B_Leave = IMS.Properties.Resources.B_click;
        Image B_Enter = IMS.Properties.Resources.B_on;
        private void ClearAll()
        {
            txtSupplierBillNo.Clear();
            txtModelNo.Clear();
            txtProductName.Clear();
            txtQTY.Clear();
            txtRate.Clear();
            txtProductID.Clear();
            cmbSupplier.SelectedIndex = -1;
            cmbBrand.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            dtPurchaseInvoice.Clear();

            txtTotalQTYBill.Text = "0";
            txtTotalQTYEntered.Text = "0";
            txtTotalValueBill.Text = "0";
            txtTotalValueEntered.Text = "0";
            txtSupplierBillNo.Focus();
        }

        private void ClearPurchaseInvoiceBillDetails()
        {
            txtModelNo.Clear();
            txtProductName.Clear();
            txtQTY.Clear();
            txtRate.Clear();
            txtProductID.Clear();
            cmbBrand.SelectedIndex = -1;

            txtProductName.Focus();
        }

        private bool Validateform()
        {
            if (ObjUtil.IsControlTextEmpty(txtProductName))
            {
                clsUtility.ShowInfoMessage("Enter Product Name           ", clsUtility.strProjectTitle);
                txtProductName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtModelNo))
            {
                clsUtility.ShowInfoMessage("Enter Model Number           ", clsUtility.strProjectTitle);
                txtModelNo.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbBrand))
            {
                clsUtility.ShowInfoMessage("Select Brand for " + txtProductName.Text, clsUtility.strProjectTitle);
                cmbBrand.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtQTY))
            {
                clsUtility.ShowInfoMessage("Enter Qty           ", clsUtility.strProjectTitle);
                txtQTY.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtRate))
            {
                clsUtility.ShowInfoMessage("Enter Rate           ", clsUtility.strProjectTitle);
                txtRate.Focus();
                return false;
            }
            return true;
        }

        private void FillSupplierData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.SupplierMaster", "SupplierID,SupplierName", "ISNULL(ActiveStatus,1)=1", "SupplierName ASC");
            cmbSupplier.DataSource = dt;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierID";

            cmbSupplier.SelectedIndex = -1;
        }

        private void FillBrandData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.BrandMaster", "BrandID,BrandName", "ISNULL(ActiveStatus,1)=1", "BrandName ASC");
            cmbBrand.DataSource = dt;
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "BrandID";

            cmbBrand.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtPurchaseInvoiceBill = (DataTable)dataGridView1.DataSource;
            if (ObjUtil.ValidateTable(dtPurchaseInvoiceBill))
            {
                int _ID = 0;
                bool b = false;
                for (int i = 0; i < dtPurchaseInvoiceBill.Rows.Count; i++)
                {
                    _ID = 0;
                    ObjDAL.SetColumnData("PurchaseInvoiceID", SqlDbType.Int, PurchaseInvoiceID);
                    ObjDAL.SetColumnData("SupplierBillNo", SqlDbType.NVarChar, txtSupplierBillNo.Text.Trim());
                    ObjDAL.SetColumnData("SupplierID", SqlDbType.Int, cmbSupplier.SelectedValue);
                    ObjDAL.SetColumnData("BillDate", SqlDbType.Date, dtpBillDate.Value.ToString("yyyy-MM-dd"));
                    ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
                    _ProductID = Convert.ToInt32(dtPurchaseInvoiceBill.Rows[i]["ProductID"]);
                    ObjDAL.SetColumnData("ProductID", SqlDbType.Int, _ProductID);
                    ObjDAL.SetColumnData("ModelNo", SqlDbType.NVarChar, dtPurchaseInvoiceBill.Rows[i]["ModelNo"].ToString());
                    ObjDAL.SetColumnData("BrandID", SqlDbType.Int, dtPurchaseInvoiceBill.Rows[i]["BrandID"].ToString());
                    _QTY = Convert.ToInt32(dtPurchaseInvoiceBill.Rows[i]["QTY"]);
                    ObjDAL.SetColumnData("QTY", SqlDbType.Int, _QTY);
                    ObjDAL.SetColumnData("Rate", SqlDbType.Decimal, dtPurchaseInvoiceBill.Rows[i]["Rate"].ToString());

                    _ID = ObjDAL.InsertData(clsUtility.DBName + ".dbo.PurchaseInvoiceDetails", true);
                    b = AddProductStockMaster();
                }

                if (_ID > 0)
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);


                    if (b)
                        clsUtility.ShowInfoMessage("Purchase Invoice for '" + cmbSupplier.SelectedItem + "' is Saved Successfully..", clsUtility.strProjectTitle);

                    ClearAll();
                    grpPurchaseBillDetail.Enabled = false;
                }
                else
                {
                    clsUtility.ShowInfoMessage("Purchase Invoice for '" + cmbSupplier.SelectedItem + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                    ObjDAL.ResetData();
                }

            }
            else
            {
                //ObjDAL.UpdateColumnData("SupplierBillNo", SqlDbType.VarChar, txtSupplierBillNo.Text.Trim());
                //ObjDAL.UpdateColumnData("ProductID", SqlDbType.Int, txtProductID.Text.Trim());
                //ObjDAL.UpdateColumnData("ModelNo", SqlDbType.NVarChar, txtModelNo.Text.Trim());
                //ObjDAL.UpdateColumnData("BrandID", SqlDbType.Int, cmbBrand.SelectedValue);
                //ObjDAL.UpdateColumnData("QTY", SqlDbType.Int, txtQTY.Text);
                //ObjDAL.UpdateColumnData("Rate", SqlDbType.Decimal, txtRate.Text.Trim());
                //ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test
                //ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now);

                //if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.PurchaseInvoiceDetails", "PurchaseInvoiceID = " + PurchaseInvoiceID + "") > 0)
                //{
                //    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);

                //    clsUtility.ShowInfoMessage("Purchase Invoice for '" + cmbSupplier.SelectedItem + "' is Updated", clsUtility.strProjectTitle);
                //    ClearAll();
                //    grpPurchaseBillDetail.Enabled = false;
                //    ObjDAL.ResetData();
                //}
                //else
                //{
                //    clsUtility.ShowInfoMessage("Purchase Invoice for '" + cmbSupplier.SelectedItem + "' is not Updated", clsUtility.strProjectTitle);
                //    ObjDAL.ResetData();
                //}
            }
            dataGridView1.DataSource = dtPurchaseInvoice;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool b = clsUtility.ShowQuestionMessage(clsUtility.MsgActionCancel, clsUtility.strProjectTitle);
            if (b)
            {
                ClearAll();
                grpPurchaseBillDetail.Enabled = false;
            }
        }

        private void Purchase_Bill_Details_Load(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = B_Leave;
            btnSave.BackgroundImage = B_Leave;
            btnCancel.BackgroundImage = B_Leave;

            clsUtility.IsAdmin = true;//removed

            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning, clsUtility.IsAdmin);

            FillSupplierData();
            FillBrandData();
            InitItemTable();
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["BrandID"].Visible = false;
        }

        private void LoadData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.PurchaseInvoice", "PurchaseInvoiceID,SupplierBillNo,SupplierID,ShipmentNo,BillDate,BillValue,TotalQTY", "SupplierBillNo = '" + txtSupplierBillNo.Text.Trim() + "'", "BillDate");

            if (ObjUtil.ValidateTable(dt))
            {
                grpPurchaseBillDetail.Enabled = true;
                dtpBillDate.Value = dt.Rows[0]["BillDate"] != DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["BillDate"]) : DateTime.Now;
                cmbSupplier.SelectedValue = Convert.ToInt32(dt.Rows[0]["SupplierID"]);
                txtTotalValueBill.Text = Convert.ToDouble(dt.Rows[0]["BillValue"]).ToString();
                txtTotalQTYBill.Text = Convert.ToDouble(dt.Rows[0]["TotalQTY"]).ToString();
                PurchaseInvoiceID = Convert.ToInt32(dt.Rows[0]["PurchaseInvoiceID"]);

                txtDiffQty.Text = (Convert.ToInt32(txtTotalQTYBill.Text) - pTotalQTY).ToString();
                txtDiffValue.Text = (Convert.ToDouble(txtTotalValueBill.Text) - pTotalAmt).ToString();

                txtProductName.Focus();
            }
            else
            {
                grpPurchaseBillDetail.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ObjUtil.IsControlTextEmpty(txtSupplierBillNo))
            {
                clsUtility.ShowInfoMessage("Enter Supplier Bill No           ", clsUtility.strProjectTitle);
                txtSupplierBillNo.Focus();
                return;
            }
            LoadData();
        }

        private void txtSupplierBillNo_Enter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);
        }

        private void txtSupplierBillNo_Leave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
        }

        private bool AddProductStockMaster()
        {
            int deafultStoreID = ObjDAL.ExecuteScalarInt("SELECT Storeid FROM " + clsUtility.DBName + ".[dbo].[DefaultStoreSetting] WHERE MachineName = '" + Environment.MachineName + "'");

            int pcount = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.ProductStockMaster", "ProductID=" + _ProductID + " AND StoreID = " + deafultStoreID);

            if (pcount == 0)
            {
                ObjDAL.SetColumnData("ProductID", SqlDbType.Int, _ProductID);
                ObjDAL.SetColumnData("QTY", SqlDbType.Int, _QTY);
                ObjDAL.SetColumnData("StoreID", SqlDbType.Int, deafultStoreID);
                ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
                if (ObjDAL.InsertData(clsUtility.DBName + ".dbo.ProductStockMaster", true) > 0)
                {
                    return true;
                }
            }
            else
            {
                int pQTY = ObjDAL.ExecuteScalarInt("SELECT Storeid FROM " + clsUtility.DBName + ".[dbo].[ProductStockMaster] WHERE ProductID=" + _ProductID + " AND StoreID = " + deafultStoreID);

                ObjDAL.UpdateColumnData("QTY", SqlDbType.Int, (pQTY + _QTY));
                ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test
                ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now);

                if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.ProductStockMaster", "ProductID=" + _ProductID + " AND StoreID = " + deafultStoreID) > 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtProductName.Text.Length > 0) // if manual entry
            {
                try
                {
                    string query = "SELECT ProductID, ProductName FROM " + clsUtility.DBName + ".dbo.ProductMaster";
                    DataTable dt = ObjDAL.ExecuteSelectStatement(query + " WHERE ProductName Like '" + txtProductName.Text + "%'");
                    if (ObjUtil.ValidateTable(dt))
                    {
                        ObjUtil.SetControlData(txtProductName, "ProductName");
                        ObjUtil.SetControlData(txtProductID, "ProductID");

                        ObjUtil.ShowDataPopup(dt, txtProductName, this, grpPurchaseBillDetail);

                        if (ObjUtil.GetDataPopup() != null && ObjUtil.GetDataPopup().DataSource != null)
                        {
                            // if there is only one column                
                            ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (ObjUtil.GetDataPopup().ColumnCount > 0)
                            {
                                ObjUtil.GetDataPopup().Columns["ProductID"].Visible = false;
                                ObjUtil.SetDataPopupSize(350, 0);


                            }
                        }
                        ObjUtil.GetDataPopup().CellClick += Purchase_Bill_Details_CellClick;
                        ObjUtil.GetDataPopup().KeyDown += Purchase_Bill_Details_KeyDown;
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
        }

        private void Purchase_Bill_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null)
            {
                GetItemDetailsByProductID(txtProductID.Text);
            }
        }

        private void Purchase_Bill_Details_KeyDown(object sender, KeyEventArgs e)
        {
            txtProductName.Focus();
        }

        private void GetItemDetailsByProductID(string productID)
        {
            string strQ = "select ProductID, ProductName from " + clsUtility.DBName + ".dbo.ProductMaster WHERE ProductID = " + productID;
            DataTable dt = ObjDAL.ExecuteSelectStatement(strQ);
            if (ObjUtil.ValidateTable(dt))
            {
                //string name = dt.Rows[0]["ProductName"].ToString();
                //string rate = dt.Rows[0]["Rate"].ToString();
                //string qty = "1";

                //decimal total = Convert.ToDecimal(rate) * Convert.ToDecimal(qty);
                //AddRowToItemDetails();

                //CalculateSubTotal();
            }
        }

        private void AddRowToItemDetails()
        {
            DataRow dRow = dtPurchaseInvoice.NewRow();
            dRow["ProductID"] = txtProductID.Text;
            dRow["ProductName"] = txtProductName.Text;
            dRow["BrandID"] = cmbBrand.SelectedValue;
            dRow["ModelNo"] = txtModelNo.Text;
            dRow["QTY"] = txtQTY.Text;
            dRow["Rate"] = txtRate.Text;
            dRow["Total"] = (Convert.ToInt32(txtQTY.Text) * Convert.ToDouble(txtRate.Text));

            dtPurchaseInvoice.Rows.Add(dRow);
            dtPurchaseInvoice.AcceptChanges();
            dataGridView1.DataSource = dtPurchaseInvoice;
            CalculateSubTotal();
            btnSave.Enabled = true;
        }

        private void InitItemTable()
        {
            dtPurchaseInvoice.Columns.Add("ProductID");
            dtPurchaseInvoice.Columns.Add("ProductName");
            dtPurchaseInvoice.Columns.Add("ModelNo");
            dtPurchaseInvoice.Columns.Add("BrandID");
            dtPurchaseInvoice.Columns.Add("QTY");
            dtPurchaseInvoice.Columns.Add("Rate");
            dtPurchaseInvoice.Columns.Add("Total");

            DataGridViewButtonColumn ColDelete = new DataGridViewButtonColumn();
            ColDelete.DataPropertyName = "Delete";
            ColDelete.HeaderText = "Delete";
            ColDelete.Name = "ColDelete";
            ColDelete.Text = "Delete";
            ColDelete.UseColumnTextForButtonValue = true;

            dtPurchaseInvoice.AcceptChanges();
            dataGridView1.DataSource = dtPurchaseInvoice;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            ColDelete});
        }

        private void linkAddPurchaseBillItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ObjUtil.IsControlTextEmpty(txtProductName))
            {
                clsUtility.ShowInfoMessage("Please Enter Product Name ", clsUtility.strProjectTitle);
                txtProductName.Focus();
                return;
            }
            else if (ObjUtil.IsControlTextEmpty(txtModelNo))
            {
                clsUtility.ShowInfoMessage("Please Model Number ", clsUtility.strProjectTitle);
                txtModelNo.Focus();
                return;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbBrand))
            {
                clsUtility.ShowInfoMessage("Please Select Brand Name ", clsUtility.strProjectTitle);
                cmbBrand.Focus();
                return;
            }
            else if (ObjUtil.IsControlTextEmpty(txtQTY))
            {
                clsUtility.ShowInfoMessage("Please Enter Quantity ", clsUtility.strProjectTitle);
                txtQTY.Focus();
                return;
            }
            else if (ObjUtil.IsControlTextEmpty(txtRate))
            {
                clsUtility.ShowInfoMessage("Please Enter Rate ", clsUtility.strProjectTitle);
                txtRate.Focus();
                return;
            }
            else if (Convert.ToInt32(txtQTY.Text) <= 0)
            {
                clsUtility.ShowInfoMessage("Please Enter Valid Quantity ", clsUtility.strProjectTitle);
                txtQTY.Focus();
                return;
            }
            else if (Convert.ToDouble(txtRate.Text) <= 0)
            {
                clsUtility.ShowInfoMessage("Please Enter Valid Rate ", clsUtility.strProjectTitle);
                txtRate.Focus();
                return;
            }
            AddRowToItemDetails();
            ClearPurchaseInvoiceBillDetails();
        }

        private void CalculateSubTotal()
        {
            pTotalQTY = 0;
            pTotalAmt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                pTotalQTY += Convert.ToInt32(dataGridView1.Rows[i].Cells["QTY"].Value);
                pTotalAmt += Convert.ToDouble(dataGridView1.Rows[i].Cells["Total"].Value);
            }
            txtTotalQTYEntered.Text = pTotalQTY.ToString();
            txtTotalValueEntered.Text = pTotalAmt.ToString();

            txtDiffQty.Text = (Convert.ToInt32(txtTotalQTYBill.Text) - pTotalQTY).ToString();
            txtDiffValue.Text = (Convert.ToDouble(txtTotalValueBill.Text) - pTotalAmt).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ColDelete")
            {

                DialogResult d = MessageBox.Show("Are you sure want to delete ? ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    dataGridView1.EndEdit();
                    CalculateSubTotal();
                    txtProductName.Focus();
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Rate" ||
                dataGridView1.Columns[e.ColumnIndex].Name == "QTY")
            {
                int QTY = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["QTY"].Value);
                double Rate = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Rate"].Value);
                double Total = QTY * Rate;

                dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = Total.ToString();
                CalculateSubTotal();
            }
        }
    }
}
