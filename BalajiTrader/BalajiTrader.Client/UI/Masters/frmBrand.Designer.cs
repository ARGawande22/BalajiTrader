namespace BalajiTrader.Client.UI.Masters
{
    partial class frmBrand
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
            pnlHeaders = new Panel();
            cmbCategory = new ComboBox();
            btnSave = new Button();
            txtCategoryName = new TextBox();
            label2 = new Label();
            label7 = new Label();
            lblCategory = new Label();
            lblBrandName = new Label();
            pnlGrid = new Panel();
            dgvBrands = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            pnlHeaders.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrands).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaders
            // 
            pnlHeaders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeaders.Controls.Add(cmbCategory);
            pnlHeaders.Controls.Add(btnSave);
            pnlHeaders.Controls.Add(txtCategoryName);
            pnlHeaders.Controls.Add(label2);
            pnlHeaders.Controls.Add(label7);
            pnlHeaders.Controls.Add(lblCategory);
            pnlHeaders.Controls.Add(lblBrandName);
            pnlHeaders.Location = new Point(12, 12);
            pnlHeaders.Name = "pnlHeaders";
            pnlHeaders.Size = new Size(546, 133);
            pnlHeaders.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.Font = new Font("Calibri", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(189, 52);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(208, 27);
            cmbCategory.TabIndex = 72;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.Save_Update;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(189, 91);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 32);
            btnSave.TabIndex = 65;
            btnSave.Text = "Save && Update";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Calibri", 12F);
            txtCategoryName.Location = new Point(189, 18);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(208, 27);
            txtCategoryName.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(110, 61);
            label2.Name = "label2";
            label2.Size = new Size(15, 18);
            label2.TabIndex = 43;
            label2.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(147, 18);
            label7.Name = "label7";
            label7.Size = new Size(15, 18);
            label7.TabIndex = 42;
            label7.Text = "*";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(24, 59);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 19);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category :";
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandName.Location = new Point(24, 17);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(97, 19);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "Brand Name :";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.BorderStyle = BorderStyle.FixedSingle;
            pnlGrid.Controls.Add(dgvBrands);
            pnlGrid.Location = new Point(12, 151);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(546, 210);
            pnlGrid.TabIndex = 1;
            // 
            // dgvBrands
            // 
            dgvBrands.AllowUserToAddRows = false;
            dgvBrands.AllowUserToResizeColumns = false;
            dgvBrands.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dgvBrands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBrands.BackgroundColor = Color.White;
            dgvBrands.BorderStyle = BorderStyle.None;
            dgvBrands.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBrands.ColumnHeadersHeight = 35;
            dgvBrands.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBrands.Columns.AddRange(new DataGridViewColumn[] { SrNo });
            dgvBrands.Dock = DockStyle.Fill;
            dgvBrands.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvBrands.EnableHeadersVisualStyles = false;
            dgvBrands.GridColor = Color.LightSteelBlue;
            dgvBrands.Location = new Point(0, 0);
            dgvBrands.Name = "dgvBrands";
            dgvBrands.ReadOnly = true;
            dgvBrands.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dgvBrands.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvBrands.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvBrands.Size = new Size(544, 208);
            dgvBrands.TabIndex = 4;
            // 
            // SrNo
            // 
            SrNo.HeaderText = "Sr No.";
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            // 
            // frmBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 379);
            Controls.Add(pnlGrid);
            Controls.Add(pnlHeaders);
            Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBrand";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Brands";
            pnlHeaders.ResumeLayout(false);
            pnlHeaders.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBrands).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaders;
        private Panel pnlGrid;
        private Label lblBrandName;
        private Label label2;
        private Label label7;
        private Label lblCategory;
        private TextBox txtCategoryName;
        private Button btnSave;
        private DataGridView dgvBrands;
        private DataGridViewTextBoxColumn SrNo;
        private ComboBox cmbCategory;
    }
}