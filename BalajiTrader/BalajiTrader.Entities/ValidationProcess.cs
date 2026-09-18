using BalajiTrader.Business.Classes;
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
                ValidationError error = new ValidationError(Constant.Namekey, "Please enter the category name", ValidationErrorTypes.Warning);
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
                ValidationError error = new ValidationError(Constant.Namekey, "Please Select the category", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_brand.BrandName))
            {
                ValidationError error = new ValidationError(Constant.Namekey1, "Please enter the Brand Name", ValidationErrorTypes.Warning);
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
                ValidationError error = new ValidationError(Constant.Namekey, "Please enter the unit name", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }

            if (string.IsNullOrEmpty(_unit.Unit))
            {
                ValidationError error = new ValidationError(Constant.Namekey1, "Please enter the unit", ValidationErrorTypes.Warning);
                validationErrors.Add(error);
            }
            #endregion

            return validationErrors;
        }
        #endregion
    }
}
