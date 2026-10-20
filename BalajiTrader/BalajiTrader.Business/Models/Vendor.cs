using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Business.Models
{
    public class Vendor
    {
        #region local Veriable
        private int _vendorId;
        private string _vendorName;
        private string _contactName;
        private string _contactNo;
        private string _address;
        private string _gstNo;
        private string _panNo;
        private string _emailId;
        private int _status;
        private int _createdBy;
        private DateTime _createdOn;
        #endregion

        #region Properties 
        public int VendorId
        {
            get { return _vendorId; }
            set { _vendorId = value; }
        }

        public string VendorName
        {
            get { return _vendorName; }
            set { _vendorName = value; }
        }

        public string ContactName
        {
            get { return _contactName; }
            set { _contactName = value; }
        }

        public string ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string GSTNo
        {
            get { return _gstNo; }
            set { _gstNo = value; }
        }

        public string PANNo
        {
            get { return _panNo; }
            set { _panNo = value; }
        }

        public string EmailId
        {
            get { return _emailId; }
            set { _emailId = value; }
        }

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public int CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public DateTime CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }
        #endregion
    }
}
