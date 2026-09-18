using BalajiTrader.Business.Classes;
using BalajiTrader.Client.Common;
using BalajiTrader.Client.UI.Common;
using BalajiTrader.Entities;
using log4net;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace BalajiTrader.Client.UI.Masters
{
    public partial class frmBrand : BaseAsyncForm
    {
        #region  Instance Variable
        private static readonly ILog log = LogManager.GetLogger(typeof(frmCategory));
        public bool FStatus { get; set; }
        ToolTip toolTip1 = new ToolTip();
        private ValidationProcess _process;
        public static List<Brand> _brands;
        private Brand _brand = null;
        private int _brandId = 0;
        private string _event = "New";

        private int rowIndex, columnIndex, firstRowIndex = 0;
        string _message = string.Empty;
        #endregion

        public frmBrand()
        {
            InitializeComponent();
            _process = new ValidationProcess();
            _brand = new Brand();
            _brandId = 0;
            CommonProcess.AddBrands = _brand;
            _event = "New";
        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        #region Events
        private void frmBrand_Load(object sender, EventArgs e)
        {
            BindComboBox();
            BindBrandsDetails(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetBrandObject();
            if (BindValidationsToControl())
            {
                if (CommonProcess.AddUpdateBrand(_brandId, _brand.CategoryId, _brand.BrandName))
                {
                    MessageBox.Show(string.Format("brand details {0} successfully..!", _event == "New" ? "inserted" : "updated"), Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FStatus = true;
                    Clear();
                    refreshData();
                }
                else
                {
                    MessageBox.Show(string.Format("Error {0} brand details..! \n{1}", _event == "New" ? "inserting" : "updating", Constant.assistsnce),
                        Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FStatus = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonProcess.AddBrands = null;
            Clear();
            FStatus = false;
        }
        #endregion

        #region Methods
        private void BindComboBox()
        {
            //Clear Existing combobox
            cmbCategory.Items.Clear();

            //Bind Country drop down
            cmbCategory.DataSource = CommonProcess.GetCategoryFromList();
            cmbCategory.DropDownStyle = Fonts.DropDownList;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }

        private void GetBrandObject()
        {
            #region Get Category Details
            _brand.BrandId = _brandId;
            _brand.CategoryId = Validations.ConvertToInt(cmbCategory.SelectedIndex > 0 ? cmbCategory.SelectedValue.ToString() : "0"); ;
            _brand.CategoryName = cmbCategory.SelectedIndex > 0 ? cmbCategory.Text : "";
            _brand.BrandName = txtBrandName.Text;
            #endregion
        }

        private bool BindValidationsToControl()
        {
            CommonProcess.AddBrands = _brand;
            ValidationErrors validateErrors = _process.BrandValidation;

            validationerrors.SetError(cmbCategory, validateErrors.GetMessageByProperty(Constant.Namekey));
            validationerrors.SetError(txtBrandName, validateErrors.GetMessageByProperty(Constant.Namekey1));

            if (validateErrors.Count == 0)
                return true;
            else
                return false;
        }

        private void Clear()
        {
            _brandId = 0;
            cmbCategory.SelectedIndex = 0;
            txtBrandName.Clear();
            _event = "New";
        }

        private void refreshData()
        {
            CommonProcess.GetAllBrands();
            BindBrandsDetails(0);
        }

        private void BindBrandsDetails(int brandId)
        {
            List<Brand> _tmpBrands = new List<Brand>();
            _tmpBrands = CommonProcess.GetBrands(brandId);

            _brands = new List<Brand>();
            foreach (Brand _tmpbrand in _tmpBrands)
            {
                _brands.Add(CommonProcess.BrandCopy(_tmpbrand));
            }

            if (_brands.Count <= 0)
            {
                //stsMessage.Visible = true;
                dgvBrands.Visible = false;
                //stsMessage.DisplayText = "Data not found for 🔎 search criteria...!";
            }
            else
            {
                //stsMessage.Visible = false;
                dgvBrands.Visible = true;
            }

            var _list = _brands.Select(bd => new
            {
                bd.BrandId,
                bd.CategoryId,
                bd.CategoryName,
                bd.BrandName,
                bd.Status,
                bd.Created
            }).ToList();

            dgvBrands.DataSource = _list;
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
                foreach (DataGridViewRow row in dgvBrands.Rows)
                {
                    row.Cells["SrNo"].Value = i;
                    i++;

                    row.DefaultCellStyle.Font = Fonts.DefaultFont;
                    row.DefaultCellStyle.BackColor = Fonts.DefaultBackColor;


                    //Highlight the CategoryName
                    //row.Cells["CategoryName"].Style.Font = Fonts.DefaultBold;
                }

                //Hide columns
                DataGridViewColumnCollection column = dgvBrands.Columns;
                column["BrandId"].Visible = false;
                column["CategoryId"].Visible = false;
                column["Status"].Visible = false;
                column["Created"].Visible = false;

                //Setting up Column width
                column["SrNo"].Width = 50;
                column["CategoryName"].Width = 150;
                column["BrandName"].Width = dgvBrands.Rows.Count < 7 ? 243 : 227;

                //Setting up Header Text
                column["SrNo"].HeaderText = "Sr No";
                column["CategoryName"].HeaderText = "Category Name";
                column["BrandName"].HeaderText = "Brand Name";

                //column Read-Only
                column["SrNo"].ReadOnly = true;
                column["CategoryName"].ReadOnly = true;
                column["BrandName"].ReadOnly = true;

                //Setting up Alignment
                column["SrNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["CategoryName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["BrandName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            catch (Exception ex) { log.Error("Error applying validations on grid"); }
        }

        private void AddButtonsToGrid()
        {
            try
            {
                DataGridViewColumnCollection column = dgvBrands.Columns;

                //Delete column before adding 
                if (dgvBrands.Columns.Contains("Edit"))
                    dgvBrands.Columns.Remove("Edit");

                //Add Edit Column
                DataGridViewImageColumn editImg = new DataGridViewImageColumn();
                editImg.HeaderText = "Edit";
                Image edit = Properties.Resources.edit;
                editImg.Image = edit;
                editImg.Name = "Edit";
                editImg.Width = 50;
                if (!dgvBrands.Columns.Contains("Edit"))
                    dgvBrands.Columns.Add(editImg);

                //Delete column before adding 
                if (dgvBrands.Columns.Contains("Delete"))
                    dgvBrands.Columns.Remove("Delete");

                //Add Delete Column
                DataGridViewImageColumn delImg = new DataGridViewImageColumn();
                delImg.HeaderText = "Disabled";
                Image del = Properties.Resources.enable;
                delImg.Image = del;
                delImg.Name = "Delete";
                delImg.Width = 50;
                if (!dgvBrands.Columns.Contains("Delete"))
                    dgvBrands.Columns.Add(delImg);

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
                for (int i = 0; i < dgvBrands.Rows.Count; i++)
                {
                    if (isDisabled(i))
                    {
                        dgvBrands.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        dgvBrands.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                        if (dgvBrands.Columns.Contains("Edit"))
                            dgvBrands.Rows[i].Cells["Edit"].Value = new Bitmap(1, 1);

                        if (dgvBrands.Columns.Contains("Delete"))
                            dgvBrands.Rows[i].Cells["Delete"].Value = Properties.Resources.disable;
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
            return dgvBrands.Rows[r].Cells["Status"].Value.ToString() == "0";
        }
        #endregion

        #region Grid Event
        private void dgvBrands_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { }
        }

        private void dgvBrands_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex != 7 && e.ColumnIndex != 8) || e.RowIndex < 0 || ((e.ColumnIndex == 7) && isDisabled(e.RowIndex)))
                {
                    dgvBrands.Cursor = Cursors.Default;
                    return;
                }

                dgvBrands.Cursor = Cursors.Hand;
                var cell = dgvBrands[e.ColumnIndex, e.RowIndex];
                if (e.ColumnIndex == 7)
                    cell.ToolTipText = "Edit brand details..!";
                else if (e.ColumnIndex == 8)
                    cell.ToolTipText = isDisabled(e.RowIndex) ? "Re-enable the brand" : "Disable the brand from here..!";
            }
            catch (Exception ex) { log.Error("Error on cell mouse enter :" + ex.Message); }
        }

        private void dgvBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            else if ((e.ColumnIndex == 7) && isDisabled(e.RowIndex)) //It is only to prevent edit if the category is disabled.
                return;
            else if (e.ColumnIndex == 7)
                EditBrand(e.RowIndex);
            else if (e.ColumnIndex == 8)
                EnableDisableBrand();
        }

        private void EditBrand(int r)
        {
            try
            {
                string BrandName = dgvBrands.Rows[r].Cells["BrandName"].Value.ToString();
                _message = string.Format("Want to edit {0} brand details.", BrandName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dialog == DialogResult.No)
                    return;

                _brandId = Validations.ConvertToInt(dgvBrands.Rows[r].Cells["BrandId"].Value.ToString());
                int CategoryId = Validations.ConvertToInt(dgvBrands.Rows[r].Cells["CategoryId"].Value.ToString());

                _event = "Edit";
                txtBrandName.Text = BrandName;
                cmbCategory.SelectedValue = CategoryId;
            }
            catch (Exception ex) { log.Error("Error while editing brand details :" + ex.Message); }
        }

        private void EnableDisableBrand()
        {
            try
            {
                string BrandName = dgvBrands.Rows[rowIndex].Cells["BrandName"].Value.ToString();
                _message = String.Format("Want to {0} brand: {1}", isDisabled(rowIndex) ? "Re-enable the" : "disable the", BrandName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (_dialog == DialogResult.No)
                    return;

                firstRowIndex = dgvBrands.FirstDisplayedScrollingRowIndex;
                int categoryId = Validations.ConvertToInt(dgvBrands.Rows[rowIndex].Cells["BrandId"].Value.ToString());
                string Status = isDisabled(rowIndex) ? "1" : "0";

                if (CommonProcess.EnableDisableBrand(categoryId, Status))
                {
                    _message = String.Format("Brand {0} ", isDisabled(rowIndex) ? "Re-enable successfully...!" : "is disabled now..!");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                    dgvBrands.FirstDisplayedScrollingRowIndex = firstRowIndex;
                }
                else
                {
                    _message = String.Format("Error in {0} brand:", isDisabled(rowIndex) ? "Re-enabling the" : "disabling the");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { log.Error("Error while enabling/disabling brand :" + ex.Message); }
        }
        #endregion
        #endregion

    }
}
