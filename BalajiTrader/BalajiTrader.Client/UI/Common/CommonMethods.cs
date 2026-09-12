using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Client.UI.Common
{
    public class CommonMethods
    {
        /// <summary>
        /// Allow only numeric value
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool ValidateEnteredIsNumeric(KeyPressEventArgs e)
        {
            return e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

    }
}
