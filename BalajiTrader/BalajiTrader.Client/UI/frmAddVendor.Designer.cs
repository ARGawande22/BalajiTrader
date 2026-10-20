namespace BalajiTrader.Client.UI
{
    partial class frmAddVendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddVendor));
            pnlMain = new Panel();
            pnlGrid = new Panel();
            stsMessage = new UserControls.Status();
            dgvVendorDettails = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            grpAddVendor = new GroupBox();
            label4 = new Label();
            txtAddress = new RichTextBox();
            lblAddress = new Label();
            label10 = new Label();
            txtMobileNo = new TextBox();
            lblMobileNo = new Label();
            txtPANNo = new TextBox();
            lblPan = new Label();
            txtGSTNo = new TextBox();
            lblGSTNo = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            lblContactName = new Label();
            txtContactName = new TextBox();
            label3 = new Label();
            pnlFooter = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            lblVendorName = new Label();
            txtVendorName = new TextBox();
            validationerrors = new ErrorProvider(components);
            pnlMain.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendorDettails).BeginInit();
            grpAddVendor.SuspendLayout();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationerrors).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlGrid);
            pnlMain.Controls.Add(grpAddVendor);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(857, 519);
            pnlMain.TabIndex = 0;
            // 
            // pnlGrid
            // 
            pnlGrid.BorderStyle = BorderStyle.FixedSingle;
            pnlGrid.Controls.Add(stsMessage);
            pnlGrid.Controls.Add(dgvVendorDettails);
            pnlGrid.Location = new Point(12, 235);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(833, 272);
            pnlGrid.TabIndex = 23;
            // 
            // stsMessage
            // 
            stsMessage.BackColor = Color.White;
            stsMessage.DisplayText = "Data not found for search criteria...!";
            stsMessage.Location = new Point(263, 43);
            stsMessage.MaximumSize = new Size(305, 183);
            stsMessage.MinimumSize = new Size(305, 183);
            stsMessage.Name = "stsMessage";
            stsMessage.Size = new Size(305, 183);
            stsMessage.TabIndex = 24;
            // 
            // dgvVendorDettails
            // 
            dgvVendorDettails.AllowUserToAddRows = false;
            dgvVendorDettails.AllowUserToResizeColumns = false;
            dgvVendorDettails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dgvVendorDettails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVendorDettails.BackgroundColor = Color.White;
            dgvVendorDettails.BorderStyle = BorderStyle.None;
            dgvVendorDettails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVendorDettails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVendorDettails.ColumnHeadersHeight = 35;
            dgvVendorDettails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVendorDettails.Columns.AddRange(new DataGridViewColumn[] { SrNo });
            dgvVendorDettails.Dock = DockStyle.Fill;
            dgvVendorDettails.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvVendorDettails.EnableHeadersVisualStyles = false;
            dgvVendorDettails.GridColor = Color.LightSteelBlue;
            dgvVendorDettails.Location = new Point(0, 0);
            dgvVendorDettails.Name = "dgvVendorDettails";
            dgvVendorDettails.ReadOnly = true;
            dgvVendorDettails.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dgvVendorDettails.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvVendorDettails.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvVendorDettails.Size = new Size(831, 270);
            dgvVendorDettails.TabIndex = 13;
            // 
            // SrNo
            // 
            SrNo.HeaderText = "Sr No.";
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            // 
            // grpAddVendor
            // 
            grpAddVendor.Controls.Add(label4);
            grpAddVendor.Controls.Add(txtAddress);
            grpAddVendor.Controls.Add(lblAddress);
            grpAddVendor.Controls.Add(label10);
            grpAddVendor.Controls.Add(txtMobileNo);
            grpAddVendor.Controls.Add(lblMobileNo);
            grpAddVendor.Controls.Add(txtPANNo);
            grpAddVendor.Controls.Add(lblPan);
            grpAddVendor.Controls.Add(txtGSTNo);
            grpAddVendor.Controls.Add(lblGSTNo);
            grpAddVendor.Controls.Add(lblEmail);
            grpAddVendor.Controls.Add(txtEmail);
            grpAddVendor.Controls.Add(label1);
            grpAddVendor.Controls.Add(lblContactName);
            grpAddVendor.Controls.Add(txtContactName);
            grpAddVendor.Controls.Add(label3);
            grpAddVendor.Controls.Add(pnlFooter);
            grpAddVendor.Controls.Add(lblVendorName);
            grpAddVendor.Controls.Add(txtVendorName);
            grpAddVendor.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpAddVendor.ForeColor = Color.SteelBlue;
            grpAddVendor.Location = new Point(12, 12);
            grpAddVendor.Name = "grpAddVendor";
            grpAddVendor.Size = new Size(833, 217);
            grpAddVendor.TabIndex = 1;
            grpAddVendor.TabStop = false;
            grpAddVendor.Text = "Add Vendor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(79, 124);
            label4.Name = "label4";
            label4.Size = new Size(15, 18);
            label4.TabIndex = 12;
            label4.Text = "*";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(142, 98);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(286, 67);
            txtAddress.TabIndex = 13;
            txtAddress.Text = "";
            txtAddress.Validated += Common_Validated;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.ControlText;
            lblAddress.Location = new Point(6, 123);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 19);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(546, 69);
            label10.Name = "label10";
            label10.Size = new Size(15, 18);
            label10.TabIndex = 9;
            label10.Text = "*";
            // 
            // txtMobileNo
            // 
            txtMobileNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMobileNo.Location = new Point(572, 65);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.PlaceholderText = "Enter contact no";
            txtMobileNo.Size = new Size(235, 26);
            txtMobileNo.TabIndex = 10;
            txtMobileNo.KeyPress += Common_KeyPress;
            txtMobileNo.Validated += Common_Validated;
            // 
            // lblMobileNo
            // 
            lblMobileNo.AutoSize = true;
            lblMobileNo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMobileNo.ForeColor = SystemColors.ControlText;
            lblMobileNo.Location = new Point(452, 68);
            lblMobileNo.Name = "lblMobileNo";
            lblMobileNo.Size = new Size(89, 19);
            lblMobileNo.TabIndex = 8;
            lblMobileNo.Text = "Contact No :";
            // 
            // txtPANNo
            // 
            txtPANNo.CharacterCasing = CharacterCasing.Upper;
            txtPANNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPANNo.Location = new Point(571, 140);
            txtPANNo.Name = "txtPANNo";
            txtPANNo.PlaceholderText = "Enter PAN no";
            txtPANNo.Size = new Size(236, 26);
            txtPANNo.TabIndex = 17;
            txtPANNo.Validated += Common_Validated;
            // 
            // lblPan
            // 
            lblPan.AutoSize = true;
            lblPan.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPan.ForeColor = SystemColors.ControlText;
            lblPan.Location = new Point(451, 140);
            lblPan.Name = "lblPan";
            lblPan.Size = new Size(65, 19);
            lblPan.TabIndex = 16;
            lblPan.Text = "PAN No :";
            // 
            // txtGSTNo
            // 
            txtGSTNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGSTNo.Location = new Point(571, 104);
            txtGSTNo.Name = "txtGSTNo";
            txtGSTNo.PlaceholderText = "Enter GST no";
            txtGSTNo.Size = new Size(236, 26);
            txtGSTNo.TabIndex = 15;
            txtGSTNo.Validated += Common_Validated;
            // 
            // lblGSTNo
            // 
            lblGSTNo.AutoSize = true;
            lblGSTNo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGSTNo.ForeColor = SystemColors.ControlText;
            lblGSTNo.Location = new Point(452, 104);
            lblGSTNo.Name = "lblGSTNo";
            lblGSTNo.Size = new Size(64, 19);
            lblGSTNo.TabIndex = 14;
            lblGSTNo.Text = "GST No :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlText;
            lblEmail.Location = new Point(6, 178);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 18);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email Id :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Calibri", 11.25F);
            txtEmail.Location = new Point(142, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Please enter email id";
            txtEmail.Size = new Size(286, 26);
            txtEmail.TabIndex = 19;
            txtEmail.Validated += Common_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(119, 70);
            label1.Name = "label1";
            label1.Size = new Size(15, 18);
            label1.TabIndex = 6;
            label1.Text = "*";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactName.ForeColor = SystemColors.ControlText;
            lblContactName.Location = new Point(6, 68);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(108, 18);
            lblContactName.TabIndex = 5;
            lblContactName.Text = "Contact Person :";
            // 
            // txtContactName
            // 
            txtContactName.Font = new Font("Calibri", 11.25F);
            txtContactName.Location = new Point(142, 65);
            txtContactName.Name = "txtContactName";
            txtContactName.PlaceholderText = "Please enter Contact person name";
            txtContactName.Size = new Size(286, 26);
            txtContactName.TabIndex = 7;
            txtContactName.Validated += Common_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(119, 34);
            label3.Name = "label3";
            label3.Size = new Size(15, 18);
            label3.TabIndex = 3;
            label3.Text = "*";
            // 
            // pnlFooter
            // 
            pnlFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Location = new Point(460, 169);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(367, 41);
            pnlFooter.TabIndex = 20;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Image = Properties.Resources.Exit;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(224, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 30);
            btnCancel.TabIndex = 22;
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
            btnSave.Location = new Point(81, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 32);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save && Update";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblVendorName
            // 
            lblVendorName.AutoSize = true;
            lblVendorName.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVendorName.ForeColor = SystemColors.ControlText;
            lblVendorName.Location = new Point(6, 32);
            lblVendorName.Name = "lblVendorName";
            lblVendorName.Size = new Size(100, 18);
            lblVendorName.TabIndex = 2;
            lblVendorName.Text = "Vendor Name :";
            // 
            // txtVendorName
            // 
            txtVendorName.Font = new Font("Calibri", 11.25F);
            txtVendorName.Location = new Point(142, 29);
            txtVendorName.Name = "txtVendorName";
            txtVendorName.PlaceholderText = "Please enter vendor name";
            txtVendorName.Size = new Size(469, 26);
            txtVendorName.TabIndex = 4;
            txtVendorName.Validated += Common_Validated;
            // 
            // validationerrors
            // 
            validationerrors.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            validationerrors.ContainerControl = this;
            validationerrors.Icon = (Icon)resources.GetObject("validationerrors.Icon");
            // 
            // frmAddVendor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(857, 519);
            Controls.Add(pnlMain);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddVendor";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendor Details";
            Load += frmAddVendor_Load;
            pnlMain.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVendorDettails).EndInit();
            grpAddVendor.ResumeLayout(false);
            grpAddVendor.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)validationerrors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private GroupBox grpAddVendor;
        private Panel pnlFooter;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private Label lblVendorName;
        private TextBox txtVendorName;
        private Label label1;
        private Label lblContactName;
        private TextBox txtContactName;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtGSTNo;
        private Label lblGSTNo;
        private TextBox txtPANNo;
        private Label lblPan;
        private Label label10;
        private TextBox txtMobileNo;
        private Label lblMobileNo;
        private Label label4;
        private RichTextBox txtAddress;
        private Label lblAddress;
        private Panel pnlGrid;
        private UserControls.Status stsMessage;
        private DataGridView dgvVendorDettails;
        private DataGridViewTextBoxColumn SrNo;
        private ErrorProvider validationerrors;
    }
}