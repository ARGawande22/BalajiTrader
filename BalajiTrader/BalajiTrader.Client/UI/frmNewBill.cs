using BalajiTrader.Client.UI.Common;
using BalajiTrader.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace BalajiTrader.Client.UI
{
    public partial class frmNewBill : BaseAsyncForm
    {
        #region Instance variables
        private static readonly ILog log = LogManager.GetLogger(typeof(frmNewBill));

        public bool FStatus { get; set; }
        ToolTip toolTip1 = new ToolTip();
        private ValidationProcess _process;
        #endregion

        public frmNewBill()
        {
            InitializeComponent();
        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        private void frmNewBill_Load(object sender, EventArgs e)
        {
            Line();
        }

        public void Line()
        {
            lblLine.AutoSize = false;
            lblLine.Height = 2;
            lblLine.BorderStyle = BorderStyle.Fixed3D;
            lblLine.Width = 995;
            lblLine.BackColor = Color.Black;
        }
    }
}
