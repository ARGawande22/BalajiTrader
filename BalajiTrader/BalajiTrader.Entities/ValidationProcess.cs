using BalajiTrader.Business.Classes;
using BalajiTrader.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BalajiTrader.Business.Models.Common;

namespace BalajiTrader.Entities
{
    public class ValidationProcess
    {
        public ValidationProcess() { }

        #region Validate Category
        public ValidationErrors CategoryValidation
        {
            get
            {
                ValidationErrors errors = ValidateCategory();
                return errors;
            }
        }

        public ValidationErrors ValidateCategory()
        {
            ValidationErrors validationErrors = new ValidationErrors();
            Category _category = CommonProcess.AddCategory;

            //Category Details
            #region Category Details
            if (string.IsNullOrEmpty(_category.CategoryName))
            {
                ValidationError error = new ValidationError(Constant.Category, "Please enter the category name", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }
            #endregion

            return validationErrors;
        }
        #endregion

        #region Validate Brand
        public ValidationErrors BrandValidation
        {
            get
            {
                ValidationErrors errors = ValidateBrand();
                return errors;
            }
        }

        public ValidationErrors ValidateBrand()
        {
            ValidationErrors validationErrors = new ValidationErrors();
            Brand _brand = CommonProcess.AddBrands;

            //Category Details
            #region Category Details
            if (string.IsNullOrEmpty(_brand.CategoryName))
            {
                ValidationError error = new ValidationError(Constant.Category, "Please Select the category", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_brand.BrandName))
            {
                ValidationError error = new ValidationError(Constant.BrandName, "Please enter the Brand Name", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }
            #endregion

            return validationErrors;
        }
        #endregion

        #region Validate Unit
        public ValidationErrors UnitValidation
        {
            get
            {
                ValidationErrors errors = ValidateUnit();
                return errors;
            }
        }

        public ValidationErrors ValidateUnit()
        {
            ValidationErrors validationErrors = new ValidationErrors();
            Units _unit = CommonProcess.AddUnit;

            //Category Details
            #region Unit Details
            if (string.IsNullOrEmpty(_unit.UnitName))
            {
                ValidationError error = new ValidationError(Constant.UnitName, "Please enter the unit name", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_unit.Unit))
            {
                ValidationError error = new ValidationError(Constant.Unit, "Please enter the unit", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }
            #endregion

            return validationErrors;
        }
        #endregion

        #region Validate Sizes
        public ValidationErrors SizeValidation
        {
            get
            {
                ValidationErrors errors = ValidateSize();
                return errors;
            }
        }

        public ValidationErrors ValidateSize()
        {
            ValidationErrors validationErrors = new ValidationErrors();
            Sizes _size = CommonProcess.AddSize;

            //Category Details
            #region Category Details
            if (string.IsNullOrEmpty(_size.CategoryName))
            {
                ValidationError error = new ValidationError(Constant.Category, "Please Select the category", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_size.Unit))
            {
                ValidationError error = new ValidationError(Constant.Unit, "Please Select the unit", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_size.SizeName))
            {
                ValidationError error = new ValidationError(Constant.SizeName, "Please enter the size Name", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }
            #endregion

            return validationErrors;
        }
        #endregion

        #region Validate Product
        public ValidationErrors ProductValidation
        {
            get
            {
                ValidationErrors errors = ValidateProduct();
                return errors;
            }
        }

        public ValidationErrors ValidateProduct()
        {
            ValidationErrors validationErrors = new ValidationErrors();
            Product _product = ProductProcess.AddProduct;

            //Product Details
            #region Product Details
            if (string.IsNullOrEmpty(_product.ProductCode))
            {                
                ValidationError error = new ValidationError(Constant.ProductCode, "Please enter the product code", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }
            //else if (true)
            //{
            //    ValidationError error = new ValidationError(Constant.ProductCode, "Product code is al-ready present", ValidationErrorTypes.Warning);
            //    validationErrors.Add(error);
            //}

            if (string.IsNullOrEmpty(_product.ProductName))
            {
                ValidationError error = new ValidationError(Constant.ProductName, "Please enter the product name", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_product.CategoryName))
            {
                ValidationError error = new ValidationError(Constant.Category, "Please Select the category", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_product.BrandName))
            {
                ValidationError error = new ValidationError(Constant.BrandName, "Please Select the Brand", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_product.Unit))
            {
                ValidationError error = new ValidationError(Constant.Unit, "Please Select the unit", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }
            #endregion

            return validationErrors;
        }
        #endregion

        #region Validate Product
        public ValidationErrors VendorValidation
        {
            get
            {
                ValidationErrors errors = ValidateVendor();
                return errors;
            }
        }

        public ValidationErrors ValidateVendor()
        {
            ValidationErrors validationErrors = new ValidationErrors();
            Vendor _vendor = VendorProcess.AddVendor;

            //Product Details
            #region Vendor Details
            if (string.IsNullOrEmpty(_vendor.VendorName))
            {
                ValidationError error = new ValidationError(Constant.VendorNameKey, "Please enter the vendor name", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_vendor.ContactName))
            {
                ValidationError error = new ValidationError(Constant.NameKey, "Please enter the contact name", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_vendor.ContactNo))
            {
                ValidationError error = new ValidationError(Constant.MobileKey, "Please enter the contact no", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }
            else if(!Validations.ValidateMobileNo(_vendor.ContactNo))
            {
                ValidationError error = new ValidationError(Constant.MobileKey, "Please enter a valid 10 digit contact no", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_vendor.Address))
            {
                ValidationError error = new ValidationError(Constant.AddressKey, "Please enter the address", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if(!string.IsNullOrEmpty(_vendor.EmailId) && !Validations.ValidateEmail(_vendor.EmailId))
            {
                ValidationError error = new ValidationError(Constant.EmailKey, "Please enter a valid email", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (!string.IsNullOrEmpty(_vendor.GSTNo) && !Validations.ValidateGSTNo(_vendor.GSTNo))
            {
                ValidationError error = new ValidationError(Constant.GSTKey, "Please enter a valid GSTNo", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (!string.IsNullOrEmpty(_vendor.PANNo) && !Validations.ValidateOtherPANNo(_vendor.PANNo))
            {
                ValidationError error = new ValidationError(Constant.PANKey, "Please enter a valid PAN no", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }
            #endregion

            return validationErrors;
        }
        #endregion

    }
}
