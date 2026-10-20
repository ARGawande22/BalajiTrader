using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Data
{
    public class DAOFactory
    {
        #region singleton instance reference
        private static CommonDAO _commonDAO;
        private static ProductDAO _productDAO;
        private static VendorDAO _vendorDAO;
        #endregion

        public static CommonDAO CommonDAO
        {
            get { return _commonDAO ?? (_commonDAO = new CommonDAO()); }
        }

        public static ProductDAO ProductDAO
        {
            get { return _productDAO ?? (_productDAO = new ProductDAO()); }
        }

        public static VendorDAO VendorDAO
        {
            get { return _vendorDAO ?? (_vendorDAO = new VendorDAO()); }
        }
    }
}
