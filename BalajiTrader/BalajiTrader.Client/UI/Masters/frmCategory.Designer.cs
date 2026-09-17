namespace BalajiTrader.Client.UI.Masters
{
    partial class frmCategory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            pnlHeaders = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            lblCatagoryName = new Label();
            txtDescription = new RichTextBox();
            lblHSNCode = new Label();
            txtHSNCode = new TextBox();
            label7 = new Label();
            txtCategoryName = new TextBox();
            label3 = new Label();
            pnlGrid = new Panel();
            dgvCategories = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            validationerrors = new ErrorProvider(components);
            pnlHeaders.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validationerrors).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaders
            // 
            pnlHeaders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeaders.Controls.Add(btnCancel);
            pnlHeaders.Controls.Add(btnSave);
            pnlHeaders.Controls.Add(lblCatagoryName);
            pnlHeaders.Controls.Add(txtDescription);
            pnlHeaders.Controls.Add(lblHSNCode);
            pnlHeaders.Controls.Add(txtHSNCode);
            pnlHeaders.Controls.Add(label7);
            pnlHeaders.Controls.Add(txtCategoryName);
            pnlHeaders.Controls.Add(label3);
            pnlHeaders.Location = new Point(12, 12);
            pnlHeaders.Name = "pnlHeaders";
            pnlHeaders.Size = new Size(546, 163);
            pnlHeaders.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Image = Properties.Resources.Exit;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(451, 123);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 75;
            btnCancel.Text = "Clear";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.Save_Update;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(308, 122);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 32);
            btnSave.TabIndex = 74;
            btnSave.Text = "Save && Update";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblCatagoryName
            // 
            lblCatagoryName.AutoSize = true;
            lblCatagoryName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatagoryName.Location = new Point(12, 10);
            lblCatagoryName.Name = "lblCatagoryName";
            lblCatagoryName.Size = new Size(117, 19);
            lblCatagoryName.TabIndex = 66;
            lblCatagoryName.Text = "Category Name :";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Calibri", 12F);
            txtDescription.Location = new Point(176, 86);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(349, 30);
            txtDescription.TabIndex = 73;
            txtDescription.Text = "";
            // 
            // lblHSNCode
            // 
            lblHSNCode.AutoSize = true;
            lblHSNCode.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHSNCode.Location = new Point(12, 52);
            lblHSNCode.Name = "lblHSNCode";
            lblHSNCode.Size = new Size(81, 19);
            lblHSNCode.TabIndex = 67;
            lblHSNCode.Text = "HSN Code :";
            // 
            // txtHSNCode
            // 
            txtHSNCode.Font = new Font("Calibri", 12F);
            txtHSNCode.Location = new Point(177, 49);
            txtHSNCode.Name = "txtHSNCode";
            txtHSNCode.Size = new Size(160, 27);
            txtHSNCode.TabIndex = 72;
            txtHSNCode.KeyPress += Common_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(136, 11);
            label7.Name = "label7";
            label7.Size = new Size(15, 18);
            label7.TabIndex = 68;
            label7.Text = "*";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Calibri", 12F);
            txtCategoryName.Location = new Point(177, 11);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(208, 27);
            txtCategoryName.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(158, 19);
            label3.TabIndex = 70;
            label3.Text = "Description (optional) :";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.BorderStyle = BorderStyle.FixedSingle;
            pnlGrid.Controls.Add(dgvCategories);
            pnlGrid.Location = new Point(12, 192);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(546, 175);
            pnlGrid.TabIndex = 1;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToResizeColumns = false;
            dgvCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.BackgroundColor = Color.White;
            dgvCategories.BorderStyle = BorderStyle.None;
            dgvCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategories.ColumnHeadersHeight = 30;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { SrNo });
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.GridColor = Color.LightSteelBlue;
            dgvCategories.Location = new Point(0, 0);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dgvCategories.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCategories.Size = new Size(544, 173);
            dgvCategories.TabIndex = 4;
            dgvCategories.CellClick += dgvCategories_CellClick;
            dgvCategories.CellMouseEnter += dgvCategories_CellMouseEnter;
            dgvCategories.DataError += dgvCategories_DataError;
            // 
            // SrNo
            // 
            SrNo.HeaderText = "Sr No.";
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            // 
            // validationerrors
            // 
            validationerrors.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            validationerrors.ContainerControl = this;
            validationerrors.Icon = (Icon)resources.GetObject("validationerrors.Icon");
            // 
            // frmCategory
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
            Name = "frmCategory";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Brands";
            Load += frmCategory_Load;
            pnlHeaders.ResumeLayout(false);
            pnlHeaders.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)validationerrors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaders;
        private Panel pnlGrid;
        private DataGridView dgvCategories;
        private DataGridViewTextBoxColumn SrNo;
        private Button btnSave;
        private Label lblCatagoryName;
        private RichTextBox txtDescription;
        private Label lblHSNCode;
        private TextBox txtHSNCode;
        private Label label7;
        private TextBox txtCategoryName;
        private Label label3;
        private Button btnCancel;
        private ErrorProvider validationerrors;
    }
}