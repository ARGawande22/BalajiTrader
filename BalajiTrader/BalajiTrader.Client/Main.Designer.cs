namespace BalajiTrader.Client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pnlMain = new Panel();
            pnlMainMenu = new Panel();
            pnlTools = new Panel();
            lblSettings = new Label();
            picTools = new PictureBox();
            lblUsers = new Label();
            lblShopDetails = new Label();
            lblTaxes = new Label();
            pnlSalesReport = new Panel();
            lblStocks = new Label();
            lblProducts = new Label();
            lblQuatation = new Label();
            lblSalesReport = new Label();
            lblIncoice = new Label();
            picSalesReport = new PictureBox();
            lblCustomer = new Label();
            pnlPurchaseReport = new Panel();
            lblPO = new Label();
            lblBills = new Label();
            lblSupplier = new Label();
            lblPurchaseReport = new Label();
            picPurchaseReport = new PictureBox();
            btnNewInvoice = new Button();
            mainMenuStrip = new MenuStrip();
            tsMaster = new ToolStripMenuItem();
            tsCatagory = new ToolStripMenuItem();
            tsBrands = new ToolStripMenuItem();
            tsUnits = new ToolStripMenuItem();
            tsSizes = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            pnlMain.SuspendLayout();
            pnlMainMenu.SuspendLayout();
            pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTools).BeginInit();
            pnlSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSalesReport).BeginInit();
            pnlPurchaseReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPurchaseReport).BeginInit();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ControlLightLight;
            pnlMain.Controls.Add(pnlMainMenu);
            pnlMain.Controls.Add(btnNewInvoice);
            pnlMain.Controls.Add(mainMenuStrip);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1008, 661);
            pnlMain.TabIndex = 6;
            // 
            // pnlMainMenu
            // 
            pnlMainMenu.Controls.Add(pnlTools);
            pnlMainMenu.Controls.Add(pnlSalesReport);
            pnlMainMenu.Controls.Add(pnlPurchaseReport);
            pnlMainMenu.Location = new Point(487, 174);
            pnlMainMenu.Name = "pnlMainMenu";
            pnlMainMenu.Size = new Size(348, 475);
            pnlMainMenu.TabIndex = 2;
            // 
            // pnlTools
            // 
            pnlTools.Controls.Add(lblSettings);
            pnlTools.Controls.Add(picTools);
            pnlTools.Controls.Add(lblUsers);
            pnlTools.Controls.Add(lblShopDetails);
            pnlTools.Controls.Add(lblTaxes);
            pnlTools.Location = new Point(3, 301);
            pnlTools.Name = "pnlTools";
            pnlTools.Size = new Size(342, 171);
            pnlTools.TabIndex = 20;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            lblSettings.ForeColor = Color.SteelBlue;
            lblSettings.Location = new Point(51, 2);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(208, 22);
            lblSettings.TabIndex = 21;
            lblSettings.Text = "MASTER SETTINGS :";
            // 
            // picTools
            // 
            picTools.BackColor = Color.Transparent;
            picTools.Image = Properties.Resources.Tools;
            picTools.Location = new Point(21, 2);
            picTools.Name = "picTools";
            picTools.Size = new Size(26, 26);
            picTools.SizeMode = PictureBoxSizeMode.StretchImage;
            picTools.TabIndex = 2;
            picTools.TabStop = false;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Cursor = Cursors.Hand;
            lblUsers.Font = new Font("Microsoft Sans Serif", 10F);
            lblUsers.ForeColor = Color.Navy;
            lblUsers.Location = new Point(67, 85);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(45, 17);
            lblUsers.TabIndex = 24;
            lblUsers.Text = "Users";
            // 
            // lblShopDetails
            // 
            lblShopDetails.AutoSize = true;
            lblShopDetails.Cursor = Cursors.Hand;
            lblShopDetails.Font = new Font("Microsoft Sans Serif", 10F);
            lblShopDetails.ForeColor = Color.Navy;
            lblShopDetails.Location = new Point(67, 35);
            lblShopDetails.Name = "lblShopDetails";
            lblShopDetails.Size = new Size(88, 17);
            lblShopDetails.TabIndex = 22;
            lblShopDetails.Text = "Shop Details";
            // 
            // lblTaxes
            // 
            lblTaxes.AutoSize = true;
            lblTaxes.Cursor = Cursors.Hand;
            lblTaxes.Font = new Font("Microsoft Sans Serif", 10F);
            lblTaxes.ForeColor = Color.Navy;
            lblTaxes.Location = new Point(67, 60);
            lblTaxes.Name = "lblTaxes";
            lblTaxes.Size = new Size(46, 17);
            lblTaxes.TabIndex = 23;
            lblTaxes.Text = "Taxes";
            // 
            // pnlSalesReport
            // 
            pnlSalesReport.Controls.Add(lblStocks);
            pnlSalesReport.Controls.Add(lblProducts);
            pnlSalesReport.Controls.Add(lblQuatation);
            pnlSalesReport.Controls.Add(lblSalesReport);
            pnlSalesReport.Controls.Add(lblIncoice);
            pnlSalesReport.Controls.Add(picSalesReport);
            pnlSalesReport.Controls.Add(lblCustomer);
            pnlSalesReport.Location = new Point(3, 123);
            pnlSalesReport.Name = "pnlSalesReport";
            pnlSalesReport.Size = new Size(342, 172);
            pnlSalesReport.TabIndex = 13;
            // 
            // lblStocks
            // 
            lblStocks.AutoSize = true;
            lblStocks.Cursor = Cursors.Hand;
            lblStocks.Font = new Font("Microsoft Sans Serif", 10F);
            lblStocks.ForeColor = Color.Navy;
            lblStocks.Location = new Point(67, 135);
            lblStocks.Name = "lblStocks";
            lblStocks.Size = new Size(50, 17);
            lblStocks.TabIndex = 19;
            lblStocks.Text = "Stocks";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Cursor = Cursors.Hand;
            lblProducts.Font = new Font("Microsoft Sans Serif", 10F);
            lblProducts.ForeColor = Color.Navy;
            lblProducts.Location = new Point(67, 110);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(130, 17);
            lblProducts.TabIndex = 18;
            lblProducts.Text = "Products / Services";
            // 
            // lblQuatation
            // 
            lblQuatation.AutoSize = true;
            lblQuatation.Cursor = Cursors.Hand;
            lblQuatation.Font = new Font("Microsoft Sans Serif", 10F);
            lblQuatation.ForeColor = Color.Navy;
            lblQuatation.Location = new Point(67, 85);
            lblQuatation.Name = "lblQuatation";
            lblQuatation.Size = new Size(77, 17);
            lblQuatation.TabIndex = 17;
            lblQuatation.Text = "Quatations";
            // 
            // lblSalesReport
            // 
            lblSalesReport.AutoSize = true;
            lblSalesReport.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            lblSalesReport.ForeColor = Color.SteelBlue;
            lblSalesReport.Location = new Point(51, 2);
            lblSalesReport.Name = "lblSalesReport";
            lblSalesReport.Size = new Size(186, 22);
            lblSalesReport.TabIndex = 14;
            lblSalesReport.Text = "SALES REPORTS :";
            // 
            // lblIncoice
            // 
            lblIncoice.AutoSize = true;
            lblIncoice.Cursor = Cursors.Hand;
            lblIncoice.Font = new Font("Microsoft Sans Serif", 10F);
            lblIncoice.ForeColor = Color.Navy;
            lblIncoice.Location = new Point(67, 60);
            lblIncoice.Name = "lblIncoice";
            lblIncoice.Size = new Size(59, 17);
            lblIncoice.TabIndex = 16;
            lblIncoice.Text = "Invoices";
            // 
            // picSalesReport
            // 
            picSalesReport.BackColor = Color.Transparent;
            picSalesReport.Image = Properties.Resources.sales_report;
            picSalesReport.Location = new Point(21, 2);
            picSalesReport.Name = "picSalesReport";
            picSalesReport.Size = new Size(26, 26);
            picSalesReport.SizeMode = PictureBoxSizeMode.StretchImage;
            picSalesReport.TabIndex = 1;
            picSalesReport.TabStop = false;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Cursor = Cursors.Hand;
            lblCustomer.Font = new Font("Microsoft Sans Serif", 10F);
            lblCustomer.ForeColor = Color.Navy;
            lblCustomer.Location = new Point(67, 35);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(75, 17);
            lblCustomer.TabIndex = 15;
            lblCustomer.Text = "Customers";
            // 
            // pnlPurchaseReport
            // 
            pnlPurchaseReport.Controls.Add(lblPO);
            pnlPurchaseReport.Controls.Add(lblBills);
            pnlPurchaseReport.Controls.Add(lblSupplier);
            pnlPurchaseReport.Controls.Add(lblPurchaseReport);
            pnlPurchaseReport.Controls.Add(picPurchaseReport);
            pnlPurchaseReport.Location = new Point(3, 3);
            pnlPurchaseReport.Name = "pnlPurchaseReport";
            pnlPurchaseReport.Size = new Size(342, 114);
            pnlPurchaseReport.TabIndex = 8;
            // 
            // lblPO
            // 
            lblPO.AutoSize = true;
            lblPO.Cursor = Cursors.Hand;
            lblPO.Font = new Font("Microsoft Sans Serif", 10F);
            lblPO.ForeColor = Color.Navy;
            lblPO.Location = new Point(67, 85);
            lblPO.Name = "lblPO";
            lblPO.Size = new Size(116, 17);
            lblPO.TabIndex = 12;
            lblPO.Text = "Purchase Orders";
            // 
            // lblBills
            // 
            lblBills.AutoSize = true;
            lblBills.Cursor = Cursors.Hand;
            lblBills.Font = new Font("Microsoft Sans Serif", 10F);
            lblBills.ForeColor = Color.Navy;
            lblBills.Location = new Point(67, 60);
            lblBills.Name = "lblBills";
            lblBills.Size = new Size(33, 17);
            lblBills.TabIndex = 11;
            lblBills.Text = "Bills";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Cursor = Cursors.Hand;
            lblSupplier.Font = new Font("Microsoft Sans Serif", 10F);
            lblSupplier.ForeColor = Color.Navy;
            lblSupplier.Location = new Point(67, 35);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(67, 17);
            lblSupplier.TabIndex = 10;
            lblSupplier.Text = "Suppliers";
            // 
            // lblPurchaseReport
            // 
            lblPurchaseReport.AutoSize = true;
            lblPurchaseReport.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            lblPurchaseReport.ForeColor = Color.SteelBlue;
            lblPurchaseReport.Location = new Point(51, 2);
            lblPurchaseReport.Name = "lblPurchaseReport";
            lblPurchaseReport.Size = new Size(231, 22);
            lblPurchaseReport.TabIndex = 9;
            lblPurchaseReport.Text = "PURCHASE REPORTS :";
            // 
            // picPurchaseReport
            // 
            picPurchaseReport.BackColor = Color.Transparent;
            picPurchaseReport.Image = Properties.Resources.purchase_report;
            picPurchaseReport.Location = new Point(21, 2);
            picPurchaseReport.Name = "picPurchaseReport";
            picPurchaseReport.Size = new Size(26, 26);
            picPurchaseReport.SizeMode = PictureBoxSizeMode.StretchImage;
            picPurchaseReport.TabIndex = 0;
            picPurchaseReport.TabStop = false;
            // 
            // btnNewInvoice
            // 
            btnNewInvoice.BackColor = Color.FromArgb(39, 146, 187);
            btnNewInvoice.Cursor = Cursors.Hand;
            btnNewInvoice.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnNewInvoice.ForeColor = SystemColors.ButtonHighlight;
            btnNewInvoice.Image = Properties.Resources.new_3;
            btnNewInvoice.ImageAlign = ContentAlignment.MiddleRight;
            btnNewInvoice.Location = new Point(166, 170);
            btnNewInvoice.Name = "btnNewInvoice";
            btnNewInvoice.Size = new Size(305, 104);
            btnNewInvoice.TabIndex = 4;
            btnNewInvoice.Text = "NEW INVOICE";
            btnNewInvoice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNewInvoice.UseVisualStyleBackColor = false;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { tsMaster, reportsToolStripMenuItem, toolsToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(1008, 24);
            mainMenuStrip.TabIndex = 2;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // tsMaster
            // 
            tsMaster.DropDownItems.AddRange(new ToolStripItem[] { tsCatagory, tsBrands, tsUnits, tsSizes });
            tsMaster.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsMaster.ForeColor = Color.SteelBlue;
            tsMaster.Name = "tsMaster";
            tsMaster.Size = new Size(55, 20);
            tsMaster.Text = "Master";
            // 
            // tsCatagory
            // 
            tsCatagory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsCatagory.ForeColor = Color.SteelBlue;
            tsCatagory.Name = "tsCatagory";
            tsCatagory.Size = new Size(129, 22);
            tsCatagory.Text = "Categories";
            tsCatagory.Click += tsCategory_Click;
            // 
            // tsBrands
            // 
            tsBrands.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsBrands.ForeColor = Color.SteelBlue;
            tsBrands.Name = "tsBrands";
            tsBrands.Size = new Size(129, 22);
            tsBrands.Text = "Brands";
            tsBrands.Click += tsBrands_Click;
            // 
            // tsUnits
            // 
            tsUnits.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsUnits.ForeColor = Color.SteelBlue;
            tsUnits.Name = "tsUnits";
            tsUnits.Size = new Size(129, 22);
            tsUnits.Text = "Units";
            tsUnits.Click += tsUnits_Click;
            // 
            // tsSizes
            // 
            tsSizes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsSizes.ForeColor = Color.SteelBlue;
            tsSizes.Name = "tsSizes";
            tsSizes.Size = new Size(129, 22);
            tsSizes.Text = "Sizes";
            tsSizes.Click += tsSizes_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportsToolStripMenuItem.ForeColor = Color.SteelBlue;
            reportsToolStripMenuItem.Image = Properties.Resources.Reports;
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(75, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolsToolStripMenuItem.ForeColor = Color.SteelBlue;
            toolsToolStripMenuItem.Image = Properties.Resources.Settings;
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(78, 20);
            toolsToolStripMenuItem.Text = "Settings";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 661);
            Controls.Add(pnlMain);
            Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = mainMenuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balaji Trader & Enterprices";
            WindowState = FormWindowState.Maximized;
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlMainMenu.ResumeLayout(false);
            pnlTools.ResumeLayout(false);
            pnlTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTools).EndInit();
            pnlSalesReport.ResumeLayout(false);
            pnlSalesReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSalesReport).EndInit();
            pnlPurchaseReport.ResumeLayout(false);
            pnlPurchaseReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPurchaseReport).EndInit();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem tsMaster;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private Button btnNewInvoice;
        private Panel pnlMainMenu;
        private Panel pnlSalesReport;
        private Panel pnlPurchaseReport;
        private Panel pnlTools;
        private PictureBox picPurchaseReport;
        private PictureBox picSalesReport;
        private PictureBox picTools;
        private Label lblPurchaseReport;
        private Label lblSalesReport;
        private Label lblSettings;
        private Label lblSupplier;
        private Label lblBills;
        private Label lblPO;
        private Label lblQuatation;
        private Label lblIncoice;
        private Label lblCustomer;
        private Label lblProducts;
        private Label lblStocks;
        private Label lblUsers;
        private Label lblShopDetails;
        private Label lblTaxes;
        private ToolStripMenuItem tsCatagory;
        private ToolStripMenuItem tsBrands;
        private ToolStripMenuItem tsUnits;
        private ToolStripMenuItem tsSizes;
    }
}