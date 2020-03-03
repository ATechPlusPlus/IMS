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
    public partial class Delivering_Purchase_Bill : Form
    {
        public Delivering_Purchase_Bill()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        DataTable dtPurchaseQTYColor = new DataTable();
        DataTable dtPurchaseInvoice = new DataTable();

        int ID = 0;
        int flag = 0;
        int ProductID = 0;

        Image B_Leave = IMS.Properties.Resources.B_click;
        Image B_Enter = IMS.Properties.Resources.B_on;

        private void FillBrandData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.BrandMaster", "BrandID,BrandName", "ISNULL(ActiveStatus,1)=1", "BrandName ASC");
            cmbBrand.DataSource = dt;
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "BrandID";

            cmbBrand.SelectedIndex = -1;
        }

        private void FillCountryData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.CountryMaster", "CountryID,CountryName", "ISNULL(ActiveStatus,1)=1", "CountryName ASC");
            cmbCountry.DataSource = dt;
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";

            cmbCountry.SelectedIndex = -1;
        }

        private void FillSizeTypeData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.SizeTypeMaster", "SizeTypeID,SizeTypeName", "ISNULL(ActiveStatus,1)=1", "SizeTypeName ASC");
            cmbSizeType.DataSource = dt;
            cmbSizeType.DisplayMember = "SizeTypeName";
            cmbSizeType.ValueMember = "SizeTypeID";

            cmbSizeType.SelectedIndex = -1;
        }

        private void FillStoreData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.StoreMaster", "StoreID,StoreName", "ISNULL(ActiveStatus,1)=1", "StoreName ASC");
            cmbStore.DataSource = dt;
            cmbStore.DisplayMember = "StoreName";
            cmbStore.ValueMember = "StoreID";

            cmbStore.SelectedIndex = -1;
        }

        private void FillCategoryData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.CategoryMaster", "CategoryID,CategoryName", "ISNULL(ActiveStatus,1)=1", "CategoryName ASC");
            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "CategoryName";
            cmbDepartment.ValueMember = "CategoryID";

            cmbDepartment.SelectedIndex = -1;
        }

        private void Delivering_Purchase_Bill_Load(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = B_Leave;
            btnSave.BackgroundImage = B_Leave;
            btnEdit.BackgroundImage = B_Leave;
            btnUpdate.BackgroundImage = B_Leave;
            btnDelete.BackgroundImage = B_Leave;
            btnCancel.BackgroundImage = B_Leave;
            btnSearch.BackgroundImage = B_Leave;

            clsUtility.IsAdmin = true;//removed

            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning, clsUtility.IsAdmin);

            FillStoreData();
            FillSizeTypeData();
            FillCountryData();
            FillBrandData();
            FillCategoryData();

            //InitItemTable();
        }

        private void InitItemTable()
        {
            dtPurchaseQTYColor.Columns.Clear();
            dtPurchaseQTYColor.Columns.Add("DeliveryPurchaseID3", typeof(int));
            dtPurchaseQTYColor.Columns.Add("Color", typeof(string));
            dtPurchaseQTYColor.Columns.Add("ColorID", typeof(int));
            dtPurchaseQTYColor.AcceptChanges();
            dgvQtycolor.DataSource = dtPurchaseQTYColor;
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

        private void txtSupplierBillNo_Enter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);
        }

        private void txtSupplierBillNo_Leave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ObjUtil.IsControlTextEmpty(txtSupplierBillNo))
            {
                clsUtility.ShowInfoMessage("Enter Supplier Bill No           ", clsUtility.strProjectTitle);
                txtSupplierBillNo.Focus();
                return;
            }
            dgvQtycolor.Enabled = false;
            cmbStore.Enabled = true;
            LoadData();
        }

        private void listBoxModelNo_KeyDown(object sender, KeyEventArgs e)
        {
            DataRow[] dRow = dtPurchaseInvoice.Select("ModelNo= '" + listBoxModelNo.SelectedItem + "'");
            if (dRow.Length > 0)
            {
                ID = Convert.ToInt32(dRow[0]["PurchaseInvoiceID"]);
                ProductID = Convert.ToInt32(dRow[0]["ProductID"]);
                cmbBrand.SelectedValue = dRow[0]["BrandID"];
                cmbCountry.SelectedValue = dRow[0]["CountryID"];
                cmbDepartment.SelectedValue = dRow[0]["CategoryID"];
                txtItemName.Text = dRow[0]["ProductName"].ToString();
                txtTotalQTYBill.Text = dRow[0]["QTY"].ToString();
                cmbSizeType.SelectedValue = dRow[0]["SizeTypeID"].ToString();
                Load_Color_SizeData();
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["PurchaseInvoiceDetailsID"].Visible = false;
            dataGridView1.Columns["PurchaseInvoiceID"].Visible = false;
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["BrandID"].Visible = false;
            dataGridView1.Columns["SupplierID"].Visible = false;
            dataGridView1.Columns["CategoryID"].Visible = false;
            dataGridView1.Columns["CountryID"].Visible = false;
            //lblTotalRecords.Text = "Total Records : " + dataGridView1.Rows.Count;
        }

        private void cmbSizeType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.SizeMaster", "SizeID,Size,SizeTypeID", "ISNULL(ActiveStatus,1) = 1 AND SizeTypeID = " + cmbSizeType.SelectedValue, null);
            if (ObjUtil.ValidateTable(dt))
            {
                InitItemTable();
                dgvQtycolor.Enabled = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dtPurchaseQTYColor.Columns.Add(dt.Rows[i]["Size"].ToString());
                }
                dtPurchaseQTYColor.Columns.Add("Total", typeof(int));
                //if (dgvQtycolor.Rows.Count == 0)
                //{
                DataRow dRow = dtPurchaseQTYColor.NewRow();
                dtPurchaseQTYColor.Rows.Add(dRow);
                ///}
                dtPurchaseQTYColor.AcceptChanges();
                dgvQtycolor.DataSource = dtPurchaseQTYColor;
                //Load_Color_SizeData();
            }
        }

        private void Load_Color_SizeData()
        {
            //DataTable dt = ObjDAL.ExecuteSelectStatement("EXEC [dbo].[Get_PurchaseInvoice_Color_Size] '" + txtSupplierBillNo.Text + "', " + listBoxModelNo.SelectedItem + "");

            dtPurchaseQTYColor = ObjDAL.ExecuteSelectStatement("EXEC [dbo].[Get_PurchaseInvoice_Color_Size] '" + txtSupplierBillNo.Text + "', " + listBoxModelNo.SelectedItem + "");
            if (ObjUtil.ValidateTable(dtPurchaseQTYColor))
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick, clsUtility.IsAdmin);
                dgvQtycolor.ReadOnly = true;
                dgvQtycolor.DataSource = dtPurchaseQTYColor;
                cmbSizeType.Enabled = false;
            }
            else
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
                dgvQtycolor.ReadOnly = false;
                dgvQtycolor.DataSource = null;
                cmbSizeType.Enabled = true;
            }
        }
        private void listBoxModelNo_MouseClick(object sender, MouseEventArgs e)
        {
            DataRow[] dRow = dtPurchaseInvoice.Select("ModelNo= '" + listBoxModelNo.SelectedItem + "'");
            if (dRow.Length > 0)
            {
                //cmbSizeType.Enabled = true;
                ID = Convert.ToInt32(dRow[0]["PurchaseInvoiceID"]);
                ProductID = Convert.ToInt32(dRow[0]["ProductID"]);
                cmbBrand.SelectedValue = dRow[0]["BrandID"];
                cmbCountry.SelectedValue = dRow[0]["CountryID"];
                cmbDepartment.SelectedValue = dRow[0]["CategoryID"];
                txtItemName.Text = dRow[0]["ProductName"].ToString();
                txtTotalQTYBill.Text = dRow[0]["QTY"].ToString();
                cmbSizeType.SelectedValue = dRow[0]["SizeTypeID"].ToString();
                Load_Color_SizeData();
            }
            else
                cmbSizeType.Enabled = false;
        }

        private void dgvQtycolor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int pTotalEnteredQTY = 0;
            if (e.ColumnIndex == 0)
            {
                int a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.ColorMaster", "ColorName = '" + dgvQtycolor.Rows[e.RowIndex].Cells["Color"].Value + "' AND ISNULL(ActiveStatus,1) = 1");
                if (a <= 0)
                {
                    flag = 1;
                    clsUtility.ShowInfoMessage("Color Name " + dgvQtycolor.Rows[e.RowIndex].Cells["Color"].Value + " is not present in Color Master", clsUtility.strProjectTitle);
                }
                else
                {
                    int ColorID = ObjDAL.ExecuteScalarInt("SELECT ColorID FROM " + clsUtility.DBName + ".dbo.ColorMaster WHERE ColorName = '" + dgvQtycolor.Rows[e.RowIndex].Cells["Color"].Value + "' AND ISNULL(ActiveStatus,1) = 1");
                    dtPurchaseQTYColor.Rows[e.RowIndex]["ColorID"] = ColorID;
                    flag = 0;
                }
            }
            else
            {
                DataRow[] dRow = dtPurchaseQTYColor.Select("Color= '" + dgvQtycolor.Rows[e.RowIndex].Cells["Color"].Value + "'");
                if (dRow.Length > 0)
                {
                    for (int i = 3; i < dtPurchaseQTYColor.Columns.Count - 1; i++)
                    {
                        pTotalEnteredQTY += dRow[0][dtPurchaseQTYColor.Columns[i]] != DBNull.Value ?
                            Convert.ToInt32(dRow[0][dtPurchaseQTYColor.Columns[i]]) : 0;
                    }
                    dgvQtycolor.Rows[e.RowIndex].Cells["Total"].Value = pTotalEnteredQTY;
                    if (pTotalEnteredQTY > Convert.ToInt32(txtTotalQTYBill.Text))
                    {
                        clsUtility.ShowInfoMessage("Entered QTY can't be greater then QTY Bill", clsUtility.strProjectTitle);
                    }
                    txtTotalQTYEntered.Text = pTotalEnteredQTY.ToString();
                    CalcTotalColorQTY();
                }
            }
        }
        private void ClearAll()
        {
            txtSupplierBillNo.Clear();
            txtItemName.Clear();
            txtDiffQty.Text = "0";
            txtTotalQTY.Text = "0";
            txtTotalQTYBill.Text = "0";
            txtTotalQTYEntered.Text = "0";
            cmbBrand.SelectedIndex = -1;
            cmbCountry.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbSizeType.SelectedIndex = -1;
            cmbStore.SelectedIndex = -1;
            listBoxModelNo.Items.Clear();
            dtPurchaseQTYColor.Clear();
            dtPurchaseInvoice.Clear();
            dgvQtycolor.DataSource = null;
            //dataGridView1.DataSource = null;
        }

        private void Clear_ColorSize()
        {
            //txtSupplierBillNo.Clear();
            txtItemName.Clear();
            txtDiffQty.Text = "0";
            txtTotalQTY.Text = "0";
            txtTotalQTYBill.Text = "0";
            txtTotalQTYEntered.Text = "0";
            //cmbBrand.SelectedIndex = -1;
            //cmbCountry.SelectedIndex = -1;
            //cmbDepartment.SelectedIndex = -1;
            cmbSizeType.SelectedIndex = -1;
            //cmbStore.SelectedIndex = -1;
            //listBoxModelNo.Items.Clear();
            dtPurchaseQTYColor.Clear();
            //dtPurchaseInvoice.Clear();
            dgvQtycolor.DataSource = null;
            //dataGridView1.DataSource = null;
        }
        private bool Validateform()
        {
            if (ObjUtil.IsControlTextEmpty(txtSupplierBillNo))
            {
                clsUtility.ShowInfoMessage("Enter Supplier Bill No           ", clsUtility.strProjectTitle);
                txtSupplierBillNo.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbStore))
            {
                clsUtility.ShowInfoMessage("Select Store for Supplier Bill No " + txtSupplierBillNo.Text, clsUtility.strProjectTitle);
                cmbStore.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbSizeType))
            {
                clsUtility.ShowInfoMessage("Select Size Type           ", clsUtility.strProjectTitle);
                cmbSizeType.Focus();
                return false;
            }
            else if (!ObjUtil.ValidateTable(dtPurchaseQTYColor))
            {
                clsUtility.ShowInfoMessage("Enter Color and Qty           ", clsUtility.strProjectTitle);
                dgvQtycolor.Focus();
                return false;
            }
            else if (ObjUtil.ValidateTable(dtPurchaseQTYColor))
            {
                for (int i = 0; i < dtPurchaseQTYColor.Rows.Count; i++)
                {
                    if (dtPurchaseQTYColor.Rows[i]["ColorID"] == DBNull.Value)
                    {
                        clsUtility.ShowInfoMessage("Enter Valid Colour Name.         ", clsUtility.strProjectTitle);
                        return false;
                    }
                }
                return true;
            }
            else if (Convert.ToInt32(txtDiffQty) < 0)
            {
                clsUtility.ShowInfoMessage("Entered QTY can't be greater then Billed QTY", clsUtility.strProjectTitle);
                dgvQtycolor.Focus();
                return false;
            }
            return true;
        }

        private bool DuplicateUser(int i)
        {
            string listbox = listBoxModelNo.SelectedItem.ToString();
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.DeliveryPurchaseBill1", "SizeTypeID=" + cmbSizeType.SelectedValue + " AND SupplierBillNo='" + txtSupplierBillNo.Text + "' AND ModelNo='" + listBoxModelNo.SelectedItem + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.DeliveryPurchaseBill1", "SizeTypeID=" + cmbSizeType.SelectedValue + " AND SupplierBillNo='" + txtSupplierBillNo.Text + "'" +
                    "AND ModelNo='" + listBoxModelNo.SelectedItem + "' AND DeliveryPurchaseID1 !=" + i);
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
        private void CalcTotalColorQTY()
        {
            if (dtPurchaseQTYColor.Columns.Contains("Total"))
            {
                object ob = dtPurchaseQTYColor.Compute("SUM(Total)", null);
                txtTotalQTYEntered.Text = ob.ToString();
            }
            int pTotal = txtTotalQTYEntered.Text.Length > 0 ? Convert.ToInt32(txtTotalQTYEntered.Text) : 0;
            txtDiffQty.Text = (Convert.ToInt32(txtTotalQTYBill.Text) - pTotal).ToString();
        }
        private int DataSavedDeliveryPurchaseBill2(int ID)
        {
            ObjDAL.SetColumnData("DeliveryPurchaseID1", SqlDbType.Int, ID);
            for (int i = 3; i < dtPurchaseQTYColor.Columns.Count - 1; i++)
            {
                ObjDAL.SetColumnData("Col" + (i - 1), SqlDbType.VarChar, dtPurchaseQTYColor.Columns[i].ColumnName);
            }
            ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
            return ObjDAL.InsertData(clsUtility.DBName + ".dbo.DeliveryPurchaseBill2", true);
        }

        private int DataSavedDeliveryPurchaseBill3(int ID1, int ID2)
        {
            int a = 0;
            for (int i = 0; i < dtPurchaseQTYColor.Rows.Count; i++)
            {
                ObjDAL.SetColumnData("DeliveryPurchaseID1", SqlDbType.Int, ID1);
                ObjDAL.SetColumnData("DeliveryPurchaseID2", SqlDbType.Int, ID2);
                ObjDAL.SetColumnData("ColorID", SqlDbType.Int, Convert.ToInt32(dtPurchaseQTYColor.Rows[i]["ColorID"]));
                for (int j = 3; j < dtPurchaseQTYColor.Columns.Count - 1; j++)
                {
                    ObjDAL.SetColumnData("Col" + (j - 1), SqlDbType.VarChar, dtPurchaseQTYColor.Rows[i][j].ToString());
                }
                ObjDAL.SetColumnData("Total", SqlDbType.Int, Convert.ToInt32(dtPurchaseQTYColor.Rows[i]["Total"]));
                ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
                a = ObjDAL.InsertData(clsUtility.DBName + ".dbo.DeliveryPurchaseBill3", true);
            }

            return a;
        }

        private int DataUpdateDeliveryPurchaseBill2(int ID)
        {
            for (int i = 3; i < dtPurchaseQTYColor.Columns.Count - 1; i++)
            {
                ObjDAL.UpdateColumnData("Col" + (i - 1), SqlDbType.VarChar, dtPurchaseQTYColor.Columns[i].ColumnName);
            }
            ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
            ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now);
            return ObjDAL.UpdateData(clsUtility.DBName + ".dbo.DeliveryPurchaseBill2", "DeliveryPurchaseID1=" + ID);
        }

        private int DataUpdateDeliveryPurchaseBill3(int ID1, int ID2)
        {
            int a = 0;
            for (int i = 0; i < dtPurchaseQTYColor.Rows.Count; i++)
            {
                //ObjDAL.SetColumnData("DeliveryPurchaseID1", SqlDbType.Int, ID1);
                //ObjDAL.SetColumnData("DeliveryPurchaseID2", SqlDbType.Int, ID2);
                ObjDAL.UpdateColumnData("ColorID", SqlDbType.Int, Convert.ToInt32(dtPurchaseQTYColor.Rows[i]["ColorID"]));
                for (int j = 3; j < dtPurchaseQTYColor.Columns.Count - 1; j++)
                {
                    ObjDAL.UpdateColumnData("Col" + (j - 1), SqlDbType.VarChar, dtPurchaseQTYColor.Rows[i][j].ToString());
                }
                ObjDAL.UpdateColumnData("Total", SqlDbType.Int, Convert.ToInt32(dtPurchaseQTYColor.Rows[i]["Total"]));
                ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
                ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now);
                a = ObjDAL.UpdateData(clsUtility.DBName + ".dbo.DeliveryPurchaseBill3", "DeliveryPurchaseID1=" + ID1 + " AND DeliveryPurchaseID2=" + ID2 + " AND DeliveryPurchaseID3 = " + Convert.ToInt32(dtPurchaseQTYColor.Rows[i]["DeliveryPurchaseID3"]));
            }

            return a;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSupplierBillNo.Enabled = true;
            btnSearch.Enabled = true;
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            grpPurchaseBillDetail.Enabled = true;
            txtSupplierBillNo.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validateform())
            {
                if (DuplicateUser(0))
                {
                    int DeliveryPurchaseBillID = 0;
                    ObjDAL.SetColumnData("PurchaseInvoiceID", SqlDbType.Int, ID);
                    ObjDAL.SetColumnData("SupplierBillNo", SqlDbType.NVarChar, txtSupplierBillNo.Text.Trim());
                    ObjDAL.SetColumnData("SizeTypeID", SqlDbType.Int, cmbSizeType.SelectedValue);
                    ObjDAL.SetColumnData("ModelNo", SqlDbType.NVarChar, listBoxModelNo.SelectedItem);
                    ObjDAL.SetColumnData("ProductID", SqlDbType.Int, ProductID);
                    ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
                    DeliveryPurchaseBillID = ObjDAL.InsertData(clsUtility.DBName + ".dbo.DeliveryPurchaseBill1", true);
                    if (DeliveryPurchaseBillID > 0)
                    {
                        int DeliveryPurchaseBillID2 = DataSavedDeliveryPurchaseBill2(DeliveryPurchaseBillID);
                        int DeliveryPurchaseBillID3 = DataSavedDeliveryPurchaseBill3(DeliveryPurchaseBillID, DeliveryPurchaseBillID2);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                        clsUtility.ShowInfoMessage(clsUtility.MsgDataSaved, clsUtility.strProjectTitle);
                        //ClearAll();
                        Clear_ColorSize();
                        LoadData();
                        txtSupplierBillNo.Enabled = false;
                        btnSearch.Enabled = false;
                        //grpPurchaseBillDetail.Enabled = false;
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage(clsUtility.MsgDatanotSaved, clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("Purchase Invoice '" + txtSupplierBillNo.Text + "' is already exist..", clsUtility.strProjectTitle);
                    ObjDAL.ResetData();
                    txtSupplierBillNo.Focus();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
            grpPurchaseBillDetail.Enabled = true;
            txtSupplierBillNo.Focus();
            txtSupplierBillNo.SelectionStart = txtSupplierBillNo.MaxLength;
            dgvQtycolor.AllowUserToAddRows = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validateform())
            {
                if (DuplicateUser(ID))
                {
                    int DeliveryPurchaseBillID = 0;
                    //ObjDAL.SetColumnData("PurchaseInvoiceID", SqlDbType.Int, ID);
                    ObjDAL.UpdateColumnData("ProductID", SqlDbType.Int, ProductID);
                    ObjDAL.UpdateColumnData("SupplierBillNo", SqlDbType.NVarChar, txtSupplierBillNo.Text.Trim());
                    ObjDAL.UpdateColumnData("SizeTypeID", SqlDbType.Int, cmbSizeType.SelectedValue);
                    ObjDAL.UpdateColumnData("ModelNo", SqlDbType.NVarChar, listBoxModelNo.SelectedItem);
                    ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
                    ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now);
                    DeliveryPurchaseBillID = ObjDAL.UpdateData(clsUtility.DBName + ".dbo.DeliveryPurchaseBill1", "PurchaseInvoiceID=" + ID);
                    if (DeliveryPurchaseBillID > 0)
                    {
                        int DeliveryPurchaseBillID2 = DataUpdateDeliveryPurchaseBill2(DeliveryPurchaseBillID);
                        int DeliveryPurchaseBillID3 = DataUpdateDeliveryPurchaseBill3(DeliveryPurchaseBillID, DeliveryPurchaseBillID2);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                        clsUtility.ShowInfoMessage(clsUtility.MsgDataSaved, clsUtility.strProjectTitle);
                        //ClearAll();
                        Clear_ColorSize();
                        LoadData();
                        txtSupplierBillNo.Enabled = false;
                        btnSearch.Enabled = false;
                        //grpPurchaseBillDetail.Enabled = false;
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage(clsUtility.MsgDatanotSaved, clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("Purchase Invoice '" + txtSupplierBillNo.Text + "' is already exist..", clsUtility.strProjectTitle);
                    ObjDAL.ResetData();
                    txtSupplierBillNo.Focus();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool d = clsUtility.ShowQuestionMessage("Are you sure want to delete Supplier Bill No. '" + txtSupplierBillNo.Text + "'", clsUtility.strProjectTitle);
            if (d)
            {
                DataTable dt = ObjDAL.ExecuteSelectStatement("EXEC Delete_PurchaseInvoice_Color_Size " + ID);
                if (ObjUtil.ValidateTable(dt))
                {
                    clsUtility.ShowInfoMessage("Supplier Bill No. '" + txtSupplierBillNo.Text + "' is deleted", clsUtility.strProjectTitle);
                    ClearAll();
                    LoadData();
                    grpPurchaseBillDetail.Enabled = false;
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
                grpPurchaseBillDetail.Enabled = false;
            }
        }

        private void dgvQtycolor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetDataGridProperty(dgvQtycolor, DataGridViewAutoSizeColumnsMode.Fill);
            //dgvQtycolor.Columns["ColorID"].Visible = false;
            if (dgvQtycolor.Columns.Contains("ColorID"))
            {
                dgvQtycolor.Columns["ColorID"].Visible = false;
            }
            if (dgvQtycolor.Columns.Contains("DeliveryPurchaseID3"))
            {
                dgvQtycolor.Columns["DeliveryPurchaseID3"].Visible = false;
            }
            if (dgvQtycolor.Columns.Contains("Total"))
            {
                dgvQtycolor.Columns["Total"].ReadOnly = true;
            }
        }

        private void dgvQtycolor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQtycolor.Columns.Contains("Total"))
                {
                    txtTotalQTYEntered.Text = dgvQtycolor.Rows[e.RowIndex].Cells["Total"].Value.ToString();
                }
                CalcTotalColorQTY();
            }
            catch { }
        }

        private void LoadData()
        {
            if (!ObjUtil.IsControlTextEmpty(txtSupplierBillNo))
            {
                dtPurchaseInvoice = ObjDAL.ExecuteSelectStatement("EXEC [dbo].[Get_Delivering_PurchaseInvoice_BillDetails] '" + txtSupplierBillNo.Text + "'");

                if (ObjUtil.ValidateTable(dtPurchaseInvoice))
                {
                    listBoxModelNo.Items.Clear();
                    for (int i = 0; i < dtPurchaseInvoice.Rows.Count; i++)
                    {
                        listBoxModelNo.Items.Add(dtPurchaseInvoice.Rows[i]["ModelNo"].ToString());
                    }
                    grpPurchaseBillDetail.Enabled = true;
                    dataGridView1.DataSource = dtPurchaseInvoice;
                    object qty = dtPurchaseInvoice.Compute("SUM(QTY)", null);
                    txtTotalQTY.Text = qty.ToString();
                }
                else
                {
                    clsUtility.ShowInfoMessage("Purchase Invoice Bill is already done OR not available for Bill No. " + txtSupplierBillNo.Text, clsUtility.strProjectTitle);
                    grpPurchaseBillDetail.Enabled = false;
                    txtTotalQTY.Text = "0";
                    dataGridView1.DataSource = null;
                }
            }
        }
    }
}
