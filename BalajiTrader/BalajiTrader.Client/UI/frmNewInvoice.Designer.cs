namespace BalajiTrader.Client.UI
{
    partial class frmNewInvoice
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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            grpInvoice = new GroupBox();
            lblInvoiceNo = new Label();
            txtInvoiceNo = new TextBox();
            lblInvoiceDate = new Label();
            dtpInvoiceDate = new DateTimePicker();
            lblCustomer = new Label();
            cmbCustomer = new ComboBox();
            lblCustomerGSTNo = new Label();
            txtCustomerGSTNo = new TextBox();
            lblPaymentMode = new Label();
            cmbPaymentMode = new ComboBox();
            chkInterState = new CheckBox();
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
            lblStock = new Label();
            txtStock = new TextBox();
            lblQuantity = new Label();
            lblQuantityStar = new Label();
            txtQuantity = new TextBox();
            lblRate = new Label();
            lblRateStar = new Label();
            txtRate = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblGst = new Label();
            lblGstStar = new Label();
            cmbGst = new ComboBox();
            chkRateIncludesGst = new CheckBox();
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
            colRate = new DataGridViewTextBoxColumn();
            colDiscountPercent = new DataGridViewTextBoxColumn();
            colGstPercent = new DataGridViewTextBoxColumn();
            colTaxableAmount = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            btnRemoveItem = new Button();
            lblGridHint = new Label();
            grpTotals = new GroupBox();
            lblSubTotal = new Label();
            txtSubTotal = new TextBox();
            lblTotalDiscount = new Label();
            txtTotalDiscount = new TextBox();
            lblTaxableAmount = new Label();
            txtTaxableAmount = new TextBox();
            lblRoundOff = new Label();
            txtRoundOff = new TextBox();
            lblCgst = new Label();
            txtCgst = new TextBox();
            lblSgst = new Label();
            txtSgst = new TextBox();
            lblIgst = new Label();
            txtIgst = new TextBox();
            lblReceivedAmount = new Label();
            txtReceivedAmount = new TextBox();
            lblBalance = new Label();
            txtBalance = new TextBox();
            lblGrandTotalCaption = new Label();
            lblGrandTotal = new Label();
            btnSave = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            validationerrors = new ErrorProvider(components);
            pnlMain.SuspendLayout();
            grpInvoice.SuspendLayout();
            grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            grpTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationerrors).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(grpInvoice);
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
            pnlMain.Size = new Size(1008, 640);
            pnlMain.TabIndex = 0;
            // 
            // grpInvoice
            // 
            grpInvoice.Controls.Add(lblInvoiceNo);
            grpInvoice.Controls.Add(txtInvoiceNo);
            grpInvoice.Controls.Add(lblInvoiceDate);
            grpInvoice.Controls.Add(dtpInvoiceDate);
            grpInvoice.Controls.Add(lblCustomer);
            grpInvoice.Controls.Add(cmbCustomer);
            grpInvoice.Controls.Add(lblCustomerGSTNo);
            grpInvoice.Controls.Add(txtCustomerGSTNo);
            grpInvoice.Controls.Add(lblPaymentMode);
            grpInvoice.Controls.Add(cmbPaymentMode);
            grpInvoice.Controls.Add(chkInterState);
            grpInvoice.Controls.Add(lblRemarks);
            grpInvoice.Controls.Add(txtRemarks);
            grpInvoice.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpInvoice.ForeColor = Color.SteelBlue;
            grpInvoice.Location = new Point(12, 8);
            grpInvoice.Name = "grpInvoice";
            grpInvoice.Size = new Size(984, 98);
            grpInvoice.TabIndex = 0;
            grpInvoice.TabStop = false;
            grpInvoice.Text = "Invoice Details";
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceNo.ForeColor = SystemColors.ControlText;
            lblInvoiceNo.Location = new Point(14, 32);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(81, 18);
            lblInvoiceNo.TabIndex = 1;
            lblInvoiceNo.Text = "Invoice No :";
            // 
            // txtInvoiceNo
            // 
            txtInvoiceNo.BackColor = Color.WhiteSmoke;
            txtInvoiceNo.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInvoiceNo.Location = new Point(104, 28);
            txtInvoiceNo.Name = "txtInvoiceNo";
            txtInvoiceNo.ReadOnly = true;
            txtInvoiceNo.Size = new Size(150, 26);
            txtInvoiceNo.TabIndex = 2;
            txtInvoiceNo.TabStop = false;
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceDate.ForeColor = SystemColors.ControlText;
            lblInvoiceDate.Location = new Point(280, 32);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(44, 18);
            lblInvoiceDate.TabIndex = 2;
            lblInvoiceDate.Text = "Date :";
            // 
            // dtpInvoiceDate
            // 
            dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            dtpInvoiceDate.Font = new Font("Calibri", 11.25F);
            dtpInvoiceDate.Format = DateTimePickerFormat.Custom;
            dtpInvoiceDate.Location = new Point(332, 28);
            dtpInvoiceDate.Name = "dtpInvoiceDate";
            dtpInvoiceDate.Size = new Size(130, 26);
            dtpInvoiceDate.TabIndex = 3;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomer.ForeColor = SystemColors.ControlText;
            lblCustomer.Location = new Point(490, 32);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(75, 18);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "Customer :";
            // 
            // cmbCustomer
            // 
            cmbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCustomer.Font = new Font("Calibri", 11.25F);
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(565, 28);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(405, 26);
            cmbCustomer.TabIndex = 5;
            // 
            // lblCustomerGSTNo
            // 
            lblCustomerGSTNo.AutoSize = true;
            lblCustomerGSTNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerGSTNo.ForeColor = SystemColors.ControlText;
            lblCustomerGSTNo.Location = new Point(14, 66);
            lblCustomerGSTNo.Name = "lblCustomerGSTNo";
            lblCustomerGSTNo.Size = new Size(59, 18);
            lblCustomerGSTNo.TabIndex = 6;
            lblCustomerGSTNo.Text = "GST No :";
            // 
            // txtCustomerGSTNo
            // 
            txtCustomerGSTNo.BackColor = Color.WhiteSmoke;
            txtCustomerGSTNo.Font = new Font("Calibri", 11.25F);
            txtCustomerGSTNo.Location = new Point(104, 62);
            txtCustomerGSTNo.Name = "txtCustomerGSTNo";
            txtCustomerGSTNo.ReadOnly = true;
            txtCustomerGSTNo.Size = new Size(150, 26);
            txtCustomerGSTNo.TabIndex = 7;
            txtCustomerGSTNo.TabStop = false;
            // 
            // lblPaymentMode
            // 
            lblPaymentMode.AutoSize = true;
            lblPaymentMode.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMode.ForeColor = SystemColors.ControlText;
            lblPaymentMode.Location = new Point(280, 66);
            lblPaymentMode.Name = "lblPaymentMode";
            lblPaymentMode.Size = new Size(70, 18);
            lblPaymentMode.TabIndex = 7;
            lblPaymentMode.Text = "Payment :";
            // 
            // cmbPaymentMode
            // 
            cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMode.Font = new Font("Calibri", 11.25F);
            cmbPaymentMode.FormattingEnabled = true;
            cmbPaymentMode.Items.AddRange(new object[] { "Cash", "UPI", "Card", "Cheque", "Credit" });
            cmbPaymentMode.Location = new Point(350, 62);
            cmbPaymentMode.Name = "cmbPaymentMode";
            cmbPaymentMode.Size = new Size(112, 26);
            cmbPaymentMode.TabIndex = 8;
            // 
            // chkInterState
            // 
            chkInterState.AutoSize = true;
            chkInterState.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkInterState.ForeColor = SystemColors.ControlText;
            chkInterState.Location = new Point(490, 64);
            chkInterState.Name = "chkInterState";
            chkInterState.Size = new Size(161, 22);
            chkInterState.TabIndex = 9;
            chkInterState.Text = "Inter-state sale (IGST)";
            chkInterState.UseVisualStyleBackColor = true;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemarks.ForeColor = SystemColors.ControlText;
            lblRemarks.Location = new Point(700, 66);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(68, 18);
            lblRemarks.TabIndex = 10;
            lblRemarks.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Calibri", 11.25F);
            txtRemarks.Location = new Point(770, 62);
            txtRemarks.MaxLength = 200;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.PlaceholderText = "Optional";
            txtRemarks.Size = new Size(200, 26);
            txtRemarks.TabIndex = 11;
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
            grpItem.Controls.Add(lblStock);
            grpItem.Controls.Add(txtStock);
            grpItem.Controls.Add(lblQuantity);
            grpItem.Controls.Add(lblQuantityStar);
            grpItem.Controls.Add(txtQuantity);
            grpItem.Controls.Add(lblRate);
            grpItem.Controls.Add(lblRateStar);
            grpItem.Controls.Add(txtRate);
            grpItem.Controls.Add(lblDiscount);
            grpItem.Controls.Add(txtDiscount);
            grpItem.Controls.Add(lblGst);
            grpItem.Controls.Add(lblGstStar);
            grpItem.Controls.Add(cmbGst);
            grpItem.Controls.Add(chkRateIncludesGst);
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
            grpItem.TabIndex = 12;
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
            lblProduct.TabIndex = 13;
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
            lblProductStar.TabIndex = 14;
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
            cmbProduct.Size = new Size(270, 26);
            cmbProduct.TabIndex = 15;
            // 
            // lblHSN
            // 
            lblHSN.AutoSize = true;
            lblHSN.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHSN.ForeColor = SystemColors.ControlText;
            lblHSN.Location = new Point(292, 24);
            lblHSN.Name = "lblHSN";
            lblHSN.Size = new Size(34, 18);
            lblHSN.TabIndex = 16;
            lblHSN.Text = "HSN";
            // 
            // txtHSN
            // 
            txtHSN.BackColor = Color.WhiteSmoke;
            txtHSN.Font = new Font("Calibri", 11.25F);
            txtHSN.Location = new Point(292, 46);
            txtHSN.Name = "txtHSN";
            txtHSN.ReadOnly = true;
            txtHSN.Size = new Size(75, 26);
            txtHSN.TabIndex = 17;
            txtHSN.TabStop = false;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnit.ForeColor = SystemColors.ControlText;
            lblUnit.Location = new Point(375, 24);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(34, 18);
            lblUnit.TabIndex = 17;
            lblUnit.Text = "Unit";
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.WhiteSmoke;
            txtUnit.Font = new Font("Calibri", 11.25F);
            txtUnit.Location = new Point(375, 46);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(50, 26);
            txtUnit.TabIndex = 18;
            txtUnit.TabStop = false;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = SystemColors.ControlText;
            lblStock.Location = new Point(433, 24);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(41, 18);
            lblStock.TabIndex = 18;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.WhiteSmoke;
            txtStock.Font = new Font("Calibri", 11.25F);
            txtStock.Location = new Point(433, 46);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(70, 26);
            txtStock.TabIndex = 19;
            txtStock.TabStop = false;
            txtStock.TextAlign = HorizontalAlignment.Right;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ControlText;
            lblQuantity.Location = new Point(511, 24);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(30, 18);
            lblQuantity.TabIndex = 19;
            lblQuantity.Text = "Qty";
            // 
            // lblQuantityStar
            // 
            lblQuantityStar.AutoSize = true;
            lblQuantityStar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantityStar.ForeColor = Color.Red;
            lblQuantityStar.Location = new Point(542, 24);
            lblQuantityStar.Name = "lblQuantityStar";
            lblQuantityStar.Size = new Size(15, 18);
            lblQuantityStar.TabIndex = 20;
            lblQuantityStar.Text = "*";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Calibri", 11.25F);
            txtQuantity.Location = new Point(511, 46);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(70, 26);
            txtQuantity.TabIndex = 21;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRate.ForeColor = SystemColors.ControlText;
            lblRate.Location = new Point(589, 24);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(36, 18);
            lblRate.TabIndex = 22;
            lblRate.Text = "Rate";
            // 
            // lblRateStar
            // 
            lblRateStar.AutoSize = true;
            lblRateStar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRateStar.ForeColor = Color.Red;
            lblRateStar.Location = new Point(623, 24);
            lblRateStar.Name = "lblRateStar";
            lblRateStar.Size = new Size(15, 18);
            lblRateStar.TabIndex = 23;
            lblRateStar.Text = "*";
            // 
            // txtRate
            // 
            txtRate.Font = new Font("Calibri", 11.25F);
            txtRate.Location = new Point(589, 46);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(90, 26);
            txtRate.TabIndex = 24;
            txtRate.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.ForeColor = SystemColors.ControlText;
            lblDiscount.Location = new Point(687, 24);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(47, 18);
            lblDiscount.TabIndex = 25;
            lblDiscount.Text = "Disc %";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Calibri", 11.25F);
            txtDiscount.Location = new Point(687, 46);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(58, 26);
            txtDiscount.TabIndex = 26;
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblGst
            // 
            lblGst.AutoSize = true;
            lblGst.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGst.ForeColor = SystemColors.ControlText;
            lblGst.Location = new Point(753, 24);
            lblGst.Name = "lblGst";
            lblGst.Size = new Size(45, 18);
            lblGst.TabIndex = 27;
            lblGst.Text = "GST %";
            // 
            // lblGstStar
            // 
            lblGstStar.AutoSize = true;
            lblGstStar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGstStar.ForeColor = Color.Red;
            lblGstStar.Location = new Point(800, 24);
            lblGstStar.Name = "lblGstStar";
            lblGstStar.Size = new Size(15, 18);
            lblGstStar.TabIndex = 28;
            lblGstStar.Text = "*";
            // 
            // cmbGst
            // 
            cmbGst.Font = new Font("Calibri", 11.25F);
            cmbGst.FormattingEnabled = true;
            cmbGst.Items.AddRange(new object[] { "0", "5", "18", "40" });
            cmbGst.Location = new Point(753, 46);
            cmbGst.Name = "cmbGst";
            cmbGst.Size = new Size(66, 26);
            cmbGst.TabIndex = 29;
            // 
            // chkRateIncludesGst
            // 
            chkRateIncludesGst.AutoSize = true;
            chkRateIncludesGst.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRateIncludesGst.ForeColor = SystemColors.ControlText;
            chkRateIncludesGst.Location = new Point(832, 49);
            chkRateIncludesGst.Name = "chkRateIncludesGst";
            chkRateIncludesGst.Size = new Size(110, 22);
            chkRateIncludesGst.TabIndex = 30;
            chkRateIncludesGst.Text = "Rate incl. GST";
            chkRateIncludesGst.UseVisualStyleBackColor = true;
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
            btnAddItem.Size = new Size(110, 28);
            btnAddItem.TabIndex = 31;
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
            btnClearItem.Location = new Point(132, 80);
            btnClearItem.Name = "btnClearItem";
            btnClearItem.Size = new Size(80, 28);
            btnClearItem.TabIndex = 32;
            btnClearItem.Text = "Clear";
            btnClearItem.TextAlign = ContentAlignment.MiddleRight;
            btnClearItem.UseVisualStyleBackColor = false;
            // 
            // lblEntryHint
            // 
            lblEntryHint.AutoSize = true;
            lblEntryHint.Font = new Font("Calibri", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEntryHint.ForeColor = Color.Gray;
            lblEntryHint.Location = new Point(226, 87);
            lblEntryHint.Name = "lblEntryHint";
            lblEntryHint.Size = new Size(345, 14);
            lblEntryHint.TabIndex = 33;
            lblEntryHint.Text = "F2 - find product   |   Enter - next field   |   Enter on GST % - add item";
            // 
            // lblLineTotalCaption
            // 
            lblLineTotalCaption.AutoSize = true;
            lblLineTotalCaption.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLineTotalCaption.ForeColor = SystemColors.ControlText;
            lblLineTotalCaption.Location = new Point(700, 86);
            lblLineTotalCaption.Name = "lblLineTotalCaption";
            lblLineTotalCaption.Size = new Size(74, 18);
            lblLineTotalCaption.TabIndex = 34;
            lblLineTotalCaption.Text = "Line Total :";
            // 
            // lblLineTotal
            // 
            lblLineTotal.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLineTotal.ForeColor = Color.SteelBlue;
            lblLineTotal.Location = new Point(776, 83);
            lblLineTotal.Name = "lblLineTotal";
            lblLineTotal.Size = new Size(195, 24);
            lblLineTotal.TabIndex = 35;
            lblLineTotal.Text = "0.00";
            lblLineTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = Color.Azure;
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.SteelBlue;
            dataGridViewCellStyle20.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle20.ForeColor = Color.White;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dgvItems.ColumnHeadersHeight = 32;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colSrNo, colProductCode, colProductName, colHSNCode, colUnit, colQuantity, colRate, colDiscountPercent, colGstPercent, colTaxableAmount, colTotalAmount });
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = SystemColors.Window;
            dataGridViewCellStyle27.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle27.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle27.SelectionForeColor = Color.Black;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle27;
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.GridColor = Color.LightSteelBlue;
            dgvItems.Location = new Point(12, 232);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(984, 190);
            dgvItems.TabIndex = 36;
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
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "0.###";
            colQuantity.DefaultCellStyle = dataGridViewCellStyle21;
            colQuantity.HeaderText = "Qty";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.SortMode = DataGridViewColumnSortMode.NotSortable;
            colQuantity.Width = 65;
            // 
            // colRate
            // 
            colRate.DataPropertyName = "Rate";
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            colRate.DefaultCellStyle = dataGridViewCellStyle22;
            colRate.HeaderText = "Rate";
            colRate.Name = "colRate";
            colRate.ReadOnly = true;
            colRate.SortMode = DataGridViewColumnSortMode.NotSortable;
            colRate.Width = 90;
            // 
            // colDiscountPercent
            // 
            colDiscountPercent.DataPropertyName = "DiscountPercent";
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N2";
            colDiscountPercent.DefaultCellStyle = dataGridViewCellStyle23;
            colDiscountPercent.HeaderText = "Disc %";
            colDiscountPercent.Name = "colDiscountPercent";
            colDiscountPercent.ReadOnly = true;
            colDiscountPercent.SortMode = DataGridViewColumnSortMode.NotSortable;
            colDiscountPercent.Width = 60;
            // 
            // colGstPercent
            // 
            colGstPercent.DataPropertyName = "GstPercent";
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N2";
            colGstPercent.DefaultCellStyle = dataGridViewCellStyle24;
            colGstPercent.HeaderText = "GST %";
            colGstPercent.Name = "colGstPercent";
            colGstPercent.ReadOnly = true;
            colGstPercent.SortMode = DataGridViewColumnSortMode.NotSortable;
            colGstPercent.Width = 60;
            // 
            // colTaxableAmount
            // 
            colTaxableAmount.DataPropertyName = "TaxableAmount";
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N2";
            colTaxableAmount.DefaultCellStyle = dataGridViewCellStyle25;
            colTaxableAmount.HeaderText = "Taxable";
            colTaxableAmount.Name = "colTaxableAmount";
            colTaxableAmount.ReadOnly = true;
            colTaxableAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTaxableAmount.Width = 90;
            // 
            // colTotalAmount
            // 
            colTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            colTotalAmount.DefaultCellStyle = dataGridViewCellStyle26;
            colTotalAmount.HeaderText = "Amount";
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            colTotalAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTotalAmount.Width = 95;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.WhiteSmoke;
            btnRemoveItem.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveItem.ForeColor = SystemColors.ActiveCaptionText;
            btnRemoveItem.Image = Properties.Resources.delete;
            btnRemoveItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoveItem.Location = new Point(12, 426);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(140, 28);
            btnRemoveItem.TabIndex = 37;
            btnRemoveItem.Text = "Remove Selected";
            btnRemoveItem.TextAlign = ContentAlignment.MiddleRight;
            btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // lblGridHint
            // 
            lblGridHint.AutoSize = true;
            lblGridHint.Font = new Font("Calibri", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGridHint.ForeColor = Color.Gray;
            lblGridHint.Location = new Point(162, 432);
            lblGridHint.Name = "lblGridHint";
            lblGridHint.Size = new Size(361, 14);
            lblGridHint.TabIndex = 38;
            lblGridHint.Text = "Double-click an item to edit it   |   Delete key removes the selected item";
            // 
            // grpTotals
            // 
            grpTotals.Controls.Add(lblSubTotal);
            grpTotals.Controls.Add(txtSubTotal);
            grpTotals.Controls.Add(lblTotalDiscount);
            grpTotals.Controls.Add(txtTotalDiscount);
            grpTotals.Controls.Add(lblTaxableAmount);
            grpTotals.Controls.Add(txtTaxableAmount);
            grpTotals.Controls.Add(lblRoundOff);
            grpTotals.Controls.Add(txtRoundOff);
            grpTotals.Controls.Add(lblCgst);
            grpTotals.Controls.Add(txtCgst);
            grpTotals.Controls.Add(lblSgst);
            grpTotals.Controls.Add(txtSgst);
            grpTotals.Controls.Add(lblIgst);
            grpTotals.Controls.Add(txtIgst);
            grpTotals.Controls.Add(lblReceivedAmount);
            grpTotals.Controls.Add(txtReceivedAmount);
            grpTotals.Controls.Add(lblBalance);
            grpTotals.Controls.Add(txtBalance);
            grpTotals.Controls.Add(lblGrandTotalCaption);
            grpTotals.Controls.Add(lblGrandTotal);
            grpTotals.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpTotals.ForeColor = Color.SteelBlue;
            grpTotals.Location = new Point(12, 458);
            grpTotals.Name = "grpTotals";
            grpTotals.Size = new Size(984, 130);
            grpTotals.TabIndex = 39;
            grpTotals.TabStop = false;
            grpTotals.Text = "Invoice Summary";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.ForeColor = SystemColors.ControlText;
            lblSubTotal.Location = new Point(14, 30);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(71, 18);
            lblSubTotal.TabIndex = 40;
            lblSubTotal.Text = "Sub Total :";
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.WhiteSmoke;
            txtSubTotal.Font = new Font("Calibri", 11.25F);
            txtSubTotal.Location = new Point(88, 26);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 26);
            txtSubTotal.TabIndex = 41;
            txtSubTotal.TabStop = false;
            txtSubTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalDiscount
            // 
            lblTotalDiscount.AutoSize = true;
            lblTotalDiscount.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDiscount.ForeColor = SystemColors.ControlText;
            lblTotalDiscount.Location = new Point(210, 30);
            lblTotalDiscount.Name = "lblTotalDiscount";
            lblTotalDiscount.Size = new Size(69, 18);
            lblTotalDiscount.TabIndex = 41;
            lblTotalDiscount.Text = "Discount :";
            // 
            // txtTotalDiscount
            // 
            txtTotalDiscount.BackColor = Color.WhiteSmoke;
            txtTotalDiscount.Font = new Font("Calibri", 11.25F);
            txtTotalDiscount.Location = new Point(285, 26);
            txtTotalDiscount.Name = "txtTotalDiscount";
            txtTotalDiscount.ReadOnly = true;
            txtTotalDiscount.Size = new Size(100, 26);
            txtTotalDiscount.TabIndex = 42;
            txtTotalDiscount.TabStop = false;
            txtTotalDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTaxableAmount
            // 
            lblTaxableAmount.AutoSize = true;
            lblTaxableAmount.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaxableAmount.ForeColor = SystemColors.ControlText;
            lblTaxableAmount.Location = new Point(406, 30);
            lblTaxableAmount.Name = "lblTaxableAmount";
            lblTaxableAmount.Size = new Size(62, 18);
            lblTaxableAmount.TabIndex = 42;
            lblTaxableAmount.Text = "Taxable :";
            // 
            // txtTaxableAmount
            // 
            txtTaxableAmount.BackColor = Color.WhiteSmoke;
            txtTaxableAmount.Font = new Font("Calibri", 11.25F);
            txtTaxableAmount.Location = new Point(468, 26);
            txtTaxableAmount.Name = "txtTaxableAmount";
            txtTaxableAmount.ReadOnly = true;
            txtTaxableAmount.Size = new Size(110, 26);
            txtTaxableAmount.TabIndex = 43;
            txtTaxableAmount.TabStop = false;
            txtTaxableAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblRoundOff
            // 
            lblRoundOff.AutoSize = true;
            lblRoundOff.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoundOff.ForeColor = SystemColors.ControlText;
            lblRoundOff.Location = new Point(612, 30);
            lblRoundOff.Name = "lblRoundOff";
            lblRoundOff.Size = new Size(77, 18);
            lblRoundOff.TabIndex = 43;
            lblRoundOff.Text = "Round Off :";
            // 
            // txtRoundOff
            // 
            txtRoundOff.BackColor = Color.WhiteSmoke;
            txtRoundOff.Font = new Font("Calibri", 11.25F);
            txtRoundOff.Location = new Point(690, 26);
            txtRoundOff.Name = "txtRoundOff";
            txtRoundOff.ReadOnly = true;
            txtRoundOff.Size = new Size(90, 26);
            txtRoundOff.TabIndex = 44;
            txtRoundOff.TabStop = false;
            txtRoundOff.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCgst
            // 
            lblCgst.AutoSize = true;
            lblCgst.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCgst.ForeColor = SystemColors.ControlText;
            lblCgst.Location = new Point(14, 62);
            lblCgst.Name = "lblCgst";
            lblCgst.Size = new Size(46, 18);
            lblCgst.TabIndex = 44;
            lblCgst.Text = "CGST :";
            // 
            // txtCgst
            // 
            txtCgst.BackColor = Color.WhiteSmoke;
            txtCgst.Font = new Font("Calibri", 11.25F);
            txtCgst.Location = new Point(88, 58);
            txtCgst.Name = "txtCgst";
            txtCgst.ReadOnly = true;
            txtCgst.Size = new Size(100, 26);
            txtCgst.TabIndex = 45;
            txtCgst.TabStop = false;
            txtCgst.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSgst
            // 
            lblSgst.AutoSize = true;
            lblSgst.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSgst.ForeColor = SystemColors.ControlText;
            lblSgst.Location = new Point(210, 62);
            lblSgst.Name = "lblSgst";
            lblSgst.Size = new Size(45, 18);
            lblSgst.TabIndex = 45;
            lblSgst.Text = "SGST :";
            // 
            // txtSgst
            // 
            txtSgst.BackColor = Color.WhiteSmoke;
            txtSgst.Font = new Font("Calibri", 11.25F);
            txtSgst.Location = new Point(276, 58);
            txtSgst.Name = "txtSgst";
            txtSgst.ReadOnly = true;
            txtSgst.Size = new Size(100, 26);
            txtSgst.TabIndex = 46;
            txtSgst.TabStop = false;
            txtSgst.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIgst
            // 
            lblIgst.AutoSize = true;
            lblIgst.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIgst.ForeColor = SystemColors.ControlText;
            lblIgst.Location = new Point(406, 62);
            lblIgst.Name = "lblIgst";
            lblIgst.Size = new Size(42, 18);
            lblIgst.TabIndex = 46;
            lblIgst.Text = "IGST :";
            // 
            // txtIgst
            // 
            txtIgst.BackColor = Color.WhiteSmoke;
            txtIgst.Font = new Font("Calibri", 11.25F);
            txtIgst.Location = new Point(468, 58);
            txtIgst.Name = "txtIgst";
            txtIgst.ReadOnly = true;
            txtIgst.Size = new Size(110, 26);
            txtIgst.TabIndex = 47;
            txtIgst.TabStop = false;
            txtIgst.TextAlign = HorizontalAlignment.Right;
            // 
            // lblReceivedAmount
            // 
            lblReceivedAmount.AutoSize = true;
            lblReceivedAmount.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceivedAmount.ForeColor = SystemColors.ControlText;
            lblReceivedAmount.Location = new Point(14, 94);
            lblReceivedAmount.Name = "lblReceivedAmount";
            lblReceivedAmount.Size = new Size(72, 18);
            lblReceivedAmount.TabIndex = 47;
            lblReceivedAmount.Text = "Received :";
            // 
            // txtReceivedAmount
            // 
            txtReceivedAmount.Font = new Font("Calibri", 11.25F);
            txtReceivedAmount.Location = new Point(94, 90);
            txtReceivedAmount.Name = "txtReceivedAmount";
            txtReceivedAmount.Size = new Size(110, 26);
            txtReceivedAmount.TabIndex = 48;
            txtReceivedAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = SystemColors.ControlText;
            lblBalance.Location = new Point(228, 94);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(63, 18);
            lblBalance.TabIndex = 49;
            lblBalance.Text = "Balance :";
            // 
            // txtBalance
            // 
            txtBalance.BackColor = Color.WhiteSmoke;
            txtBalance.Font = new Font("Calibri", 11.25F);
            txtBalance.Location = new Point(297, 90);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(110, 26);
            txtBalance.TabIndex = 50;
            txtBalance.TabStop = false;
            txtBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // lblGrandTotalCaption
            // 
            lblGrandTotalCaption.AutoSize = true;
            lblGrandTotalCaption.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotalCaption.ForeColor = SystemColors.ControlText;
            lblGrandTotalCaption.Location = new Point(840, 30);
            lblGrandTotalCaption.Name = "lblGrandTotalCaption";
            lblGrandTotalCaption.Size = new Size(95, 18);
            lblGrandTotalCaption.TabIndex = 50;
            lblGrandTotalCaption.Text = "GRAND TOTAL";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = Color.SteelBlue;
            lblGrandTotal.Location = new Point(780, 54);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(196, 40);
            lblGrandTotal.TabIndex = 51;
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
            btnSave.Location = new Point(627, 596);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 34);
            btnSave.TabIndex = 52;
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
            btnClear.Image = Properties.Resources.sales_report;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(768, 596);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 34);
            btnClear.TabIndex = 53;
            btnClear.Text = "New Invoice";
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
            btnCancel.Location = new Point(894, 596);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 34);
            btnCancel.TabIndex = 54;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // validationerrors
            // 
            validationerrors.ContainerControl = this;
            // 
            // frmNewInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 640);
            Controls.Add(pnlMain);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewInvoice";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Invoice";
            Load += frmNewInvoice_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            grpInvoice.ResumeLayout(false);
            grpInvoice.PerformLayout();
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
        private GroupBox grpInvoice;
        private Label lblInvoiceNo;
        private TextBox txtInvoiceNo;
        private Label lblInvoiceDate;
        private DateTimePicker dtpInvoiceDate;
        private Label lblCustomer;
        private ComboBox cmbCustomer;
        private Label lblCustomerGSTNo;
        private TextBox txtCustomerGSTNo;
        private Label lblPaymentMode;
        private ComboBox cmbPaymentMode;
        private CheckBox chkInterState;
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
        private Label lblStock;
        private TextBox txtStock;
        private Label lblQuantity;
        private Label lblQuantityStar;
        private TextBox txtQuantity;
        private Label lblRate;
        private Label lblRateStar;
        private TextBox txtRate;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Label lblGst;
        private Label lblGstStar;
        private ComboBox cmbGst;
        private CheckBox chkRateIncludesGst;
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
        private Label lblTaxableAmount;
        private TextBox txtTaxableAmount;
        private Label lblRoundOff;
        private TextBox txtRoundOff;
        private Label lblCgst;
        private TextBox txtCgst;
        private Label lblSgst;
        private TextBox txtSgst;
        private Label lblIgst;
        private TextBox txtIgst;
        private Label lblReceivedAmount;
        private TextBox txtReceivedAmount;
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
        private DataGridViewTextBoxColumn colRate;
        private DataGridViewTextBoxColumn colDiscountPercent;
        private DataGridViewTextBoxColumn colGstPercent;
        private DataGridViewTextBoxColumn colTaxableAmount;
        private DataGridViewTextBoxColumn colTotalAmount;
        private ErrorProvider validationerrors;
    }
}