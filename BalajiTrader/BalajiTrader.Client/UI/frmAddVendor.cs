using BalajiTrader.Business.Classes;
using BalajiTrader.Business.Models;
using BalajiTrader.Client.UI.Common;
using BalajiTrader.Client.UI.Masters;
using BalajiTrader.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BalajiTrader.Business.Models.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BalajiTrader.Client.UI
{
    public partial class frmAddVendor : BaseAsyncForm
    {
        #region Instance variables
        private static readonly ILog log = LogManager.GetLogger(typeof(frmAddVendor));

        public bool FStatus { get; set; }
        ToolTip toolTip1 = new ToolTip();
        private ValidationProcess _process;

        public static List<Vendor> _vendors;
        private Vendor _vendor = null;
        private int _vendorId = 0;
        private string _event = "New";
        #endregion
        public frmAddVendor()
        {
            InitializeComponent();
            _process = new ValidationProcess();
            _vendor = new Vendor();
            _vendorId = 0;
            VendorProcess.Vendors = _vendors;
            _event = "New";
        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        #region Form Events
        private void frmAddVendor_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetVendorObject();
            if (BindValidationsToControl())
            {
                if (VendorProcess.AddUpdateVendor(_vendorId, _vendor.VendorName, _vendor.ContactName,_vendor.ContactNo,_vendor.Address,_vendor.GSTNo,_vendor.PANNo,_vendor.EmailId))
                {
                    MessageBox.Show(string.Format("Vendor details {0} successfully..!", _event == "New" ? "inserted" : "updated"), Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FStatus = true;
                    Clear();
                    //refreshData();
                }
                else
                {
                    MessageBox.Show(string.Format("Error {0} vendor details..! \n{1}", _event == "New" ? "inserting" : "updating", Constant.assistance),
                        Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FStatus = false;
                }
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Common_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.ValidateEnteredIsNumeric(e);
        }

        private void Common_Validated(object sender, EventArgs e)
        {
            GetVendorObject();
            BindValidationsToControl();
        }
        #endregion

        #region Methods
        private void GetVendorObject()
        {
            //Get the User details
            _vendor.VendorId = _vendorId;
            _vendor.VendorName = txtVendorName.Text;
            _vendor.ContactName = txtContactName.Text;
            _vendor.ContactNo = txtMobileNo.Text;
            _vendor.Address=txtAddress.Text;
            _vendor.GSTNo = txtGSTNo.Text;
            _vendor.PANNo = txtPANNo.Text;
            _vendor.EmailId = txtEmail.Text;
        }

        private bool BindValidationsToControl()
        {
            VendorProcess.AddVendor = _vendor;
            ValidationErrors validateErrors = _process.VendorValidation;

            validationerrors.SetError(txtVendorName, validateErrors.GetMessageByProperty(Constant.VendorNameKey));
            validationerrors.SetError(txtContactName, validateErrors.GetMessageByProperty(Constant.NameKey));
            validationerrors.SetError(txtMobileNo, validateErrors.GetMessageByProperty(Constant.MobileKey));
            validationerrors.SetError(txtAddress, validateErrors.GetMessageByProperty(Constant.AddressKey));
            validationerrors.SetError(txtGSTNo, validateErrors.GetMessageByProperty(Constant.GSTKey));
            validationerrors.SetError(txtEmail, validateErrors.GetMessageByProperty(Constant.EmailKey));
            validationerrors.SetError(txtPANNo, validateErrors.GetMessageByProperty(Constant.PANKey));

            if (validateErrors.Count == 0)
                return true;
            else
                return false;
        }

        private void Clear()
        {
            _vendorId = 0;
            txtVendorName.Clear();
            txtContactName.Clear();
            txtMobileNo.Clear();
            txtAddress.Clear();
            txtGSTNo.Clear();
            txtPANNo.Clear();
            txtEmail.Clear();
        }
        #endregion


    }
}
