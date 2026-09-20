using BalajiTrader.Business.Classes;
using BalajiTrader.Business.Models;
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

namespace BalajiTrader.Client.UI
{
    public partial class frmAddProduct : BaseAsyncForm
    {
        #region Instance variables
        private static readonly ILog log = LogManager.GetLogger(typeof(frmAddProduct));

        public bool FStatus { get; set; }
        ToolTip toolTip1 = new ToolTip();
        private ValidationProcess _process;

        private Product _product = null;
        private int _productId = 0;
        private string _event = "New";
        #endregion

        public frmAddProduct()
        {
            InitializeComponent();
        }

        public frmAddProduct(Product product, string Event)
        {
            InitializeComponent();
            _process = new ValidationProcess();
            this._product = product;
            this._productId = 0;
            this._event = Event;
        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        #region Events
        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            BindComboBox();
            if (_product != null)
                BindProductDetails();
            else
                _product = new Product();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                if (_event == "New")
                {
                    Clear();
                    return;
                }
                FStatus = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Common_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.ValidateEnteredIsNumeric(e);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int CategoryId = cmbCategory.SelectedIndex > 0 ? Convert.ToInt32(cmbCategory.SelectedValue.ToString()) : 0;
                //clear Existing 
                cmbBrand.DataSource = null;
                cmbBrand.DropDownStyle = Fonts.DropDown;
                cmbBrand.DropDownHeight = Fonts.DefaultDropdownsize;
                cmbSize.DataSource = null;
                cmbSize.DropDownStyle = Fonts.DropDown;
                cmbSize.DropDownHeight = Fonts.DefaultDropdownsize;
                if (CategoryId == 0) return;

                cmbBrand.DataSource = CommonProcess.GetBrandsFromList(CategoryId);
                cmbBrand.DropDownStyle = Fonts.DropDownList;
                cmbBrand.DropDownHeight = Fonts.Dropdownsize;
                cmbBrand.DisplayMember = "BrandName";
                cmbBrand.ValueMember = "BrandId";

                cmbSize.DataSource = CommonProcess.GetSizesFromList(CategoryId);
                cmbSize.DropDownStyle = Fonts.DropDownList;
                cmbSize.DropDownHeight = Fonts.Dropdownsize;
                cmbSize.DisplayMember = "SizeName";
                cmbSize.ValueMember = "SizeId";

            }
            catch (Exception ex) { }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int SizeId = cmbSize.SelectedIndex > 0 ? Convert.ToInt32(cmbSize.SelectedValue.ToString()) : 0;
                if (SizeId == 0)
                {
                    cmbUnit.Enabled = true;
                    cmbUnit.SelectedIndex = 0;
                    return;
                }

                Units unit = CommonProcess.GetUnitBySizeId(SizeId);
                if (unit!= null)
                {
                    cmbUnit.SelectedValue = unit.UnitId;
                    cmbUnit.Enabled = false;
                }
            }
            catch (Exception ex) { }
        }

        private void Common_Validated(object sender, EventArgs e)
        {
            GetProductObject();
            BindValidationsToControl();
        }

        #endregion

        #region Methods
        private void BindComboBox()
        {
            //Clear Existing combo box
            cmbCategory.Items.Clear();
            cmbUnit.Items.Clear();

            //Bind Category drop down
            cmbCategory.DataSource = CommonProcess.GetCategoryFromList();
            cmbCategory.DropDownStyle = Fonts.DropDownList;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            //Bind Unit drop down
            cmbUnit.DataSource = CommonProcess.GetUnitsFromList();
            cmbUnit.DropDownStyle = Fonts.DropDownList;
            cmbUnit.DisplayMember = "Unit";
            cmbUnit.ValueMember = "UnitId";
        }

        private void BindProductDetails()
        {
            try
            {
                //Bind Product Details
                _productId = _product.ProductId;
                txtProductCode.Text = _product.ProductCode;
                txtProductName.Text = _product.ProductName;
                cmbCategory.SelectedValue = _product.CategoryId;
                cmbBrand.SelectedValue = _product.BrandId;
                cmbSize.SelectedValue = _product.SizeId > 0 ? _product.SizeId : 0;
                cmbUnit.SelectedValue = _product.UnitId;
                txtHSNCode.Text = _product.HSNCode;
            }
            catch (Exception ex) { log.Error(String.Format("Error : {0}", ex.Message)); }
        }

        public void GetProductObject()
        {
            //Get the User details
            _product.ProductId = _productId;
            _product.ProductCode = txtProductCode.Text;
            _product.ProductName = txtProductName.Text;
            _product.CategoryId = Validations.ConvertToInt(cmbCategory.SelectedIndex > 0 ? cmbCategory.SelectedValue.ToString() : "0");
            _product.CategoryName = cmbCategory.SelectedIndex > 0 ? cmbCategory.Text : "";
            if (cmbCategory.SelectedIndex > 0)
            {
                _product.BrandId = Validations.ConvertToInt(cmbBrand.SelectedIndex > 0 ? cmbBrand.SelectedValue.ToString() : "0");
                _product.BrandName = cmbBrand.SelectedIndex > 0 ? cmbBrand.Text : "";
                _product.UnitId = Validations.ConvertToInt(cmbUnit.SelectedIndex > 0 ? cmbUnit.SelectedValue.ToString() : "0");
                _product.Unit = cmbUnit.SelectedIndex > 0 ? cmbUnit.Text : "";
            }
            _product.SizeId = Validations.ConvertToInt(cmbSize.SelectedIndex > 0 ? cmbSize.SelectedValue.ToString() : "0");
            _product.SizeName = cmbSize.SelectedIndex > 0 ? cmbSize.Text : "";
            _product.HSNCode = txtHSNCode.Text;
        }

        private bool BindValidationsToControl()
        {
            ProductProcess.AddProduct = _product;
            ValidationErrors validateErrors = _process.ProductValidation;

            validationerrors.SetError(txtProductCode, validateErrors.GetMessageByProperty(Constant.ProductCode));
            validationerrors.SetError(txtProductName, validateErrors.GetMessageByProperty(Constant.ProductName));
            validationerrors.SetError(cmbCategory, validateErrors.GetMessageByProperty(Constant.Category));
            validationerrors.SetError(cmbBrand, validateErrors.GetMessageByProperty(Constant.BrandName));
            validationerrors.SetError(cmbUnit, validateErrors.GetMessageByProperty(Constant.Unit));

            if (validateErrors.Count == 0)
                return true;
            else
                return false;
        }

        private void Clear()
        {
            _productId = 0;
            txtProductCode.Clear();
            txtProductName.Clear();
            cmbCategory.SelectedIndex = 0;
            txtHSNCode.Clear();
        }

        private bool Save()
        {
            string Status = _event == "New" ? "created" : "updated";
            GetProductObject();
            if (BindValidationsToControl())
            {
                if (ProductProcess.SaveUpdateProductDetails(_event))
                {
                    MessageBox.Show(String.Format("{0} product {1} successfully..! ", _product.ProductCode, Status), Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;// Clear();
                }
                else
                {
                    MessageBox.Show(String.Format("Error creating new product \n{0}", Constant.assistance), Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
                return false;
        }

        #endregion





    }
}
