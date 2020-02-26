namespace IMS.Purchase
{
    partial class Delivering_Purchase_Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSupplierBillNo = new System.Windows.Forms.Label();
            this.txtSupplierBillNo = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.grpPurchaseBillDetail = new System.Windows.Forms.GroupBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.listBoxModelNo = new System.Windows.Forms.ListBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblModelNo = new System.Windows.Forms.Label();
            this.cmbSizeType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvQtycolor = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDiffQty = new System.Windows.Forms.Label();
            this.txtDiffQty = new System.Windows.Forms.TextBox();
            this.lblTotalQtyBill = new System.Windows.Forms.Label();
            this.txtTotalQTYBill = new System.Windows.Forms.TextBox();
            this.lblTotalEnteredQty = new System.Windows.Forms.Label();
            this.txtTotalQTYEntered = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalQTY = new System.Windows.Forms.TextBox();
            this.grpPurchaseBillDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQtycolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(283, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 25);
            this.btnSearch.TabIndex = 245;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // lblSupplierBillNo
            // 
            this.lblSupplierBillNo.AutoSize = true;
            this.lblSupplierBillNo.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplierBillNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierBillNo.Location = new System.Drawing.Point(12, 59);
            this.lblSupplierBillNo.Name = "lblSupplierBillNo";
            this.lblSupplierBillNo.Size = new System.Drawing.Size(107, 17);
            this.lblSupplierBillNo.TabIndex = 244;
            this.lblSupplierBillNo.Text = "Supplier Bill No :";
            // 
            // txtSupplierBillNo
            // 
            this.txtSupplierBillNo.BackColor = System.Drawing.Color.White;
            this.txtSupplierBillNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtSupplierBillNo.Location = new System.Drawing.Point(153, 59);
            this.txtSupplierBillNo.Name = "txtSupplierBillNo";
            this.txtSupplierBillNo.Size = new System.Drawing.Size(124, 25);
            this.txtSupplierBillNo.TabIndex = 243;
            this.txtSupplierBillNo.Enter += new System.EventHandler(this.txtSupplierBillNo_Enter);
            this.txtSupplierBillNo.Leave += new System.EventHandler(this.txtSupplierBillNo_Leave);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(462, 67);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(46, 17);
            this.lblSupplier.TabIndex = 246;
            this.lblSupplier.Text = "Store :";
            // 
            // cmbStore
            // 
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.Enabled = false;
            this.cmbStore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbStore.Location = new System.Drawing.Point(603, 67);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(206, 27);
            this.cmbStore.TabIndex = 247;
            // 
            // grpPurchaseBillDetail
            // 
            this.grpPurchaseBillDetail.BackColor = System.Drawing.Color.Transparent;
            this.grpPurchaseBillDetail.Controls.Add(this.txtItemName);
            this.grpPurchaseBillDetail.Controls.Add(this.listBoxModelNo);
            this.grpPurchaseBillDetail.Controls.Add(this.cmbCountry);
            this.grpPurchaseBillDetail.Controls.Add(this.label2);
            this.grpPurchaseBillDetail.Controls.Add(this.cmbDepartment);
            this.grpPurchaseBillDetail.Controls.Add(this.label1);
            this.grpPurchaseBillDetail.Controls.Add(this.lblBrand);
            this.grpPurchaseBillDetail.Controls.Add(this.cmbBrand);
            this.grpPurchaseBillDetail.Controls.Add(this.lblProductName);
            this.grpPurchaseBillDetail.Controls.Add(this.lblModelNo);
            this.grpPurchaseBillDetail.Enabled = false;
            this.grpPurchaseBillDetail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPurchaseBillDetail.Location = new System.Drawing.Point(7, 110);
            this.grpPurchaseBillDetail.Name = "grpPurchaseBillDetail";
            this.grpPurchaseBillDetail.Size = new System.Drawing.Size(882, 130);
            this.grpPurchaseBillDetail.TabIndex = 248;
            this.grpPurchaseBillDetail.TabStop = false;
            this.grpPurchaseBillDetail.Text = "Item Details";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.Enabled = false;
            this.txtItemName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtItemName.Location = new System.Drawing.Point(596, 58);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(206, 25);
            this.txtItemName.TabIndex = 265;
            this.txtItemName.Enter += new System.EventHandler(this.txtSupplierBillNo_Enter);
            this.txtItemName.Leave += new System.EventHandler(this.txtSupplierBillNo_Leave);
            // 
            // listBoxModelNo
            // 
            this.listBoxModelNo.FormattingEnabled = true;
            this.listBoxModelNo.ItemHeight = 17;
            this.listBoxModelNo.Location = new System.Drawing.Point(118, 24);
            this.listBoxModelNo.Name = "listBoxModelNo";
            this.listBoxModelNo.Size = new System.Drawing.Size(206, 55);
            this.listBoxModelNo.TabIndex = 256;
            this.listBoxModelNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxModelNo_MouseClick);
            this.listBoxModelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxModelNo_KeyDown);
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Enabled = false;
            this.cmbCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbCountry.Location = new System.Drawing.Point(596, 95);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(206, 27);
            this.cmbCountry.TabIndex = 255;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 254;
            this.label2.Text = "Country :";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Enabled = false;
            this.cmbDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbDepartment.Location = new System.Drawing.Point(118, 91);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(206, 27);
            this.cmbDepartment.TabIndex = 253;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 252;
            this.label1.Text = "Department :";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(455, 23);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(51, 17);
            this.lblBrand.TabIndex = 243;
            this.lblBrand.Text = "Brand :";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Enabled = false;
            this.cmbBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbBrand.Location = new System.Drawing.Point(596, 19);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(206, 27);
            this.cmbBrand.TabIndex = 244;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(455, 58);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(82, 17);
            this.lblProductName.TabIndex = 229;
            this.lblProductName.Text = "Item Name :";
            // 
            // lblModelNo
            // 
            this.lblModelNo.AutoSize = true;
            this.lblModelNo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelNo.Location = new System.Drawing.Point(19, 29);
            this.lblModelNo.Name = "lblModelNo";
            this.lblModelNo.Size = new System.Drawing.Size(74, 17);
            this.lblModelNo.TabIndex = 231;
            this.lblModelNo.Text = "Model No :";
            // 
            // cmbSizeType
            // 
            this.cmbSizeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeType.Enabled = false;
            this.cmbSizeType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSizeType.FormattingEnabled = true;
            this.cmbSizeType.Location = new System.Drawing.Point(603, 247);
            this.cmbSizeType.Name = "cmbSizeType";
            this.cmbSizeType.Size = new System.Drawing.Size(206, 27);
            this.cmbSizeType.TabIndex = 257;
            this.cmbSizeType.SelectionChangeCommitted += new System.EventHandler(this.cmbSizeType_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 256;
            this.label3.Text = "Size Tpye :";
            // 
            // dgvQtycolor
            // 
            this.dgvQtycolor.AllowUserToAddRows = false;
            this.dgvQtycolor.AllowUserToDeleteRows = false;
            this.dgvQtycolor.BackgroundColor = System.Drawing.Color.White;
            this.dgvQtycolor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQtycolor.Location = new System.Drawing.Point(7, 285);
            this.dgvQtycolor.Name = "dgvQtycolor";
            this.dgvQtycolor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvQtycolor.Size = new System.Drawing.Size(845, 147);
            this.dgvQtycolor.TabIndex = 258;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(452, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 25);
            this.btnUpdate.TabIndex = 262;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(616, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 25);
            this.btnCancel.TabIndex = 264;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(534, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 25);
            this.btnDelete.TabIndex = 263;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(372, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 25);
            this.btnEdit.TabIndex = 261;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(290, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 25);
            this.btnSave.TabIndex = 260;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(201, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 25);
            this.btnAdd.TabIndex = 259;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // lblDiffQty
            // 
            this.lblDiffQty.AutoSize = true;
            this.lblDiffQty.BackColor = System.Drawing.Color.Transparent;
            this.lblDiffQty.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiffQty.Location = new System.Drawing.Point(600, 449);
            this.lblDiffQty.Name = "lblDiffQty";
            this.lblDiffQty.Size = new System.Drawing.Size(113, 17);
            this.lblDiffQty.TabIndex = 270;
            this.lblDiffQty.Text = "Difference QTY :";
            // 
            // txtDiffQty
            // 
            this.txtDiffQty.BackColor = System.Drawing.Color.White;
            this.txtDiffQty.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtDiffQty.Location = new System.Drawing.Point(719, 442);
            this.txtDiffQty.Name = "txtDiffQty";
            this.txtDiffQty.ReadOnly = true;
            this.txtDiffQty.Size = new System.Drawing.Size(133, 25);
            this.txtDiffQty.TabIndex = 269;
            this.txtDiffQty.Text = "0";
            // 
            // lblTotalQtyBill
            // 
            this.lblTotalQtyBill.AutoSize = true;
            this.lblTotalQtyBill.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalQtyBill.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQtyBill.Location = new System.Drawing.Point(304, 446);
            this.lblTotalQtyBill.Name = "lblTotalQtyBill";
            this.lblTotalQtyBill.Size = new System.Drawing.Size(134, 17);
            this.lblTotalQtyBill.TabIndex = 268;
            this.lblTotalQtyBill.Text = "Total  QTY with Bill :";
            // 
            // txtTotalQTYBill
            // 
            this.txtTotalQTYBill.BackColor = System.Drawing.Color.White;
            this.txtTotalQTYBill.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtTotalQTYBill.Location = new System.Drawing.Point(447, 441);
            this.txtTotalQTYBill.Name = "txtTotalQTYBill";
            this.txtTotalQTYBill.ReadOnly = true;
            this.txtTotalQTYBill.Size = new System.Drawing.Size(133, 25);
            this.txtTotalQTYBill.TabIndex = 267;
            this.txtTotalQTYBill.Text = "0";
            // 
            // lblTotalEnteredQty
            // 
            this.lblTotalEnteredQty.AutoSize = true;
            this.lblTotalEnteredQty.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalEnteredQty.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEnteredQty.Location = new System.Drawing.Point(4, 446);
            this.lblTotalEnteredQty.Name = "lblTotalEnteredQty";
            this.lblTotalEnteredQty.Size = new System.Drawing.Size(130, 17);
            this.lblTotalEnteredQty.TabIndex = 266;
            this.lblTotalEnteredQty.Text = "Total  QTY entered :";
            // 
            // txtTotalQTYEntered
            // 
            this.txtTotalQTYEntered.BackColor = System.Drawing.Color.White;
            this.txtTotalQTYEntered.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtTotalQTYEntered.Location = new System.Drawing.Point(140, 441);
            this.txtTotalQTYEntered.Name = "txtTotalQTYEntered";
            this.txtTotalQTYEntered.ReadOnly = true;
            this.txtTotalQTYEntered.Size = new System.Drawing.Size(133, 25);
            this.txtTotalQTYEntered.TabIndex = 265;
            this.txtTotalQTYEntered.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 477);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(845, 147);
            this.dataGridView1.TabIndex = 271;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 633);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 273;
            this.label4.Text = "Total  QTY :";
            // 
            // txtTotalQTY
            // 
            this.txtTotalQTY.BackColor = System.Drawing.Color.White;
            this.txtTotalQTY.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtTotalQTY.Location = new System.Drawing.Point(140, 628);
            this.txtTotalQTY.Name = "txtTotalQTY";
            this.txtTotalQTY.ReadOnly = true;
            this.txtTotalQTY.Size = new System.Drawing.Size(133, 25);
            this.txtTotalQTY.TabIndex = 272;
            this.txtTotalQTY.Text = "0";
            // 
            // Delivering_Purchase_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 658);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalQTY);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDiffQty);
            this.Controls.Add(this.txtDiffQty);
            this.Controls.Add(this.lblTotalQtyBill);
            this.Controls.Add(this.txtTotalQTYBill);
            this.Controls.Add(this.lblTotalEnteredQty);
            this.Controls.Add(this.txtTotalQTYEntered);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvQtycolor);
            this.Controls.Add(this.cmbSizeType);
            this.Controls.Add(this.grpPurchaseBillDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSupplierBillNo);
            this.Controls.Add(this.txtSupplierBillNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Delivering_Purchase_Bill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivering Purchase Bill";
            this.Load += new System.EventHandler(this.Delivering_Purchase_Bill_Load);
            this.grpPurchaseBillDetail.ResumeLayout(false);
            this.grpPurchaseBillDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQtycolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSupplierBillNo;
        private System.Windows.Forms.TextBox txtSupplierBillNo;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.GroupBox grpPurchaseBillDetail;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblModelNo;
        private System.Windows.Forms.ComboBox cmbSizeType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvQtycolor;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxModelNo;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblDiffQty;
        private System.Windows.Forms.TextBox txtDiffQty;
        private System.Windows.Forms.Label lblTotalQtyBill;
        private System.Windows.Forms.TextBox txtTotalQTYBill;
        private System.Windows.Forms.Label lblTotalEnteredQty;
        private System.Windows.Forms.TextBox txtTotalQTYEntered;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalQTY;
    }
}