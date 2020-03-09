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
            btnPrint.BackgroundImage = B_Leave;
            BindStoreDetails();

            GenerateInvoiceNumber();
            InitItemTable();
            dtpSalesDate.Value = DateTime.Now;
            txtProductName.Focus();
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
        private bool IsItemExist(string pID)
        {
            DataRow [] dRow=  dtItemDetails.Select("ProductID='" + pID + "'");
            if (dRow.Length==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void UpdateQTYByOne(string pID, decimal rate)
        {
           
            
            DataRow[] dRow = dtItemDetails.Select("ProductID='" + pID + "'");
            
            // add one qty
            decimal NewQTY= Convert.ToDecimal(dRow[0]["QTY"]) + 1;

            if (CheckProductQTY(Convert.ToInt32(pID), Convert.ToDecimal(NewQTY)))
            {
                // set to col
                dRow[0]["QTY"] = NewQTY.ToString();

                // cal total
                decimal total = rate * NewQTY;

                // set the total
                dRow[0]["Total"] = total.ToString();

                dtItemDetails.AcceptChanges();
                dgvProductDetails.DataSource = dtItemDetails;
            }
            else
            {
                clsUtility.ShowInfoMessage("No QTY avaiable for the given Product.", clsUtility.strProjectTitle);
            }
           
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
            Masters.Customer_Master customer_Master = new Masters.Customer_Master();
            customer_Master.ShowDialog();
        }

        DataTable dtItemDetails = new DataTable();
        private void btnAdd_Click(object sender, EventArgs e)
        {

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


        private Image GetProductPhoto(int ProductID)
        {
            Image imgProduct = null;

           DataTable dt= ObjDAL.ExecuteSelectStatement("select Photo from "+ clsUtility.DBName+".dbo.ProductMaster where ProductID="+ ProductID );
            if (dt!=null && dt.Rows.Count>=0)
            {
                if (dt.Rows[0]["Photo"]!=DBNull.Value)
                {
                    byte[] imgData = (byte[])(dt.Rows[0]["Photo"]);
                    imgProduct = ObjUtil.GetImage(imgData);
                }
               
            }

            return imgProduct;


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
            else
            {
                if(txtProductName.Text.Trim().Length!=0 && !ObjUtil.IsNumeric(txtProductName.Text))
                {
                   clsUtility.ShowInfoMessage("Invalid BarCode Entry. Please check the Product Code.",clsUtility.strProjectTitle);
                }
               
               
            }
        }

        private void Sales_Invoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (cboEntryMode.SelectedIndex==1)
                {
                    
                    GetItemDetailsByProductID(txtProductID.Text);
                }
                else
                {
                 
                    
                }
             
            }
        }

        private void Sales_Invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null)
            {
                GetItemDetailsByProductID(txtProductID.Text);
            }


        }
        private void CustomerPopup_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        private bool CheckProductQTY(int ProductID, decimal CurQTY)
        {
            string strSQL = "select QTY from  " + clsUtility.DBName + ".[dbo].[ProductStockMaster] where ProductID="+ ProductID + " and StoreID="+cmbShop.SelectedValue.ToString();

   
            decimal TotalQTY =  Convert.ToDecimal(ObjDAL.ExecuteScalar(strSQL));


            if (CurQTY > TotalQTY)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void GetItemDetailsByProductID(string _productID)
        {
            string strQ = "select p1.ProductID, p1.ProductName,p1.Rate,p2.QTY from " + clsUtility.DBName + ".dbo.ProductMaster p1 join " +
                          clsUtility.DBName + " .dbo.ProductStockMaster p2 on p1.ProductID = p2.ProductID " +
                           " where p2.StoreID = " + cmbShop.SelectedValue + " and p1.ProductID = " + _productID;
            DataTable dt = ObjDAL.ExecuteSelectStatement(strQ);
            if (ObjUtil.ValidateTable(dt))
            {

                string name = dt.Rows[0]["ProductName"].ToString();
                string rate = dt.Rows[0]["Rate"].ToString();
                string qty = "1";

                decimal total = Convert.ToDecimal(rate) * Convert.ToDecimal(qty);

                if (CheckProductQTY(Convert.ToInt32(_productID), Convert.ToDecimal(qty)))
                {
                    // if Item already there in the grid, then just increase the QTY
                    if (IsItemExist(_productID))
                    {
                        UpdateQTYByOne(_productID.ToString(), Convert.ToDecimal(rate));
                        picProduct.Image = GetProductPhoto(Convert.ToInt32(_productID));
                    }
                    else
                    {
                        AddRowToItemDetails(_productID, name, qty, rate, total.ToString());
                     picProduct.Image=   GetProductPhoto(Convert.ToInt32(_productID));
                       
                    }
                    
                   
                    
                    txtProductID.Clear();
                    txtProductName.Clear();

                    CalculateGrandTotal();
                    dgvProductDetails.ClearSelection();
                    txtProductName.Focus();
                }
                else
                {
                    clsUtility.ShowInfoMessage("No QTY avaiable for the Product : "+txtProductName.Text,clsUtility.strProjectTitle);
                }
               
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
                int _ProductID = Convert.ToInt32(dgvProductDetails.Rows[e.RowIndex].Cells["ProductID"].Value);
                if (CheckProductQTY(_ProductID,Convert.ToDecimal(QTY)))
                {
                    dgvProductDetails.Rows[e.RowIndex].Cells["Total"].Value = Total.ToString();
                    CalculateGrandTotal();
                }
                else
                {
                    dgvProductDetails.Rows[e.RowIndex].Cells["QTY"].Value = _StartValue;
                    CalculateGrandTotal();

                    clsUtility.ShowInfoMessage("QTY : "+ QTY + "NOT avaiable for the Product : " + dgvProductDetails.Rows[e.RowIndex].Cells["ProductName"].Value, clsUtility.strProjectTitle);
                }
                
                
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
            else
            {
                int _PID =Convert.ToInt32( dgvProductDetails.Rows[e.RowIndex].Cells["ProductID"].Value);
                picProduct.Image = GetProductPhoto(Convert.ToInt32(_PID));
            }

         
        }

        private void ClearAll()
        {
            Other_Forms.frmPayment.strPaymentAutoID = "";
            lblPMode.Text = "";
            txtCustomerID.Clear();
            txtCustomerMobile.Clear();
            dtItemDetails.Clear();
            txtProductID.Clear();
            txtEmpID.Clear();

            txtInvoiceNumber.Clear();
            txtProductName.Clear();
            txtCustomerMobile.Clear();
            cmbShop.SelectedIndex = -1;
            txtTotalItems.Text = "0";

            txtSubTotal.Text = "0";
            txtDeliveryCharges.Text = "0";
            txtDiscount.Text = "0";
            txtGrandTotal.Text = "0";
            picProduct.Image = null;
            BindStoreDetails();
          
            txtSalesMan.Clear();


        }
        private bool SalesValidation()
        {
            if (txtCustomerID.Text.Trim().Length==0)
            {
                clsUtility.ShowInfoMessage("Please Enter Customer Name.", clsUtility.strProjectTitle);
                txtCustomerMobile.Focus();
                return false;
            }
            if (txtEmpID.Text.Trim().Length == 0)
            {
                clsUtility.ShowInfoMessage("Please Enter Sales Man Name.", clsUtility.strProjectTitle);
                txtSalesMan.Focus();
                return false;
            }
            if (Other_Forms.frmPayment.strPaymentAutoID.Trim().Length==0)
            {
                clsUtility.ShowInfoMessage("Please Select Payment Mode.", clsUtility.strProjectTitle);
              
                return false;
            }

            return true;

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (SalesValidation())
            {
                dgvProductDetails.EndEdit();

                // Before sales invocing make sure you have available qty for particular store

                #region SalesInvoiceDetails
                ObjDAL.SetColumnData("InvoiceNumber", SqlDbType.NVarChar, txtInvoiceNumber.Text);
                ObjDAL.SetColumnData("InvoiceDate", SqlDbType.DateTime, dtpSalesDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                ObjDAL.SetColumnData("SubTotal", SqlDbType.Decimal, txtSubTotal.Text);
                ObjDAL.SetColumnData("Discount", SqlDbType.Decimal, txtDiscount.Text);
                ObjDAL.SetColumnData("Tax", SqlDbType.Decimal, txtDeliveryCharges.Text);
                ObjDAL.SetColumnData("GrandTotal", SqlDbType.Decimal, txtGrandTotal.Text);
                ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID);
                ObjDAL.SetColumnData("CustomerID", SqlDbType.Int, txtCustomerID.Text);
                ObjDAL.SetColumnData("SalesMan", SqlDbType.Int, txtEmpID.Text);
                ObjDAL.SetColumnData("ShopeID", SqlDbType.Int, cmbShop.SelectedValue.ToString());

                ObjDAL.SetColumnData("PaymentMode", SqlDbType.NVarChar, lblPMode.Text);
                ObjDAL.SetColumnData("PaymentAutoID", SqlDbType.Int, Other_Forms.frmPayment.strPaymentAutoID);

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
                    ObjDAL.SetColumnData("Rate", SqlDbType.Decimal, Rate);
                    ObjDAL.InsertData(clsUtility.DBName + ".dbo.SalesDetails", false);

                    ObjDAL.ExecuteNonQuery("UPDATE " + clsUtility.DBName + ".dbo.ProductStockMaster SET QTY=QTY-" + QTY + " WHERE ProductID=" + ProductID + " and StoreID=" + cmbShop.SelectedValue.ToString());
                }
                clsUtility.ShowInfoMessage("Record has been saved successfully.", clsUtility.strProjectTitle);
                ClearAll();


                Button button = (Button)sender;
                if (button.Name=="btnPrint")
                {
                    Report.frmSalesInvoice frmSalesInvoice = new Report.frmSalesInvoice();
                    frmSalesInvoice.InvoiceID = InvoiceID;
                    frmSalesInvoice.IsDirectPrint = true;
                    frmSalesInvoice.Show();
                }
                else
                {
                    
                    Report.frmSalesInvoice frmSalesInvoice = new Report.frmSalesInvoice();
                    frmSalesInvoice.InvoiceID = InvoiceID;
                    frmSalesInvoice.IsDirectPrint = false;
                    frmSalesInvoice.Show();
                }
               
            }

           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result=clsUtility.ShowQuestionMessage("Are you sure, you want to cancel?", clsUtility.strProjectTitle);
            if (result)
            {
                ClearAll();
            }
            
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateGrandTotal();
        }

        decimal _StartValue = 0;
        private void dgvProductDetails_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                _StartValue = Convert.ToDecimal(dgvProductDetails.Rows[e.RowIndex].Cells["QTY"].Value);
            }
            catch (Exception)
            {

               
            }
           
        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (cboEntryMode.SelectedIndex == 0)
            {
                if (e.KeyData==Keys.Enter)
                {
                    



                    GetItemDetailsByProductID(txtProductName.Text);
                }
               
            }
            else
            {
                if (ObjUtil.GetDataPopup() != null)
                {
                    ObjUtil.GetDataPopup().Focus();
                }

            }
           
          
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerMobile.Text.Trim().Length>0)
                {
                  
                    string query = "select CustomerID,Name,PhoneNo from " + clsUtility.DBName + ".dbo.CustomerMaster where PhoneNo like '%" + txtCustomerMobile.Text + "%'";
                    DataTable dt = ObjDAL.ExecuteSelectStatement(query);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        ObjUtil.SetControlData(txtCustomerName, "Name");
                        ObjUtil.SetControlData(txtCustomerMobile, "PhoneNo");
                        ObjUtil.SetControlData(txtCustomerID, "CustomerID");

                        ObjUtil.ShowDataPopup(dt, txtCustomerMobile, this, this);

                        if (ObjUtil.GetDataPopup() != null && ObjUtil.GetDataPopup().DataSource != null)
                        {
                            // if there is only one column                
                            ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (ObjUtil.GetDataPopup().ColumnCount > 0)
                            {
                                ObjUtil.GetDataPopup().Columns["CustomerID"].Visible = false;
                                ObjUtil.SetDataPopupSize(450, 0);


                            }
                        }
                        //ObjUtil.GetDataPopup().CellClick += Sales_Invoice_CellClick;
                        //ObjUtil.GetDataPopup().KeyDown += Sales_Invoice_KeyDown;
                    }
                    else
                    {
                        ObjUtil.CloseAutoExtender();
                    }
                }
               
            }
            catch (Exception)
            {

            }
        }

        private void picCash_Click(object sender, EventArgs e)
        {
            lblPMode.Text = "Cash";
            //deafult auto ID for cash is four times zero
            Other_Forms.frmPayment.strPaymentAutoID = "0000";
        }

        private void picKnet_Click(object sender, EventArgs e)
        {
            lblPMode.Text = "K Net";
            Other_Forms.frmPayment frmPayment = new Other_Forms.frmPayment();
            Other_Forms.frmPayment.strPaymentAutoID = "";
            frmPayment.lblPaymentMode.Text = "K Net";
            frmPayment.picPaymentMode.Image = picKnet.Image;
            frmPayment.ShowDialog();



        }

        private void picVisa_Click(object sender, EventArgs e)
        {
            lblPMode.Text = "Visa";
            Other_Forms.frmPayment frmPayment = new Other_Forms.frmPayment();
            Other_Forms.frmPayment.strPaymentAutoID = "";
            frmPayment.lblPaymentMode.Text = "Visa";
            frmPayment.picPaymentMode.Image = picVisa.Image;
            frmPayment.ShowDialog();
        }

        private void PicMaster_Click(object sender, EventArgs e)
        {
            lblPMode.Text = "Master Card";
            Other_Forms.frmPayment frmPayment = new Other_Forms.frmPayment();
            Other_Forms.frmPayment.strPaymentAutoID = "";
            frmPayment.lblPaymentMode.Text = "Master Card";
            frmPayment.picPaymentMode.Image = PicMaster.Image;
            frmPayment.ShowDialog();
        }

        private void picOther_Click(object sender, EventArgs e)
        {
            lblPMode.Text = "Other";
            Other_Forms.frmPayment frmPayment = new Other_Forms.frmPayment();
            Other_Forms.frmPayment.strPaymentAutoID = "";
            frmPayment.lblPaymentMode.Text = "Other";
            frmPayment.picPaymentMode.Image = picOther.Image;
            frmPayment.ShowDialog();
        }

        private void lblActiveStatus_Click(object sender, EventArgs e)
        {
            txtInvoiceNumber.ReadOnly = false;
        }

        private void Sales_Invoice_Activated(object sender, EventArgs e)
        {
            txtProductName.Focus();
        }
    }
}
