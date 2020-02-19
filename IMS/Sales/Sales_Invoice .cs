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
    public partial class Sales_Invoice : Form
    {
        public Sales_Invoice()
        {
            InitializeComponent();
        }
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsUtility ObjUtil = new clsUtility();

        Image B_Leave = IMS.Properties.Resources.B_click;
        Image B_Enter = IMS.Properties.Resources.B_on;
        private void Sales_Invoice_Load(object sender, EventArgs e)
        {
            cboEntryMode.SelectedIndex = 0; // by default
            btnAdd.BackgroundImage = B_Leave;
            btnSave.BackgroundImage = B_Leave;
            BindStoreDetails();

            GenerateInvoiceNumber();
            InitItemTable();
        }
        private void InitItemTable()
        {
            dtItemDetails.Columns.Add("ProductID");
            dtItemDetails.Columns.Add("ProductName");
            dtItemDetails.Columns.Add("QTY");
            dtItemDetails.Columns.Add("Rate");
            dtItemDetails.Columns.Add("Total");
            dtItemDetails.Columns.Add("Delete");


        }
        private void AddRowToItemDetails(string productID, string name, string qty, string rate, string total)
        {
            DataRow dRow = dtItemDetails.NewRow();
            dRow["ProductID"] = productID;
            dRow["ProductName"] = name;
            dRow["QTY"] = qty;
            dRow["Rate"] = rate;
            dRow["Total"] = total;
            dRow["Delete"] = "Delete";

            dtItemDetails.Rows.Add(dRow);
            dtItemDetails.AcceptChanges();

            dgvProductDetails.DataSource = dtItemDetails;

        }
        private void GenerateInvoiceNumber()
        {
            //SequenceInvoice : this is a sequance object created in SQL ( this is not a table)
            int LastID = ObjDAL.ExecuteScalarInt("SELECT NEXT VALUE FOR " + clsUtility.DBName + ".[dbo].SequenceInvoice");
            string InvoiceNumber = "INV-" + LastID;

            txtInvoiceNumber.Text = InvoiceNumber;
        }
        private void BindStoreDetails()
        {
            DataTable dt = null;
            dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.StoreMaster", "StoreID,StoreName", "ISNULL(ActiveStatus,1)=1", " StoreID");
            cmbShop.DataSource = dt;
            cmbShop.DisplayMember = "StoreName";
            cmbShop.ValueMember = "StoreID";

            cmbShop.SelectedIndex = -1;

            // set Default store

            int deafultStoreID = ObjDAL.ExecuteScalarInt("SELECT Storeid FROM " + clsUtility.DBName + ".[dbo].[DefaultStoreSetting] WHERE MachineName = '" + Environment.MachineName + "'");
            cmbShop.SelectedValue = deafultStoreID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masters.Store_Master Obj = new Masters.Store_Master();
            Obj.Show();
        }

        private void btnDrug_Click(object sender, EventArgs e)
        {
            Masters.Employee_Details Obj = new Masters.Employee_Details();
            Obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        DataTable dtItemDetails = new DataTable();
        private void btnAdd_Click(object sender, EventArgs e)
        {

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

        private void txtSalesMan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ObjDAL.ExecuteSelectStatement("select Empid,Name from " + clsUtility.DBName + ".dbo.employeeDetails where Name Like '" + txtSalesMan.Text + "%'");
                if (dt != null && dt.Rows.Count > 0)
                {
                    ObjUtil.SetControlData(txtSalesMan, "Name");
                    ObjUtil.SetControlData(txtEmpID, "Empid");


                    ObjUtil.ShowDataPopup(dt, txtSalesMan, this, this);

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
                    //ObjUtil.GetDataPopup().CellClick += frmSalecounter_CellClick;
                    //ObjUtil.GetDataPopup().KeyDown += frmSalecounter_KeyDown;
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


        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (cboEntryMode.SelectedIndex == 1) // if manual entry
            {
                try
                {
                    string query = "SELECT p1.ProductID, p1.ProductName,p1.Rate,p2.QTY from " + clsUtility.DBName + ".dbo.ProductMaster p1 join " + clsUtility.DBName + ".dbo.ProductStockMaster p2 " +
                        "ON p1.ProductID = p2.ProductID WHERE p2.StoreID = " + cmbShop.SelectedValue.ToString();
                    DataTable dt = ObjDAL.ExecuteSelectStatement(query + " AND p1.ProductName Like '" + txtProductName.Text + "%'");
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        ObjUtil.SetControlData(txtProductName, "ProductName");
                        ObjUtil.SetControlData(txtProductID, "ProductID");

                        ObjUtil.ShowDataPopup(dt, txtProductName, this, this);

                        if (ObjUtil.GetDataPopup() != null && ObjUtil.GetDataPopup().DataSource != null)
                        {
                            // if there is only one column                
                            ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (ObjUtil.GetDataPopup().ColumnCount > 0)
                            {
                                ObjUtil.GetDataPopup().Columns["ProductID"].Visible = false;
                                ObjUtil.SetDataPopupSize(450, 0);


                            }
                        }
                        ObjUtil.GetDataPopup().CellClick += Sales_Invoice_CellClick;
                        ObjUtil.GetDataPopup().KeyDown += Sales_Invoice_KeyDown;
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

        private void Sales_Invoice_KeyDown(object sender, KeyEventArgs e)
        {
            txtProductName.Focus();
        }

        private void Sales_Invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null)
            {
                GetItemDetailsByProductID(txtProductID.Text);
            }


        }
        private void GetItemDetailsByProductID(string productID)
        {
            string strQ = "select p1.ProductID, p1.ProductName,p1.Rate,p2.QTY from " + clsUtility.DBName + ".dbo.ProductMaster p1 join " +
                          clsUtility.DBName + " .dbo.ProductStockMaster p2 on p1.ProductID = p2.ProductID " +
                           " where p2.StoreID = " + cmbShop.SelectedValue + " and p1.ProductID = " + productID;
            DataTable dt = ObjDAL.ExecuteSelectStatement(strQ);
            if (ObjUtil.ValidateTable(dt))
            {

                string name = dt.Rows[0]["ProductName"].ToString();
                string rate = dt.Rows[0]["Rate"].ToString();
                string qty = "1";

                decimal total = Convert.ToDecimal(rate) * Convert.ToDecimal(qty);
                AddRowToItemDetails(productID, name, qty, rate, total.ToString());
                txtProductID.Clear();
                txtProductName.Clear();

                CalculateGrandTotal();
            }
        }

        private void dgvProductDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvProductDetails);
            ObjUtil.SetDataGridProperty(dgvProductDetails, DataGridViewAutoSizeColumnsMode.Fill);
            dgvProductDetails.Columns["ProductID"].Visible = false;

            txtTotalItems.Text = dgvProductDetails.Rows.Count.ToString();
        }

        private void dgvProductDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //dgvProductDetails.Columns[e.ColumnIndex].Name == "Rate" ||
            if (dgvProductDetails.Columns[e.ColumnIndex].Name == "QTY")
            {
                decimal QTY = Convert.ToDecimal(dgvProductDetails.Rows[e.RowIndex].Cells["QTY"].Value);
                decimal Rate = Convert.ToDecimal(dgvProductDetails.Rows[e.RowIndex].Cells["Rate"].Value);
                decimal Total = QTY * Rate;

                dgvProductDetails.Rows[e.RowIndex].Cells["Total"].Value = Total.ToString();
                CalculateGrandTotal();
            }
        }
        private void CalculateGrandTotal()
        {
            decimal SubTotal = 0.0M;
            decimal Discount = 0.0M;
            decimal Deliverycharges = 0.0M;
            decimal GrandTotal = 0.0M;

            for (int i = 0; i < dgvProductDetails.Rows.Count; i++)
            {
                SubTotal += Convert.ToDecimal(dgvProductDetails.Rows[i].Cells["Total"].Value);
            }
            txtSubTotal.Text = Math.Round(SubTotal, 2).ToString();

            Discount = txtDiscount.Text.Length > 0 ? Convert.ToDecimal(txtDiscount.Text) : 0;
            Deliverycharges = txtDeliveryCharges.Text.Length > 0 ? Convert.ToDecimal(txtDeliveryCharges.Text) : 0;

            GrandTotal = SubTotal - (SubTotal * Discount * 0.01M) + Deliverycharges;
            txtGrandTotal.Text = Math.Round(GrandTotal, 2).ToString();
        }

        private void dgvProductDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductDetails.Columns[e.ColumnIndex].Name == "ColDelete")
            {

                DialogResult d = MessageBox.Show("Are you sure want to delete ? ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    dgvProductDetails.Rows.RemoveAt(e.RowIndex);
                    dgvProductDetails.EndEdit();
                    CalculateGrandTotal();
                }
            }
        }

        private void ClearAll()
        {
            dtItemDetails.Clear();
            txtProductID.Clear();
            txtEmpID.Clear();

            txtInvoiceNumber.Clear();
            txtProductName.Clear();
            txtCustomerName.Clear();
            cmbShop.SelectedIndex = -1;
            txtTotalItems.Clear();

            txtSubTotal.Text = "0";
            txtDeliveryCharges.Text = "0";
            txtDiscount.Text = "0";
            txtGrandTotal.Text = "0";

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            dgvProductDetails.EndEdit();

            // Before sales invocing make sure you have available qty for particular store

            #region SalesInvoiceDetails
            ObjDAL.SetColumnData("InvoiceNumber", SqlDbType.NVarChar, txtInvoiceNumber.Text);
            ObjDAL.SetColumnData("InvoiceDate", SqlDbType.DateTime, dtpSalesDate.Value.ToString("yyyy-MM-dd"));
            ObjDAL.SetColumnData("SubTotal", SqlDbType.Decimal, txtSubTotal.Text);
            ObjDAL.SetColumnData("Discount", SqlDbType.Decimal, txtDiscount.Text);
            ObjDAL.SetColumnData("Tax", SqlDbType.Decimal, txtDeliveryCharges.Text);
            ObjDAL.SetColumnData("GrandTotal", SqlDbType.Decimal, txtGrandTotal.Text);
            ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID);
            ObjDAL.SetColumnData("CustomerName", SqlDbType.NVarChar, txtCustomerName.Text);
            ObjDAL.SetColumnData("SalesMan", SqlDbType.Int, txtEmpID.Text);
            ObjDAL.SetColumnData("ShopeID", SqlDbType.Int, cmbShop.SelectedValue.ToString());
            int InvoiceID = ObjDAL.InsertData(clsUtility.DBName + ".dbo.SalesInvoiceDetails", true);
            #endregion

            for (int i = 0; i < dgvProductDetails.Rows.Count; i++)
            {
                string Total = dgvProductDetails.Rows[i].Cells["Total"].Value.ToString();
                string ProductID = dgvProductDetails.Rows[i].Cells["ProductID"].Value.ToString();
                string QTY = dgvProductDetails.Rows[i].Cells["QTY"].Value.ToString();
                string Rate = dgvProductDetails.Rows[i].Cells["Rate"].Value.ToString();

                ObjDAL.SetColumnData("InvoiceID", SqlDbType.Int, InvoiceID);
                ObjDAL.SetColumnData("ProductID", SqlDbType.Int, ProductID);
                ObjDAL.SetColumnData("QTY", SqlDbType.Decimal, QTY);
                ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID);
                ObjDAL.InsertData(clsUtility.DBName + ".dbo.SalesDetails", false);

                ObjDAL.ExecuteNonQuery("UPDATE " + clsUtility.DBName + ".dbo.ProductStockMaster SET QTY=QTY-" + QTY + " WHERE ProductID=" + ProductID + " and StoreID=" + cmbShop.SelectedValue.ToString());
            }
            clsUtility.ShowInfoMessage("Record has been saved !", clsUtility.strProjectTitle);
            ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateGrandTotal();
        }
    }
}
