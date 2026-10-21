using BalajiTrader.Business;
using BalajiTrader.Business.Classes;
using BalajiTrader.Business.Models;
using BalajiTrader.Client.Common;
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
using System.Net;
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

        private int rowIndex, columnIndex, firstRowIndex = 0;
        string _message = string.Empty;
        #endregion
        public frmAddVendor()
        {
            InitializeComponent();
            _process = new ValidationProcess();
            _vendor = new Vendor();
            _vendorId = 0;
            VendorProcess.AddVendor = _vendor;
            _event = "New";
        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        #region Form Events
        private void frmAddVendor_Load(object sender, EventArgs e)
        {
            BindVendorsDetails(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetVendorObject();
            if (BindValidationsToControl())
            {
                if (VendorProcess.AddUpdateVendor(_vendorId, _vendor.VendorName, _vendor.ContactName, _vendor.ContactNo, _vendor.Address, _vendor.GSTNo, _vendor.PANNo, _vendor.EmailId))
                {
                    MessageBox.Show(string.Format("Vendor details {0} successfully..!", _event == "New" ? "inserted" : "updated"), Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FStatus = true;
                    Clear();
                    refreshData();
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
            VendorProcess.AddVendor = null;
            Clear();
            FStatus = false;
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
            _vendor.Address = txtAddress.Text;
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

        private void refreshData()
        {
            VendorProcess.GetAllVendors();
            BindVendorsDetails(0);
        }

        private void BindVendorsDetails(int vendorId)
        {
            List<Vendor> _tmpVendors = new List<Vendor>();
            _tmpVendors = VendorProcess.GetVendors(vendorId);

            _vendors = new List<Vendor>();
            foreach (Vendor _tmpvendor in _tmpVendors)
            {
                _vendors.Add(VendorProcess.VendorCopy(_tmpvendor));
            }

            if (_vendors.Count <= 0)
            {
                stsMessage.Visible = true;
                dgvVendorDetails.Visible = false;
                stsMessage.DisplayText = "Vendor data not found for 🔎 search criteria...!";
            }
            else
            {
                stsMessage.Visible = false;
                dgvVendorDetails.Visible = true;
            }

            var _list = _vendors.Select(vd => new
            {
                vd.VendorId,
                vd.VendorName,
                vd.ContactName,
                vd.ContactNo,
                vd.Address,
                vd.GSTNo,
                vd.PANNo,
                vd.EmailId,
                vd.Status,
                vd.CreatedOn
            }).ToList();

            dgvVendorDetails.DataSource = _list;
            BindGridOnReset();
        }

        #region DataridValidation
        public void BindGridOnReset()
        {
            try
            {
                GridValidations();
                AddButtonsToGrid();
                RemoveDisabledBrandButtons();
            }
            catch (Exception ex) { log.Error("Error while binding data to grid " + ex.Message); }
        }

        private void GridValidations()
        {
            try
            {
                int i = 1;
                foreach (DataGridViewRow row in dgvVendorDetails.Rows)
                {
                    row.Cells["SrNo"].Value = i;
                    i++;

                    row.DefaultCellStyle.Font = Fonts.DefaultFont;
                    row.DefaultCellStyle.BackColor = Fonts.DefaultBackColor;


                    //Highlight the CategoryName
                    //row.Cells["CategoryName"].Style.Font = Fonts.DefaultBold;
                }

                //Hide columns
                DataGridViewColumnCollection column = dgvVendorDetails.Columns;
                column["VendorId"].Visible = false;
                column["EmailId"].Visible = false;
                column["CreatedOn"].Visible = false;
                column["Status"].Visible = false;
                column["GSTNo"].Visible = false;
                column["PANNo"].Visible = false;

                //Setting up Column width
                column["SrNo"].Width = 50;
                column["VendorName"].Width = dgvVendorDetails.Rows.Count < 7 ? 220 : 203;
                column["ContactName"].Width = 140;
                column["ContactNo"].Width = 90;
                column["Address"].Width = 250;
                //column["GSTNo"].Width = 100;
                //column["PANNo"].Width = 80;

                //Setting up Header Text
                column["SrNo"].HeaderText = "Sr No";
                column["VendorName"].HeaderText = "Vendor Name";
                column["ContactName"].HeaderText = "Contact Name";
                column["ContactNo"].HeaderText = "Contact No";
                column["Address"].HeaderText = "Address";
                //column["GSTNo"].HeaderText = "GST No";
                //column["PANNo"].HeaderText = "PAN No";

                //column Read-Only
                column["SrNo"].ReadOnly = true;
                column["VendorName"].ReadOnly = true;
                column["ContactName"].ReadOnly = true;
                column["ContactNo"].ReadOnly = true;
                column["Address"].ReadOnly = true;
                //column["GSTNo"].ReadOnly = true;
                //column["PANNo"].ReadOnly = true;

                //Setting up Alignment
                column["SrNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["VendorName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["ContactName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["ContactNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column["Address"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                //column["GSTNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //column["PANNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex) { log.Error("Error applying validations on grid"); }
        }

        private void AddButtonsToGrid()
        {
            try
            {
                DataGridViewColumnCollection column = dgvVendorDetails.Columns;

                //Delete column before adding 
                if (dgvVendorDetails.Columns.Contains("Edit"))
                    dgvVendorDetails.Columns.Remove("Edit");

                //Add Edit Column
                DataGridViewImageColumn editImg = new DataGridViewImageColumn();
                editImg.HeaderText = "Edit";
                Image edit = Properties.Resources.edit;
                editImg.Image = edit;
                editImg.Name = "Edit";
                editImg.Width = 40;
                if (!dgvVendorDetails.Columns.Contains("Edit"))
                    dgvVendorDetails.Columns.Add(editImg);

                //Delete column before adding 
                if (dgvVendorDetails.Columns.Contains("Delete"))
                    dgvVendorDetails.Columns.Remove("Delete");

                //Add Delete Column
                DataGridViewImageColumn delImg = new DataGridViewImageColumn();
                delImg.HeaderText = "Disabled";
                Image del = Properties.Resources.enable;
                delImg.Image = del;
                delImg.Name = "Delete";
                delImg.Width = 40;
                if (!dgvVendorDetails.Columns.Contains("Delete"))
                    dgvVendorDetails.Columns.Add(delImg);

            }
            catch (Exception ex)
            {
                log.Error("Error while populating buttons in grid " + ex.Message);
            }
        }

        private void RemoveDisabledBrandButtons()
        {
            try
            {
                for (int i = 0; i < dgvVendorDetails.Rows.Count; i++)
                {
                    if (isDisabled(i))
                    {
                        dgvVendorDetails.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        dgvVendorDetails.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                        if (dgvVendorDetails.Columns.Contains("Edit"))
                            dgvVendorDetails.Rows[i].Cells["Edit"].Value = new Bitmap(1, 1);

                        if (dgvVendorDetails.Columns.Contains("Delete"))
                            dgvVendorDetails.Rows[i].Cells["Delete"].Value = Properties.Resources.disable;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Error removing disabled vendor buttons...!");
            }
        }

        private bool isDisabled(int r)
        {
            return dgvVendorDetails.Rows[r].Cells["Status"].Value.ToString() == "0";
        }
        #endregion

        #region Grid Event
        private void dgvVendorDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { }
        }

        private void dgvVendorDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex != 11 && e.ColumnIndex != 12) || e.RowIndex < 0 || ((e.ColumnIndex == 11) && isDisabled(e.RowIndex)))
                {
                    dgvVendorDetails.Cursor = Cursors.Default;
                    return;
                }

                dgvVendorDetails.Cursor = Cursors.Hand;
                var cell = dgvVendorDetails[e.ColumnIndex, e.RowIndex];
                if (e.ColumnIndex == 11)
                    cell.ToolTipText = "Edit Vendor details..!";
                else if (e.ColumnIndex == 12)
                    cell.ToolTipText = isDisabled(e.RowIndex) ? "Re-enable the vendor" : "Disable the vendor from here..!";
            }
            catch (Exception ex) { log.Error("Error on cell mouse enter :" + ex.Message); }
        }

        private void dgvVendorDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            else if ((e.ColumnIndex == 11) && isDisabled(e.RowIndex)) //It is only to prevent edit if the Vendor is disabled.
                return;
            else if (e.ColumnIndex == 11)
                EditVendor(e.RowIndex);
            else if (e.ColumnIndex == 12)
                EnableDisableVendor();
        }

        private void EditVendor(int r)
        {
            try
            {
                string VendorName = dgvVendorDetails.Rows[r].Cells["VendorName"].Value.ToString();
                _message = string.Format("Want to edit {0} vendor details.", VendorName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dialog == DialogResult.No)
                    return;

                _vendorId = Validations.ConvertToInt(dgvVendorDetails.Rows[r].Cells["VendorId"].Value.ToString());
                string ContactName = dgvVendorDetails.Rows[r].Cells["ContactName"].Value.ToString();
                string ContactNo = dgvVendorDetails.Rows[r].Cells["ContactNo"].Value.ToString();
                string Address = dgvVendorDetails.Rows[r].Cells["Address"].Value.ToString();
                string GSTNo = dgvVendorDetails.Rows[r].Cells["GSTNo"].Value.ToString();
                string PANNo = dgvVendorDetails.Rows[r].Cells["PANNo"].Value.ToString();
                string EmailId = dgvVendorDetails.Rows[r].Cells["EmailId"].Value.ToString();


                _event = "Edit";
                txtVendorName.Text = VendorName;
                txtContactName.Text = ContactName;
                txtMobileNo.Text = ContactNo;
                txtAddress.Text = Address;
                txtGSTNo.Text = GSTNo;
                txtPANNo.Text = PANNo;
                txtEmail.Text = EmailId;
            }
            catch (Exception ex) { log.Error("Error while editing vendor details :" + ex.Message); }
        }

        private void EnableDisableVendor()
        {
            try
            {
                string VendorName = dgvVendorDetails.Rows[rowIndex].Cells["VendorName"].Value.ToString();
                _message = String.Format("Want to {0} vendor: {1}", isDisabled(rowIndex) ? "Re-enable the" : "disable the", VendorName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (_dialog == DialogResult.No)
                    return;

                firstRowIndex = dgvVendorDetails.FirstDisplayedScrollingRowIndex;
                int vendorId = Validations.ConvertToInt(dgvVendorDetails.Rows[rowIndex].Cells["VendorId"].Value.ToString());
                string Status = isDisabled(rowIndex) ? "1" : "0";

                if (VendorProcess.EnableDisableVendor(vendorId, Status))
                {
                    _message = String.Format("Vendor {0} ", isDisabled(rowIndex) ? "Re-enable successfully...!" : "is disabled now..!");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                    dgvVendorDetails.FirstDisplayedScrollingRowIndex = firstRowIndex;
                }
                else
                {
                    _message = String.Format("Error in {0} vendor:", isDisabled(rowIndex) ? "Re-enabling the" : "disabling the");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { log.Error("Error while enabling/disabling vendor :" + ex.Message); }
        }
        #endregion
        #endregion




    }
}
