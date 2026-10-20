using BalajiTrader.Business;
using BalajiTrader.Business.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Entities
{
    public class VendorProcess
    {
        #region Instance Variables
        private static readonly ILog log = LogManager.GetLogger(typeof(VendorProcess));

        public static List<Vendor> _vendors;
        public static Vendor _addVendor = null;
        #endregion

        #region Prperties
        public static List<Vendor> Vendors
        {
            get { return _vendors; }
            set { _vendors = value; }
        }

        public static Vendor AddVendor
        {
            get { return _addVendor; }
            set { _addVendor = value; }
        }
        #endregion

        #region Post Method
        public static bool AddUpdateVendor(int vendorId, string vendorName,string contactName,string contactNo,string address, string gstNo,string panNo,string emailId)
        {
            return BOFactory.VendorBO.AddUpdateVendor(vendorId, vendorName, contactName, contactNo, address, gstNo, panNo, emailId);
        }
        #endregion

    }
}
