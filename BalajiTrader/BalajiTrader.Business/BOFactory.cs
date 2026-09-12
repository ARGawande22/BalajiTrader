using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Business
{
    public static class BOFactory
    {
        #region singleton instance reference
        private static CommonBO _commonBO;
        #endregion

        public static CommonBO CommonBO
        {
            get { return _commonBO ?? (_commonBO = new CommonBO()); }
        }
    }
}
