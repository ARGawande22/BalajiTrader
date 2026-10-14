namespace BalajiTrader.Client.UI.Masters
{
    partial class frmShopDetails
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
            pnlFooter = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            grpShopDetails = new GroupBox();
            btnRemove = new Button();
            btnBrowse = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            txtPANNo = new TextBox();
            lblPan = new Label();
            txtGSTNo = new TextBox();
            lblGSTNo = new Label();
            txtWebSite = new TextBox();
            lblWebsite = new Label();
            label13 = new Label();
            txtPinCode = new TextBox();
            lblPincode = new Label();
            label10 = new Label();
            txtEmailId = new TextBox();
            lblEmail = new Label();
            txtMobileNo = new TextBox();
            lblMobileNo = new Label();
            label4 = new Label();
            txtShopAddress = new RichTextBox();
            lblShopAddress = new Label();
            label1 = new Label();
            lblOwnerName = new Label();
            txtOwnerName = new TextBox();
            label3 = new Label();
            lbShopName = new Label();
            txtShopName = new TextBox();
            pnlMain.SuspendLayout();
            pnlFooter.SuspendLayout();
            grpShopDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlFooter);
            pnlMain.Controls.Add(grpShopDetails);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 487);
            pnlMain.TabIndex = 0;
            // 
            // pnlFooter
            // 
            pnlFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Location = new Point(12, 440);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(776, 41);
            pnlFooter.TabIndex = 27;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Image = Properties.Resources.Exit;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(690, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 30);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.Save_Update;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(547, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 32);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save && Update";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // grpShopDetails
            // 
            grpShopDetails.Controls.Add(btnRemove);
            grpShopDetails.Controls.Add(btnBrowse);
            grpShopDetails.Controls.Add(pictureBox1);
            grpShopDetails.Controls.Add(label5);
            grpShopDetails.Controls.Add(txtPANNo);
            grpShopDetails.Controls.Add(lblPan);
            grpShopDetails.Controls.Add(txtGSTNo);
            grpShopDetails.Controls.Add(lblGSTNo);
            grpShopDetails.Controls.Add(txtWebSite);
            grpShopDetails.Controls.Add(lblWebsite);
            grpShopDetails.Controls.Add(label13);
            grpShopDetails.Controls.Add(txtPinCode);
            grpShopDetails.Controls.Add(lblPincode);
            grpShopDetails.Controls.Add(label10);
            grpShopDetails.Controls.Add(txtEmailId);
            grpShopDetails.Controls.Add(lblEmail);
            grpShopDetails.Controls.Add(txtMobileNo);
            grpShopDetails.Controls.Add(lblMobileNo);
            grpShopDetails.Controls.Add(label4);
            grpShopDetails.Controls.Add(txtShopAddress);
            grpShopDetails.Controls.Add(lblShopAddress);
            grpShopDetails.Controls.Add(label1);
            grpShopDetails.Controls.Add(lblOwnerName);
            grpShopDetails.Controls.Add(txtOwnerName);
            grpShopDetails.Controls.Add(label3);
            grpShopDetails.Controls.Add(lbShopName);
            grpShopDetails.Controls.Add(txtShopName);
            grpShopDetails.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpShopDetails.ForeColor = Color.SteelBlue;
            grpShopDetails.Location = new Point(12, 12);
            grpShopDetails.Name = "grpShopDetails";
            grpShopDetails.Size = new Size(776, 422);
            grpShopDetails.TabIndex = 1;
            grpShopDetails.TabStop = false;
            grpShopDetails.Text = "Shop Details";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.WhiteSmoke;
            btnRemove.Font = new Font("Calibri", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.Red;
            btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemove.Location = new Point(688, 199);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(69, 30);
            btnRemove.TabIndex = 26;
            btnRemove.Text = "Remove....";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.WhiteSmoke;
            btnBrowse.Font = new Font("Calibri", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBrowse.ForeColor = Color.SteelBlue;
            btnBrowse.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrowse.Location = new Point(611, 199);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(74, 30);
            btnBrowse.TabIndex = 25;
            btnBrowse.Text = "Browse....";
            btnBrowse.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(610, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 103);
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(547, 133);
            label5.Name = "label5";
            label5.Size = new Size(40, 19);
            label5.TabIndex = 23;
            label5.Text = "Logo";
            // 
            // txtPANNo
            // 
            txtPANNo.CharacterCasing = CharacterCasing.Upper;
            txtPANNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPANNo.Location = new Point(152, 385);
            txtPANNo.Name = "txtPANNo";
            txtPANNo.PlaceholderText = "Enter PAN no";
            txtPANNo.Size = new Size(160, 26);
            txtPANNo.TabIndex = 23;
            // 
            // lblPan
            // 
            lblPan.AutoSize = true;
            lblPan.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPan.ForeColor = SystemColors.ControlText;
            lblPan.Location = new Point(15, 385);
            lblPan.Name = "lblPan";
            lblPan.Size = new Size(65, 19);
            lblPan.TabIndex = 22;
            lblPan.Text = "PAN No :";
            // 
            // txtGSTNo
            // 
            txtGSTNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGSTNo.Location = new Point(152, 349);
            txtGSTNo.Name = "txtGSTNo";
            txtGSTNo.PlaceholderText = "Enter GST no";
            txtGSTNo.Size = new Size(276, 26);
            txtGSTNo.TabIndex = 21;
            // 
            // lblGSTNo
            // 
            lblGSTNo.AutoSize = true;
            lblGSTNo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGSTNo.ForeColor = SystemColors.ControlText;
            lblGSTNo.Location = new Point(16, 349);
            lblGSTNo.Name = "lblGSTNo";
            lblGSTNo.Size = new Size(64, 19);
            lblGSTNo.TabIndex = 20;
            lblGSTNo.Text = "GST No :";
            // 
            // txtWebSite
            // 
            txtWebSite.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWebSite.Location = new Point(152, 310);
            txtWebSite.Name = "txtWebSite";
            txtWebSite.PlaceholderText = "Enter website URL";
            txtWebSite.Size = new Size(344, 26);
            txtWebSite.TabIndex = 19;
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWebsite.ForeColor = SystemColors.ControlText;
            lblWebsite.Location = new Point(15, 310);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(70, 19);
            lblWebsite.TabIndex = 18;
            lblWebsite.Text = "WebSite :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(96, 187);
            label13.Name = "label13";
            label13.Size = new Size(15, 18);
            label13.TabIndex = 11;
            label13.Text = "*";
            // 
            // txtPinCode
            // 
            txtPinCode.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPinCode.Location = new Point(152, 187);
            txtPinCode.Name = "txtPinCode";
            txtPinCode.PlaceholderText = "Enter pincode";
            txtPinCode.Size = new Size(160, 26);
            txtPinCode.TabIndex = 12;
            // 
            // lblPincode
            // 
            lblPincode.AutoSize = true;
            lblPincode.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPincode.ForeColor = SystemColors.ControlText;
            lblPincode.Location = new Point(16, 187);
            lblPincode.Name = "lblPincode";
            lblPincode.Size = new Size(74, 19);
            lblPincode.TabIndex = 10;
            lblPincode.Text = "Pin Code :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(109, 227);
            label10.Name = "label10";
            label10.Size = new Size(15, 18);
            label10.TabIndex = 14;
            label10.Text = "*";
            // 
            // txtEmailId
            // 
            txtEmailId.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailId.Location = new Point(152, 270);
            txtEmailId.Name = "txtEmailId";
            txtEmailId.PlaceholderText = "Enter e-mail id";
            txtEmailId.Size = new Size(344, 26);
            txtEmailId.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlText;
            lblEmail.Location = new Point(15, 270);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(69, 19);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email Id :";
            // 
            // txtMobileNo
            // 
            txtMobileNo.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMobileNo.Location = new Point(152, 226);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.PlaceholderText = "Enter contact no";
            txtMobileNo.Size = new Size(160, 26);
            txtMobileNo.TabIndex = 15;
            // 
            // lblMobileNo
            // 
            lblMobileNo.AutoSize = true;
            lblMobileNo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMobileNo.ForeColor = SystemColors.ControlText;
            lblMobileNo.Location = new Point(15, 226);
            lblMobileNo.Name = "lblMobileNo";
            lblMobileNo.Size = new Size(89, 19);
            lblMobileNo.TabIndex = 13;
            lblMobileNo.Text = "Contact No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(89, 134);
            label4.Name = "label4";
            label4.Size = new Size(15, 18);
            label4.TabIndex = 8;
            label4.Text = "*";
            // 
            // txtShopAddress
            // 
            txtShopAddress.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShopAddress.Location = new Point(152, 108);
            txtShopAddress.Name = "txtShopAddress";
            txtShopAddress.Size = new Size(344, 67);
            txtShopAddress.TabIndex = 9;
            txtShopAddress.Text = "";
            // 
            // lblShopAddress
            // 
            lblShopAddress.AutoSize = true;
            lblShopAddress.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShopAddress.ForeColor = SystemColors.ControlText;
            lblShopAddress.Location = new Point(16, 133);
            lblShopAddress.Name = "lblShopAddress";
            lblShopAddress.Size = new Size(69, 19);
            lblShopAddress.TabIndex = 7;
            lblShopAddress.Text = "Address :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(129, 76);
            label1.Name = "label1";
            label1.Size = new Size(15, 18);
            label1.TabIndex = 5;
            label1.Text = "*";
            // 
            // lblOwnerName
            // 
            lblOwnerName.AutoSize = true;
            lblOwnerName.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOwnerName.ForeColor = SystemColors.ControlText;
            lblOwnerName.Location = new Point(16, 74);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(97, 18);
            lblOwnerName.TabIndex = 4;
            lblOwnerName.Text = "Owner Name :";
            // 
            // txtOwnerName
            // 
            txtOwnerName.Font = new Font("Calibri", 11.25F);
            txtOwnerName.Location = new Point(152, 71);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.PlaceholderText = "Please enter owner name";
            txtOwnerName.Size = new Size(344, 26);
            txtOwnerName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(129, 40);
            label3.Name = "label3";
            label3.Size = new Size(15, 18);
            label3.TabIndex = 2;
            label3.Text = "*";
            // 
            // lbShopName
            // 
            lbShopName.AutoSize = true;
            lbShopName.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbShopName.ForeColor = SystemColors.ControlText;
            lbShopName.Location = new Point(16, 38);
            lbShopName.Name = "lbShopName";
            lbShopName.Size = new Size(86, 18);
            lbShopName.TabIndex = 1;
            lbShopName.Text = "Shop Name :";
            // 
            // txtShopName
            // 
            txtShopName.Font = new Font("Calibri", 11.25F);
            txtShopName.Location = new Point(152, 35);
            txtShopName.Name = "txtShopName";
            txtShopName.PlaceholderText = "Please enter shop name";
            txtShopName.Size = new Size(604, 26);
            txtShopName.TabIndex = 3;
            // 
            // frmShopDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 487);
            Controls.Add(pnlMain);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShopDetails";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Details";
            pnlMain.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            grpShopDetails.ResumeLayout(false);
            grpShopDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private GroupBox grpShopDetails;
        private Panel pnlFooter;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private Label lbShopName;
        private TextBox txtShopName;
        private Label label1;
        private Label lblOwnerName;
        private TextBox txtOwnerName;
        private Label label4;
        private RichTextBox txtShopAddress;
        private Label lblShopAddress;
        private Label label13;
        private TextBox txtPinCode;
        private Label lblPincode;
        private Label label10;
        private TextBox txtEmailId;
        private Label lblEmail;
        private TextBox txtMobileNo;
        private Label lblMobileNo;
        private TextBox txtWebSite;
        private Label lblWebsite;
        private TextBox txtGSTNo;
        private Label lblGSTNo;
        private TextBox txtPANNo;
        private Label lblPan;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btnBrowse;
        private Button btnRemove;
    }
}