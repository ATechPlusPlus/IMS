namespace IMS.Purchase
{
    partial class Posting_Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Posting_Delivery));
            this.cmbEntryType = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblSupplierBillNo = new System.Windows.Forms.Label();
            this.txtSupplierBillNo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalQTY = new System.Windows.Forms.TextBox();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPurchaseInvoiceID = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEntryType
            // 
            this.cmbEntryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntryType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntryType.FormattingEnabled = true;
            this.cmbEntryType.Items.AddRange(new object[] {
            "Delivery Entry for Purchase Invoice"});
            this.cmbEntryType.Location = new System.Drawing.Point(141, 139);
            this.cmbEntryType.Name = "cmbEntryType";
            this.cmbEntryType.Size = new System.Drawing.Size(240, 27);
            this.cmbEntryType.Sorted = true;
            this.cmbEntryType.TabIndex = 239;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(22, 177);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(111, 17);
            this.lblSupplier.TabIndex = 238;
            this.lblSupplier.Text = "Supplier Bill No. :";
            // 
            // lblSupplierBillNo
            // 
            this.lblSupplierBillNo.AutoSize = true;
            this.lblSupplierBillNo.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplierBillNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierBillNo.Location = new System.Drawing.Point(22, 142);
            this.lblSupplierBillNo.Name = "lblSupplierBillNo";
            this.lblSupplierBillNo.Size = new System.Drawing.Size(80, 17);
            this.lblSupplierBillNo.TabIndex = 237;
            this.lblSupplierBillNo.Text = "Entry Type :";
            // 
            // txtSupplierBillNo
            // 
            this.txtSupplierBillNo.BackColor = System.Drawing.Color.White;
            this.txtSupplierBillNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierBillNo.Location = new System.Drawing.Point(141, 175);
            this.txtSupplierBillNo.Name = "txtSupplierBillNo";
            this.txtSupplierBillNo.Size = new System.Drawing.Size(206, 25);
            this.txtSupplierBillNo.TabIndex = 236;
            this.txtSupplierBillNo.TextChanged += new System.EventHandler(this.txtSupplierBillNo_TextChanged);
            this.txtSupplierBillNo.Enter += new System.EventHandler(this.txtSupplierBillNo_Enter);
            this.txtSupplierBillNo.Leave += new System.EventHandler(this.txtSupplierBillNo_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(276, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 25);
            this.btnCancel.TabIndex = 241;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnPost_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnPost_MouseLeave);
            // 
            // btnPost
            // 
            this.btnPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPost.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(141, 278);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(76, 25);
            this.btnPost.TabIndex = 240;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            this.btnPost.MouseEnter += new System.EventHandler(this.btnPost_MouseEnter);
            this.btnPost.MouseLeave += new System.EventHandler(this.btnPost_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 44);
            this.label1.TabIndex = 242;
            this.label1.Text = "You have to post delivered enteries for \r\npurchase invoice to able to view the it" +
    "ems in system";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 40);
            this.panel2.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Posting Delivery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 244;
            this.label2.Text = "Total QTY :";
            // 
            // txtTotalQTY
            // 
            this.txtTotalQTY.BackColor = System.Drawing.Color.White;
            this.txtTotalQTY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQTY.Location = new System.Drawing.Point(141, 245);
            this.txtTotalQTY.Name = "txtTotalQTY";
            this.txtTotalQTY.ReadOnly = true;
            this.txtTotalQTY.Size = new System.Drawing.Size(206, 25);
            this.txtTotalQTY.TabIndex = 243;
            this.txtTotalQTY.Enter += new System.EventHandler(this.txtSupplierBillNo_Enter);
            this.txtTotalQTY.Leave += new System.EventHandler(this.txtSupplierBillNo_Leave);
            // 
            // cmbStore
            // 
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.Enabled = false;
            this.cmbStore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(141, 209);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(206, 27);
            this.cmbStore.Sorted = true;
            this.cmbStore.TabIndex = 246;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 245;
            this.label3.Text = "Store :";
            // 
            // txtPurchaseInvoiceID
            // 
            this.txtPurchaseInvoiceID.BackColor = System.Drawing.Color.White;
            this.txtPurchaseInvoiceID.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtPurchaseInvoiceID.Location = new System.Drawing.Point(388, 175);
            this.txtPurchaseInvoiceID.Name = "txtPurchaseInvoiceID";
            this.txtPurchaseInvoiceID.Size = new System.Drawing.Size(57, 25);
            this.txtPurchaseInvoiceID.TabIndex = 247;
            this.txtPurchaseInvoiceID.Visible = false;
            // 
            // Posting_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 323);
            this.Controls.Add(this.txtPurchaseInvoiceID);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalQTY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.cmbEntryType);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblSupplierBillNo);
            this.Controls.Add(this.txtSupplierBillNo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Posting_Delivery";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posting Delivery";
            this.Load += new System.EventHandler(this.Posting_Delivery_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbEntryType;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblSupplierBillNo;
        private System.Windows.Forms.TextBox txtSupplierBillNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalQTY;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPurchaseInvoiceID;
    }
}