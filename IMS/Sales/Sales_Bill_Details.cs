using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;

namespace IMS.Sales
{
    public partial class Sales_Bill_Details : Form
    {
        public Sales_Bill_Details()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        private void dgvProductDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvProductDetails);
            ObjUtil.SetDataGridProperty(dgvProductDetails, DataGridViewAutoSizeColumnsMode.Fill);
           

            dgvProductDetails.Columns["SalesMan"].Visible = false;
            dgvProductDetails.Columns["ShopeID"].Visible = false;

        }

        private void Sales_Bill_Details_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string strQ = "select s1.id, s1.InvoiceNumber,s1.InvoiceDate,s1.SubTotal, s1.Discount,s1.Tax, s1.GrandTotal,s1.SalesMan, s1.ShopeID, e1.Name,s2.StoreName from IMS_DB.dbo.SalesInvoiceDetails s1 Left join" +
                            " IMS_DB.dbo.EmployeeDetails e1 on s1.SalesMan = e1.empID" +
                            " left join IMS_DB.dbo.StoreMaster s2 on s1.ShopeID = s2.StoreID";

         dgvProductDetails.DataSource=   ObjDAL.ExecuteSelectStatement(strQ);
        }

        private void rdShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAll.Checked)
            {
                LoadData();
            }
        }
    }
}
