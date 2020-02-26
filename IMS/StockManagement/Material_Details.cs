using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;

namespace IMS.StockManagement
{
    public partial class Material_Details : Form
    {
        public Material_Details()
        {
            InitializeComponent();
        }
        string query = string.Empty;

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        private void FillStoreData()
        {
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".[dbo].[StoreMaster]", "StoreID,StoreName", "ISNULL(ActiveStatus,1)=1", "StoreName ASC");
            if (ObjUtil.ValidateTable(dt))
            {
                cmbShop.DataSource = dt;
                cmbShop.DisplayMember = "StoreName";
                cmbShop.ValueMember = "StoreID";
                cmbShop.SelectedIndex = -1;
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchByProductName.Text.Length > 0) // if manual entry
                {
                    DataTable dt = ObjDAL.ExecuteSelectStatement(query + " WHERE pm.ProductName Like '" + txtSearchByProductName.Text + "%'");
                    if (ObjUtil.ValidateTable(dt))
                    {
                        dgvProductDetails.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void Material_Details_KeyDown(object sender, KeyEventArgs e)
        {
            txtSearchByProductName.Focus();
        }

        private void Material_Details_Load(object sender, EventArgs e)
        {
            FillStoreData();
            query = "SELECT pm.ProductID,pm.ProductName,pm.CategoryID,cm.CategoryName [Department] " +
                    ", psm.StoreID,sm.StoreName,ISNULL(psm.QTY, 0)QTY " +
                    " FROM ProductMaster pm" +
                    " LEFT JOIN ProductStockMaster psm ON pm.ProductID = psm.ProductID " +
                    " LEFT JOIN StoreMaster sm ON psm.StoreID = sm.StoreID " +
                    " LEFT JOIN CategoryMaster cm ON pm.CategoryID = cm.CategoryID ";
            rdShowAll.Checked = true;
        }

        private void cmbShop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = ObjDAL.ExecuteSelectStatement(query + " WHERE ISNULL(psm.StoreID,0) = " + cmbShop.SelectedValue);
            dgvProductDetails.DataSource = dt;
        }

        private void rdSearchByStore_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByStore.Checked)
            {
                cmbShop.Enabled = true;
                cmbShop.Focus();
            }
            else
            {
                cmbShop.Enabled = false;
                cmbShop.SelectedIndex = -1;
            }
        }

        private void rdSearchByItem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByItem.Checked)
            {
                txtSearchByProductName.Enabled = true;
                txtSearchByProductName.Focus();
            }
            else
            {
                txtSearchByProductName.Enabled = false;
                txtSearchByProductName.Clear();
            }
        }

        private void rdShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAll.Checked)
            {
                DataTable dt = ObjDAL.ExecuteSelectStatement(query);
                dgvProductDetails.DataSource = dt;
            }
            else
            {
                cmbShop.SelectedIndex = -1;
                txtSearchByProductName.Clear();
            }
        }

        private void dgvProductDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvProductDetails);
            ObjUtil.SetDataGridProperty(dgvProductDetails, DataGridViewAutoSizeColumnsMode.Fill);
            dgvProductDetails.Columns["ProductID"].Visible = false;
            dgvProductDetails.Columns["StoreID"].Visible = false;
            dgvProductDetails.Columns["CategoryID"].Visible = false;
        }
    }
}
