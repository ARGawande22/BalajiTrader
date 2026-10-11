using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalajiTrader.Client.UI.UserControls
{
    public partial class Status : UserControl
    {
        public Status()
        {
            InitializeComponent();            
        }

        private void Status_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            lblMessage.Left = (pnlMain.Width - lblMessage.Width) / 2;
            picIcon.Left = (pnlMain.Width - picIcon.Width) / 2;
        }


        public string DisplayText
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        
    }
}
