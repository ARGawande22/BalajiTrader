namespace BalajiTrader.Client.UI
{
    partial class frmNewBill
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            grpBill = new GroupBox();
            lblVendor = new Label();
            lblVendorStar = new Label();
            cmbVendor = new ComboBox();
            lblBillNo = new Label();
            lblBillNoStar = new Label();
            txtBillNo = new TextBox();
            lblBillDate = new Label();
            dtpBillDate = new DateTimePicker();
            lblVendorGSTNo = new Label();
            txtVendorGSTNo = new TextBox();
            lblPaymentMode = new Label();
            cmbPaymentMode = new ComboBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            grpItem = new GroupBox();
            lblProduct = new Label();
            lblProductStar = new Label();
            cmbProduct = new ComboBox();
            lblHSN = new Label();
            txtHSN = new TextBox();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblQuantity = new Label();
            lblQuantityStar = new Label();
            txtQuantity = new TextBox();
            lblPurchaseRate = new Label();
            lblPurchaseRateStar = new Label();
            txtPurchaseRate = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblGst = new Label();
            lblGstStar = new Label();
            cmbGst = new ComboBox();
            lblSellingRate = new Label();
            lblSellingRateStar = new Label();
            txtSellingRate = new TextBox();
            lblMargin = new Label();
            txtMargin = new TextBox();
            btnAddItem = new Button();
            btnClearItem = new Button();
            lblEntryHint = new Label();
            lblLineTotalCaption = new Label();
            lblLineTotal = new Label();
            dgvItems = new DataGridView();
            colSrNo = new DataGridViewTextBoxColumn();
            colProductCode = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colHSNCode = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPurchaseRate = new DataGridViewTextBoxColumn();
            colDiscountPercent = new DataGridViewTextBoxColumn();
            colGstPercent = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colSellingRate = new DataGridViewTextBoxColumn();
            colMarginPercent = new DataGridViewTextBoxColumn();
            btnRemoveItem = new Button();
            lblGridHint = new Label();
            grpTotals = new GroupBox();
            lblSubTotal = new Label();
            txtSubTotal = new TextBox();
            lblTotalDiscount = new Label();
            txtTotalDiscount = new TextBox();
            lblTotalGst = new Label();
            txtTotalGst = new TextBox();
            lblRoundOff = new Label();
            txtRoundOff = new TextBox();
            lblPaidAmount = new Label();
            txtPaidAmount = new TextBox();
            lblBalance = new Label();
            txtBalance = new TextBox();
            lblGrandTotalCaption = new Label();
            lblGrandTotal = new Label();
            btnSave = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            validationerrors = new ErrorProvider(components);
            pnlMain.SuspendLayout();
            grpBill.SuspendLayout();
            grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            grpTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationerrors).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(grpBill);
            pnlMain.Controls.Add(grpItem);
            pnlMain.Controls.Add(dgvItems);
            pnlMain.Controls.Add(btnRemoveItem);
            pnlMain.Controls.Add(lblGridHint);
            pnlMain.Controls.Add(grpTotals);
            pnlMain.Controls.Add(btnSave);
            pnlMain.Controls.Add(btnClear);
            pnlMain.Controls.Add(btnCancel);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1008, 650);
            pnlMain.TabIndex = 0;
            // 
            // grpBill
            // 
            grpBill.Controls.Add(lblVendor);
            grpBill.Controls.Add(lblVendorStar);
            grpBill.Controls.Add(cmbVendor);
            grpBill.Controls.Add(lblBillNo);
            grpBill.Controls.Add(lblBillNoStar);
            grpBill.Controls.Add(txtBillNo);
            grpBill.Controls.Add(lblBillDate);
            grpBill.Controls.Add(dtpBillDate);
            grpBill.Controls.Add(lblVendorGSTNo);
            grpBill.Controls.Add(txtVendorGSTNo);
            grpBill.Controls.Add(lblPaymentMode);
            grpBill.Controls.Add(cmbPaymentMode);
            grpBill.Controls.Add(lblRemarks);
            grpBill.Controls.Add(txtRemarks);
            grpBill.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBill.ForeColor = Color.SteelBlue;
            grpBill.Location = new Point(12, 8);
            grpBill.Name = "grpBill";
            grpBill.Size = new Size(984, 98);
            grpBill.TabIndex = 0;
            grpBill.TabStop = false;
            grpBill.Text = "Vendor && Bill Details";
            // 
            // lblVendor
            // 
            lblVendor.AutoSize = true;
            lblVendor.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVendor.ForeColor = SystemColors.ControlText;
            lblVendor.Location = new Point(14, 32);
            lblVendor.Name = "lblVendor";
            lblVendor.Size = new Size(60, 18);
            lblVendor.TabIndex = 1;
            lblVendor.Text = "Vendor :";
            // 
            // lblVendorStar
            // 
            lblVendorStar.AutoSize = true;
            lblVendorStar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVendorStar.ForeColor = Color.Red;
            lblVendorStar.Location = new Point(88, 32);
            lblVendorStar.Name = "lblVendorStar";
            lblVendorStar.Size = new Size(15, 18);
            lblVendorStar.TabIndex = 2;
            lblVendorStar.Text = "*";
            // 
            // cmbVendor
            // 
            cmbVendor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendor.Font = new Font("Calibri", 11.25F);
            cmbVendor.FormattingEnabled = true;
            cmbVendor.Location = new Point(104, 28);
            cmbVendor.Name = "cmbVendor";
            cmbVendor.Size = new Size(320, 26);
            cmbVendor.TabIndex = 3;
            // 
            // lblBillNo
            // 
            lblBillNo.AutoSize = true;
            lblBillNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillNo.ForeColor = SystemColors.ControlText;
            lblBillNo.Location = new Point(444, 32);
            lblBillNo.Name = "lblBillNo";
            lblBillNo.Size = new Size(56, 18);
            lblBillNo.TabIndex = 4;
            lblBillNo.Text = "Bill No :";
            // 
            // lblBillNoStar
            // 
            lblBillNoStar.AutoSize = true;
            lblBillNoStar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillNoStar.ForeColor = Color.Red;
            lblBillNoStar.Location = new Point(512, 32);
            lblBillNoStar.Name = "lblBillNoStar";
            lblBillNoStar.Size = new Size(15, 18);
            lblBillNoStar.TabIndex = 5;
            lblBillNoStar.Text = "*";
            // 
            // txtBillNo
            // 
            txtBillNo.Font = new Font("Calibri", 11.25F);
            txtBillNo.Location = new Point(528, 28);
            txtBillNo.MaxLength = 30;
            txtBillNo.Name = "txtBillNo";
            txtBillNo.PlaceholderText = "Vendor bill no";
            txtBillNo.Size = new Size(140, 26);
            txtBillNo.TabIndex = 6;
            // 
            // lblBillDate
            // 
            lblBillDate.AutoSize = true;
            lblBillDate.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillDate.ForeColor = SystemColors.ControlText;
            lblBillDate.Location = new Point(690, 32);
            lblBillDate.Name = "lblBillDate";
            lblBillDate.Size = new Size(67, 18);
            lblBillDate.TabIndex = 7;
            lblBillDate.Text = "Bill Date :";
            // 
            // dtpBillDate
            // 
            dtpBillDate.CustomFormat = "dd/MM/yyyy";
            dtpBillDate.Font = new Font("Calibri", 11.25F);
            dtpBillDate.Format = DateTimePickerFormat.Custom;
            dtpBillDate.Location = new Point(762, 28);
            dtpBillDate.Name = "dtpBillDate";
            dtpBillDate.Size = new Size(130, 26);
            dtpBillDate.TabIndex = 8;
            // 
            // lblVendorGSTNo
            // 
            lblVendorGSTNo.AutoSize = true;
            lblVendorGSTNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVendorGSTNo.ForeColor = SystemColors.ControlText;
            lblVendorGSTNo.Location = new Point(14, 66);
            lblVendorGSTNo.Name = "lblVendorGSTNo";
            lblVendorGSTNo.Size = new Size(59, 18);
            lblVendorGSTNo.TabIndex = 9;
            lblVendorGSTNo.Text = "GST No :";
            // 
            // txtVendorGSTNo
            // 
            txtVendorGSTNo.BackColor = Color.WhiteSmoke;
            txtVendorGSTNo.Font = new Font("Calibri", 11.25F);
            txtVendorGSTNo.Location = new Point(104, 62);
            txtVendorGSTNo.Name = "txtVendorGSTNo";
            txtVendorGSTNo.ReadOnly = true;
            txtVendorGSTNo.Size = new Size(200, 26);
            txtVendorGSTNo.TabIndex = 10;
            txtVendorGSTNo.TabStop = false;
            // 
            // lblPaymentMode
            // 
            lblPaymentMode.AutoSize = true;
            lblPaymentMode.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMode.ForeColor = SystemColors.ControlText;
            lblPaymentMode.Location = new Point(444, 66);
            lblPaymentMode.Name = "lblPaymentMode";
            lblPaymentMode.Size = new Size(70, 18);
            lblPaymentMode.TabIndex = 10;
            lblPaymentMode.Text = "Payment :";
            // 
            // cmbPaymentMode
            // 
            cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMode.Font = new Font("Calibri", 11.25F);
            cmbPaymentMode.FormattingEnabled = true;
            cmbPaymentMode.Items.AddRange(new object[] { "Cash", "UPI", "Cheque", "Bank Transfer", "Credit" });
            cmbPaymentMode.Location = new Point(528, 62);
            cmbPaymentMode.Name = "cmbPaymentMode";
            cmbPaymentMode.Size = new Size(140, 26);
            cmbPaymentMode.TabIndex = 11;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemarks.ForeColor = SystemColors.ControlText;
            lblRemarks.Location = new Point(690, 66);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(68, 18);
            lblRemarks.TabIndex = 12;
            lblRemarks.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Calibri", 11.25F);
            txtRemarks.Location = new Point(762, 62);
            txtRemarks.MaxLength = 200;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.PlaceholderText = "Optional";
            txtRemarks.Size = new Size(210, 26);
            txtRemarks.TabIndex = 13;
            // 
            // grpItem
            // 
            grpItem.Controls.Add(lblProduct);
            grpItem.Controls.Add(lblProductStar);
            grpItem.Controls.Add(cmbProduct);
            grpItem.Controls.Add(lblHSN);
            grpItem.Controls.Add(txtHSN);
            grpItem.Controls.Add(lblUnit);
            grpItem.Controls.Add(txtUnit);
            grpItem.Controls.Add(lblQuantity);
            grpItem.Controls.Add(lblQuantityStar);
            grpItem.Controls.Add(txtQuantity);
            grpItem.Controls.Add(lblPurchaseRate);
            grpItem.Controls.Add(lblPurchaseRateStar);
            grpItem.Controls.Add(txtPurchaseRate);
            grpItem.Controls.Add(lblDiscount);
            grpItem.Controls.Add(txtDiscount);
            grpItem.Controls.Add(lblGst);
            grpItem.Controls.Add(lblGstStar);
            grpItem.Controls.Add(cmbGst);
            grpItem.Controls.Add(lblSellingRate);
            grpItem.Controls.Add(lblSellingRateStar);
            grpItem.Controls.Add(txtSellingRate);
            grpItem.Controls.Add(lblMargin);
            grpItem.Controls.Add(txtMargin);
            grpItem.Controls.Add(btnAddItem);
            grpItem.Controls.Add(btnClearItem);
            grpItem.Controls.Add(lblEntryHint);
            grpItem.Controls.Add(lblLineTotalCaption);
            grpItem.Controls.Add(lblLineTotal);
            grpItem.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpItem.ForeColor = Color.SteelBlue;
            grpItem.Location = new Point(12, 112);
            grpItem.Name = "grpItem";
            grpItem.Size = new Size(984, 114);
            grpItem.TabIndex = 14;
            grpItem.TabStop = false;
            grpItem.Text = "Add Item";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduct.ForeColor = SystemColors.ControlText;
            lblProduct.Location = new Point(14, 24);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(56, 18);
            lblProduct.TabIndex = 15;
            lblProduct.Text = "Product";
            // 
            // lblProductStar
            // 
            lblProductStar.AutoSize = true;
            lblProductStar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductStar.ForeColor = Color.Red;
            lblProductStar.Location = new Point(62, 24);
            lblProductStar.Name = "lblProductStar";
            lblProductStar.Size = new Size(15, 18);
            lblProductStar.TabIndex = 16;
            lblProductStar.Text = "*";
            // 
            // cmbProduct
            // 
            cmbProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProduct.Font = new Font("Calibri", 11.25F);
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(14, 46);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(300, 26);
            cmbProduct.TabIndex = 17;
            // 
            // lblHSN
            // 
            lblHSN.AutoSize = true;
            lblHSN.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHSN.ForeColor = SystemColors.ControlText;
            lblHSN.Location = new Point(322, 24);
            lblHSN.Name = "lblHSN";
            lblHSN.Size = new Size(34, 18);
            lblHSN.TabIndex = 18;
            lblHSN.Text = "HSN";
            // 
            // txtHSN
            // 
            txtHSN.BackColor = Color.WhiteSmoke;
            txtHSN.Font = new Font("Calibri", 11.25F);
            txtHSN.Location = new Point(322, 46);
            txtHSN.Name = "txtHSN";
            txtHSN.ReadOnly = true;
            txtHSN.Size = new Size(80, 26);
            txtHSN.TabIndex = 19;
            txtHSN.TabStop = false;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnit.ForeColor = SystemColors.ControlText;
            lblUnit.Location = new Point(410, 24);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(34, 18);
            lblUnit.TabIndex = 19;
            lblUnit.Text = "Unit";
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.WhiteSmoke;
            txtUnit.Font = new Font("Calibri", 11.25F);
            txtUnit.Location = new Point(410, 46);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(55, 26);
            txtUnit.TabIndex = 20;
            txtUnit.TabStop = false;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ControlText;
            lblQuantity.Location = new Point(473, 24);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(30, 18);
            lblQuantity.TabIndex = 20;
            lblQuantity.Text = "Qty";
            // 
            // lblQuantityStar
            // 
            lblQuantityStar.AutoSize = true;
            lblQuantityStar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantityStar.ForeColor = Color.Red;
            lblQuantityStar.Location = new Point(509, 24);
            lblQuantityStar.Name = "lblQuantityStar";
            lblQuantityStar.Size = new Size(15, 18);
            lblQuantityStar.TabIndex = 21;
            lblQuantityStar.Text = "*";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Calibri", 11.25F);
            txtQuantity.Location = new Point(473, 46);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(72, 26);
            txtQuantity.TabIndex = 22;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPurchaseRate
            // 
            lblPurchaseRate.AutoSize = true;
            lblPurchaseRate.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPurchaseRate.ForeColor = SystemColors.ControlText;
            lblPurchaseRate.Location = new Point(553, 24);
            lblPurchaseRate.Name = "lblPurchaseRate";
            lblPurchaseRate.Size = new Size(95, 18);
            lblPurchaseRate.TabIndex = 23;
            lblPurchaseRate.Text = "Purchase Rate";
            // 
            // lblPurchaseRateStar
            // 
            lblPurchaseRateStar.AutoSize = true;
            lblPurchaseRateStar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPurchaseRateStar.ForeColor = Color.Red;
            lblPurchaseRateStar.Location = new Point(639, 24);
            lblPurchaseRateStar.Name = "lblPurchaseRateStar";
            lblPurchaseRateStar.Size = new Size(15, 18);
            lblPurchaseRateStar.TabIndex = 24;
            lblPurchaseRateStar.Text = "*";
            // 
            // txtPurchaseRate
            // 
            txtPurchaseRate.Font = new Font("Calibri", 11.25F);
            txtPurchaseRate.Location = new Point(553, 46);
            txtPurchaseRate.Name = "txtPurchaseRate";
            txtPurchaseRate.Size = new Size(92, 26);
            txtPurchaseRate.TabIndex = 25;
            txtPurchaseRate.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.ForeColor = SystemColors.ControlText;
            lblDiscount.Location = new Point(653, 24);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(47, 18);
            lblDiscount.TabIndex = 26;
            lblDiscount.Text = "Disc %";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Calibri", 11.25F);
            txtDiscount.Location = new Point(653, 46);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(60, 26);
            txtDiscount.TabIndex = 27;
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblGst
            // 
            lblGst.AutoSize = true;
            lblGst.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGst.ForeColor = SystemColors.ControlText;
            lblGst.Location = new Point(721, 24);
            lblGst.Name = "lblGst";
            lblGst.Size = new Size(45, 18);
            lblGst.TabIndex = 28;
            lblGst.Text = "GST %";
            // 
            // lblGstStar
            // 
            lblGstStar.AutoSize = true;
            lblGstStar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGstStar.ForeColor = Color.Red;
            lblGstStar.Location = new Point(769, 24);
            lblGstStar.Name = "lblGstStar";
            lblGstStar.Size = new Size(15, 18);
            lblGstStar.TabIndex = 29;
            lblGstStar.Text = "*";
            // 
            // cmbGst
            // 
            cmbGst.Font = new Font("Calibri", 11.25F);
            cmbGst.FormattingEnabled = true;
            cmbGst.Items.AddRange(new object[] { "0", "5", "12", "18", "28" });
            cmbGst.Location = new Point(721, 46);
            cmbGst.Name = "cmbGst";
            cmbGst.Size = new Size(66, 26);
            cmbGst.TabIndex = 30;
            // 
            // lblSellingRate
            // 
            lblSellingRate.AutoSize = true;
            lblSellingRate.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSellingRate.ForeColor = SystemColors.ControlText;
            lblSellingRate.Location = new Point(795, 24);
            lblSellingRate.Name = "lblSellingRate";
            lblSellingRate.Size = new Size(81, 18);
            lblSellingRate.TabIndex = 31;
            lblSellingRate.Text = "Selling Rate";
            // 
            // lblSellingRateStar
            // 
            lblSellingRateStar.AutoSize = true;
            lblSellingRateStar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSellingRateStar.ForeColor = Color.Red;
            lblSellingRateStar.Location = new Point(873, 24);
            lblSellingRateStar.Name = "lblSellingRateStar";
            lblSellingRateStar.Size = new Size(15, 18);
            lblSellingRateStar.TabIndex = 32;
            lblSellingRateStar.Text = "*";
            // 
            // txtSellingRate
            // 
            txtSellingRate.Font = new Font("Calibri", 11.25F);
            txtSellingRate.Location = new Point(795, 46);
            txtSellingRate.Name = "txtSellingRate";
            txtSellingRate.Size = new Size(92, 26);
            txtSellingRate.TabIndex = 33;
            txtSellingRate.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMargin
            // 
            lblMargin.AutoSize = true;
            lblMargin.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMargin.ForeColor = SystemColors.ControlText;
            lblMargin.Location = new Point(895, 24);
            lblMargin.Name = "lblMargin";
            lblMargin.Size = new Size(65, 18);
            lblMargin.TabIndex = 34;
            lblMargin.Text = "Margin %";
            // 
            // txtMargin
            // 
            txtMargin.BackColor = Color.WhiteSmoke;
            txtMargin.Font = new Font("Calibri", 11.25F);
            txtMargin.Location = new Point(895, 46);
            txtMargin.Name = "txtMargin";
            txtMargin.ReadOnly = true;
            txtMargin.Size = new Size(76, 26);
            txtMargin.TabIndex = 35;
            txtMargin.TabStop = false;
            txtMargin.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.WhiteSmoke;
            btnAddItem.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = SystemColors.ActiveCaptionText;
            btnAddItem.Image = Properties.Resources.plusb;
            btnAddItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddItem.Location = new Point(14, 80);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(95, 28);
            btnAddItem.TabIndex = 35;
            btnAddItem.Text = "Add Item";
            btnAddItem.TextAlign = ContentAlignment.MiddleRight;
            btnAddItem.UseVisualStyleBackColor = false;
            // 
            // btnClearItem
            // 
            btnClearItem.BackColor = Color.WhiteSmoke;
            btnClearItem.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearItem.ForeColor = SystemColors.ActiveCaptionText;
            btnClearItem.Image = Properties.Resources.Exit;
            btnClearItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearItem.Location = new Point(117, 80);
            btnClearItem.Name = "btnClearItem";
            btnClearItem.Size = new Size(75, 28);
            btnClearItem.TabIndex = 36;
            btnClearItem.Text = "Clear";
            btnClearItem.TextAlign = ContentAlignment.MiddleRight;
            btnClearItem.UseVisualStyleBackColor = false;
            // 
            // lblEntryHint
            // 
            lblEntryHint.AutoSize = true;
            lblEntryHint.Font = new Font("Calibri", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEntryHint.ForeColor = Color.Gray;
            lblEntryHint.Location = new Point(211, 87);
            lblEntryHint.Name = "lblEntryHint";
            lblEntryHint.Size = new Size(372, 14);
            lblEntryHint.TabIndex = 37;
            lblEntryHint.Text = "F2 - find product   |   Enter - next field   |   Enter on Selling Rate - add item";
            // 
            // lblLineTotalCaption
            // 
            lblLineTotalCaption.AutoSize = true;
            lblLineTotalCaption.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLineTotalCaption.ForeColor = SystemColors.ControlText;
            lblLineTotalCaption.Location = new Point(700, 86);
            lblLineTotalCaption.Name = "lblLineTotalCaption";
            lblLineTotalCaption.Size = new Size(74, 18);
            lblLineTotalCaption.TabIndex = 38;
            lblLineTotalCaption.Text = "Line Total :";
            // 
            // lblLineTotal
            // 
            lblLineTotal.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLineTotal.ForeColor = Color.SteelBlue;
            lblLineTotal.Location = new Point(776, 83);
            lblLineTotal.Name = "lblLineTotal";
            lblLineTotal.Size = new Size(195, 24);
            lblLineTotal.TabIndex = 39;
            lblLineTotal.Text = "0.00";
            lblLineTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle41.BackColor = Color.Azure;
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.BackColor = Color.SteelBlue;
            dataGridViewCellStyle42.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle42.ForeColor = Color.White;
            dataGridViewCellStyle42.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.False;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            dgvItems.ColumnHeadersHeight = 32;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colSrNo, colProductCode, colProductName, colHSNCode, colUnit, colQuantity, colPurchaseRate, colDiscountPercent, colGstPercent, colTotalAmount, colSellingRate, colMarginPercent });
            dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = SystemColors.Window;
            dataGridViewCellStyle50.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle50.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle50.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle50.SelectionForeColor = Color.Black;
            dataGridViewCellStyle50.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle50;
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.GridColor = Color.LightSteelBlue;
            dgvItems.Location = new Point(12, 232);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(984, 226);
            dgvItems.TabIndex = 40;
            // 
            // colSrNo
            // 
            colSrNo.DataPropertyName = "SrNo";
            colSrNo.HeaderText = "Sr No.";
            colSrNo.Name = "colSrNo";
            colSrNo.ReadOnly = true;
            colSrNo.SortMode = DataGridViewColumnSortMode.NotSortable;
            colSrNo.Width = 45;
            // 
            // colProductCode
            // 
            colProductCode.DataPropertyName = "ProductCode";
            colProductCode.HeaderText = "Code";
            colProductCode.Name = "colProductCode";
            colProductCode.ReadOnly = true;
            colProductCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            colProductCode.Width = 75;
            // 
            // colProductName
            // 
            colProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductName.DataPropertyName = "ProductName";
            colProductName.HeaderText = "Product";
            colProductName.MinimumWidth = 120;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colHSNCode
            // 
            colHSNCode.DataPropertyName = "HSNCode";
            colHSNCode.HeaderText = "HSN";
            colHSNCode.Name = "colHSNCode";
            colHSNCode.ReadOnly = true;
            colHSNCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            colHSNCode.Width = 75;
            // 
            // colUnit
            // 
            colUnit.DataPropertyName = "Unit";
            colUnit.HeaderText = "Unit";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            colUnit.SortMode = DataGridViewColumnSortMode.NotSortable;
            colUnit.Width = 50;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle43.Format = "0.###";
            colQuantity.DefaultCellStyle = dataGridViewCellStyle43;
            colQuantity.HeaderText = "Qty";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.SortMode = DataGridViewColumnSortMode.NotSortable;
            colQuantity.Width = 65;
            // 
            // colPurchaseRate
            // 
            colPurchaseRate.DataPropertyName = "PurchaseRate";
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle44.Format = "N2";
            colPurchaseRate.DefaultCellStyle = dataGridViewCellStyle44;
            colPurchaseRate.HeaderText = "Purchase Rate";
            colPurchaseRate.Name = "colPurchaseRate";
            colPurchaseRate.ReadOnly = true;
            colPurchaseRate.SortMode = DataGridViewColumnSortMode.NotSortable;
            colPurchaseRate.Width = 90;
            // 
            // colDiscountPercent
            // 
            colDiscountPercent.DataPropertyName = "DiscountPercent";
            dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle45.Format = "N2";
            colDiscountPercent.DefaultCellStyle = dataGridViewCellStyle45;
            colDiscountPercent.HeaderText = "Disc %";
            colDiscountPercent.Name = "colDiscountPercent";
            colDiscountPercent.ReadOnly = true;
            colDiscountPercent.SortMode = DataGridViewColumnSortMode.NotSortable;
            colDiscountPercent.Width = 60;
            // 
            // colGstPercent
            // 
            colGstPercent.DataPropertyName = "GstPercent";
            dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle46.Format = "N2";
            colGstPercent.DefaultCellStyle = dataGridViewCellStyle46;
            colGstPercent.HeaderText = "GST %";
            colGstPercent.Name = "colGstPercent";
            colGstPercent.ReadOnly = true;
            colGstPercent.SortMode = DataGridViewColumnSortMode.NotSortable;
            colGstPercent.Width = 60;
            // 
            // colTotalAmount
            // 
            colTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle47.Format = "N2";
            colTotalAmount.DefaultCellStyle = dataGridViewCellStyle47;
            colTotalAmount.HeaderText = "Amount";
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            colTotalAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTotalAmount.Width = 90;
            // 
            // colSellingRate
            // 
            colSellingRate.DataPropertyName = "SellingRate";
            dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle48.Format = "N2";
            colSellingRate.DefaultCellStyle = dataGridViewCellStyle48;
            colSellingRate.HeaderText = "Selling Rate";
            colSellingRate.Name = "colSellingRate";
            colSellingRate.ReadOnly = true;
            colSellingRate.SortMode = DataGridViewColumnSortMode.NotSortable;
            colSellingRate.Width = 90;
            // 
            // colMarginPercent
            // 
            colMarginPercent.DataPropertyName = "MarginPercent";
            dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle49.Format = "N2";
            colMarginPercent.DefaultCellStyle = dataGridViewCellStyle49;
            colMarginPercent.HeaderText = "Margin %";
            colMarginPercent.Name = "colMarginPercent";
            colMarginPercent.ReadOnly = true;
            colMarginPercent.SortMode = DataGridViewColumnSortMode.NotSortable;
            colMarginPercent.Width = 75;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.WhiteSmoke;
            btnRemoveItem.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveItem.ForeColor = SystemColors.ActiveCaptionText;
            btnRemoveItem.Image = Properties.Resources.delete;
            btnRemoveItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoveItem.Location = new Point(12, 464);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(140, 28);
            btnRemoveItem.TabIndex = 41;
            btnRemoveItem.Text = "Remove Selected";
            btnRemoveItem.TextAlign = ContentAlignment.MiddleRight;
            btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // lblGridHint
            // 
            lblGridHint.AutoSize = true;
            lblGridHint.Font = new Font("Calibri", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGridHint.ForeColor = Color.Gray;
            lblGridHint.Location = new Point(162, 470);
            lblGridHint.Name = "lblGridHint";
            lblGridHint.Size = new Size(361, 14);
            lblGridHint.TabIndex = 42;
            lblGridHint.Text = "Double-click an item to edit it   |   Delete key removes the selected item";
            // 
            // grpTotals
            // 
            grpTotals.Controls.Add(lblSubTotal);
            grpTotals.Controls.Add(txtSubTotal);
            grpTotals.Controls.Add(lblTotalDiscount);
            grpTotals.Controls.Add(txtTotalDiscount);
            grpTotals.Controls.Add(lblTotalGst);
            grpTotals.Controls.Add(txtTotalGst);
            grpTotals.Controls.Add(lblRoundOff);
            grpTotals.Controls.Add(txtRoundOff);
            grpTotals.Controls.Add(lblPaidAmount);
            grpTotals.Controls.Add(txtPaidAmount);
            grpTotals.Controls.Add(lblBalance);
            grpTotals.Controls.Add(txtBalance);
            grpTotals.Controls.Add(lblGrandTotalCaption);
            grpTotals.Controls.Add(lblGrandTotal);
            grpTotals.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpTotals.ForeColor = Color.SteelBlue;
            grpTotals.Location = new Point(12, 498);
            grpTotals.Name = "grpTotals";
            grpTotals.Size = new Size(984, 98);
            grpTotals.TabIndex = 43;
            grpTotals.TabStop = false;
            grpTotals.Text = "Bill Summary";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.ForeColor = SystemColors.ControlText;
            lblSubTotal.Location = new Point(14, 32);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(71, 18);
            lblSubTotal.TabIndex = 44;
            lblSubTotal.Text = "Sub Total :";
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.WhiteSmoke;
            txtSubTotal.Font = new Font("Calibri", 11.25F);
            txtSubTotal.Location = new Point(88, 28);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(110, 26);
            txtSubTotal.TabIndex = 45;
            txtSubTotal.TabStop = false;
            txtSubTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalDiscount
            // 
            lblTotalDiscount.AutoSize = true;
            lblTotalDiscount.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDiscount.ForeColor = SystemColors.ControlText;
            lblTotalDiscount.Location = new Point(212, 32);
            lblTotalDiscount.Name = "lblTotalDiscount";
            lblTotalDiscount.Size = new Size(69, 18);
            lblTotalDiscount.TabIndex = 45;
            lblTotalDiscount.Text = "Discount :";
            // 
            // txtTotalDiscount
            // 
            txtTotalDiscount.BackColor = Color.WhiteSmoke;
            txtTotalDiscount.Font = new Font("Calibri", 11.25F);
            txtTotalDiscount.Location = new Point(283, 28);
            txtTotalDiscount.Name = "txtTotalDiscount";
            txtTotalDiscount.ReadOnly = true;
            txtTotalDiscount.Size = new Size(110, 26);
            txtTotalDiscount.TabIndex = 46;
            txtTotalDiscount.TabStop = false;
            txtTotalDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalGst
            // 
            lblTotalGst.AutoSize = true;
            lblTotalGst.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalGst.ForeColor = SystemColors.ControlText;
            lblTotalGst.Location = new Point(402, 32);
            lblTotalGst.Name = "lblTotalGst";
            lblTotalGst.Size = new Size(91, 18);
            lblTotalGst.TabIndex = 46;
            lblTotalGst.Text = "GST Amount :";
            // 
            // txtTotalGst
            // 
            txtTotalGst.BackColor = Color.WhiteSmoke;
            txtTotalGst.Font = new Font("Calibri", 11.25F);
            txtTotalGst.Location = new Point(494, 28);
            txtTotalGst.Name = "txtTotalGst";
            txtTotalGst.ReadOnly = true;
            txtTotalGst.Size = new Size(110, 26);
            txtTotalGst.TabIndex = 47;
            txtTotalGst.TabStop = false;
            txtTotalGst.TextAlign = HorizontalAlignment.Right;
            // 
            // lblRoundOff
            // 
            lblRoundOff.AutoSize = true;
            lblRoundOff.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoundOff.ForeColor = SystemColors.ControlText;
            lblRoundOff.Location = new Point(618, 32);
            lblRoundOff.Name = "lblRoundOff";
            lblRoundOff.Size = new Size(77, 18);
            lblRoundOff.TabIndex = 47;
            lblRoundOff.Text = "Round Off :";
            // 
            // txtRoundOff
            // 
            txtRoundOff.BackColor = Color.WhiteSmoke;
            txtRoundOff.Font = new Font("Calibri", 11.25F);
            txtRoundOff.Location = new Point(696, 28);
            txtRoundOff.Name = "txtRoundOff";
            txtRoundOff.ReadOnly = true;
            txtRoundOff.Size = new Size(80, 26);
            txtRoundOff.TabIndex = 48;
            txtRoundOff.TabStop = false;
            txtRoundOff.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.AutoSize = true;
            lblPaidAmount.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaidAmount.ForeColor = SystemColors.ControlText;
            lblPaidAmount.Location = new Point(14, 66);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(95, 18);
            lblPaidAmount.TabIndex = 48;
            lblPaidAmount.Text = "Paid Amount :";
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Font = new Font("Calibri", 11.25F);
            txtPaidAmount.Location = new Point(111, 62);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(110, 26);
            txtPaidAmount.TabIndex = 49;
            txtPaidAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = SystemColors.ControlText;
            lblBalance.Location = new Point(228, 66);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(63, 18);
            lblBalance.TabIndex = 50;
            lblBalance.Text = "Balance :";
            // 
            // txtBalance
            // 
            txtBalance.BackColor = Color.WhiteSmoke;
            txtBalance.Font = new Font("Calibri", 11.25F);
            txtBalance.Location = new Point(294, 62);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(110, 26);
            txtBalance.TabIndex = 51;
            txtBalance.TabStop = false;
            txtBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // lblGrandTotalCaption
            // 
            lblGrandTotalCaption.AutoSize = true;
            lblGrandTotalCaption.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotalCaption.ForeColor = SystemColors.ControlText;
            lblGrandTotalCaption.Location = new Point(840, 22);
            lblGrandTotalCaption.Name = "lblGrandTotalCaption";
            lblGrandTotalCaption.Size = new Size(95, 18);
            lblGrandTotalCaption.TabIndex = 51;
            lblGrandTotalCaption.Text = "GRAND TOTAL";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = Color.SteelBlue;
            lblGrandTotal.Location = new Point(780, 44);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(196, 40);
            lblGrandTotal.TabIndex = 52;
            lblGrandTotal.Text = "0.00";
            lblGrandTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.Save_Update;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(637, 606);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 34);
            btnSave.TabIndex = 53;
            btnSave.Text = "Save && Update";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Image = Properties.Resources.purchase_report;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(779, 606);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 34);
            btnClear.TabIndex = 54;
            btnClear.Text = "New Bill";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Image = Properties.Resources.Exit;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(886, 606);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 34);
            btnCancel.TabIndex = 55;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // validationerrors
            // 
            validationerrors.ContainerControl = this;
            // 
            // frmNewBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 650);
            Controls.Add(pnlMain);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewBill";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Bill";
            Load += frmNewBill_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            grpBill.ResumeLayout(false);
            grpBill.PerformLayout();
            grpItem.ResumeLayout(false);
            grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            grpTotals.ResumeLayout(false);
            grpTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)validationerrors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private GroupBox grpBill;
        private Label lblVendor;
        private Label lblVendorStar;
        private ComboBox cmbVendor;
        private Label lblBillNo;
        private Label lblBillNoStar;
        private TextBox txtBillNo;
        private Label lblBillDate;
        private DateTimePicker dtpBillDate;
        private Label lblVendorGSTNo;
        private TextBox txtVendorGSTNo;
        private Label lblPaymentMode;
        private ComboBox cmbPaymentMode;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private GroupBox grpItem;
        private Label lblProduct;
        private Label lblProductStar;
        private ComboBox cmbProduct;
        private Label lblHSN;
        private TextBox txtHSN;
        private Label lblUnit;
        private TextBox txtUnit;
        private Label lblQuantity;
        private Label lblQuantityStar;
        private TextBox txtQuantity;
        private Label lblPurchaseRate;
        private Label lblPurchaseRateStar;
        private TextBox txtPurchaseRate;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Label lblGst;
        private Label lblGstStar;
        private ComboBox cmbGst;
        private Label lblSellingRate;
        private Label lblSellingRateStar;
        private TextBox txtSellingRate;
        private Label lblMargin;
        private TextBox txtMargin;
        private Button btnAddItem;
        private Button btnClearItem;
        private Label lblEntryHint;
        private Label lblLineTotalCaption;
        private Label lblLineTotal;
        private Button btnRemoveItem;
        private Label lblGridHint;
        private GroupBox grpTotals;
        private Label lblSubTotal;
        private TextBox txtSubTotal;
        private Label lblTotalDiscount;
        private TextBox txtTotalDiscount;
        private Label lblTotalGst;
        private TextBox txtTotalGst;
        private Label lblRoundOff;
        private TextBox txtRoundOff;
        private Label lblPaidAmount;
        private TextBox txtPaidAmount;
        private Label lblBalance;
        private TextBox txtBalance;
        private Label lblGrandTotalCaption;
        private Label lblGrandTotal;
        private Button btnSave;
        private Button btnClear;
        private Button btnCancel;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn colSrNo;
        private DataGridViewTextBoxColumn colProductCode;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colHSNCode;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPurchaseRate;
        private DataGridViewTextBoxColumn colDiscountPercent;
        private DataGridViewTextBoxColumn colGstPercent;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colSellingRate;
        private DataGridViewTextBoxColumn colMarginPercent;
        private ErrorProvider validationerrors;
    }
}