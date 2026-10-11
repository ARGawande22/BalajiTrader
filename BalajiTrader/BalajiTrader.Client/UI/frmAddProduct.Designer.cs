namespace BalajiTrader.Client.UI
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            grpProduct = new GroupBox();
            lblHSNCode = new Label();
            txtHSNCode = new TextBox();
            label4 = new Label();
            cmbUnit = new ComboBox();
            lblUnit = new Label();
            label2 = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            label3 = new Label();
            txtProductCode = new TextBox();
            lblProductCode = new Label();
            cmbSize = new ComboBox();
            lblSize = new Label();
            label1 = new Label();
            cmbBrand = new ComboBox();
            lblBrand = new Label();
            label5 = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            pnlMain = new Panel();
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            validationerrors = new ErrorProvider(components);
            grpProduct.SuspendLayout();
            pnlMain.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationerrors).BeginInit();
            SuspendLayout();
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(lblHSNCode);
            grpProduct.Controls.Add(txtHSNCode);
            grpProduct.Controls.Add(label4);
            grpProduct.Controls.Add(cmbUnit);
            grpProduct.Controls.Add(lblUnit);
            grpProduct.Controls.Add(label2);
            grpProduct.Controls.Add(txtProductName);
            grpProduct.Controls.Add(lblProductName);
            grpProduct.Controls.Add(label3);
            grpProduct.Controls.Add(txtProductCode);
            grpProduct.Controls.Add(lblProductCode);
            grpProduct.Controls.Add(cmbSize);
            grpProduct.Controls.Add(lblSize);
            grpProduct.Controls.Add(label1);
            grpProduct.Controls.Add(cmbBrand);
            grpProduct.Controls.Add(lblBrand);
            grpProduct.Controls.Add(label5);
            grpProduct.Controls.Add(cmbCategory);
            grpProduct.Controls.Add(lblCategory);
            grpProduct.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpProduct.ForeColor = Color.SteelBlue;
            grpProduct.Location = new Point(12, 12);
            grpProduct.Name = "grpProduct";
            grpProduct.Size = new Size(651, 292);
            grpProduct.TabIndex = 2;
            grpProduct.TabStop = false;
            grpProduct.Text = "Product / Service";
            // 
            // lblHSNCode
            // 
            lblHSNCode.AutoSize = true;
            lblHSNCode.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHSNCode.ForeColor = SystemColors.ControlText;
            lblHSNCode.Location = new Point(155, 248);
            lblHSNCode.Name = "lblHSNCode";
            lblHSNCode.Size = new Size(106, 18);
            lblHSNCode.TabIndex = 20;
            lblHSNCode.Text = "HSN/SAC Code :";
            // 
            // txtHSNCode
            // 
            txtHSNCode.Font = new Font("Calibri", 12F);
            txtHSNCode.Location = new Point(290, 238);
            txtHSNCode.Name = "txtHSNCode";
            txtHSNCode.PlaceholderText = "HSN / SAC code";
            txtHSNCode.Size = new Size(153, 27);
            txtHSNCode.TabIndex = 21;
            txtHSNCode.KeyPress += Common_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(268, 209);
            label4.Name = "label4";
            label4.Size = new Size(15, 18);
            label4.TabIndex = 18;
            label4.Text = "*";
            // 
            // cmbUnit
            // 
            cmbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnit.Font = new Font("Calibri", 11.25F);
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(291, 203);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(79, 26);
            cmbUnit.TabIndex = 19;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnit.ForeColor = SystemColors.ControlText;
            lblUnit.Location = new Point(155, 209);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(41, 18);
            lblUnit.TabIndex = 17;
            lblUnit.Text = "Unit :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(268, 67);
            label2.Name = "label2";
            label2.Size = new Size(15, 18);
            label2.TabIndex = 7;
            label2.Text = "*";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Calibri", 11.25F);
            txtProductName.Location = new Point(291, 61);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Enter product name";
            txtProductName.Size = new Size(233, 26);
            txtProductName.TabIndex = 8;
            txtProductName.Validated += Common_Validated;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = SystemColors.ControlText;
            lblProductName.Location = new Point(155, 66);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(103, 18);
            lblProductName.TabIndex = 6;
            lblProductName.Text = "Product Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(268, 30);
            label3.Name = "label3";
            label3.Size = new Size(15, 18);
            label3.TabIndex = 4;
            label3.Text = "*";
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Calibri", 11.25F);
            txtProductCode.Location = new Point(291, 25);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.PlaceholderText = "Enter product code";
            txtProductCode.Size = new Size(233, 26);
            txtProductCode.TabIndex = 5;
            txtProductCode.Validated += Common_Validated;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductCode.ForeColor = SystemColors.ControlText;
            lblProductCode.Location = new Point(155, 30);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(98, 18);
            lblProductCode.TabIndex = 3;
            lblProductCode.Text = "Product Code :";
            // 
            // cmbSize
            // 
            cmbSize.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSize.Font = new Font("Calibri", 11.25F);
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(291, 168);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(186, 26);
            cmbSize.TabIndex = 16;
            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;
            cmbSize.Validated += Common_Validated;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSize.ForeColor = SystemColors.ControlText;
            lblSize.Location = new Point(156, 175);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(40, 18);
            lblSize.TabIndex = 15;
            lblSize.Text = "Size :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(268, 139);
            label1.Name = "label1";
            label1.Size = new Size(15, 18);
            label1.TabIndex = 12;
            label1.Text = "*";
            // 
            // cmbBrand
            // 
            cmbBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBrand.Font = new Font("Calibri", 11.25F);
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(291, 133);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(186, 26);
            cmbBrand.TabIndex = 14;
            cmbBrand.Validated += Common_Validated;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = SystemColors.ControlText;
            lblBrand.Location = new Point(155, 138);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(51, 18);
            lblBrand.TabIndex = 12;
            lblBrand.Text = "Brand :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(268, 101);
            label5.Name = "label5";
            label5.Size = new Size(15, 18);
            label5.TabIndex = 10;
            label5.Text = "*";
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.Font = new Font("Calibri", 11.25F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(291, 97);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(186, 26);
            cmbCategory.TabIndex = 11;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbCategory.Validated += Common_Validated;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ControlText;
            lblCategory.Location = new Point(155, 101);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(70, 18);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category :";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(panel1);
            pnlMain.Controls.Add(grpProduct);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(675, 359);
            pnlMain.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(12, 310);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 41);
            panel1.TabIndex = 22;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Image = Properties.Resources.Exit;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(566, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 30);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.Save_Update;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(425, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 32);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save && Update";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // validationerrors
            // 
            validationerrors.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            validationerrors.ContainerControl = this;
            validationerrors.Icon = (Icon)resources.GetObject("validationerrors.Icon");
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(675, 359);
            Controls.Add(pnlMain);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddProduct";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Product";
            Load += frmAddProduct_Load;
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            pnlMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)validationerrors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProduct;
        private Panel pnlMain;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cmbSize;
        private Label lblSize;
        private Label label1;
        private ComboBox cmbBrand;
        private Label lblBrand;
        private Label label5;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private Label label2;
        private TextBox txtProductName;
        private Label lblProductName;
        private Label label3;
        private TextBox txtProductCode;
        private Label lblProductCode;
        private Label label4;
        private ComboBox cmbUnit;
        private Label lblUnit;
        private Label lblHSNCode;
        private TextBox txtHSNCode;
        private ErrorProvider validationerrors;
    }
}