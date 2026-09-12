namespace BalajiTrader.Client.UI.Masters
{
    partial class frmUnits
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
            txtUnit = new TextBox();
            btnSave = new Button();
            txtUnitName = new TextBox();
            label2 = new Label();
            label7 = new Label();
            lblUnit = new Label();
            lblUnitName = new Label();
            pnlGrid = new Panel();
            dgvUnits = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            pnlHeaders.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnits).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaders
            // 
            pnlHeaders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeaders.Controls.Add(txtUnit);
            pnlHeaders.Controls.Add(btnSave);
            pnlHeaders.Controls.Add(txtUnitName);
            pnlHeaders.Controls.Add(label2);
            pnlHeaders.Controls.Add(label7);
            pnlHeaders.Controls.Add(lblUnit);
            pnlHeaders.Controls.Add(lblUnitName);
            pnlHeaders.Location = new Point(12, 12);
            pnlHeaders.Name = "pnlHeaders";
            pnlHeaders.Size = new Size(546, 133);
            pnlHeaders.TabIndex = 0;
            // 
            // txtUnit
            // 
            txtUnit.Font = new Font("Calibri", 12F);
            txtUnit.Location = new Point(189, 51);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(137, 27);
            txtUnit.TabIndex = 66;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.Save_Update;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(189, 88);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 32);
            btnSave.TabIndex = 65;
            btnSave.Text = "Save && Update";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtUnitName
            // 
            txtUnitName.Font = new Font("Calibri", 12F);
            txtUnitName.Location = new Point(189, 18);
            txtUnitName.Name = "txtUnitName";
            txtUnitName.Size = new Size(208, 27);
            txtUnitName.TabIndex = 45;
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
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnit.Location = new Point(24, 59);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(44, 19);
            lblUnit.TabIndex = 1;
            lblUnit.Text = "Unit :";
            // 
            // lblUnitName
            // 
            lblUnitName.AutoSize = true;
            lblUnitName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnitName.Location = new Point(24, 17);
            lblUnitName.Name = "lblUnitName";
            lblUnitName.Size = new Size(86, 19);
            lblUnitName.TabIndex = 0;
            lblUnitName.Text = "Unit Name :";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.BorderStyle = BorderStyle.FixedSingle;
            pnlGrid.Controls.Add(dgvUnits);
            pnlGrid.Location = new Point(12, 151);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(546, 210);
            pnlGrid.TabIndex = 1;
            // 
            // dgvUnits
            // 
            dgvUnits.AllowUserToAddRows = false;
            dgvUnits.AllowUserToResizeColumns = false;
            dgvUnits.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.Azure;
            dgvUnits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUnits.BackgroundColor = Color.White;
            dgvUnits.BorderStyle = BorderStyle.None;
            dgvUnits.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.SteelBlue;
            dataGridViewCellStyle5.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvUnits.ColumnHeadersHeight = 35;
            dgvUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUnits.Columns.AddRange(new DataGridViewColumn[] { SrNo });
            dgvUnits.Dock = DockStyle.Fill;
            dgvUnits.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvUnits.EnableHeadersVisualStyles = false;
            dgvUnits.GridColor = Color.LightSteelBlue;
            dgvUnits.Location = new Point(0, 0);
            dgvUnits.Name = "dgvUnits";
            dgvUnits.ReadOnly = true;
            dgvUnits.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSkyBlue;
            dgvUnits.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvUnits.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvUnits.Size = new Size(544, 208);
            dgvUnits.TabIndex = 4;
            // 
            // SrNo
            // 
            SrNo.HeaderText = "Sr No.";
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            // 
            // frmUnits
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
            Name = "frmUnits";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Unit";
            pnlHeaders.ResumeLayout(false);
            pnlHeaders.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUnits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaders;
        private Panel pnlGrid;
        private Label lblUnitName;
        private Label label2;
        private Label label7;
        private Label lblUnit;
        private TextBox txtUnitName;
        private Button btnSave;
        private DataGridView dgvUnits;
        private DataGridViewTextBoxColumn SrNo;
        private TextBox txtUnit;
    }
}