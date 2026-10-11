using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Client.UI.UserControls
{
    public class ResizeControls
    {

        public static void SetLocation(Panel pnlGrid, UserControl stsMessage)
        {
            try
            {
                int x = (pnlGrid.Width - stsMessage.Width) / 2;
                int y = (pnlGrid.Height - stsMessage.Height) / 2;
                stsMessage.Location = new System.Drawing.Point(x, y);
            }
            catch (Exception ex) { }
        }

        public static void SetFormPosition(Form  frmForm)
        {
            try
            {
                var screen = Screen.FromControl(frmForm);
                int screenWidth = screen.WorkingArea.Width;
                int screenHeight = screen.WorkingArea.Height;

                int x= (screenWidth - frmForm.Width) / 2;
                int y= (screenHeight - frmForm.Height) / 2;

                frmForm.StartPosition = FormStartPosition.Manual;
                frmForm.Left = x;
                frmForm.Top = y;
            }
            catch (Exception ex) { }
        }

    }
}
