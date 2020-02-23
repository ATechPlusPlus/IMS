namespace IMS.Masters
{
    partial class Size_Type_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Size_Type_Master));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSizeTypeDetails = new System.Windows.Forms.GroupBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSizeTypeName = new System.Windows.Forms.Label();
            this.lblActiveStatus = new System.Windows.Forms.Label();
            this.txtSizeTypeName = new System.Windows.Forms.TextBox();
            this.cmbActiveStatus = new System.Windows.Forms.ComboBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.rdShowAll = new System.Windows.Forms.RadioButton();
            this.rdSearchBySizeType = new System.Windows.Forms.RadioButton();
            this.txtSearchBySizeType = new System.Windows.Forms.TextBox();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.grpGridview = new System.Windows.Forms.GroupBox();
            this.dgvSizeTypeMaster = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.grpSizeTypeDetails.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizeTypeMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 49);
            this.panel2.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 26);
            this.label12.TabIndex = 82;
            this.label12.Text = "Size Type Master";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(395, 66);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 31);
            this.btnUpdate.TabIndex = 217;
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
            this.btnCancel.Location = new System.Drawing.Point(614, 66);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 31);
            this.btnCancel.TabIndex = 219;
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
            this.btnDelete.Location = new System.Drawing.Point(504, 66);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 31);
            this.btnDelete.TabIndex = 218;
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
            this.btnEdit.Location = new System.Drawing.Point(284, 66);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 31);
            this.btnEdit.TabIndex = 216;
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
            this.btnSave.Location = new System.Drawing.Point(173, 66);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 31);
            this.btnSave.TabIndex = 215;
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
            this.btnAdd.Location = new System.Drawing.Point(61, 66);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 31);
            this.btnAdd.TabIndex = 214;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // grpSizeTypeDetails
            // 
            this.grpSizeTypeDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpSizeTypeDetails.Controls.Add(this.cmbDepartment);
            this.grpSizeTypeDetails.Controls.Add(this.lblDepartment);
            this.grpSizeTypeDetails.Controls.Add(this.lblSizeTypeName);
            this.grpSizeTypeDetails.Controls.Add(this.lblActiveStatus);
            this.grpSizeTypeDetails.Controls.Add(this.txtSizeTypeName);
            this.grpSizeTypeDetails.Controls.Add(this.cmbActiveStatus);
            this.grpSizeTypeDetails.Enabled = false;
            this.grpSizeTypeDetails.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSizeTypeDetails.Location = new System.Drawing.Point(61, 116);
            this.grpSizeTypeDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpSizeTypeDetails.Name = "grpSizeTypeDetails";
            this.grpSizeTypeDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpSizeTypeDetails.Size = new System.Drawing.Size(648, 186);
            this.grpSizeTypeDetails.TabIndex = 220;
            this.grpSizeTypeDetails.TabStop = false;
            this.grpSizeTypeDetails.Text = "Size Type Details";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(212, 81);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(273, 30);
            this.cmbDepartment.TabIndex = 194;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(24, 84);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(105, 21);
            this.lblDepartment.TabIndex = 193;
            this.lblDepartment.Text = "Department :";
            // 
            // lblSizeTypeName
            // 
            this.lblSizeTypeName.AutoSize = true;
            this.lblSizeTypeName.BackColor = System.Drawing.Color.Transparent;
            this.lblSizeTypeName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeTypeName.Location = new System.Drawing.Point(24, 33);
            this.lblSizeTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSizeTypeName.Name = "lblSizeTypeName";
            this.lblSizeTypeName.Size = new System.Drawing.Size(141, 21);
            this.lblSizeTypeName.TabIndex = 187;
            this.lblSizeTypeName.Text = "Size Type Name :";
            // 
            // lblActiveStatus
            // 
            this.lblActiveStatus.AutoSize = true;
            this.lblActiveStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveStatus.Location = new System.Drawing.Point(24, 135);
            this.lblActiveStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveStatus.Name = "lblActiveStatus";
            this.lblActiveStatus.Size = new System.Drawing.Size(118, 21);
            this.lblActiveStatus.TabIndex = 189;
            this.lblActiveStatus.Text = "Active Status :";
            // 
            // txtSizeTypeName
            // 
            this.txtSizeTypeName.BackColor = System.Drawing.Color.White;
            this.txtSizeTypeName.Location = new System.Drawing.Point(212, 33);
            this.txtSizeTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSizeTypeName.Name = "txtSizeTypeName";
            this.txtSizeTypeName.Size = new System.Drawing.Size(273, 29);
            this.txtSizeTypeName.TabIndex = 184;
            this.txtSizeTypeName.Enter += new System.EventHandler(this.txtSizeTypeName_Enter);
            this.txtSizeTypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSizeTypeName_KeyDown);
            this.txtSizeTypeName.Leave += new System.EventHandler(this.txtSizeTypeName_Leave);
            // 
            // cmbActiveStatus
            // 
            this.cmbActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActiveStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActiveStatus.FormattingEnabled = true;
            this.cmbActiveStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbActiveStatus.Location = new System.Drawing.Point(212, 133);
            this.cmbActiveStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbActiveStatus.Name = "cmbActiveStatus";
            this.cmbActiveStatus.Size = new System.Drawing.Size(273, 30);
            this.cmbActiveStatus.TabIndex = 186;
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.rdShowAll);
            this.grpSearch.Controls.Add(this.rdSearchBySizeType);
            this.grpSearch.Controls.Add(this.txtSearchBySizeType);
            this.grpSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(42, 310);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(4);
            this.grpSearch.Size = new System.Drawing.Size(703, 63);
            this.grpSearch.TabIndex = 223;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // rdShowAll
            // 
            this.rdShowAll.AutoSize = true;
            this.rdShowAll.Checked = true;
            this.rdShowAll.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdShowAll.Location = new System.Drawing.Point(587, 23);
            this.rdShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.rdShowAll.Name = "rdShowAll";
            this.rdShowAll.Size = new System.Drawing.Size(99, 25);
            this.rdShowAll.TabIndex = 106;
            this.rdShowAll.TabStop = true;
            this.rdShowAll.Text = "Show All";
            this.rdShowAll.UseVisualStyleBackColor = true;
            this.rdShowAll.CheckedChanged += new System.EventHandler(this.rdShowAll_CheckedChanged);
            // 
            // rdSearchBySizeType
            // 
            this.rdSearchBySizeType.AutoSize = true;
            this.rdSearchBySizeType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearchBySizeType.Location = new System.Drawing.Point(17, 25);
            this.rdSearchBySizeType.Margin = new System.Windows.Forms.Padding(4);
            this.rdSearchBySizeType.Name = "rdSearchBySizeType";
            this.rdSearchBySizeType.Size = new System.Drawing.Size(188, 25);
            this.rdSearchBySizeType.TabIndex = 6;
            this.rdSearchBySizeType.Text = "By Size Type Name :";
            this.rdSearchBySizeType.UseVisualStyleBackColor = true;
            this.rdSearchBySizeType.CheckedChanged += new System.EventHandler(this.rdSearchBySizeType_CheckedChanged);
            // 
            // txtSearchBySizeType
            // 
            this.txtSearchBySizeType.BackColor = System.Drawing.Color.White;
            this.txtSearchBySizeType.Enabled = false;
            this.txtSearchBySizeType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBySizeType.Location = new System.Drawing.Point(244, 22);
            this.txtSearchBySizeType.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBySizeType.Name = "txtSearchBySizeType";
            this.txtSearchBySizeType.Size = new System.Drawing.Size(273, 29);
            this.txtSearchBySizeType.TabIndex = 5;
            this.txtSearchBySizeType.TextChanged += new System.EventHandler(this.txtSearchBySizeType_TextChanged);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(-1, 601);
            this.lblTotalRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(150, 22);
            this.lblTotalRecords.TabIndex = 222;
            this.lblTotalRecords.Text = "Total Records : 0";
            // 
            // grpGridview
            // 
            this.grpGridview.BackColor = System.Drawing.Color.Transparent;
            this.grpGridview.Controls.Add(this.dgvSizeTypeMaster);
            this.grpGridview.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGridview.Location = new System.Drawing.Point(11, 381);
            this.grpGridview.Margin = new System.Windows.Forms.Padding(4);
            this.grpGridview.Name = "grpGridview";
            this.grpGridview.Padding = new System.Windows.Forms.Padding(4);
            this.grpGridview.Size = new System.Drawing.Size(767, 215);
            this.grpGridview.TabIndex = 221;
            this.grpGridview.TabStop = false;
            this.grpGridview.Text = "List of Size Types";
            // 
            // dgvSizeTypeMaster
            // 
            this.dgvSizeTypeMaster.AllowUserToAddRows = false;
            this.dgvSizeTypeMaster.AllowUserToDeleteRows = false;
            this.dgvSizeTypeMaster.BackgroundColor = System.Drawing.Color.White;
            this.dgvSizeTypeMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSizeTypeMaster.Location = new System.Drawing.Point(8, 25);
            this.dgvSizeTypeMaster.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSizeTypeMaster.Name = "dgvSizeTypeMaster";
            this.dgvSizeTypeMaster.ReadOnly = true;
            this.dgvSizeTypeMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSizeTypeMaster.Size = new System.Drawing.Size(749, 181);
            this.dgvSizeTypeMaster.TabIndex = 0;
            this.dgvSizeTypeMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSizeTypeMaster_CellDoubleClick);
            this.dgvSizeTypeMaster.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSizeTypeMaster_DataBindingComplete);
            // 
            // Size_Type_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 624);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.grpSizeTypeDetails);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Size_Type_Master";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Size Type Master";
            this.Load += new System.EventHandler(this.Size_Type_Master_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpSizeTypeDetails.ResumeLayout(false);
            this.grpSizeTypeDetails.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizeTypeMaster)).EndInit();
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
        private System.Windows.Forms.GroupBox grpSizeTypeDetails;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSizeTypeName;
        private System.Windows.Forms.Label lblActiveStatus;
        private System.Windows.Forms.TextBox txtSizeTypeName;
        private System.Windows.Forms.ComboBox cmbActiveStatus;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton rdShowAll;
        private System.Windows.Forms.RadioButton rdSearchBySizeType;
        private System.Windows.Forms.TextBox txtSearchBySizeType;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.GroupBox grpGridview;
        private System.Windows.Forms.DataGridView dgvSizeTypeMaster;
    }
}