using BalajiTrader.Business;
using BalajiTrader.Business.Classes;
using BalajiTrader.Business.Models;
using BalajiTrader.Client.Common;
using BalajiTrader.Client.UI.Common;
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

namespace BalajiTrader.Client.UI
{
    public partial class frmProductDetails : BaseAsyncForm
    {
        #region Instance variables
        private static readonly ILog log = LogManager.GetLogger(typeof(frmProductDetails));
        public static List<Product> _products;
        public static Product _product;
        private bool isInitializing = true;
        private bool search = true;
        int _categoryId = 0, _brandId = 0;

        private int rowIndex, columnIndex, firstRowIndex = 0;
        string _message = string.Empty;
        #endregion

        public frmProductDetails()
        {
            InitializeComponent();
            _categoryId = 0;
            _brandId = 0;
        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        #region Event
        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            isInitializing = true;
            BindComboBox();

            refreshData();

            isInitializing = false;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Product product = null;
            frmAddProduct _frmAddProduct = new frmAddProduct(product, "New");
            _frmAddProduct.ShowDialog();

            if (!_frmAddProduct.FStatus)
                return;

            refreshData();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (isInitializing) return;

                int CategoryId = cmbCategory.SelectedIndex > 0 ? Convert.ToInt32(cmbCategory.SelectedValue.ToString()) : 0;
                //clear Existing 
                search = true;
                cmbBrand.DataSource = null;
                cmbBrand.DropDownStyle = Fonts.DropDown;
                cmbBrand.DropDownHeight = Fonts.DefaultDropdownsize;
                if (CategoryId == 0) return;

                cmbBrand.DataSource = CommonProcess.GetBrandsFromList(CategoryId);
                cmbBrand.DropDownStyle = Fonts.DropDownList;
                cmbBrand.DropDownHeight = Fonts.Dropdownsize;
                cmbBrand.DisplayMember = "BrandName";
                cmbBrand.ValueMember = "BrandId";

                SearchDetails();
                search = false;
            }
            catch (Exception ex) { log.Error("Error loading product details " + ex.Message); }
        }

        private void cmbCommon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (isInitializing || search) return;

                SearchDetails();
            }
            catch (Exception ex) { log.Error("Error loading product details " + ex.Message); }
        }
        #endregion


        #region Methods
        private void BindComboBox()
        {
            //Clear Existing combobox
            cmbCategory.Items.Clear();

            //Bind Category drop down
            cmbCategory.DataSource = CommonProcess.GetCategoryFromList();
            cmbCategory.DropDownStyle = Fonts.DropDownList;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }

        private void refreshData()
        {
            ProductProcess.GetAllProduct(0);

            BindProductDetails();
        }

        public void SearchDetails()
        {
            _categoryId = cmbCategory.SelectedIndex > 0 ? Convert.ToInt32(cmbCategory.SelectedValue.ToString()) : 0;
            if (_categoryId > 0)
                _brandId = cmbBrand.SelectedIndex > 0 ? Convert.ToInt32(cmbBrand.SelectedValue.ToString()) : 0;

            BindProductDetails();
        }

        private void BindProductDetails()
        {
            List<Product> _tmpProducts = new List<Product>();
            _tmpProducts = ProductProcess.GetProducts(_categoryId, _brandId);

            _products = new List<Product>();
            foreach (Product _tmpproduct in _tmpProducts)
            {
                _products.Add(ProductProcess.ProductCopy(_tmpproduct));
            }

            if (_products.Count <= 0)
            {
                //stsMessage.Visible = true;
                dgvProductDetails.Visible = false;
                //stsMessage.DisplayText = "Data not found for 🔎 search criteria...!";
            }
            else
            {
                //stsMessage.Visible = false;
                dgvProductDetails.Visible = true;
            }

            var _list = _products.Select(pd => new
            {
                pd.ProductId,
                pd.ProductCode,
                pd.ProductName,
                pd.CategoryId,
                pd.CategoryName,
                pd.BrandId,
                pd.BrandName,
                pd.SizeId,
                pd.SizeName,
                pd.UnitId,
                pd.UnitName,
                pd.Unit,
                pd.HSNCode,
                pd.Status,
                pd.Created
            }).ToList();

            dgvProductDetails.DataSource = _list;
            BindGridOnReset();
        }

        #region DataridValidation
        public void BindGridOnReset()
        {
            try
            {
                GridValidations();
                AddButtonsToGrid();
                RemoveDisabledProductButtons();
            }
            catch (Exception ex) { log.Error("Error while binding data to grid " + ex.Message); }
        }

        private void GridValidations()
        {
            try
            {
                int i = 1;
                foreach (DataGridViewRow row in dgvProductDetails.Rows)
                {
                    row.Cells["SrNo"].Value = i;
                    i++;

                    //row.DefaultCellStyle.Font = new Font("Cambria", 9);
                    row.DefaultCellStyle.Font = Fonts.DefaultFont;
                    row.DefaultCellStyle.BackColor = Color.Azure;


                    //Highlight the UserId & Password
                    row.Cells["ProductCode"].Style.Font = Fonts.DefaultBoldItalicFont;
                    row.Cells["ProductCode"].Style.ForeColor = Color.Red;
                }

                //Hide columns
                DataGridViewColumnCollection column = dgvProductDetails.Columns;
                column["ProductId"].Visible = false;
                column["CategoryId"].Visible = false;
                column["BrandId"].Visible = false;
                column["SizeId"].Visible = false;
                column["UnitId"].Visible = false;
                column["UnitName"].Visible = false;
                column["Status"].Visible = false;
                column["Created"].Visible = false;

                //Setting up Column width
                column["SrNo"].Width = 45;
                column["ProductCode"].Width = 130;
                column["ProductName"].Width = dgvProductDetails.Rows.Count <= 15 ? 150 : 134;
                column["CategoryName"].Width = 85;
                column["BrandName"].Width = 80;
                column["HSNCode"].Width = 80;
                column["SizeName"].Width = 70;
                column["Unit"].Width = 56;

                //Setting up Header Text
                column["SrNo"].HeaderText = "Sr No";
                column["ProductCode"].HeaderText = "Product Code";
                column["ProductName"].HeaderText = "Product Name";
                column["CategoryName"].HeaderText = "Category";
                column["BrandName"].HeaderText = "Brand";
                column["SizeName"].HeaderText = "Size";
                column["Unit"].HeaderText = "Unit";
                column["HSNCode"].HeaderText = "HSN Code";

                //column Read-Only
                column["SrNo"].ReadOnly = true;
                column["ProductCode"].ReadOnly = true;
                column["ProductName"].ReadOnly = true;
                column["CategoryName"].ReadOnly = true;
                column["BrandName"].ReadOnly = true;
                column["SizeName"].ReadOnly = true;
                column["Unit"].ReadOnly = true;
                column["HSNCode"].ReadOnly = true;

                //Setting up Alignment
                column["SrNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["ProductCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["ProductName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["CategoryName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column["BrandName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column["SizeName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column["HSNCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex) { log.Error("Error applying validations on grid"); }
        }

        private void AddButtonsToGrid()
        {
            try
            {
                DataGridViewColumnCollection column = dgvProductDetails.Columns;

                //Delete column before adding 
                if (dgvProductDetails.Columns.Contains("Edit"))
                    dgvProductDetails.Columns.Remove("Edit");

                //Add Edit Column
                DataGridViewImageColumn editImg = new DataGridViewImageColumn();
                editImg.HeaderText = "Edit";
                Image edit = Properties.Resources.edit;
                editImg.Image = edit;
                editImg.Name = "Edit";
                editImg.Width = 45;
                if (!dgvProductDetails.Columns.Contains("Edit"))
                    dgvProductDetails.Columns.Add(editImg);

                //Delete column before adding 
                if (dgvProductDetails.Columns.Contains("Delete"))
                    dgvProductDetails.Columns.Remove("Delete");

                //Add Delete Column
                DataGridViewImageColumn delImg = new DataGridViewImageColumn();
                delImg.HeaderText = "Disabled";
                Image del = Properties.Resources.enable;
                delImg.Image = del;
                delImg.Name = "Delete";
                delImg.Width = 45;
                if (!dgvProductDetails.Columns.Contains("Delete"))
                    dgvProductDetails.Columns.Add(delImg);

            }
            catch (Exception ex)
            {
                log.Error("Error while populating buttons in grid " + ex.Message);
            }
        }

        private void RemoveDisabledProductButtons()
        {
            try
            {
                for (int i = 0; i < dgvProductDetails.Rows.Count; i++)
                {
                    if (isDisabled(i))
                    {
                        dgvProductDetails.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        dgvProductDetails.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                        if (dgvProductDetails.Columns.Contains("Edit"))
                            dgvProductDetails.Rows[i].Cells["Edit"].Value = new Bitmap(1, 1);

                        if (dgvProductDetails.Columns.Contains("Delete"))
                            dgvProductDetails.Rows[i].Cells["Delete"].Value = Properties.Resources.disable;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Error removing disabled product buttons...!");
            }
        }

        private bool isDisabled(int r)
        {
            return dgvProductDetails.Rows[r].Cells["Status"].Value.ToString() == "0";
        }
        #endregion

        #region Grid Event
        private void dgvProductDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { }
        }

        private void dgvProductDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex != 16 && e.ColumnIndex != 17) || e.RowIndex < 0 || ((e.ColumnIndex == 16) && isDisabled(e.RowIndex)))
                {
                    dgvProductDetails.Cursor = Cursors.Default;
                    return;
                }

                dgvProductDetails.Cursor = Cursors.Hand;
                var cell = dgvProductDetails[e.ColumnIndex, e.RowIndex];
                if (e.ColumnIndex == 16)
                    cell.ToolTipText = "Edit product details..!";
                else if (e.ColumnIndex == 17)
                    cell.ToolTipText = isDisabled(e.RowIndex) ? "Re-enable the product" : "Disable the product from here..!";
            }
            catch (Exception ex) { log.Error("Error on cell mouse enter :" + ex.Message); }
        }

        private void dgvProductDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            else if ((e.ColumnIndex == 16) && isDisabled(e.RowIndex)) //It is only to prevent edit if the product is disabled.
                return;
            else if (e.ColumnIndex == 16)
                EditBrand(e.RowIndex);
            else if (e.ColumnIndex == 17)
                EnableDisableProduct();
        }

        private void EditBrand(int r)
        {
            try
            {
                string ProductName = dgvProductDetails.Rows[rowIndex].Cells["ProductCode"].Value.ToString();
                _message = string.Format("Want to edit {0} brand details.", ProductName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dialog == DialogResult.No)
                    return;

                int ProductId = Validations.ConvertToInt(dgvProductDetails.Rows[rowIndex].Cells["ProductId"].Value.ToString());

                //_event = "Edit";
                //txtBrandName.Text = BrandName;
                //cmbCategory.SelectedValue = CategoryId;
            }
            catch (Exception ex) { log.Error("Error while editing brand details :" + ex.Message); }
        }

        private void EnableDisableProduct()
        {
            try
            {
                string ProductName = dgvProductDetails.Rows[rowIndex].Cells["ProductCode"].Value.ToString();
                _message = String.Format("Want to {0} brand: {1}", isDisabled(rowIndex) ? "Re-enable the" : "disable the", ProductName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (_dialog == DialogResult.No)
                    return;

                firstRowIndex = dgvProductDetails.FirstDisplayedScrollingRowIndex;
                int ProductId = Validations.ConvertToInt(dgvProductDetails.Rows[rowIndex].Cells["ProductId"].Value.ToString());
                string Status = isDisabled(rowIndex) ? "1" : "0";

                if (ProductProcess.EnableDisableProduct(ProductId, Status))
                {
                    _message = String.Format("Product {0} ", isDisabled(rowIndex) ? "Re-enable successfully...!" : "is disabled now..!");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                    dgvProductDetails.FirstDisplayedScrollingRowIndex = firstRowIndex;
                }
                else
                {
                    _message = String.Format("Error in {0} product:", isDisabled(rowIndex) ? "Re-enabling the" : "disabling the");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { log.Error("Error while enabling/disabling product :" + ex.Message); }
        }
        #endregion
        #endregion


    }
}
