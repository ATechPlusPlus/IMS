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
    public partial class Store_Master : Form
    {
        public Store_Master()
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
            txtStoreName.Clear();
            txtTel.Clear();
            txtFax.Clear();
            txtPlace.Clear();
            cmbActiveStatus.SelectedIndex = -1;

            txtStoreName.Focus();
        }

        private bool Validateform()
        {
            if (ObjUtil.IsControlTextEmpty(txtStoreName))
            {
                clsUtility.ShowInfoMessage("Enter Store Name           ", clsUtility.strProjectTitle);
                txtStoreName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtPlace))
            {
                clsUtility.ShowInfoMessage("Enter Place for "+txtStoreName.Text+" Store", clsUtility.strProjectTitle);
                txtPlace.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbActiveStatus))
            {
                clsUtility.ShowInfoMessage("Select Active Status.", clsUtility.strProjectTitle);
                cmbActiveStatus.Focus();
                return false;
            }
            return true;
        }

        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.StoreMaster", "StoreName='" + txtStoreName.Text.Trim() + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.StoreMaster", "StoreName='" + txtStoreName.Text + "' AND StoreID !=" + i);
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
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            DataTable dt = null;
            dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.StoreMaster", "StoreID,StoreName,Tel,Place,Fax,(CASE WHEN ActiveStatus =1 THEN 'Active' WHEN ActiveStatus =0 THEN 'InActive' END) ActiveStatus", "StoreID");

            if (ObjUtil.ValidateTable(dt))
            {
                dataGridView1.DataSource = dt;
                lblTotalRecords.Text = "Total Records : " + dt.Rows.Count;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            grpStore.Enabled = true;
            txtStoreName.Focus();
        }
    }
}
