namespace IMS
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userCreationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobilePartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.hardwarePartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Purchaseitem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSoldReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherArtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picLogOut = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.storeManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyValueSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userCreationToolStripMenuItem,
            this.mobilePartsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.hardwarePartsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reportsToolStripMenuItem,
            this.otherArtsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(985, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userCreationToolStripMenuItem
            // 
            this.userCreationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userCreationToolStripMenuItem.Image")));
            this.userCreationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userCreationToolStripMenuItem.Name = "userCreationToolStripMenuItem";
            this.userCreationToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.userCreationToolStripMenuItem.Text = "User Creation";
            this.userCreationToolStripMenuItem.ToolTipText = "User Creation";
            this.userCreationToolStripMenuItem.Click += new System.EventHandler(this.userCreationToolStripMenuItem_Click);
            // 
            // mobilePartsToolStripMenuItem
            // 
            this.mobilePartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catMaster,
            this.storeManagerToolStripMenuItem,
            this.supplierDetailsToolStripMenuItem,
            this.employeeDetailsToolStripMenuItem});
            this.mobilePartsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mobilePartsToolStripMenuItem.Image")));
            this.mobilePartsToolStripMenuItem.Name = "mobilePartsToolStripMenuItem";
            this.mobilePartsToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.mobilePartsToolStripMenuItem.Text = "Masters";
            this.mobilePartsToolStripMenuItem.ToolTipText = "Mobile Parts";
            // 
            // catMaster
            // 
            this.catMaster.Name = "catMaster";
            this.catMaster.Size = new System.Drawing.Size(192, 24);
            this.catMaster.Text = "Category Master";
            // 
            // hardwarePartsToolStripMenuItem
            // 
            this.hardwarePartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Purchaseitem,
            this.purchaseCounterToolStripMenuItem});
            this.hardwarePartsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hardwarePartsToolStripMenuItem.Image")));
            this.hardwarePartsToolStripMenuItem.Name = "hardwarePartsToolStripMenuItem";
            this.hardwarePartsToolStripMenuItem.Size = new System.Drawing.Size(69, 36);
            this.hardwarePartsToolStripMenuItem.Text = "Sales";
            this.hardwarePartsToolStripMenuItem.ToolTipText = "Hardware Parts";
            // 
            // Purchaseitem
            // 
            this.Purchaseitem.Name = "Purchaseitem";
            this.Purchaseitem.Size = new System.Drawing.Size(180, 24);
            this.Purchaseitem.Text = "Sales Invoice ";
            // 
            // purchaseCounterToolStripMenuItem
            // 
            this.purchaseCounterToolStripMenuItem.Name = "purchaseCounterToolStripMenuItem";
            this.purchaseCounterToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.purchaseCounterToolStripMenuItem.Text = "Sales Bill Details";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSoldReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(101, 36);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.ToolTipText = "Reports";
            // 
            // itemSoldReportToolStripMenuItem
            // 
            this.itemSoldReportToolStripMenuItem.Name = "itemSoldReportToolStripMenuItem";
            this.itemSoldReportToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.itemSoldReportToolStripMenuItem.Text = "Sales Report";
            this.itemSoldReportToolStripMenuItem.ToolTipText = "Monthly Sales Report";
            // 
            // otherArtsToolStripMenuItem
            // 
            this.otherArtsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("otherArtsToolStripMenuItem.Image")));
            this.otherArtsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otherArtsToolStripMenuItem.Name = "otherArtsToolStripMenuItem";
            this.otherArtsToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.otherArtsToolStripMenuItem.Text = " Backup/Restore";
            this.otherArtsToolStripMenuItem.ToolTipText = "Other Parts";
            this.otherArtsToolStripMenuItem.Click += new System.EventHandler(this.otherArtsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "About";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(159, 36);
            this.settingsToolStripMenuItem.Text = "Software Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoginName,
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(985, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblLoginName
            // 
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(77, 17);
            this.lblLoginName.Text = "Login By :";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(888, 17);
            this.lblVersion.Spring = true;
            this.lblVersion.Text = "Version : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(358, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // picLogOut
            // 
            this.picLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogOut.BackColor = System.Drawing.Color.Transparent;
            this.picLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogOut.Image = ((System.Drawing.Image)(resources.GetObject("picLogOut.Image")));
            this.picLogOut.Location = new System.Drawing.Point(907, 59);
            this.picLogOut.Name = "picLogOut";
            this.picLogOut.Size = new System.Drawing.Size(48, 60);
            this.picLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogOut.TabIndex = 25;
            this.picLogOut.TabStop = false;
            this.picLogOut.Click += new System.EventHandler(this.picLogOut_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(905, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.picLogOut_Click);
            // 
            // storeManagerToolStripMenuItem
            // 
            this.storeManagerToolStripMenuItem.Name = "storeManagerToolStripMenuItem";
            this.storeManagerToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.storeManagerToolStripMenuItem.Text = "Store/Shop Details";
            // 
            // supplierDetailsToolStripMenuItem
            // 
            this.supplierDetailsToolStripMenuItem.Name = "supplierDetailsToolStripMenuItem";
            this.supplierDetailsToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.supplierDetailsToolStripMenuItem.Text = "Supplier Details";
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.employeeDetailsToolStripMenuItem.Text = "Employee Details";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 36);
            this.toolStripMenuItem1.Text = "Stock Manager";
            this.toolStripMenuItem1.ToolTipText = "Print Invoice";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem3.Text = " Material Details";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(92, 36);
            this.toolStripMenuItem4.Text = "Purchase";
            this.toolStripMenuItem4.ToolTipText = "Hardware Parts";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(201, 24);
            this.toolStripMenuItem5.Text = "Purchase Invoice ";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(201, 24);
            this.toolStripMenuItem6.Text = "Purchase Bill Details";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currencyValueSettingToolStripMenuItem});
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(68, 36);
            this.toolStripMenuItem2.Text = "Settings";
            this.toolStripMenuItem2.ToolTipText = "Settings";
            // 
            // currencyValueSettingToolStripMenuItem
            // 
            this.currencyValueSettingToolStripMenuItem.Name = "currencyValueSettingToolStripMenuItem";
            this.currencyValueSettingToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.currencyValueSettingToolStripMenuItem.Text = "Currency Value Setting";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogOut);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userCreationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobilePartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catMaster;
        private System.Windows.Forms.ToolStripMenuItem hardwarePartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Purchaseitem;
        private System.Windows.Forms.ToolStripMenuItem purchaseCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSoldReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherArtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginName;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem storeManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem currencyValueSettingToolStripMenuItem;
    }
}

