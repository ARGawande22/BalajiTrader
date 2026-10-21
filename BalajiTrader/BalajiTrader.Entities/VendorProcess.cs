using BalajiTrader.Business;
using BalajiTrader.Business.Classes;
using BalajiTrader.Business.Models;
using BalajiTrader.Data;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BalajiTrader.Business.Models.Common;

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

        public static void GetAllVendors(int vendorId=0)
        {
            try
            {
                DataSet ds = BOFactory.VendorBO.GetVendors(vendorId);
                DataTable vendor = ds != null ? ds.Tables[0] : null;
                if (vendor != null && vendor.Rows.Count != 0)
                {
                    _vendors = new List<Vendor>();
                    for (int i = 0; i < vendor.Rows.Count; i++)
                    {
                        Vendor _tmpVendor = new Vendor
                        {
                            VendorId = Validations.ConvertToInt(vendor.Rows[i]["VendorId"].ToString()),
                            VendorName = vendor.Rows[i]["VendorName"].ToString(),
                            ContactName = vendor.Rows[i]["ContactName"].ToString(),
                            ContactNo = vendor.Rows[i]["Phone"].ToString(),
                            Address = vendor.Rows[i]["Address"].ToString(),
                            GSTNo = vendor.Rows[i]["GSTIN"].ToString(),
                            PANNo = vendor.Rows[i]["PANNo"].ToString(),
                            EmailId = vendor.Rows[i]["Emaild"].ToString(),
                            Status = Validations.ConvertToInt(vendor.Rows[i]["IsActive"].ToString()),
                            CreatedOn = Validations.ConvertDateTime(vendor.Rows[i]["CreatedAt"].ToString())
                        };
                        _vendors.Add(_tmpVendor);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Info("Error getting vendor. " + ex.Message);
            }

        }

        public static bool EnableDisableVendor(int vendorId, string Status)
        {
            return BOFactory.VendorBO.EnableDisableVendor(vendorId, Status);
        }

        #region Linq Methods
        public static List<Vendor> GetVendors(int vendorId = 0)
        {
            List<Vendor> _vendors = new List<Vendor>();

            _vendors = (from v in Vendors
                       where ((v.VendorId == vendorId || vendorId == 0))
                       orderby v.VendorName
                       select v).ToList();

            return _vendors;
        }

        public static Vendor VendorCopy(Vendor vendor)
        {
            Vendor _tmpvendor = new Vendor
            {
                VendorId = vendor.VendorId,
                VendorName = vendor.VendorName,
                ContactName = vendor.ContactName,
                ContactNo = vendor.ContactNo,
                Address= vendor.Address,
                GSTNo = vendor.GSTNo,
                PANNo = vendor.PANNo,
                EmailId = vendor.EmailId,
                Status = vendor.Status,
                CreatedOn = vendor.CreatedOn
            };
            return _tmpvendor;
        }
        #endregion
        #endregion

    }
}
