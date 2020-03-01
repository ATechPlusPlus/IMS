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
    public partial class frmSalesInvoice : Form
    {
        public frmSalesInvoice()
        {
            InitializeComponent();
        }
        CoreApp.clsConnection_DAL ObjCon = new CoreApp.clsConnection_DAL(true);
        public int InvoiceID = 0;
        private void frmSalesInvoice_Load(object sender, EventArgs e)
        {
          
          

            string query= "select p1.ProductName,s1.QTY,s1.Rate, (s1.Qty*s1.Rate) as Total from IMS.[dbo].[SalesDetails] s1 join IMS.dbo.ProductMaster p1 "+
                           " on s1.ProductID = p1.ProductID where s1.InvoiceID = "+ InvoiceID;


          DataTable dtSalesDetails=  ObjCon.ExecuteSelectStatement(query);


            string strQueryHeader_Footer = "select s1.InvoiceNumber,s1.InvoiceDate, c1.Name as CustName,e1.Name as empName,st1.StoreName as StoreName,s1.SubTotal,s1.Discount,s1.Tax,s1.GrandTotal,s1.PaymentMode,s1.PaymentAutoID from IMS.dbo.SalesInvoiceDetails s1 left join " +
                                            " IMS.dbo.EmployeeDetails e1 on s1.SalesMan = e1.EmpID left join" +
                                            " IMS.[dbo].[CustomerMaster] c1 on s1.CustomerID = c1.CustomerID left join" +
                                            " IMS.dbo.StoreMaster st1 on st1.StoreID = s1.ShopeID where s1.Id=" + InvoiceID;


            DataTable dtSalesHeader_Footer = ObjCon.ExecuteSelectStatement(strQueryHeader_Footer);


            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet_SalesInvoice", dtSalesDetails);
            ReportDataSource rds2 = new ReportDataSource("DataSet_SalesInvoice_Header_Footer", dtSalesHeader_Footer);


            string strcomName = "";
            string strAddress = "";
           DataTable dtCompinfo=  ObjCon.ExecuteSelectStatement("Select CompanyName,[Address] from IMS.dbo.CompanyMaster");
            if (dtCompinfo!=null && dtCompinfo.Rows.Count>0)
            {
                strcomName = dtCompinfo.Rows[0]["CompanyName"].ToString();
                strAddress= dtCompinfo.Rows[0]["Address"].ToString();
            }
            else
            {
                strcomName = "Default Store/Shop Name";
                strAddress = "Default Address Line. Road No, Block No, Pin Code and State.";
            }

            // creating the parameter with the extact name as in the report.
            ReportParameter param1 = new ReportParameter("CompanyName", strcomName, true);
            ReportParameter param2 = new ReportParameter("Address", strAddress, true);

            // adding the parameter in the report dynamically
            reportViewer1.LocalReport.SetParameters(param1);
            reportViewer1.LocalReport.SetParameters(param2);


            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds2);


            this.reportViewer1.RefreshReport();

        }
    }
}
