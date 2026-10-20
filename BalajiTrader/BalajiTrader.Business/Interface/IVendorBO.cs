using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Business.Interface
{
    interface IVendorBO
    {
        bool AddUpdateVendor(int vendorId, string vendorName, string contactName, string contactNo, string address, string gstNo, string panNo, string emailId);
    }
}
