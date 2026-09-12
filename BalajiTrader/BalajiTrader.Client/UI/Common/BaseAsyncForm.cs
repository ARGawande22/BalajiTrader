using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalajiTrader.Client.UI.Common
{
    public partial class BaseAsyncForm : Form
    {
        // Each derived form overrides this to specify which control gets focus on F2/Ctrl+F
        protected virtual Control ShortcutFocusControl => null;

        // Each derived form overrides this to do cleanup (cancel tokens, hide loaders, etc.) before closing on Escape
        protected virtual void OnEscapePressed()
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2 || keyData == (Keys.Control | Keys.F))
            {
                if (ShortcutFocusControl != null)
                {
                    ShortcutFocusControl.Focus();
                    if (ShortcutFocusControl is TextBoxBase tb)
                        tb.SelectAll();
                }
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                OnEscapePressed();
                return true; // handled — don't fall through to base
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        //Token Cancellation
        protected CancellationTokenSource _cts;

        protected void ResetCancellation()
        {
            _cts?.Cancel();
            _cts = new CancellationTokenSource();
        }

        protected CancellationToken Token => _cts?.Token ?? CancellationToken.None;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Cancel running async operations
            _cts?.Cancel();

            base.OnFormClosing(e);
        }
    }
}
