using BalajiTrader.Data.Interface;
using BalajiTrader.DataAccess;
using log4net;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Data
{
    public class VendorDAO : BaseDAO, IVendorDAO
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(VendorDAO));

        public bool AddUpdateVendor(int vendorId, string vendorName, string contactName, string contactNo, string address, string gstNo, string panNo, string emailId)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@vendorId",vendorId),
                    new SqlParameter("@vendorName",vendorName),
                    new SqlParameter("@contactName",contactName),
                    new SqlParameter("@contactNo",contactNo),
                    new SqlParameter("@address",address),
                    new SqlParameter("@gstNo",gstNo),
                    new SqlParameter("@panNo",panNo),
                    new SqlParameter("@emailId",emailId)
                };

                ExecuteNonQuery(StoreProcedures.AddUpdateVendor, parameters);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return false;
            }
        }
    }
}
