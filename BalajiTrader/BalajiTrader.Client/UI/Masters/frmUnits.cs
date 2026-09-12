using BalajiTrader.Client.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalajiTrader.Client.UI.Masters
{
    public partial class frmUnits : BaseAsyncForm
    {
        public frmUnits()
        {
            InitializeComponent();
        }

        protected override void OnEscapePressed()
        {
            Close();
        }
    }
}
