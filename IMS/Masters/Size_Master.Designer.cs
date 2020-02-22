namespace IMS.Masters
{
    partial class Size_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Size_Master));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.rdShowAll = new System.Windows.Forms.RadioButton();
            this.rdSearchBySize = new System.Windows.Forms.RadioButton();
            this.txtSearchBySizeType = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpGridview = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSizeTypeName = new System.Windows.Forms.Label();
            this.lblActiveStatus = new System.Windows.Forms.Label();
            this.txtSizeTypeName = new System.Windows.Forms.TextBox();
            this.cmbActiveStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.grpSizeType = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpGridview.SuspendLayout();
            this.grpSizeType.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(562, 147);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(-1, 489);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(121, 17);
            this.lblTotalRecords.TabIndex = 233;
            this.lblTotalRecords.Text = "Total Records : 0";
            // 
            // rdShowAll
            // 
            this.rdShowAll.AutoSize = true;
            this.rdShowAll.Checked = true;
            this.rdShowAll.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdShowAll.Location = new System.Drawing.Point(440, 19);
            this.rdShowAll.Name = "rdShowAll";
            this.rdShowAll.Size = new System.Drawing.Size(79, 21);
            this.rdShowAll.TabIndex = 106;
            this.rdShowAll.TabStop = true;
            this.rdShowAll.Text = "Show All";
            this.rdShowAll.UseVisualStyleBackColor = true;
            // 
            // rdSearchBySize
            // 
            this.rdSearchBySize.AutoSize = true;
            this.rdSearchBySize.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearchBySize.Location = new System.Drawing.Point(34, 22);
            this.rdSearchBySize.Name = "rdSearchBySize";
            this.rdSearchBySize.Size = new System.Drawing.Size(78, 21);
            this.rdSearchBySize.TabIndex = 6;
            this.rdSearchBySize.Text = "By Size :";
            this.rdSearchBySize.UseVisualStyleBackColor = true;
            // 
            // txtSearchBySizeType
            // 
            this.txtSearchBySizeType.BackColor = System.Drawing.Color.White;
            this.txtSearchBySizeType.Enabled = false;
            this.txtSearchBySizeType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBySizeType.Location = new System.Drawing.Point(172, 22);
            this.txtSearchBySizeType.Name = "txtSearchBySizeType";
            this.txtSearchBySizeType.Size = new System.Drawing.Size(206, 25);
            this.txtSearchBySizeType.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdShowAll);
            this.groupBox1.Controls.Add(this.rdSearchBySize);
            this.groupBox1.Controls.Add(this.txtSearchBySizeType);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 51);
            this.groupBox1.TabIndex = 234;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // grpGridview
            // 
            this.grpGridview.BackColor = System.Drawing.Color.Transparent;
            this.grpGridview.Controls.Add(this.dataGridView1);
            this.grpGridview.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGridview.Location = new System.Drawing.Point(2, 309);
            this.grpGridview.Name = "grpGridview";
            this.grpGridview.Size = new System.Drawing.Size(575, 175);
            this.grpGridview.TabIndex = 232;
            this.grpGridview.TabStop = false;
            this.grpGridview.Text = "List of Sizes";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(159, 66);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(206, 27);
            this.cmbCategory.TabIndex = 194;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(18, 68);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 17);
            this.lblCategory.TabIndex = 193;
            this.lblCategory.Text = "Size Type :";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(129, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 25);
            this.btnSave.TabIndex = 226;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(40, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 25);
            this.btnAdd.TabIndex = 225;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblSizeTypeName
            // 
            this.lblSizeTypeName.AutoSize = true;
            this.lblSizeTypeName.BackColor = System.Drawing.Color.Transparent;
            this.lblSizeTypeName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeTypeName.Location = new System.Drawing.Point(18, 27);
            this.lblSizeTypeName.Name = "lblSizeTypeName";
            this.lblSizeTypeName.Size = new System.Drawing.Size(39, 17);
            this.lblSizeTypeName.TabIndex = 187;
            this.lblSizeTypeName.Text = "Size :";
            // 
            // lblActiveStatus
            // 
            this.lblActiveStatus.AutoSize = true;
            this.lblActiveStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveStatus.Location = new System.Drawing.Point(18, 110);
            this.lblActiveStatus.Name = "lblActiveStatus";
            this.lblActiveStatus.Size = new System.Drawing.Size(94, 17);
            this.lblActiveStatus.TabIndex = 189;
            this.lblActiveStatus.Text = "Active Status :";
            // 
            // txtSizeTypeName
            // 
            this.txtSizeTypeName.BackColor = System.Drawing.Color.White;
            this.txtSizeTypeName.Location = new System.Drawing.Point(159, 27);
            this.txtSizeTypeName.Name = "txtSizeTypeName";
            this.txtSizeTypeName.Size = new System.Drawing.Size(206, 25);
            this.txtSizeTypeName.TabIndex = 184;
            // 
            // cmbActiveStatus
            // 
            this.cmbActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActiveStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActiveStatus.FormattingEnabled = true;
            this.cmbActiveStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbActiveStatus.Location = new System.Drawing.Point(159, 108);
            this.cmbActiveStatus.Name = "cmbActiveStatus";
            this.cmbActiveStatus.Size = new System.Drawing.Size(206, 27);
            this.cmbActiveStatus.TabIndex = 186;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(291, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 25);
            this.btnUpdate.TabIndex = 228;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(455, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 25);
            this.btnCancel.TabIndex = 230;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(373, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 25);
            this.btnDelete.TabIndex = 229;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(211, 51);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 25);
            this.btnEdit.TabIndex = 227;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Size";
            // 
            // grpSizeType
            // 
            this.grpSizeType.BackColor = System.Drawing.Color.Transparent;
            this.grpSizeType.Controls.Add(this.cmbCategory);
            this.grpSizeType.Controls.Add(this.lblCategory);
            this.grpSizeType.Controls.Add(this.lblSizeTypeName);
            this.grpSizeType.Controls.Add(this.lblActiveStatus);
            this.grpSizeType.Controls.Add(this.txtSizeTypeName);
            this.grpSizeType.Controls.Add(this.cmbActiveStatus);
            this.grpSizeType.Enabled = false;
            this.grpSizeType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSizeType.Location = new System.Drawing.Point(15, 92);
            this.grpSizeType.Name = "grpSizeType";
            this.grpSizeType.Size = new System.Drawing.Size(486, 151);
            this.grpSizeType.TabIndex = 231;
            this.grpSizeType.TabStop = false;
            this.grpSizeType.Text = "Size Details";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 40);
            this.panel2.TabIndex = 224;
            // 
            // Size_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 507);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpSizeType);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Size_Master";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Size";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGridview.ResumeLayout(false);
            this.grpSizeType.ResumeLayout(false);
            this.grpSizeType.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.RadioButton rdShowAll;
        private System.Windows.Forms.RadioButton rdSearchBySize;
        private System.Windows.Forms.TextBox txtSearchBySizeType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpGridview;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSizeTypeName;
        private System.Windows.Forms.Label lblActiveStatus;
        private System.Windows.Forms.TextBox txtSizeTypeName;
        private System.Windows.Forms.ComboBox cmbActiveStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpSizeType;
        private System.Windows.Forms.Panel panel2;
    }
}