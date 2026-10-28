namespace BalajiTrader.Client.UI
{
    partial class frmBillReport
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            grpFilter = new GroupBox();
            btnAddBill = new Button();
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            lblPeriod = new Label();
            cmbPeriod = new ComboBox();
            lblParty = new Label();
            cmbVendor = new ComboBox();
            lblPaymentMode = new Label();
            cmbPaymentMode = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSearch = new Button();
            btnReset = new Button();
            btnExport = new Button();
            dgvBills = new DataGridView();
            colSrNo = new DataGridViewTextBoxColumn();
            colBillNo = new DataGridViewTextBoxColumn();
            colBillDate = new DataGridViewTextBoxColumn();
            colVendorName = new DataGridViewTextBoxColumn();
            colPaymentMode = new DataGridViewTextBoxColumn();
            colItemCount = new DataGridViewTextBoxColumn();
            colSubTotal = new DataGridViewTextBoxColumn();
            colTotalDiscount = new DataGridViewTextBoxColumn();
            colTotalGst = new DataGridViewTextBoxColumn();
            colGrandTotal = new DataGridViewTextBoxColumn();
            colPaidAmount = new DataGridViewTextBoxColumn();
            colBalanceAmount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colVendorGSTNo = new DataGridViewTextBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            grpTotals = new GroupBox();
            lblRecordCount = new Label();
            txtRecordCount = new TextBox();
            lblTotalGst = new Label();
            txtTotalGst = new TextBox();
            lblGrandTotal = new Label();
            txtGrandTotal = new TextBox();
            lblTotalPaid = new Label();
            txtTotalPaid = new TextBox();
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
            colItemAmount = new DataGridViewTextBoxColumn();
            colItemSellingRate = new DataGridViewTextBoxColumn();
            colItemMargin = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            pnlMain.SuspendLayout();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            grpTotals.SuspendLayout();
            grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(grpFilter);
            pnlMain.Controls.Add(dgvBills);
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
            grpFilter.Controls.Add(btnAddBill);
            grpFilter.Controls.Add(lblFromDate);
            grpFilter.Controls.Add(dtpFromDate);
            grpFilter.Controls.Add(lblToDate);
            grpFilter.Controls.Add(dtpToDate);
            grpFilter.Controls.Add(lblPeriod);
            grpFilter.Controls.Add(cmbPeriod);
            grpFilter.Controls.Add(lblParty);
            grpFilter.Controls.Add(cmbVendor);
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
            // btnAddBill
            // 
            btnAddBill.BackColor = Color.WhiteSmoke;
            btnAddBill.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBill.ForeColor = SystemColors.ActiveCaptionText;
            btnAddBill.Image = Properties.Resources.plusb;
            btnAddBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBill.Location = new Point(798, 60);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(118, 28);
            btnAddBill.TabIndex = 32;
            btnAddBill.Text = "Add New Bill";
            btnAddBill.TextAlign = ContentAlignment.MiddleRight;
            btnAddBill.UseVisualStyleBackColor = false;
            btnAddBill.Click += btnAddBill_Click;
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
            cmbPeriod.Size = new Size(170, 26);
            cmbPeriod.TabIndex = 6;
            // 
            // lblParty
            // 
            lblParty.AutoSize = true;
            lblParty.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParty.ForeColor = SystemColors.ControlText;
            lblParty.Location = new Point(628, 32);
            lblParty.Name = "lblParty";
            lblParty.Size = new Size(60, 18);
            lblParty.TabIndex = 7;
            lblParty.Text = "Vendor :";
            // 
            // cmbVendor
            // 
            cmbVendor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendor.Font = new Font("Calibri", 11.25F);
            cmbVendor.FormattingEnabled = true;
            cmbVendor.Location = new Point(694, 28);
            cmbVendor.Name = "cmbVendor";
            cmbVendor.Size = new Size(210, 26);
            cmbVendor.TabIndex = 8;
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
            cmbPaymentMode.Items.AddRange(new object[] { "All", "Cash", "UPI", "Cheque", "Bank Transfer", "Credit" });
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
            txtSearch.PlaceholderText = "Bill no / vendor / remarks";
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
            btnReset.Size = new Size(80, 28);
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
            btnExport.Location = new Point(1000, 60);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(140, 28);
            btnExport.TabIndex = 17;
            btnExport.Text = "Export to Excel";
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.UseVisualStyleBackColor = false;
            // 
            // dgvBills
            // 
            dgvBills.AllowUserToAddRows = false;
            dgvBills.AllowUserToDeleteRows = false;
            dgvBills.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dgvBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBills.BackgroundColor = Color.White;
            dgvBills.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBills.ColumnHeadersHeight = 32;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBills.Columns.AddRange(new DataGridViewColumn[] { colSrNo, colBillNo, colBillDate, colVendorName, colPaymentMode, colItemCount, colSubTotal, colTotalDiscount, colTotalGst, colGrandTotal, colPaidAmount, colBalanceAmount, colStatus, colVendorGSTNo, colRemarks });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvBills.DefaultCellStyle = dataGridViewCellStyle12;
            dgvBills.EnableHeadersVisualStyles = false;
            dgvBills.GridColor = Color.LightSteelBlue;
            dgvBills.Location = new Point(12, 106);
            dgvBills.MultiSelect = false;
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dgvBills.RowHeadersVisible = false;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(1156, 266);
            dgvBills.TabIndex = 18;
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
            // colBillNo
            // 
            colBillNo.DataPropertyName = "BillNo";
            colBillNo.HeaderText = "Bill No";
            colBillNo.Name = "colBillNo";
            colBillNo.ReadOnly = true;
            colBillNo.SortMode = DataGridViewColumnSortMode.Programmatic;
            colBillNo.Width = 105;
            // 
            // colBillDate
            // 
            colBillDate.DataPropertyName = "BillDate";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            colBillDate.DefaultCellStyle = dataGridViewCellStyle3;
            colBillDate.HeaderText = "Date";
            colBillDate.Name = "colBillDate";
            colBillDate.ReadOnly = true;
            colBillDate.SortMode = DataGridViewColumnSortMode.Programmatic;
            colBillDate.Width = 80;
            // 
            // colVendorName
            // 
            colVendorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVendorName.DataPropertyName = "VendorName";
            colVendorName.HeaderText = "Vendor";
            colVendorName.MinimumWidth = 150;
            colVendorName.Name = "colVendorName";
            colVendorName.ReadOnly = true;
            colVendorName.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            colItemCount.DefaultCellStyle = dataGridViewCellStyle4;
            colItemCount.HeaderText = "Items";
            colItemCount.Name = "colItemCount";
            colItemCount.ReadOnly = true;
            colItemCount.SortMode = DataGridViewColumnSortMode.Programmatic;
            colItemCount.Width = 45;
            // 
            // colSubTotal
            // 
            colSubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            colSubTotal.DefaultCellStyle = dataGridViewCellStyle5;
            colSubTotal.HeaderText = "Sub Total";
            colSubTotal.Name = "colSubTotal";
            colSubTotal.ReadOnly = true;
            colSubTotal.SortMode = DataGridViewColumnSortMode.Programmatic;
            colSubTotal.Width = 90;
            // 
            // colTotalDiscount
            // 
            colTotalDiscount.DataPropertyName = "TotalDiscount";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            colTotalDiscount.DefaultCellStyle = dataGridViewCellStyle6;
            colTotalDiscount.HeaderText = "Discount";
            colTotalDiscount.Name = "colTotalDiscount";
            colTotalDiscount.ReadOnly = true;
            colTotalDiscount.SortMode = DataGridViewColumnSortMode.Programmatic;
            colTotalDiscount.Width = 75;
            // 
            // colTotalGst
            // 
            colTotalGst.DataPropertyName = "TotalGst";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            colTotalGst.DefaultCellStyle = dataGridViewCellStyle7;
            colTotalGst.HeaderText = "GST";
            colTotalGst.Name = "colTotalGst";
            colTotalGst.ReadOnly = true;
            colTotalGst.SortMode = DataGridViewColumnSortMode.Programmatic;
            colTotalGst.Width = 75;
            // 
            // colGrandTotal
            // 
            colGrandTotal.DataPropertyName = "GrandTotal";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            colGrandTotal.DefaultCellStyle = dataGridViewCellStyle8;
            colGrandTotal.HeaderText = "Grand Total";
            colGrandTotal.Name = "colGrandTotal";
            colGrandTotal.ReadOnly = true;
            colGrandTotal.SortMode = DataGridViewColumnSortMode.Programmatic;
            colGrandTotal.Width = 95;
            // 
            // colPaidAmount
            // 
            colPaidAmount.DataPropertyName = "PaidAmount";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            colPaidAmount.DefaultCellStyle = dataGridViewCellStyle9;
            colPaidAmount.HeaderText = "Paid";
            colPaidAmount.Name = "colPaidAmount";
            colPaidAmount.ReadOnly = true;
            colPaidAmount.SortMode = DataGridViewColumnSortMode.Programmatic;
            colPaidAmount.Width = 85;
            // 
            // colBalanceAmount
            // 
            colBalanceAmount.DataPropertyName = "BalanceAmount";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            colBalanceAmount.DefaultCellStyle = dataGridViewCellStyle10;
            colBalanceAmount.HeaderText = "Balance";
            colBalanceAmount.Name = "colBalanceAmount";
            colBalanceAmount.ReadOnly = true;
            colBalanceAmount.SortMode = DataGridViewColumnSortMode.Programmatic;
            colBalanceAmount.Width = 85;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStatus.DefaultCellStyle = dataGridViewCellStyle11;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.Programmatic;
            colStatus.Width = 65;
            // 
            // colVendorGSTNo
            // 
            colVendorGSTNo.DataPropertyName = "VendorGSTNo";
            colVendorGSTNo.HeaderText = "GST No";
            colVendorGSTNo.Name = "colVendorGSTNo";
            colVendorGSTNo.ReadOnly = true;
            colVendorGSTNo.SortMode = DataGridViewColumnSortMode.Programmatic;
            colVendorGSTNo.Visible = false;
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
            grpTotals.Controls.Add(txtTotalPaid);
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
            lblTotalPaid.Size = new Size(42, 18);
            lblTotalPaid.TabIndex = 23;
            lblTotalPaid.Text = "Paid :";
            // 
            // txtTotalPaid
            // 
            txtTotalPaid.BackColor = Color.WhiteSmoke;
            txtTotalPaid.Font = new Font("Calibri", 11.25F);
            txtTotalPaid.Location = new Point(690, 24);
            txtTotalPaid.Name = "txtTotalPaid";
            txtTotalPaid.ReadOnly = true;
            txtTotalPaid.Size = new Size(140, 26);
            txtTotalPaid.TabIndex = 24;
            txtTotalPaid.TabStop = false;
            txtTotalPaid.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.AutoSize = true;
            lblTotalBalance.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalBalance.ForeColor = SystemColors.ControlText;
            lblTotalBalance.Location = new Point(858, 28);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(63, 18);
            lblTotalBalance.TabIndex = 24;
            lblTotalBalance.Text = "Balance :";
            // 
            // txtTotalBalance
            // 
            txtTotalBalance.BackColor = Color.WhiteSmoke;
            txtTotalBalance.Font = new Font("Calibri", 11.25F);
            txtTotalBalance.Location = new Point(928, 24);
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
            grpItems.Text = "Bill Items";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = Color.Azure;
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.SteelBlue;
            dataGridViewCellStyle14.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvItems.ColumnHeadersHeight = 32;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colItemSrNo, colItemCode, colItemName, colItemHSN, colItemUnit, colItemQty, colItemRate, colItemDisc, colItemGst, colItemAmount, colItemSellingRate, colItemMargin });
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Window;
            dataGridViewCellStyle22.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle22.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle22.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle22.SelectionForeColor = Color.Black;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle22;
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
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "0.###";
            colItemQty.DefaultCellStyle = dataGridViewCellStyle15;
            colItemQty.HeaderText = "Qty";
            colItemQty.Name = "colItemQty";
            colItemQty.ReadOnly = true;
            colItemQty.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemQty.Width = 70;
            // 
            // colItemRate
            // 
            colItemRate.DataPropertyName = "PurchaseRate";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            colItemRate.DefaultCellStyle = dataGridViewCellStyle16;
            colItemRate.HeaderText = "Purchase Rate";
            colItemRate.Name = "colItemRate";
            colItemRate.ReadOnly = true;
            colItemRate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colItemDisc
            // 
            colItemDisc.DataPropertyName = "DiscountPercent";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            colItemDisc.DefaultCellStyle = dataGridViewCellStyle17;
            colItemDisc.HeaderText = "Disc %";
            colItemDisc.Name = "colItemDisc";
            colItemDisc.ReadOnly = true;
            colItemDisc.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemDisc.Width = 70;
            // 
            // colItemGst
            // 
            colItemGst.DataPropertyName = "GstPercent";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            colItemGst.DefaultCellStyle = dataGridViewCellStyle18;
            colItemGst.HeaderText = "GST %";
            colItemGst.Name = "colItemGst";
            colItemGst.ReadOnly = true;
            colItemGst.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemGst.Width = 70;
            // 
            // colItemAmount
            // 
            colItemAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            colItemAmount.DefaultCellStyle = dataGridViewCellStyle19;
            colItemAmount.HeaderText = "Amount";
            colItemAmount.Name = "colItemAmount";
            colItemAmount.ReadOnly = true;
            colItemAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colItemSellingRate
            // 
            colItemSellingRate.DataPropertyName = "SellingRate";
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            colItemSellingRate.DefaultCellStyle = dataGridViewCellStyle20;
            colItemSellingRate.HeaderText = "Selling Rate";
            colItemSellingRate.Name = "colItemSellingRate";
            colItemSellingRate.ReadOnly = true;
            colItemSellingRate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colItemMargin
            // 
            colItemMargin.DataPropertyName = "MarginPercent";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            colItemMargin.DefaultCellStyle = dataGridViewCellStyle21;
            colItemMargin.HeaderText = "Margin %";
            colItemMargin.Name = "colItemMargin";
            colItemMargin.ReadOnly = true;
            colItemMargin.SortMode = DataGridViewColumnSortMode.NotSortable;
            colItemMargin.Width = 85;
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
            // frmBillReport
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
            Name = "frmBillReport";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill Report";
            pnlMain.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
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
        private ComboBox cmbVendor;
        private Label lblPaymentMode;
        private ComboBox cmbPaymentMode;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSearch;
        private Button btnReset;
        private Button btnExport;
        private DataGridView dgvBills;
        private GroupBox grpTotals;
        private Label lblRecordCount;
        private TextBox txtRecordCount;
        private Label lblTotalGst;
        private TextBox txtTotalGst;
        private Label lblGrandTotal;
        private TextBox txtGrandTotal;
        private Label lblTotalPaid;
        private TextBox txtTotalPaid;
        private Label lblTotalBalance;
        private TextBox txtTotalBalance;
        private GroupBox grpItems;
        private DataGridView dgvItems;
        private Button btnClose;
        private DataGridViewTextBoxColumn colSrNo;
        private DataGridViewTextBoxColumn colBillNo;
        private DataGridViewTextBoxColumn colBillDate;
        private DataGridViewTextBoxColumn colVendorName;
        private DataGridViewTextBoxColumn colPaymentMode;
        private DataGridViewTextBoxColumn colItemCount;
        private DataGridViewTextBoxColumn colSubTotal;
        private DataGridViewTextBoxColumn colTotalDiscount;
        private DataGridViewTextBoxColumn colTotalGst;
        private DataGridViewTextBoxColumn colGrandTotal;
        private DataGridViewTextBoxColumn colPaidAmount;
        private DataGridViewTextBoxColumn colBalanceAmount;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colVendorGSTNo;
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
        private DataGridViewTextBoxColumn colItemAmount;
        private DataGridViewTextBoxColumn colItemSellingRate;
        private DataGridViewTextBoxColumn colItemMargin;
        private Button btnAddBill;
    }
}