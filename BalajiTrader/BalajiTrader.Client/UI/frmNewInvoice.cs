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

namespace BalajiTrader.Client.UI
{
    public partial class frmNewInvoice : BaseAsyncForm
    {
        #region Instance variables
        private static readonly ILog log = LogManager.GetLogger(typeof(frmNewInvoice));

        public bool FStatus { get; set; }
        ToolTip toolTip1 = new ToolTip();
        private ValidationProcess _process;
        #endregion

        public frmNewInvoice()
        {
            InitializeComponent();
        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        private void frmNewInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
