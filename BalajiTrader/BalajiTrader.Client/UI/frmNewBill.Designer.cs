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
            pnlMain = new Panel();
            lblLine = new Label();
            pnlAddProductDetails = new Panel();
            pnlVendorDetails = new Panel();
            btnAddVendor = new Button();
            label2 = new Label();
            txtBillNo = new TextBox();
            lblBillNo = new Label();
            label11 = new Label();
            dtpBillDate = new DateTimePicker();
            lblBillDate = new Label();
            txtGSTNo = new TextBox();
            lblGSTNo = new Label();
            txtMobileNo = new TextBox();
            lblMobileNo = new Label();
            txtAddress = new RichTextBox();
            lblAddress = new Label();
            label3 = new Label();
            lblVendorName = new Label();
            txtVendorName = new TextBox();
            pnlMain.SuspendLayout();
            pnlVendorDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lblLine);
            pnlMain.Controls.Add(pnlAddProductDetails);
            pnlMain.Controls.Add(pnlVendorDetails);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1008, 597);
            pnlMain.TabIndex = 0;
            // 
            // lblLine
            // 
            lblLine.Location = new Point(6, 121);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(28, 10);
            lblLine.TabIndex = 2;
            lblLine.Text = "line";
            // 
            // pnlAddProductDetails
            // 
            pnlAddProductDetails.Location = new Point(3, 131);
            pnlAddProductDetails.Name = "pnlAddProductDetails";
            pnlAddProductDetails.Size = new Size(1002, 112);
            pnlAddProductDetails.TabIndex = 1;
            // 
            // pnlVendorDetails
            // 
            pnlVendorDetails.Controls.Add(btnAddVendor);
            pnlVendorDetails.Controls.Add(label2);
            pnlVendorDetails.Controls.Add(txtBillNo);
            pnlVendorDetails.Controls.Add(lblBillNo);
            pnlVendorDetails.Controls.Add(label11);
            pnlVendorDetails.Controls.Add(dtpBillDate);
            pnlVendorDetails.Controls.Add(lblBillDate);
            pnlVendorDetails.Controls.Add(txtGSTNo);
            pnlVendorDetails.Controls.Add(lblGSTNo);
            pnlVendorDetails.Controls.Add(txtMobileNo);
            pnlVendorDetails.Controls.Add(lblMobileNo);
            pnlVendorDetails.Controls.Add(txtAddress);
            pnlVendorDetails.Controls.Add(lblAddress);
            pnlVendorDetails.Controls.Add(label3);
            pnlVendorDetails.Controls.Add(lblVendorName);
            pnlVendorDetails.Controls.Add(txtVendorName);
            pnlVendorDetails.Location = new Point(3, 3);
            pnlVendorDetails.Name = "pnlVendorDetails";
            pnlVendorDetails.Size = new Size(1002, 115);
            pnlVendorDetails.TabIndex = 0;
            // 
            // btnAddVendor
            // 
            btnAddVendor.BackColor = Color.WhiteSmoke;
            btnAddVendor.ForeColor = SystemColors.ActiveCaptionText;
            btnAddVendor.Image = Properties.Resources.fontplus;
            btnAddVendor.Location = new Point(407, 13);
            btnAddVendor.Name = "btnAddVendor";
            btnAddVendor.Size = new Size(27, 27);
            btnAddVendor.TabIndex = 50;
            btnAddVendor.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(521, 55);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 49;
            label2.Text = "*";
            // 
            // txtBillNo
            // 
            txtBillNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillNo.Location = new Point(550, 49);
            txtBillNo.Name = "txtBillNo";
            txtBillNo.PlaceholderText = "Enter bill no";
            txtBillNo.Size = new Size(142, 26);
            txtBillNo.TabIndex = 48;
            // 
            // lblBillNo
            // 
            lblBillNo.AutoSize = true;
            lblBillNo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillNo.ForeColor = SystemColors.ControlText;
            lblBillNo.Location = new Point(455, 52);
            lblBillNo.Name = "lblBillNo";
            lblBillNo.Size = new Size(60, 19);
            lblBillNo.TabIndex = 47;
            lblBillNo.Text = "Bill No :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(533, 19);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 46;
            label11.Text = "*";
            // 
            // dtpBillDate
            // 
            dtpBillDate.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBillDate.Format = DateTimePickerFormat.Custom;
            dtpBillDate.Location = new Point(553, 13);
            dtpBillDate.Name = "dtpBillDate";
            dtpBillDate.Size = new Size(137, 26);
            dtpBillDate.TabIndex = 45;
            // 
            // lblBillDate
            // 
            lblBillDate.AutoSize = true;
            lblBillDate.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillDate.ForeColor = SystemColors.ControlText;
            lblBillDate.Location = new Point(455, 16);
            lblBillDate.Name = "lblBillDate";
            lblBillDate.Size = new Size(73, 19);
            lblBillDate.TabIndex = 44;
            lblBillDate.Text = "Bill Date :";
            // 
            // txtGSTNo
            // 
            txtGSTNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGSTNo.Location = new Point(804, 50);
            txtGSTNo.Name = "txtGSTNo";
            txtGSTNo.PlaceholderText = "GST no";
            txtGSTNo.Size = new Size(190, 26);
            txtGSTNo.TabIndex = 17;
            // 
            // lblGSTNo
            // 
            lblGSTNo.AutoSize = true;
            lblGSTNo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGSTNo.ForeColor = SystemColors.ControlText;
            lblGSTNo.Location = new Point(708, 51);
            lblGSTNo.Name = "lblGSTNo";
            lblGSTNo.Size = new Size(64, 19);
            lblGSTNo.TabIndex = 16;
            lblGSTNo.Text = "GST No :";
            // 
            // txtMobileNo
            // 
            txtMobileNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMobileNo.Location = new Point(803, 12);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.PlaceholderText = "Contact no";
            txtMobileNo.Size = new Size(142, 26);
            txtMobileNo.TabIndex = 14;
            // 
            // lblMobileNo
            // 
            lblMobileNo.AutoSize = true;
            lblMobileNo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMobileNo.ForeColor = SystemColors.ControlText;
            lblMobileNo.Location = new Point(708, 15);
            lblMobileNo.Name = "lblMobileNo";
            lblMobileNo.Size = new Size(89, 19);
            lblMobileNo.TabIndex = 13;
            lblMobileNo.Text = "Contact No :";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(137, 49);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(297, 59);
            txtAddress.TabIndex = 12;
            txtAddress.Text = "";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.ControlText;
            lblAddress.Location = new Point(9, 75);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 19);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(114, 19);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 6;
            label3.Text = "*";
            // 
            // lblVendorName
            // 
            lblVendorName.AutoSize = true;
            lblVendorName.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVendorName.ForeColor = SystemColors.ControlText;
            lblVendorName.Location = new Point(9, 16);
            lblVendorName.Name = "lblVendorName";
            lblVendorName.Size = new Size(100, 18);
            lblVendorName.TabIndex = 5;
            lblVendorName.Text = "Vendor Name :";
            // 
            // txtVendorName
            // 
            txtVendorName.Font = new Font("Calibri", 11.25F);
            txtVendorName.Location = new Point(137, 13);
            txtVendorName.Name = "txtVendorName";
            txtVendorName.PlaceholderText = "Select vendor name";
            txtVendorName.Size = new Size(269, 26);
            txtVendorName.TabIndex = 7;
            // 
            // frmNewBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 597);
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
            pnlVendorDetails.ResumeLayout(false);
            pnlVendorDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlVendorDetails;
        private Panel pnlAddProductDetails;
        private Label lblLine;
        private Label label3;
        private Label lblVendorName;
        private TextBox txtVendorName;
        private RichTextBox txtAddress;
        private Label lblAddress;
        private TextBox txtMobileNo;
        private Label lblMobileNo;
        private TextBox txtGSTNo;
        private Label lblGSTNo;
        private Label label11;
        private DateTimePicker dtpBillDate;
        private Label lblBillDate;
        private Label label2;
        private TextBox txtBillNo;
        private Label lblBillNo;
        private Button btnAddVendor;
    }
}