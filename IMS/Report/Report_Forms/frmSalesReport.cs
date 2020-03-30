using CoreApp;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMS.Report
{
    public partial class frmSalesReport : Form
    {
        public frmSalesReport()
        {
            InitializeComponent();
        }
        CoreApp.clsConnection_DAL ObjDAL = new CoreApp.clsConnection_DAL(true);
        CoreApp.clsUtility ObjUtil = new CoreApp.clsUtility();
        Image B_Leave = IMS.Properties.Resources.B_click;
        Image B_Enter = IMS.Properties.Resources.B_on;

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
        private string GenerateCondition()
        {
            string strCondition = "";

            if (txtInvoiceNumber.Text.Trim().Length!=0)
            {
                strCondition= "InvoiceNumber='" + txtInvoiceNumber.Text + "' AND ";
            }

            if (txtEmpID.Text.Trim().Length!=0)
            {
                strCondition += "SalesMan=" + txtEmpID.Text+" AND ";
            }

            if (cmbShop.SelectedIndex!=-1)
            {
                strCondition += "ShopeID=" + cmbShop.SelectedValue.ToString()+" AND ";
            }


            strCondition += "InvoiceDate between '"+dtpFromDate.Value.ToString("yyyy-MM-dd")+"' AND '"+ dtpToDate.Value.ToString("yyyy-MM-dd") + "'";
            return strCondition;
        }
        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            FillStoreData();
           

            btnGenerateReport.BackgroundImage = B_Leave;
            btnClear.BackgroundImage = B_Leave;
        }
        private void btnViewDetails_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnViewDetails_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpID.Clear();
            txtInvoiceNumber.Clear();
            txtSalesMan.Clear();
            cmbShop.SelectedIndex = -1;
        }

        private void txtSalesMan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSalesMan.Text.Trim().Length == 0)
                {
                    return;
                }
                DataTable dt = ObjDAL.ExecuteSelectStatement("select Empid,Name from " + clsUtility.DBName + ".dbo.employeeDetails where Name Like '" + txtSalesMan.Text + "%'");
                if (dt != null && dt.Rows.Count > 0)
                {


                    ObjUtil.SetControlData(txtSalesMan, "Name");
                    ObjUtil.SetControlData(txtEmpID, "Empid");


                    ObjUtil.ShowDataPopup(dt, txtSalesMan, this, groupBox1);

                    if (ObjUtil.GetDataPopup() != null && ObjUtil.GetDataPopup().DataSource != null)
                    {
                        // if there is only one column                
                        ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        if (ObjUtil.GetDataPopup().ColumnCount > 0)
                        {
                            ObjUtil.GetDataPopup().Columns["Empid"].Visible = false;
                            ObjUtil.SetDataPopupSize(450, 0);
                        }
                    }
                    //ObjUtil.GetDataPopup().CellClick += Sales_Bill_Details_CellClick;
                    //ObjUtil.GetDataPopup().KeyDown += Sales_Bill_Details_KeyDown;
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

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            //string strQuery = "select * from "+ clsUtility.DBName + ".dbo.View_SalesBillDetails";

            string strQuery = "select * from "+clsUtility.DBName+".dbo.View_SalesBillDetails v1 join " +
                       clsUtility.DBName+".dbo.View_SalesDetails v2 on v1.id = v2.InvoiceID Where " + GenerateCondition(); ;
            
            DataTable dtSalesDetails = ObjDAL.ExecuteSelectStatement(strQuery);
            if (dtSalesDetails.Rows.Count>0)
            {
                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("ds_SalesInvoiceReport", dtSalesDetails);

                reportViewer1.LocalReport.DataSources.Add(rds);

                this.reportViewer1.RefreshReport();
            }
            else
            {
                clsUtility.ShowInfoMessage("No Datafound for the given filter.", clsUtility.strProjectTitle);
                reportViewer1.LocalReport.DataSources.Clear();
                
            }
            

           

        }

        private void txtInvoiceNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
