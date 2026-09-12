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
    }
}
