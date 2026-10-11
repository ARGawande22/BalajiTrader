namespace BalajiTrader.Client.UI.Masters
{
    partial class frmGSTMaster
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
            panel1 = new Panel();
            pnlGrid = new Panel();
            stsMessage = new UserControls.Status();
            dgvGST = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            grpaddGST = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            lblPercentage = new Label();
            label13 = new Label();
            lblGSTName = new Label();
            txtGSTName = new TextBox();
            lblGSTPer = new Label();
            txtGSTPer = new TextBox();
            label10 = new Label();
            RightClickEvent = new ContextMenuStrip(components);
            tsSetAsDefault = new ToolStripMenuItem();
            panel1.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGST).BeginInit();
            grpaddGST.SuspendLayout();
            RightClickEvent.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlGrid);
            panel1.Controls.Add(grpaddGST);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 416);
            panel1.TabIndex = 0;
            // 
            // pnlGrid
            // 
            pnlGrid.BorderStyle = BorderStyle.FixedSingle;
            pnlGrid.Controls.Add(stsMessage);
            pnlGrid.Controls.Add(dgvGST);
            pnlGrid.Location = new Point(12, 162);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(479, 242);
            pnlGrid.TabIndex = 11;
            // 
            // stsMessage
            // 
            stsMessage.BackColor = Color.White;
            stsMessage.DisplayText = "Data not found for search criteria...!";
            stsMessage.Location = new Point(86, 42);
            stsMessage.MaximumSize = new Size(305, 140);
            stsMessage.MinimumSize = new Size(305, 140);
            stsMessage.Name = "stsMessage";
            stsMessage.Size = new Size(305, 140);
            stsMessage.TabIndex = 12;
            // 
            // dgvGST
            // 
            dgvGST.AllowUserToAddRows = false;
            dgvGST.AllowUserToResizeColumns = false;
            dgvGST.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dgvGST.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGST.BackgroundColor = Color.White;
            dgvGST.BorderStyle = BorderStyle.None;
            dgvGST.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGST.ColumnHeadersHeight = 35;
            dgvGST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGST.Columns.AddRange(new DataGridViewColumn[] { SrNo });
            dgvGST.Dock = DockStyle.Fill;
            dgvGST.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvGST.EnableHeadersVisualStyles = false;
            dgvGST.GridColor = Color.LightSteelBlue;
            dgvGST.Location = new Point(0, 0);
            dgvGST.Name = "dgvGST";
            dgvGST.ReadOnly = true;
            dgvGST.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dgvGST.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvGST.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvGST.Size = new Size(477, 240);
            dgvGST.TabIndex = 5;
            // 
            // SrNo
            // 
            SrNo.HeaderText = "Sr No.";
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            // 
            // grpaddGST
            // 
            grpaddGST.Controls.Add(btnCancel);
            grpaddGST.Controls.Add(btnSave);
            grpaddGST.Controls.Add(lblPercentage);
            grpaddGST.Controls.Add(label13);
            grpaddGST.Controls.Add(lblGSTName);
            grpaddGST.Controls.Add(txtGSTName);
            grpaddGST.Controls.Add(lblGSTPer);
            grpaddGST.Controls.Add(txtGSTPer);
            grpaddGST.Controls.Add(label10);
            grpaddGST.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpaddGST.ForeColor = Color.SteelBlue;
            grpaddGST.Location = new Point(12, 12);
            grpaddGST.Name = "grpaddGST";
            grpaddGST.Size = new Size(479, 144);
            grpaddGST.TabIndex = 1;
            grpaddGST.TabStop = false;
            grpaddGST.Text = "Add GST";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Image = Properties.Resources.Exit;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(394, 106);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 30);
            btnCancel.TabIndex = 10;
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
            btnSave.Location = new Point(251, 106);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 32);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save && Update";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentage.ForeColor = SystemColors.ControlText;
            lblPercentage.Location = new Point(254, 75);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(24, 23);
            lblPercentage.TabIndex = 8;
            lblPercentage.Text = "%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(107, 34);
            label13.Name = "label13";
            label13.Size = new Size(15, 18);
            label13.TabIndex = 3;
            label13.Text = "*";
            // 
            // lblGSTName
            // 
            lblGSTName.AutoSize = true;
            lblGSTName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGSTName.ForeColor = SystemColors.ControlText;
            lblGSTName.Location = new Point(17, 34);
            lblGSTName.Name = "lblGSTName";
            lblGSTName.Size = new Size(84, 19);
            lblGSTName.TabIndex = 2;
            lblGSTName.Text = "GST Name :";
            // 
            // txtGSTName
            // 
            txtGSTName.Font = new Font("Calibri", 12F);
            txtGSTName.Location = new Point(138, 31);
            txtGSTName.Name = "txtGSTName";
            txtGSTName.PlaceholderText = "Enter GST name";
            txtGSTName.Size = new Size(184, 27);
            txtGSTName.TabIndex = 4;
            // 
            // lblGSTPer
            // 
            lblGSTPer.AutoSize = true;
            lblGSTPer.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGSTPer.ForeColor = SystemColors.ControlText;
            lblGSTPer.Location = new Point(16, 73);
            lblGSTPer.Name = "lblGSTPer";
            lblGSTPer.Size = new Size(57, 19);
            lblGSTPer.TabIndex = 5;
            lblGSTPer.Text = "GST % :";
            // 
            // txtGSTPer
            // 
            txtGSTPer.Font = new Font("Calibri", 12F);
            txtGSTPer.Location = new Point(138, 73);
            txtGSTPer.Name = "txtGSTPer";
            txtGSTPer.PlaceholderText = "Enter GST %";
            txtGSTPer.Size = new Size(114, 27);
            txtGSTPer.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(86, 74);
            label10.Name = "label10";
            label10.Size = new Size(15, 18);
            label10.TabIndex = 6;
            label10.Text = "*";
            // 
            // RightClickEvent
            // 
            RightClickEvent.Items.AddRange(new ToolStripItem[] { tsSetAsDefault });
            RightClickEvent.Name = "RightClickEvent";
            RightClickEvent.Size = new Size(146, 26);
            // 
            // tsSetAsDefault
            // 
            tsSetAsDefault.Name = "tsSetAsDefault";
            tsSetAsDefault.Size = new Size(145, 22);
            tsSetAsDefault.Text = "Set as Default";
            // 
            // frmGSTMaster
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(503, 416);
            Controls.Add(panel1);
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGSTMaster";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GST Masters";
            panel1.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGST).EndInit();
            grpaddGST.ResumeLayout(false);
            grpaddGST.PerformLayout();
            RightClickEvent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grpaddGST;
        private Panel pnlGrid;
        private ContextMenuStrip RightClickEvent;
        private ToolStripMenuItem tsSetAsDefault;
        private Label label13;
        private Label lblGSTName;
        private TextBox txtGSTName;
        private Label lblGSTPer;
        private TextBox txtGSTPer;
        private Label label10;
        private Label lblPercentage;
        private Button btnCancel;
        private Button btnSave;
        private DataGridView dgvGST;
        private DataGridViewTextBoxColumn SrNo;
        private UserControls.Status stsMessage;
    }
}