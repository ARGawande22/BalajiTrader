using BalajiTrader.Client.UI.Common;
using BalajiTrader.Client.UI.Masters;
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
    public partial class frmAddClient: BaseAsyncForm
    {
        #region Instance variables
        private static readonly ILog log = LogManager.GetLogger(typeof(frmAddClient));

        public bool FStatus { get; set; }
        ToolTip toolTip1 = new ToolTip();
        private ValidationProcess _process;
        #endregion
        public frmAddClient()
        {
            InitializeComponent();
        }

        protected override void OnEscapePressed()
        {
            Close();
        }
    }
}
