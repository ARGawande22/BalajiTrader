namespace BalajiTrader.Client.UI
{
    partial class frmInvoiceReport
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
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle54 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle51 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle52 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle53 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle55 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle56 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle63 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle57 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle58 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle59 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle60 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle61 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle62 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            grpFilter = new GroupBox();
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            lblPeriod = new Label();
            cmbPeriod = new ComboBox();
            lblParty = new Label();
            cmbCustomer = new ComboBox();
            lblPaymentMode = new Label();
            cmbPaymentMode = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSearch = new Button();
            btnReset = new Button();
            btnExport = new Button();
            dgvInvoices = new DataGridView();
            colSrNo = new DataGridViewTextBoxColumn();
            colInvoiceNo = new DataGridViewTextBoxColumn();
            colInvoiceDate = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colPaymentMode = new DataGridViewTextBoxColumn();
            colItemCount = new DataGridViewTextBoxColumn();
            colTaxableAmount = new DataGridViewTextBoxColumn();
            colTotalDiscount = new DataGridViewTextBoxColumn();
            colTotalGst = new DataGridViewTextBoxColumn();
            colGrandTotal = new DataGridViewTextBoxColumn();
            colReceivedAmount = new DataGridViewTextBoxColumn();
            colBalanceAmount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCustomerGSTNo = new DataGridViewTextBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            grpTotals = new GroupBox();
            lblRecordCount = new Label();
            txtRecordCount = new TextBox();
            lblTotalGst = new Label();
            txtTotalGst = new TextBox();
            lblGrandTotal = new Label();
            txtGrandTotal = new TextBox();
            lblTotalPaid = new Label();
            txtTotalReceived = new TextBox();
            lblTotalBalance = new Label();
            txtTotalBalance = new TextBox();
            grpItems = new GroupBox();
            dgvItems = new DataGridView();
            colItemSrNo = new DataGridViewTextBoxColumn();
            colItemCode = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colItemHSN = new DataGridViewTextBoxColumn();
            colItemUnit = new DataGridViewTextBoxColumn();
            colItemQty = new DataGridViewTextBoxColumn();
            colItemRate = new DataGridViewTextBoxColumn();
            colItemDisc = new DataGridViewTextBoxColumn();
            colItemGst = new DataGridViewTextBoxColumn();
            colItemTaxable = new DataGridViewTextBoxColumn();
            colItemAmount = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            btnAddInvoice = new Button();
            pnlMain.SuspendLayout();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            grpTotals.SuspendLayout();
            grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(grpFilter);
            pnlMain.Controls.Add(dgvInvoices);
            pnlMain.Controls.Add(grpTotals);
            pnlMain.Controls.Add(grpItems);
            pnlMain.Controls.Add(btnClose);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1180, 684);
            pnlMain.TabIndex = 0;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(btnAddInvoice);
            grpFilter.Controls.Add(lblFromDate);
            grpFilter.Controls.Add(dtpFromDate);
            grpFilter.Controls.Add(lblToDate);
            grpFilter.Controls.Add(dtpToDate);
            grpFilter.Controls.Add(lblPeriod);
            grpFilter.Controls.Add(cmbPeriod);
            grpFilter.Controls.Add(lblParty);
            grpFilter.Controls.Add(cmbCustomer);
            grpFilter.Controls.Add(lblPaymentMode);
            grpFilter.Controls.Add(cmbPaymentMode);
            grpFilter.Controls.Add(lblSearch);
            grpFilter.Controls.Add(txtSearch);
            grpFilter.Controls.Add(lblStatus);
            grpFilter.Controls.Add(cmbStatus);
            grpFilter.Controls.Add(btnSearch);
            grpFilter.Controls.Add(btnReset);
            grpFilter.Controls.Add(btnExport);
            grpFilter.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpFilter.ForeColor = Color.SteelBlue;
            grpFilter.Location = new Point(12, 8);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(1156, 92);
            grpFilter.TabIndex = 0;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFromDate.ForeColor = SystemColors.ControlText;
            lblFromDate.Location = new Point(14, 32);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(47, 18);
            lblFromDate.TabIndex = 1;
            lblFromDate.Text = "From :";
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Font = new Font("Calibri", 11.25F);
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(62, 28);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(120, 26);
            dtpFromDate.TabIndex = 2;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToDate.ForeColor = SystemColors.ControlText;
            lblToDate.Location = new Point(200, 32);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(29, 18);
            lblToDate.TabIndex = 3;
            lblToDate.Text = "To :";
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Font = new Font("Calibri", 11.25F);
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(232, 28);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(120, 26);
            dtpToDate.TabIndex = 4;
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPeriod.ForeColor = SystemColors.ControlText;
            lblPeriod.Location = new Point(372, 32);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(56, 18);
            lblPeriod.TabIndex = 5;
            lblPeriod.Text = "Period :";
            // 
            // cmbPeriod
            // 
            cmbPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriod.Font = new Font("Calibri", 11.25F);
            cmbPeriod.FormattingEnabled = true;
            cmbPeriod.Items.AddRange(new object[] { "Today", "This Week", "This Month", "Last Month", "This Financial Year", "Custom" });
            cmbPeriod.Location = new Point(438, 28);
            cmbPeriod.Name = "cmbPeriod";
            cmbPeriod.Size = new Size(144, 26);
            cmbPeriod.TabIndex = 6;
            // 
            // lblParty
            // 
            lblParty.AutoSize = true;
            lblParty.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParty.ForeColor = SystemColors.ControlText;
            lblParty.Location = new Point(613, 32);
            lblParty.Name = "lblParty";
            lblParty.Size = new Size(75, 18);
            lblParty.TabIndex = 7;
            lblParty.Text = "Customer :";
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.Font = new Font("Calibri", 11.25F);
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(694, 28);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(210, 26);
            cmbCustomer.TabIndex = 8;
            // 
            // lblPaymentMode
            // 
            lblPaymentMode.AutoSize = true;
            lblPaymentMode.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMode.ForeColor = SystemColors.ControlText;
            lblPaymentMode.Location = new Point(920, 32);
            lblPaymentMode.Name = "lblPaymentMode";
            lblPaymentMode.Size = new Size(70, 18);
            lblPaymentMode.TabIndex = 9;
            lblPaymentMode.Text = "Payment :";
            // 
            // cmbPaymentMode
            // 
            cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMode.Font = new Font("Calibri", 11.25F);
            cmbPaymentMode.FormattingEnabled = true;
            cmbPaymentMode.Items.AddRange(new object[] { "All", "Cash", "UPI", "Card", "Cheque", "Credit" });
            cmbPaymentMode.Location = new Point(990, 28);
            cmbPaymentMode.Name = "cmbPaymentMode";
            cmbPaymentMode.Size = new Size(150, 26);
            cmbPaymentMode.TabIndex = 10;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = SystemColors.ControlText;
            lblSearch.Location = new Point(14, 66);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 18);
            lblSearch.TabIndex = 11;
            lblSearch.Text = "Search :";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Calibri", 11.25F);
            txtSearch.Location = new Point(80, 62);
            txtSearch.MaxLength = 100;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Invoice no / customer / remarks";
            txtSearch.Size = new Size(300, 26);
            txtSearch.TabIndex = 12;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Location = new Point(400, 66);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 18);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status :";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Calibri", 11.25F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "All", "Paid", "Pending" });
            cmbStatus.Location = new Point(462, 62);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(120, 26);
            cmbStatus.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.WhiteSmoke;
            btnSearch.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Image = Properties.Resources.download;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(604, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 28);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.WhiteSmoke;
            btnReset.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.ActiveCaptionText;
            btnReset.Image = Properties.Resources.Exit;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(703, 59);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(79, 28);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.WhiteSmoke;
            btnExport.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.ForeColor = SystemColors.ActiveCaptionText;
            btnExport.Image = Properties.Resources.Excel;
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(1004, 58);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(136, 28);
            btnExport.TabIndex = 17;
            btnExport.Text = "Export to Excel";
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.UseVisualStyleBackColor = false;
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.AllowUserToResizeRows = false;
            dataGridViewCellStyle43.BackColor = Color.Azure;
            dgvInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle43;
            dgvInvoices.BackgroundColor = Color.White;
            dgvInvoices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = Color.SteelBlue;
            dataGridViewCellStyle44.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle44.ForeColor = Color.White;
            dataGridViewCellStyle44.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = DataGridViewTriState.False;
            dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
            dgvInvoices.ColumnHeadersHeight = 32;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInvoices.Columns.AddRange(new DataGridViewColumn[] { colSrNo, colInvoiceNo, colInvoiceDate, colCustomerName, colPaymentMode, colItemCount, colTaxableAmount, colTotalDiscount, colTotalGst, colGrandTotal, colReceivedAmount, colBalanceAmount, colStatus, colCustomerGSTNo, colRemarks });
            dataGridViewCellStyle54.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = SystemColors.Window;
            dataGridViewCellStyle54.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle54.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle54.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle54.SelectionForeColor = Color.Black;
            dataGridViewCellStyle54.WrapMode = DataGridViewTriState.False;
            dgvInvoices.DefaultCellStyle = dataGridViewCellStyle54;
            dgvInvoices.EnableHeadersVisualStyles = false;
            dgvInvoices.GridColor = Color.LightSteelBlue;
            dgvInvoices.Location = new Point(12, 106);
            dgvInvoices.MultiSelect = false;
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new Size(1156, 266);
            dgvInvoices.TabIndex = 18;
            // 
            // colSrNo
            // 
            colSrNo.DataPropertyName = "SrNo";
            colSrNo.HeaderText = "Sr No.";
            colSrNo.Name = "colSrNo";
            colSrNo.ReadOnly = true;
            colSrNo.SortMode = DataGridViewColumnSortMode.Programmatic;
            colSrNo.Width = 40;
            // 
            // colInvoiceNo
            // 
            colInvoiceNo.DataPropertyName = "InvoiceNo";
            colInvoiceNo.HeaderText = "Invoice No";
            colInvoiceNo.Name = "colInvoiceNo";
            colInvoiceNo.ReadOnly = true;
            colInvoiceNo.SortMode = DataGridViewColumnSortMode.Programmatic;
            colInvoiceNo.Width = 120;
            // 
            // colInvoiceDate
            // 
            colInvoiceDate.DataPropertyName = "InvoiceDate";
            dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.Format = "dd/MM/yyyy";
            colInvoiceDate.DefaultCellStyle = dataGridViewCellStyle45;
            colInvoiceDate.HeaderText = "Date";
            colInvoiceDate.Name = "colInvoiceDate";
            colInvoiceDate.ReadOnly = true;
            colInvoiceDate.SortMode = DataGridViewColumnSortMode.Programmatic;
            colInvoiceDate.Width = 80;
            // 
            // colCustomerName
            // 
            colCustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCustomerName.DataPropertyName = "CustomerName";
            colCustomerName.HeaderText = "Customer";
            colCustomerName.MinimumWidth = 150;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            colCustomerName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // colPaymentMode
            // 
            colPaymentMode.DataPropertyName = "PaymentMode";
            colPaymentMode.HeaderText = "Payment";
            colPaymentMode.Name = "colPaymentMode";
            colPaymentMode.ReadOnly = true;
            colPaymentMode.SortMode = DataGridViewColumnSortMode.Programmatic;
            colPaymentMode.Width = 80;
            // 
            // colItemCount
            // 
            colItemCount.DataPropertyName = "ItemCount";
            dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleRight;
            colItemCount.DefaultCellStyle = dataGridViewCellStyle46;
            colItemCount.HeaderText = "Items";
            colItemCount.Name = "colItemCount";
            colItemCount.ReadOnly = true;
            colItemCount.SortMode = DataGridViewColumnSortMode.Programmatic;
            colItemCount.Width = 45;
            // 
            // colTaxableAmount
            // 
            colTaxableAmount.DataPropertyName = "TaxableAmount";
            dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle47.Format = "N2";
            colTaxableAmount.DefaultCellStyle = dataGridViewCellStyle47;
            colTaxableAmount.HeaderText = "Taxable";
            colTaxableAmount.Name = "colTaxableAmount";
            colTaxableAmount.ReadOnly = true;
            colTaxableAmount.SortMode = DataGridViewColumnSortMode.Programmatic;
            colTaxableAmount.Width = 90;
            // 
            // colTotalDiscount
            // 
            colTotalDiscount.DataPropertyName = "TotalDiscount";
            dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle48.Format = "N2";
            colTotalDiscount.DefaultCellStyle = dataGridViewCellStyle48;
            colTotalDiscount.HeaderText = "Discount";
            colTotalDiscount.Name = "colTotalDiscount";
            colTotalDiscount.ReadOnly = true;
            colTotalDiscount.SortMode = DataGridViewColumnSortMode.Programmatic;
            colTotalDiscount.Width = 75;
            // 
            // colTotalGst
            // 
            colTotalGst.DataPropertyName = "TotalGst";
            dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle49.Format = "N2";
            colTotalGst.DefaultCellStyle = dataGridViewCellStyle49;
            colTotalGst.HeaderText = "GST";
            colTotalGst.Name = "colTotalGst";
            colTotalGst.ReadOnly = true;
            colTotalGst.SortMode = DataGridViewColumnSortMode.Programmatic;
            colTotalGst.Width = 75;
            // 
            // colGrandTotal
            // 
            colGrandTotal.DataPropertyName = "GrandTotal";
            dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle50.Format = "N2";
            colGrandTotal.DefaultCellStyle = dataGridViewCellStyle50;
            colGrandTotal.HeaderText = "Grand Total";
            colGrandTotal.Name = "colGrandTotal";
            colGrandTotal.ReadOnly = true;
            colGrandTotal.SortMode = DataGridViewColumnSortMode.Programmatic;
            colGrandTotal.Width = 95;
            // 
            // colReceivedAmount
            // 
            colReceivedAmount.DataPropertyName = "ReceivedAmount";
            dataGridViewCellStyle51.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle51.Format = "N2";
            colReceivedAmount.DefaultCellStyle = dataGridViewCellStyle51;
            colReceivedAmount.HeaderText = "Received";
            colReceivedAmount.Name = "colReceivedAmount";
            colReceivedAmount.ReadOnly = true;
            colReceivedAmount.SortMode = DataGridViewColumnSortMode.Programmatic;
            colReceivedAmount.Width = 85;
            // 
            // colBalanceAmount
            // 
            colBalanceAmount.DataPropertyName = "BalanceAmount";
            dataGridViewCellStyle52.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle52.Format = "N2";
            colBalanceAmount.DefaultCellStyle = dataGridViewCellStyle52;
            colBalanceAmount.HeaderText = "Balance";
            colBalanceAmount.Name = "colBalanceAmount";
            colBalanceAmount.ReadOnly = true;
            colBalanceAmount.SortMode = DataGridViewColumnSortMode.Programmatic;
            colBalanceAmount.Width = 85;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            dataGridViewCellStyle53.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStatus.DefaultCellStyle = dataGridViewCellStyle53;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.Programmatic;
            colStatus.Width = 65;
            // 
            // colCustomerGSTNo
            // 
            colCustomerGSTNo.DataPropertyName = "CustomerGSTNo";
            colCustomerGSTNo.HeaderText = "GST No";
            colCustomerGSTNo.Name = "colCustomerGSTNo";
            colCustomerGSTNo.ReadOnly = true;
            colCustomerGSTNo.SortMode = DataGridViewColumnSortMode.Programmatic;
            colCustomerGSTNo.Visible = false;
            // 
            // colRemarks
            // 
            colRemarks.DataPropertyName = "Remarks";
            colRemarks.HeaderText = "Remarks";
            colRemarks.Name = "colRemarks";
            colRemarks.ReadOnly = true;
            colRemarks.SortMode = DataGridViewColumnSortMode.Programmatic;
            colRemarks.Visible = false;
            // 
            // grpTotals
            // 
            grpTotals.Controls.Add(lblRecordCount);
            grpTotals.Controls.Add(txtRecordCount);
            grpTotals.Controls.Add(lblTotalGst);
            grpTotals.Controls.Add(txtTotalGst);
            grpTotals.Controls.Add(lblGrandTotal);
            grpTotals.Controls.Add(txtGrandTotal);
            grpTotals.Controls.Add(lblTotalPaid);
            grpTotals.Controls.Add(txtTotalReceived);
            grpTotals.Controls.Add(lblTotalBalance);
            grpTotals.Controls.Add(txtTotalBalance);
            grpTotals.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpTotals.ForeColor = Color.SteelBlue;
            grpTotals.Location = new Point(12, 376);
            grpTotals.Name = "grpTotals";
            grpTotals.Size = new Size(1156, 62);
            grpTotals.TabIndex = 19;
            grpTotals.TabStop = false;
            grpTotals.Text = "Totals";
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.ForeColor = SystemColors.ControlText;
            lblRecordCount.Location = new Point(14, 28);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(64, 18);
            lblRecordCount.TabIndex = 20;
            lblRecordCount.Text = "Records :";
            // 
            // txtRecordCount
            // 
            txtRecordCount.BackColor = Color.WhiteSmoke;
            txtRecordCount.Font = new Font("Calibri", 11.25F);
            txtRecordCount.Location = new Point(82, 24);
            txtRecordCount.Name = "txtRecordCount";
            txtRecordCount.ReadOnly = true;
            txtRecordCount.Size = new Size(60, 26);
            txtRecordCount.TabIndex = 21;
            txtRecordCount.TabStop = false;
            txtRecordCount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalGst
            // 
            lblTotalGst.AutoSize = true;
            lblTotalGst.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalGst.ForeColor = SystemColors.ControlText;
            lblTotalGst.Location = new Point(170, 28);
            lblTotalGst.Name = "lblTotalGst";
            lblTotalGst.Size = new Size(38, 18);
            lblTotalGst.TabIndex = 21;
            lblTotalGst.Text = "GST :";
            // 
            // txtTotalGst
            // 
            txtTotalGst.BackColor = Color.WhiteSmoke;
            txtTotalGst.Font = new Font("Calibri", 11.25F);
            txtTotalGst.Location = new Point(212, 24);
            txtTotalGst.Name = "txtTotalGst";
            txtTotalGst.ReadOnly = true;
            txtTotalGst.Size = new Size(130, 26);
            txtTotalGst.TabIndex = 22;
            txtTotalGst.TabStop = false;
            txtTotalGst.TextAlign = HorizontalAlignment.Right;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = SystemColors.ControlText;
            lblGrandTotal.Location = new Point(370, 28);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(85, 18);
            lblGrandTotal.TabIndex = 22;
            lblGrandTotal.Text = "Grand Total :";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.BackColor = Color.WhiteSmoke;
            txtGrandTotal.Font = new Font("Calibri", 11.25F);
            txtGrandTotal.Location = new Point(462, 24);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(140, 26);
            txtGrandTotal.TabIndex = 23;
            txtGrandTotal.TabStop = false;
            txtGrandTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPaid.ForeColor = SystemColors.ControlText;
            lblTotalPaid.Location = new Point(630, 28);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(72, 18);
            lblTotalPaid.TabIndex = 23;
            lblTotalPaid.Text = "Received :";
            // 
            // txtTotalReceived
            // 
            txtTotalReceived.BackColor = Color.WhiteSmoke;
            txtTotalReceived.Font = new Font("Calibri", 11.25F);
            txtTotalReceived.Location = new Point(713, 24);
            txtTotalReceived.Name = "txtTotalReceived";
            txtTotalReceived.ReadOnly = true;
            txtTotalReceived.Size = new Size(140, 26);
            txtTotalReceived.TabIndex = 24;
            txtTotalReceived.TabStop = false;
            txtTotalReceived.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.AutoSize = true;
            lblTotalBalance.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalBalance.ForeColor = SystemColors.ControlText;
            lblTotalBalance.Location = new Point(881, 28);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(63, 18);
            lblTotalBalance.TabIndex = 24;
            lblTotalBalance.Text = "Balance :";
            // 
            // txtTotalBalance
            // 
            txtTotalBalance.BackColor = Color.WhiteSmoke;
            txtTotalBalance.Font = new Font("Calibri", 11.25F);
            txtTotalBalance.Location = new Point(951, 24);
            txtTotalBalance.Name = "txtTotalBalance";
            txtTotalBalance.ReadOnly = true;
            txtTotalBalance.Size = new Size(140, 26);
            txtTotalBalance.TabIndex = 25;
            txtTotalBalance.TabStop = false;
            txtTotalBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // grpItems
            // 
            grpItems.Controls.Add(dgvItems);
            grpItems.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpItems.ForeColor = Color.SteelBlue;
            grpItems.Location = new Point(12, 444);
            grpItems.Name = "grpItems";
            grpItems.Size = new Size(1156, 192);
            grpItems.TabIndex = 25;
            grpItems.TabStop = false;
            grpItems.Text = "Invoice Items";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle55.BackColor = Color.Azure;
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle55;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle56.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle56.BackColor = Color.SteelBlue;
            dataGridViewCellStyle56.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle56.ForeColor = Color.White;
            dataGridViewCellStyle56.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = DataGridViewTriState.False;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle56;
            dgvItems.ColumnHeadersHeight = 32;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colItemSrNo, colItemCode, colItemName, colItemHSN, colItemUnit, colItemQty, colItemRate, colItemDisc, colItemGst, colItemTaxable, colItemAmount });
            dataGridViewCellStyle63.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = SystemColors.Window;
            dataGridViewCellStyle63.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle63.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle63.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle63.SelectionForeColor = Color.Black;
            dataGridViewCellStyle63.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle63;
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.GridColor = Color.LightSteelBlue;
            dgvItems.Location = new Point(10, 26);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(1136, 156);
            dgvItems.TabIndex = 26;
            // 
            // colItemSrNo
            // 
            colItemSrNo.DataPropertyName = "SrNo";
            colItemSrNo.HeaderText = "Sr No.";
            colItemSrNo.Name = "colItemSrNo";
            colItemSrNo.ReadOnly = true;
            colItemSrNo.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemSrNo.Width = 45;
            // 
            // colItemCode
            // 
            colItemCode.DataPropertyName = "ProductCode";
            colItemCode.HeaderText = "Code";
            colItemCode.Name = "colItemCode";
            colItemCode.ReadOnly = true;
            colItemCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemCode.Width = 90;
            // 
            // colItemName
            // 
            colItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colItemName.DataPropertyName = "ProductName";
            colItemName.HeaderText = "Product";
            colItemName.MinimumWidth = 150;
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            colItemName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colItemHSN
            // 
            colItemHSN.DataPropertyName = "HSNCode";
            colItemHSN.HeaderText = "HSN";
            colItemHSN.Name = "colItemHSN";
            colItemHSN.ReadOnly = true;
            colItemHSN.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemHSN.Width = 80;
            // 
            // colItemUnit
            // 
            colItemUnit.DataPropertyName = "Unit";
            colItemUnit.HeaderText = "Unit";
            colItemUnit.Name = "colItemUnit";
            colItemUnit.ReadOnly = true;
            colItemUnit.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemUnit.Width = 55;
            // 
            // colItemQty
            // 
            colItemQty.DataPropertyName = "Quantity";
            dataGridViewCellStyle57.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle57.Format = "0.###";
            colItemQty.DefaultCellStyle = dataGridViewCellStyle57;
            colItemQty.HeaderText = "Qty";
            colItemQty.Name = "colItemQty";
            colItemQty.ReadOnly = true;
            colItemQty.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemQty.Width = 70;
            // 
            // colItemRate
            // 
            colItemRate.DataPropertyName = "Rate";
            dataGridViewCellStyle58.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle58.Format = "N2";
            colItemRate.DefaultCellStyle = dataGridViewCellStyle58;
            colItemRate.HeaderText = "Rate";
            colItemRate.Name = "colItemRate";
            colItemRate.ReadOnly = true;
            colItemRate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colItemDisc
            // 
            colItemDisc.DataPropertyName = "DiscountPercent";
            dataGridViewCellStyle59.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle59.Format = "N2";
            colItemDisc.DefaultCellStyle = dataGridViewCellStyle59;
            colItemDisc.HeaderText = "Disc %";
            colItemDisc.Name = "colItemDisc";
            colItemDisc.ReadOnly = true;
            colItemDisc.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemDisc.Width = 70;
            // 
            // colItemGst
            // 
            colItemGst.DataPropertyName = "GstPercent";
            dataGridViewCellStyle60.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle60.Format = "N2";
            colItemGst.DefaultCellStyle = dataGridViewCellStyle60;
            colItemGst.HeaderText = "GST %";
            colItemGst.Name = "colItemGst";
            colItemGst.ReadOnly = true;
            colItemGst.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemGst.Width = 70;
            // 
            // colItemTaxable
            // 
            colItemTaxable.DataPropertyName = "TaxableAmount";
            dataGridViewCellStyle61.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle61.Format = "N2";
            colItemTaxable.DefaultCellStyle = dataGridViewCellStyle61;
            colItemTaxable.HeaderText = "Taxable";
            colItemTaxable.Name = "colItemTaxable";
            colItemTaxable.ReadOnly = true;
            colItemTaxable.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colItemAmount
            // 
            colItemAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle62.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle62.Format = "N2";
            colItemAmount.DefaultCellStyle = dataGridViewCellStyle62;
            colItemAmount.HeaderText = "Amount";
            colItemAmount.Name = "colItemAmount";
            colItemAmount.ReadOnly = true;
            colItemAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.WhiteSmoke;
            btnClose.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Image = Properties.Resources.Exit;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1088, 642);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 32);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.BackColor = Color.WhiteSmoke;
            btnAddInvoice.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddInvoice.ForeColor = SystemColors.ActiveCaptionText;
            btnAddInvoice.Image = Properties.Resources.plusb;
            btnAddInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddInvoice.Location = new Point(798, 59);
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.Size = new Size(140, 28);
            btnAddInvoice.TabIndex = 33;
            btnAddInvoice.Text = "Add New Invoice";
            btnAddInvoice.TextAlign = ContentAlignment.MiddleRight;
            btnAddInvoice.UseVisualStyleBackColor = false;
            btnAddInvoice.Click += btnAddInvoice_Click;
            // 
            // frmInvoiceReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 684);
            Controls.Add(pnlMain);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInvoiceReport";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Report";
            pnlMain.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            grpTotals.ResumeLayout(false);
            grpTotals.PerformLayout();
            grpItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private GroupBox grpFilter;
        private Label lblFromDate;
        private DateTimePicker dtpFromDate;
        private Label lblToDate;
        private DateTimePicker dtpToDate;
        private Label lblPeriod;
        private ComboBox cmbPeriod;
        private Label lblParty;
        private ComboBox cmbCustomer;
        private Label lblPaymentMode;
        private ComboBox cmbPaymentMode;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSearch;
        private Button btnReset;
        private Button btnExport;
        private DataGridView dgvInvoices;
        private GroupBox grpTotals;
        private Label lblRecordCount;
        private TextBox txtRecordCount;
        private Label lblTotalGst;
        private TextBox txtTotalGst;
        private Label lblGrandTotal;
        private TextBox txtGrandTotal;
        private Label lblTotalPaid;
        private TextBox txtTotalReceived;
        private Label lblTotalBalance;
        private TextBox txtTotalBalance;
        private GroupBox grpItems;
        private DataGridView dgvItems;
        private Button btnClose;
        private DataGridViewTextBoxColumn colSrNo;
        private DataGridViewTextBoxColumn colInvoiceNo;
        private DataGridViewTextBoxColumn colInvoiceDate;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colPaymentMode;
        private DataGridViewTextBoxColumn colItemCount;
        private DataGridViewTextBoxColumn colTaxableAmount;
        private DataGridViewTextBoxColumn colTotalDiscount;
        private DataGridViewTextBoxColumn colTotalGst;
        private DataGridViewTextBoxColumn colGrandTotal;
        private DataGridViewTextBoxColumn colReceivedAmount;
        private DataGridViewTextBoxColumn colBalanceAmount;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colCustomerGSTNo;
        private DataGridViewTextBoxColumn colRemarks;
        private DataGridViewTextBoxColumn colItemSrNo;
        private DataGridViewTextBoxColumn colItemCode;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colItemHSN;
        private DataGridViewTextBoxColumn colItemUnit;
        private DataGridViewTextBoxColumn colItemQty;
        private DataGridViewTextBoxColumn colItemRate;
        private DataGridViewTextBoxColumn colItemDisc;
        private DataGridViewTextBoxColumn colItemGst;
        private DataGridViewTextBoxColumn colItemTaxable;
        private DataGridViewTextBoxColumn colItemAmount;
        private Button btnAddInvoice;
    }
}