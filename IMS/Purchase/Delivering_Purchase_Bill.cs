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
        int ID = 0, QTYEntered = 0;

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

            InitItemTable();
        }

        private void InitItemTable()
        {
            dtPurchaseQTYColor.Columns.Clear();
            dtPurchaseQTYColor.Columns.Add("Color");
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
            cmbSizeType.Enabled = true;
            LoadData();
        }

        private void listBoxModelNo_KeyDown(object sender, KeyEventArgs e)
        {
            DataRow[] dRow = dtPurchaseInvoice.Select("ModelNo= '" + listBoxModelNo.SelectedItem + "'");
            if (dRow.Length > 0)
            {
                cmbBrand.SelectedValue = dRow[0]["BrandID"];
                cmbCountry.SelectedValue = dRow[0]["CountryID"];
                cmbDepartment.SelectedValue = dRow[0]["CategoryID"];
                txtItemName.Text = dRow[0]["ProductName"].ToString();
                txtTotalQTYBill.Text = dRow[0]["QTY"].ToString();
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
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.SizeMaster", "SizeID,Size,SizeTypeID", "ISNULL(ActiveStatus,0) = 1 AND SizeTypeID = " + cmbSizeType.SelectedValue, null);
            if (ObjUtil.ValidateTable(dt))
            {
                InitItemTable();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dtPurchaseQTYColor.Columns.Add(dt.Rows[i]["Size"].ToString());
                }
                DataRow dRow = dtPurchaseQTYColor.NewRow();
                dtPurchaseQTYColor.Rows.Add(dRow);
                dtPurchaseQTYColor.AcceptChanges();
                dgvQtycolor.DataSource = dtPurchaseQTYColor;
            }
        }

        private void listBoxModelNo_MouseClick(object sender, MouseEventArgs e)
        {
            DataRow[] dRow = dtPurchaseInvoice.Select("ModelNo= '" + listBoxModelNo.SelectedItem + "'");
            if (dRow.Length > 0)
            {
                cmbBrand.SelectedValue = dRow[0]["BrandID"];
                cmbCountry.SelectedValue = dRow[0]["CountryID"];
                cmbDepartment.SelectedValue = dRow[0]["CategoryID"];
                txtItemName.Text = dRow[0]["ProductName"].ToString();
                txtTotalQTYBill.Text = dRow[0]["QTY"].ToString();
            }
        }

        private void LoadData()
        {
            dtPurchaseInvoice = ObjDAL.ExecuteSelectStatement("EXEC [dbo].[Get_Delivering_PurchaseInvoice_BillDetails] '" + txtSupplierBillNo.Text + "'");

            if (ObjUtil.ValidateTable(dtPurchaseInvoice))
            {
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
