namespace BalajiTrader.Client.UI.Masters
{
    partial class frmSizes
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlHeaders = new Panel();
            btnSave = new Button();
            txtSizename = new RichTextBox();
            lblSizeName = new Label();
            pnlGrid = new Panel();
            dgvSizes = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            cmbCategory = new ComboBox();
            label1 = new Label();
            lblCategory = new Label();
            cmbUnits = new ComboBox();
            label2 = new Label();
            lblUnits = new Label();
            pnlHeaders.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSizes).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaders
            // 
            pnlHeaders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeaders.Controls.Add(cmbUnits);
            pnlHeaders.Controls.Add(label2);
            pnlHeaders.Controls.Add(lblUnits);
            pnlHeaders.Controls.Add(cmbCategory);
            pnlHeaders.Controls.Add(btnSave);
            pnlHeaders.Controls.Add(label1);
            pnlHeaders.Controls.Add(txtSizename);
            pnlHeaders.Controls.Add(lblCategory);
            pnlHeaders.Controls.Add(lblSizeName);
            pnlHeaders.Location = new Point(12, 12);
            pnlHeaders.Name = "pnlHeaders";
            pnlHeaders.Size = new Size(546, 163);
            pnlHeaders.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.Save_Update;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(177, 122);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 32);
            btnSave.TabIndex = 74;
            btnSave.Text = "Save && Update";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtSizename
            // 
            txtSizename.BorderStyle = BorderStyle.FixedSingle;
            txtSizename.Font = new Font("Calibri", 12F);
            txtSizename.Location = new Point(167, 86);
            txtSizename.Name = "txtSizename";
            txtSizename.Size = new Size(258, 30);
            txtSizename.TabIndex = 73;
            txtSizename.Text = "";
            // 
            // lblSizeName
            // 
            lblSizeName.AutoSize = true;
            lblSizeName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSizeName.Location = new Point(60, 91);
            lblSizeName.Name = "lblSizeName";
            lblSizeName.Size = new Size(84, 19);
            lblSizeName.TabIndex = 70;
            lblSizeName.Text = "Size Name :";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.BorderStyle = BorderStyle.FixedSingle;
            pnlGrid.Controls.Add(dgvSizes);
            pnlGrid.Location = new Point(12, 192);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(546, 175);
            pnlGrid.TabIndex = 1;
            // 
            // dgvSizes
            // 
            dgvSizes.AllowUserToAddRows = false;
            dgvSizes.AllowUserToResizeColumns = false;
            dgvSizes.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.Azure;
            dgvSizes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSizes.BackgroundColor = Color.White;
            dgvSizes.BorderStyle = BorderStyle.None;
            dgvSizes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.SteelBlue;
            dataGridViewCellStyle5.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvSizes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSizes.ColumnHeadersHeight = 35;
            dgvSizes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSizes.Columns.AddRange(new DataGridViewColumn[] { SrNo });
            dgvSizes.Dock = DockStyle.Fill;
            dgvSizes.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvSizes.EnableHeadersVisualStyles = false;
            dgvSizes.GridColor = Color.LightSteelBlue;
            dgvSizes.Location = new Point(0, 0);
            dgvSizes.Name = "dgvSizes";
            dgvSizes.ReadOnly = true;
            dgvSizes.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSkyBlue;
            dgvSizes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvSizes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSizes.Size = new Size(544, 173);
            dgvSizes.TabIndex = 4;
            // 
            // SrNo
            // 
            SrNo.HeaderText = "Sr No.";
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.Font = new Font("Calibri", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(168, 12);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(204, 27);
            cmbCategory.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(142, 16);
            label1.Name = "label1";
            label1.Size = new Size(15, 18);
            label1.TabIndex = 74;
            label1.Text = "*";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(60, 15);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 19);
            lblCategory.TabIndex = 73;
            lblCategory.Text = "Category :";
            // 
            // cmbUnits
            // 
            cmbUnits.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnits.Font = new Font("Calibri", 12F);
            cmbUnits.FormattingEnabled = true;
            cmbUnits.Location = new Point(168, 50);
            cmbUnits.Name = "cmbUnits";
            cmbUnits.Size = new Size(186, 27);
            cmbUnits.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(118, 53);
            label2.Name = "label2";
            label2.Size = new Size(15, 18);
            label2.TabIndex = 77;
            label2.Text = "*";
            // 
            // lblUnits
            // 
            lblUnits.AutoSize = true;
            lblUnits.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnits.Location = new Point(60, 53);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(51, 19);
            lblUnits.TabIndex = 76;
            lblUnits.Text = "Units :";
            // 
            // frmSizes
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
            Name = "frmSizes";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Brands";
            pnlHeaders.ResumeLayout(false);
            pnlHeaders.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSizes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaders;
        private Panel pnlGrid;
        private DataGridView dgvSizes;
        private DataGridViewTextBoxColumn SrNo;
        private Button btnSave;
        private RichTextBox txtSizename;
        private Label lblSizeName;
        private ComboBox cmbCategory;
        private Label label1;
        private Label lblCategory;
        private ComboBox cmbUnits;
        private Label label2;
        private Label lblUnits;
    }
}