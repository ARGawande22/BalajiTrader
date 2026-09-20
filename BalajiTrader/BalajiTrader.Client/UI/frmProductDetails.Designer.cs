namespace BalajiTrader.Client.UI
{
    partial class frmProductDetails
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            pnlGrid = new Panel();
            dgvProductDetails = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            pnHeaders = new Panel();
            cmbBrand = new ComboBox();
            lblBrand = new Label();
            cmbCategory = new ComboBox();
            btnAddUser = new Button();
            lblCategory = new Label();
            pnlMain.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductDetails).BeginInit();
            pnHeaders.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlGrid);
            pnlMain.Controls.Add(pnHeaders);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(813, 468);
            pnlMain.TabIndex = 0;
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.BorderStyle = BorderStyle.FixedSingle;
            pnlGrid.Controls.Add(dgvProductDetails);
            pnlGrid.Location = new Point(12, 62);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(789, 394);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProductDetails
            // 
            dgvProductDetails.AllowUserToAddRows = false;
            dgvProductDetails.AllowUserToResizeColumns = false;
            dgvProductDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dgvProductDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductDetails.BackgroundColor = Color.White;
            dgvProductDetails.BorderStyle = BorderStyle.None;
            dgvProductDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductDetails.ColumnHeadersHeight = 35;
            dgvProductDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductDetails.Columns.AddRange(new DataGridViewColumn[] { SrNo });
            dgvProductDetails.Dock = DockStyle.Fill;
            dgvProductDetails.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvProductDetails.EnableHeadersVisualStyles = false;
            dgvProductDetails.GridColor = Color.LightSteelBlue;
            dgvProductDetails.Location = new Point(0, 0);
            dgvProductDetails.Name = "dgvProductDetails";
            dgvProductDetails.ReadOnly = true;
            dgvProductDetails.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dgvProductDetails.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductDetails.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvProductDetails.Size = new Size(787, 392);
            dgvProductDetails.TabIndex = 1;
            dgvProductDetails.CellClick += dgvProductDetails_CellClick;
            dgvProductDetails.CellMouseEnter += dgvProductDetails_CellMouseEnter;
            dgvProductDetails.DataError += dgvProductDetails_DataError;
            // 
            // SrNo
            // 
            SrNo.HeaderText = "Sr No.";
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            // 
            // pnHeaders
            // 
            pnHeaders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnHeaders.Controls.Add(cmbBrand);
            pnHeaders.Controls.Add(lblBrand);
            pnHeaders.Controls.Add(cmbCategory);
            pnHeaders.Controls.Add(btnAddUser);
            pnHeaders.Controls.Add(lblCategory);
            pnHeaders.Location = new Point(12, 12);
            pnHeaders.Name = "pnHeaders";
            pnHeaders.Size = new Size(789, 44);
            pnHeaders.TabIndex = 1;
            // 
            // cmbBrand
            // 
            cmbBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBrand.Font = new Font("Calibri", 11.25F);
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(404, 10);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(186, 26);
            cmbBrand.TabIndex = 67;
            cmbBrand.SelectedIndexChanged += cmbCommon_SelectedIndexChanged;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = SystemColors.ControlText;
            lblBrand.Location = new Point(338, 13);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(51, 18);
            lblBrand.TabIndex = 66;
            lblBrand.Text = "Brand :";
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.Font = new Font("Calibri", 11.25F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(113, 10);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(186, 26);
            cmbCategory.TabIndex = 64;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Right;
            btnAddUser.BackColor = Color.WhiteSmoke;
            btnAddUser.ForeColor = SystemColors.ActiveCaptionText;
            btnAddUser.Image = Properties.Resources.plusb;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(658, 6);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(126, 32);
            btnAddUser.TabIndex = 21;
            btnAddUser.Text = "Add New Product";
            btnAddUser.TextAlign = ContentAlignment.MiddleRight;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ControlText;
            lblCategory.Location = new Point(19, 13);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(70, 18);
            lblCategory.TabIndex = 63;
            lblCategory.Text = "Category :";
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 468);
            Controls.Add(pnlMain);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProductDetails";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Details";
            Load += frmProductDetails_Load;
            pnlMain.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductDetails).EndInit();
            pnHeaders.ResumeLayout(false);
            pnHeaders.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnHeaders;
        private Panel pnlGrid;
        private DataGridView dgvProductDetails;
        private Button btnAddUser;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private ComboBox cmbBrand;
        private Label lblBrand;
        private DataGridViewTextBoxColumn SrNo;
    }
}