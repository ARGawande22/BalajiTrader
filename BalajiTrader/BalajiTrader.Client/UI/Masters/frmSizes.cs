using BalajiTrader.Business.Classes;
using BalajiTrader.Client.Common;
using BalajiTrader.Client.UI.Common;
using BalajiTrader.Entities;
using log4net;
using Microsoft.IdentityModel.Tokens.Experimental;
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

namespace BalajiTrader.Client.UI.Masters
{
    public partial class frmSizes : BaseAsyncForm
    {
        #region  Instance Variable
        private static readonly ILog log = LogManager.GetLogger(typeof(frmSizes));
        public bool FStatus { get; set; }
        ToolTip toolTip1 = new ToolTip();
        private ValidationProcess _process;
        public static List<Sizes> _sizes;
        private Sizes _size = null;
        private int _sizeId = 0;
        private string _event = "New";

        private int rowIndex, columnIndex, firstRowIndex = 0;
        string _message = string.Empty;
        #endregion

        public frmSizes()
        {
            InitializeComponent();
            _process = new ValidationProcess();
            _size = new Sizes();
            _sizeId = 0;
            CommonProcess.AddSize = _size;
            _event = "New";
        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        #region Event
        private void frmSizes_Load(object sender, EventArgs e)
        {
            BindComboBox();
            BindSizesDetails(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonProcess.AddSize = null;
            Clear();
            FStatus = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetSizeObject();
            if (BindValidationsToControl())
            {
                if (CommonProcess.AddUpdateSize(_sizeId, _size.CategoryId, _size.UnitId, _size.SizeName))
                {
                    MessageBox.Show(string.Format("Size details {0} successfully..!", _event == "New" ? "inserted" : "updated"), Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FStatus = true;
                    Clear();
                    refreshData();
                }
                else
                {
                    MessageBox.Show(string.Format("Error {0} size details..! \n{1}", _event == "New" ? "inserting" : "updating", Constant.assistsnce),
                        Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FStatus = false;
                }
            }
        }
        #endregion

        #region Methods
        private void BindComboBox()
        {
            //Clear Existing combobox
            cmbCategory.Items.Clear();
            cmbUnits.Items.Clear();

            //Bind Category drop down
            cmbCategory.DataSource = CommonProcess.GetCategoryFromList();
            cmbCategory.DropDownStyle = Fonts.DropDownList;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            //Bind Unit drop down
            cmbUnits.DataSource = CommonProcess.GetUnitsFromList();
            cmbUnits.DropDownStyle = Fonts.DropDownList;
            cmbUnits.DisplayMember = "Unit";
            cmbUnits.ValueMember = "UnitId";
        }

        private void Clear()
        {
            _sizeId = 0;
            cmbCategory.SelectedIndex = 0;
            cmbUnits.SelectedIndex = 0;
            txtSizename.Clear();
            _event = "New";
        }

        private void GetSizeObject()
        {
            #region Get Category Details
            _size.SizeId = _sizeId;
            _size.CategoryId = Validations.ConvertToInt(cmbCategory.SelectedIndex > 0 ? cmbCategory.SelectedValue.ToString() : "0"); ;
            _size.CategoryName = cmbCategory.SelectedIndex > 0 ? cmbCategory.Text : "";
            _size.UnitId = Validations.ConvertToInt(cmbUnits.SelectedIndex > 0 ? cmbUnits.SelectedValue.ToString() : "0"); ;
            _size.Unit = cmbUnits.SelectedIndex > 0 ? cmbUnits.Text : "";
            _size.SizeName = txtSizename.Text;
            #endregion
        }

        private bool BindValidationsToControl()
        {
            CommonProcess.AddSize = _size;
            ValidationErrors validateErrors = _process.SizeValidation;

            validationerrors.SetError(cmbCategory, validateErrors.GetMessageByProperty(Constant.Namekey));
            validationerrors.SetError(cmbUnits, validateErrors.GetMessageByProperty(Constant.Namekey1));
            validationerrors.SetError(txtSizename, validateErrors.GetMessageByProperty(Constant.Namekey2));

            if (validateErrors.Count == 0)
                return true;
            else
                return false;
        }

        private void refreshData()
        {
            CommonProcess.GetAllSizes();
            BindSizesDetails(0);
        }

        private void BindSizesDetails(int sizeId)
        {
            List<Sizes> _tmpSizes = new List<Sizes>();
            _tmpSizes = CommonProcess.GetSizes(sizeId);

            _sizes = new List<Sizes>();
            foreach (Sizes _tmpsize in _tmpSizes)
            {
                _sizes.Add(CommonProcess.SizeCopy(_tmpsize));
            }

            if (_sizes.Count <= 0)
            {
                //stsMessage.Visible = true;
                dgvSizes.Visible = false;
                //stsMessage.DisplayText = "Data not found for 🔎 search criteria...!";
            }
            else
            {
                //stsMessage.Visible = false;
                dgvSizes.Visible = true;
            }

            var _list = _sizes.Select(sd => new
            {
                sd.SizeId,
                sd.CategoryId,
                sd.CategoryName,
                sd.UnitId,
                sd.UnitName,
                sd.Unit,
                sd.SizeName,
                sd.Status,
                sd.Created
            }).ToList();

            dgvSizes.DataSource = _list;
            BindGridOnReset();
        }

        #region DataridValidation
        public void BindGridOnReset()
        {
            try
            {
                GridValidations();
                AddButtonsToGrid();
                RemoveDisabledClientButtons();
            }
            catch (Exception ex) { log.Error("Error while binding data to grid " + ex.Message); }
        }

        private void GridValidations()
        {
            try
            {
                int i = 1;
                foreach (DataGridViewRow row in dgvSizes.Rows)
                {
                    row.Cells["SrNo"].Value = i;
                    i++;

                    row.DefaultCellStyle.Font = Fonts.DefaultFont;
                    row.DefaultCellStyle.BackColor = Fonts.DefaultBackColor;


                    //Highlight the CategoryName
                    //row.Cells["CategoryName"].Style.Font = Fonts.DefaultBold;
                }

                //Hide columns
                DataGridViewColumnCollection column = dgvSizes.Columns;
                column["SizeId"].Visible = false;
                column["CategoryId"].Visible = false;
                column["UnitId"].Visible = false;
                column["UnitName"].Visible = false;
                column["Status"].Visible = false;
                column["Created"].Visible = false;

                //Setting up Column width
                column["SrNo"].Width = 50;
                column["CategoryName"].Width = 140;
                column["Unit"].Width = 130;
                column["SizeName"].Width = dgvSizes.Rows.Count < 6 ? 123 : 106;

                //Setting up Header Text
                column["SrNo"].HeaderText = "Sr No";
                column["CategoryName"].HeaderText = "Category Name";
                column["Unit"].HeaderText = "Unit";
                column["SizeName"].HeaderText = "Size";

                //column Read-Only
                column["SrNo"].ReadOnly = true;
                column["CategoryName"].ReadOnly = true;
                column["Unit"].ReadOnly = true;
                column["SizeName"].ReadOnly = true;

                //Setting up Alignment
                column["SrNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["CategoryName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column["SizeName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex) { log.Error("Error applying validations on grid"); }
        }

        private void AddButtonsToGrid()
        {
            try
            {
                DataGridViewColumnCollection column = dgvSizes.Columns;

                //Delete column before adding 
                if (dgvSizes.Columns.Contains("Edit"))
                    dgvSizes.Columns.Remove("Edit");

                //Add Edit Column
                DataGridViewImageColumn editImg = new DataGridViewImageColumn();
                editImg.HeaderText = "Edit";
                Image edit = Properties.Resources.edit;
                editImg.Image = edit;
                editImg.Name = "Edit";
                editImg.Width = 50;
                if (!dgvSizes.Columns.Contains("Edit"))
                    dgvSizes.Columns.Add(editImg);

                //Delete column before adding 
                if (dgvSizes.Columns.Contains("Delete"))
                    dgvSizes.Columns.Remove("Delete");

                //Add Delete Column
                DataGridViewImageColumn delImg = new DataGridViewImageColumn();
                delImg.HeaderText = "Disabled";
                Image del = Properties.Resources.enable;
                delImg.Image = del;
                delImg.Name = "Delete";
                delImg.Width = 50;
                if (!dgvSizes.Columns.Contains("Delete"))
                    dgvSizes.Columns.Add(delImg);

            }
            catch (Exception ex)
            {
                log.Error("Error while populating buttons in grid " + ex.Message);
            }
        }

        private void RemoveDisabledClientButtons()
        {
            try
            {
                for (int i = 0; i < dgvSizes.Rows.Count; i++)
                {
                    if (isDisabled(i))
                    {
                        dgvSizes.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        dgvSizes.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                        if (dgvSizes.Columns.Contains("Edit"))
                            dgvSizes.Rows[i].Cells["Edit"].Value = new Bitmap(1, 1);

                        if (dgvSizes.Columns.Contains("Delete"))
                            dgvSizes.Rows[i].Cells["Delete"].Value = Properties.Resources.disable;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Error removing disabled category buttons...!");
            }
        }

        private bool isDisabled(int r)
        {
            return dgvSizes.Rows[r].Cells["Status"].Value.ToString() == "0";
        }
        #endregion

        #region Grid Event
        private void dgvSizes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { }
        }

        private void dgvSizes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex != 10 && e.ColumnIndex != 11) || e.RowIndex < 0 || ((e.ColumnIndex == 10) && isDisabled(e.RowIndex)))
                {
                    dgvSizes.Cursor = Cursors.Default;
                    return;
                }

                dgvSizes.Cursor = Cursors.Hand;
                var cell = dgvSizes[e.ColumnIndex, e.RowIndex];
                if (e.ColumnIndex == 10)
                    cell.ToolTipText = "Edit size details..!";
                else if (e.ColumnIndex == 11)
                    cell.ToolTipText = isDisabled(e.RowIndex) ? "Re-enable the size" : "Disable the size from here..!";
            }
            catch (Exception ex) { log.Error("Error on cell mouse enter :" + ex.Message); }
        }

        private void dgvSizes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            else if ((e.ColumnIndex == 10) && isDisabled(e.RowIndex)) //It is only to prevent edit if the category is disabled.
                return;
            else if (e.ColumnIndex == 10)
                EditSize(e.RowIndex);
            else if (e.ColumnIndex == 11)
                EnableDisableSize();
        }

        private void EditSize(int r)
        {
            try
            {
                string SizeName = dgvSizes.Rows[r].Cells["SizeName"].Value.ToString();
                _message = string.Format("Want to edit {0} size details.", SizeName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dialog == DialogResult.No)
                    return;

                _sizeId = Validations.ConvertToInt(dgvSizes.Rows[r].Cells["SizeId"].Value.ToString());
                int CategoryId = Validations.ConvertToInt(dgvSizes.Rows[r].Cells["CategoryId"].Value.ToString());
                int UnitId = Validations.ConvertToInt(dgvSizes.Rows[r].Cells["UnitId"].Value.ToString());

                _event = "Edit";                
                cmbCategory.SelectedValue = CategoryId;
                cmbUnits.SelectedValue = UnitId;
                txtSizename.Text = SizeName;
            }
            catch (Exception ex) { log.Error("Error while editing unit details :" + ex.Message); }
        }

        private void EnableDisableSize()
        {
            try
            {
                string SizeName = dgvSizes.Rows[rowIndex].Cells["SizeName"].Value.ToString();
                _message = String.Format("Want to {0} size: {1}", isDisabled(rowIndex) ? "Re-enable the" : "disable the", SizeName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (_dialog == DialogResult.No)
                    return;

                firstRowIndex = dgvSizes.FirstDisplayedScrollingRowIndex;
                int sizeid = Validations.ConvertToInt(dgvSizes.Rows[rowIndex].Cells["SizeId"].Value.ToString());
                string Status = isDisabled(rowIndex) ? "1" : "0";

                if (CommonProcess.EnableDisableSize(sizeid, Status))
                {
                    _message = String.Format("Size {0} ", isDisabled(rowIndex) ? "Re-enable successfully...!" : "is disabled now..!");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                    dgvSizes.FirstDisplayedScrollingRowIndex = firstRowIndex;
                }
                else
                {
                    _message = String.Format("Error in {0} size:", isDisabled(rowIndex) ? "Re-enabling the" : "disabling the");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { log.Error("Error while enabling/disabling size :" + ex.Message); }
        }
        #endregion
        #endregion       
    }
}
