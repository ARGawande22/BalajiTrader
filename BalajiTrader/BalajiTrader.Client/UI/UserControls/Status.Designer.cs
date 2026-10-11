namespace BalajiTrader.Client.UI.UserControls
{
    partial class Status
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            lblMessage = new Label();
            picIcon = new PictureBox();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lblMessage);
            pnlMain.Controls.Add(picIcon);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(305, 183);
            pnlMain.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(36, 117);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(228, 18);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Data not found for search criteria...!";
            // 
            // picIcon
            // 
            picIcon.Image = Properties.Resources.warning_70;
            picIcon.Location = new Point(115, 33);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(70, 70);
            picIcon.TabIndex = 0;
            picIcon.TabStop = false;
            // 
            // Status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlMain);
            Name = "Status";
            Size = new Size(305, 183);
            Load += Status_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private PictureBox picIcon;
        private Label lblMessage;
    }
}
