namespace IMS.Purchase
{
    partial class Purchase_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_Invoice));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdShowAll = new System.Windows.Forms.RadioButton();
            this.rdSearchByShipment = new System.Windows.Forms.RadioButton();
            this.txtSearchByShipmentNo = new System.Windows.Forms.TextBox();
            this.grpGridview = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.grpPurchaseInvoice = new System.Windows.Forms.GroupBox();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.txtTotalQTY = new System.Windows.Forms.TextBox();
            this.lblBillValue = new System.Windows.Forms.Label();
            this.txtBillValue = new System.Windows.Forms.TextBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblShipmentNo = new System.Windows.Forms.Label();
            this.txtShipmentNo = new System.Windows.Forms.TextBox();
            this.lblSupplierBillNo = new System.Windows.Forms.Label();
            this.txtSupplierBillNo = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpPurchaseInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 40);
            this.panel2.TabIndex = 110;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Purchase Invoice";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(373, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 25);
            this.btnUpdate.TabIndex = 231;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(537, 57);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 25);
            this.btnCancel.TabIndex = 233;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(455, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 25);
            this.btnDelete.TabIndex = 232;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(293, 57);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 25);
            this.btnEdit.TabIndex = 230;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(211, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 25);
            this.btnSave.TabIndex = 229;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(122, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 25);
            this.btnAdd.TabIndex = 228;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdShowAll);
            this.groupBox1.Controls.Add(this.rdSearchByShipment);
            this.groupBox1.Controls.Add(this.txtSearchByShipmentNo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 51);
            this.groupBox1.TabIndex = 235;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // rdShowAll
            // 
            this.rdShowAll.AutoSize = true;
            this.rdShowAll.Checked = true;
            this.rdShowAll.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdShowAll.Location = new System.Drawing.Point(457, 19);
            this.rdShowAll.Name = "rdShowAll";
            this.rdShowAll.Size = new System.Drawing.Size(79, 21);
            this.rdShowAll.TabIndex = 106;
            this.rdShowAll.TabStop = true;
            this.rdShowAll.Text = "Show All";
            this.rdShowAll.UseVisualStyleBackColor = true;
            this.rdShowAll.CheckedChanged += new System.EventHandler(this.rdShowAll_CheckedChanged);
            // 
            // rdSearchByShipment
            // 
            this.rdSearchByShipment.AutoSize = true;
            this.rdSearchByShipment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearchByShipment.Location = new System.Drawing.Point(18, 20);
            this.rdSearchByShipment.Name = "rdSearchByShipment";
            this.rdSearchByShipment.Size = new System.Drawing.Size(130, 21);
            this.rdSearchByShipment.TabIndex = 6;
            this.rdSearchByShipment.Text = "By Shipment No :";
            this.rdSearchByShipment.UseVisualStyleBackColor = true;
            this.rdSearchByShipment.CheckedChanged += new System.EventHandler(this.rdSearchByShipment_CheckedChanged);
            // 
            // txtSearchByShipmentNo
            // 
            this.txtSearchByShipmentNo.BackColor = System.Drawing.Color.White;
            this.txtSearchByShipmentNo.Enabled = false;
            this.txtSearchByShipmentNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByShipmentNo.Location = new System.Drawing.Point(167, 18);
            this.txtSearchByShipmentNo.Name = "txtSearchByShipmentNo";
            this.txtSearchByShipmentNo.Size = new System.Drawing.Size(206, 25);
            this.txtSearchByShipmentNo.TabIndex = 5;
            this.txtSearchByShipmentNo.TextChanged += new System.EventHandler(this.txtSearchByShipmentNo_TextChanged);
            // 
            // grpGridview
            // 
            this.grpGridview.BackColor = System.Drawing.Color.Transparent;
            this.grpGridview.Controls.Add(this.dataGridView1);
            this.grpGridview.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGridview.Location = new System.Drawing.Point(20, 330);
            this.grpGridview.Name = "grpGridview";
            this.grpGridview.Size = new System.Drawing.Size(730, 175);
            this.grpGridview.TabIndex = 234;
            this.grpGridview.TabStop = false;
            this.grpGridview.Text = "List of Purchases Invoice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(717, 147);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(17, 514);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(121, 17);
            this.lblTotalRecords.TabIndex = 236;
            this.lblTotalRecords.Text = "Total Records : 0";
            // 
            // grpPurchaseInvoice
            // 
            this.grpPurchaseInvoice.BackColor = System.Drawing.Color.Transparent;
            this.grpPurchaseInvoice.Controls.Add(this.lblTotalQty);
            this.grpPurchaseInvoice.Controls.Add(this.txtTotalQTY);
            this.grpPurchaseInvoice.Controls.Add(this.lblBillValue);
            this.grpPurchaseInvoice.Controls.Add(this.txtBillValue);
            this.grpPurchaseInvoice.Controls.Add(this.cmbSupplier);
            this.grpPurchaseInvoice.Controls.Add(this.lblSupplier);
            this.grpPurchaseInvoice.Controls.Add(this.dtpBillDate);
            this.grpPurchaseInvoice.Controls.Add(this.lblBillDate);
            this.grpPurchaseInvoice.Controls.Add(this.lblShipmentNo);
            this.grpPurchaseInvoice.Controls.Add(this.txtShipmentNo);
            this.grpPurchaseInvoice.Controls.Add(this.lblSupplierBillNo);
            this.grpPurchaseInvoice.Controls.Add(this.txtSupplierBillNo);
            this.grpPurchaseInvoice.Enabled = false;
            this.grpPurchaseInvoice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPurchaseInvoice.Location = new System.Drawing.Point(20, 92);
            this.grpPurchaseInvoice.Name = "grpPurchaseInvoice";
            this.grpPurchaseInvoice.Size = new System.Drawing.Size(746, 173);
            this.grpPurchaseInvoice.TabIndex = 237;
            this.grpPurchaseInvoice.TabStop = false;
            this.grpPurchaseInvoice.Text = "Purchase Invoice";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalQty.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.Location = new System.Drawing.Point(389, 131);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(72, 17);
            this.lblTotalQty.TabIndex = 239;
            this.lblTotalQty.Text = "Total QTY";
            // 
            // txtTotalQTY
            // 
            this.txtTotalQTY.BackColor = System.Drawing.Color.White;
            this.txtTotalQTY.Location = new System.Drawing.Point(530, 131);
            this.txtTotalQTY.Name = "txtTotalQTY";
            this.txtTotalQTY.Size = new System.Drawing.Size(206, 25);
            this.txtTotalQTY.TabIndex = 238;
            this.txtTotalQTY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalQTY_KeyDown);
            // 
            // lblBillValue
            // 
            this.lblBillValue.AutoSize = true;
            this.lblBillValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBillValue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillValue.Location = new System.Drawing.Point(10, 131);
            this.lblBillValue.Name = "lblBillValue";
            this.lblBillValue.Size = new System.Drawing.Size(71, 17);
            this.lblBillValue.TabIndex = 237;
            this.lblBillValue.Text = "Bill Value :";
            // 
            // txtBillValue
            // 
            this.txtBillValue.BackColor = System.Drawing.Color.White;
            this.txtBillValue.Location = new System.Drawing.Point(151, 131);
            this.txtBillValue.Name = "txtBillValue";
            this.txtBillValue.Size = new System.Drawing.Size(206, 25);
            this.txtBillValue.TabIndex = 236;
            this.txtBillValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillValue_KeyDown);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbSupplier.Location = new System.Drawing.Point(151, 80);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(206, 27);
            this.cmbSupplier.TabIndex = 235;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(10, 82);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(62, 17);
            this.lblSupplier.TabIndex = 234;
            this.lblSupplier.Text = "Supplier :";
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBillDate.Location = new System.Drawing.Point(530, 79);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(190, 25);
            this.dtpBillDate.TabIndex = 233;
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBillDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(389, 79);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(67, 17);
            this.lblBillDate.TabIndex = 232;
            this.lblBillDate.Text = "Bill Date :";
            // 
            // lblShipmentNo
            // 
            this.lblShipmentNo.AutoSize = true;
            this.lblShipmentNo.BackColor = System.Drawing.Color.Transparent;
            this.lblShipmentNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentNo.Location = new System.Drawing.Point(389, 41);
            this.lblShipmentNo.Name = "lblShipmentNo";
            this.lblShipmentNo.Size = new System.Drawing.Size(91, 17);
            this.lblShipmentNo.TabIndex = 231;
            this.lblShipmentNo.Text = "Shipment No :";
            // 
            // txtShipmentNo
            // 
            this.txtShipmentNo.BackColor = System.Drawing.Color.White;
            this.txtShipmentNo.Location = new System.Drawing.Point(530, 41);
            this.txtShipmentNo.Name = "txtShipmentNo";
            this.txtShipmentNo.Size = new System.Drawing.Size(206, 25);
            this.txtShipmentNo.TabIndex = 230;
            this.txtShipmentNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShipmentNo_KeyDown);
            // 
            // lblSupplierBillNo
            // 
            this.lblSupplierBillNo.AutoSize = true;
            this.lblSupplierBillNo.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplierBillNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierBillNo.Location = new System.Drawing.Point(10, 41);
            this.lblSupplierBillNo.Name = "lblSupplierBillNo";
            this.lblSupplierBillNo.Size = new System.Drawing.Size(111, 17);
            this.lblSupplierBillNo.TabIndex = 229;
            this.lblSupplierBillNo.Text = "Supplier Bill No. :";
            // 
            // txtSupplierBillNo
            // 
            this.txtSupplierBillNo.BackColor = System.Drawing.Color.White;
            this.txtSupplierBillNo.Location = new System.Drawing.Point(151, 41);
            this.txtSupplierBillNo.Name = "txtSupplierBillNo";
            this.txtSupplierBillNo.Size = new System.Drawing.Size(206, 25);
            this.txtSupplierBillNo.TabIndex = 228;
            this.txtSupplierBillNo.Enter += new System.EventHandler(this.txtSupplierBillNo_Enter);
            this.txtSupplierBillNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplierBillNo_KeyDown);
            this.txtSupplierBillNo.Leave += new System.EventHandler(this.txtSupplierBillNo_Leave);
            // 
            // Purchase_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 533);
            this.Controls.Add(this.grpPurchaseInvoice);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Purchase_Invoice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Invoice";
            this.Load += new System.EventHandler(this.Purchase_Invoice_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpPurchaseInvoice.ResumeLayout(false);
            this.grpPurchaseInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdShowAll;
        private System.Windows.Forms.RadioButton rdSearchByShipment;
        private System.Windows.Forms.TextBox txtSearchByShipmentNo;
        private System.Windows.Forms.GroupBox grpGridview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.GroupBox grpPurchaseInvoice;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.TextBox txtTotalQTY;
        private System.Windows.Forms.Label lblBillValue;
        private System.Windows.Forms.TextBox txtBillValue;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblShipmentNo;
        private System.Windows.Forms.TextBox txtShipmentNo;
        private System.Windows.Forms.Label lblSupplierBillNo;
        private System.Windows.Forms.TextBox txtSupplierBillNo;
    }
}