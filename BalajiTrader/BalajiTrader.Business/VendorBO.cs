using BalajiTrader.Business.Interface;
using BalajiTrader.Data;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Business
{
    public class VendorBO : IVendorBO
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(VendorBO));

        public bool AddUpdateVendor(int vendorId, string vendorName, string contactName, string contactNo, string address, string gstNo, string panNo, string emailId)
        {
            return DAOFactory.VendorDAO.AddUpdateVendor(vendorId, vendorName, contactName, contactNo, address, gstNo, panNo, emailId);
        }

        public DataSet GetVendors(int vendorId)
        {
            return DAOFactory.VendorDAO.GetVendors(vendorId);
        }

        public bool EnableDisableVendor(int vendorId, string Status)
        {
            return DAOFactory.VendorDAO.EnableDisableVendor(vendorId, Status);
        }
    }
}
