using BalajiTrader.Business.Classes;
using BalajiTrader.Client.UI.Common;
using BalajiTrader.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BalajiTrader.Business.Models.Common;

namespace BalajiTrader.Client.UI.Masters
{
    public partial class frmCategory : BaseAsyncForm
    {
        #region  Instance Variable
        private static readonly ILog log = LogManager.GetLogger(typeof(frmCategory));        
        public bool FStatus { get; set; }
        ToolTip toolTip1 = new ToolTip();
        private ValidationProcess _process;
        private Category _category = null;
        private int _categoryId = 0;
        private string _event = "New";
        #endregion

        public frmCategory()
        {
            _categoryId = 0;
            CommonProcess.AddCategory = null;
            _event = "New";
            InitializeComponent();
        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonProcess.AddCategory = null;
            FStatus = false;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetCategoryObject();
            if (BindValidationsToControl())
            {
                if (CommonProcess.AddUpdateCategory(_categoryId,_category.CategoryName,_category.HSNCode,_category.Description))
                {
                    MessageBox.Show(string.Format("Employee details {0} successfully..!", _event == "New" ? "inserted" : "updated"), Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FStatus = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(string.Format("Error {0} Employee details..! \n{1}", _event == "New" ? "inserting" : "updating", Constant.assistsnce),
                        Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FStatus = false;
                }
            }                
        }

        private void Common_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.ValidateEnteredIsNumeric(e);
        }
        #endregion

        #region Methods
        private void GetCategoryObject()
        {
            #region Get Category Details
            _category.CategoryId = _categoryId;
            _category.CategoryName = txtCategoryName.Text;
            _category.HSNCode = txtHSNCode.Text;
            _category.Description = txtDescription.Text;
            #endregion
        }

        private bool BindValidationsToControl()
        {
            CommonProcess.AddCategory = _category;
            ValidationErrors validateErrors = _process.CategoryValidation;

            validationerrors.SetError(txtCategoryName, validateErrors.GetMessageByProperty(Constant.Namekey));

            if (validateErrors.Count == 0)
                return true;
            else
                return false;
        }
        #endregion
    }
}
