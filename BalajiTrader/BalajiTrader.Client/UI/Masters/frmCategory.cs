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
        public static List<Category> _categorys;
        private Category _category = null;
        private int _categoryId = 0;
        private string _event = "New";
        #endregion

        public frmCategory()
        {           
            InitializeComponent();
            _process = new ValidationProcess();
            _category = new Category();
            _categoryId = 0;
            CommonProcess.AddCategory = _category;
            _event = "New";

        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            refreshData();
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
                    MessageBox.Show(string.Format("categories details {0} successfully..!", _event == "New" ? "inserted" : "updated"), Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FStatus = true;
                    Clear();
                    refreshData();
                }
                else
                {
                    MessageBox.Show(string.Format("Error {0} categories details..! \n{1}", _event == "New" ? "inserting" : "updating", Constant.assistsnce),
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

        private void Clear()
        {
            _categoryId = 0;
            txtCategoryName.Clear();
            txtHSNCode.Clear();
            txtDescription.Clear();
        }

        private void refreshData()
        {
            CommonProcess.GetAllCategories();

            BindCategoriesDetails(0);
        }

        private void BindCategoriesDetails(int categoryId)
        {
            List<Category> _tmpCategories = new List<Category>();
            _tmpCategories   = CommonProcess.GetCategories(categoryId);

            _categorys = new List<Category>();
            foreach (Category _tmpcategory in _tmpCategories)
            {
                _categorys.Add(CommonProcess.CategoryCopy(_tmpcategory));
            }

            if (_categorys.Count <= 0)
            {
                //stsMessage.Visible = true;
                dgvCategories.Visible = false;
                //stsMessage.DisplayText = "Data not found for 🔎 search criteria...!";
            }
            else
            {
                //stsMessage.Visible = false;
                dgvCategories.Visible = true;
            }            

            var _list = _categorys.Select(cd => new
            {
                cd.CategoryId,
                cd.CategoryName,
                cd.HSNCode,
                cd.Description,
                cd.Status,
                cd.Created
            }).ToList();

            dgvCategories.DataSource = _list;
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
                foreach (DataGridViewRow row in dgvCategories.Rows)
                {
                    row.Cells["SrNo"].Value = i;
                    i++;

                    row.DefaultCellStyle.Font = Fonts.DefaultFont;
                    row.DefaultCellStyle.BackColor = Fonts.DefaultBackColor;


                    //Highlight the CategoryName
                    row.Cells["CategoryName"].Style.Font = Fonts.DefaultBold;
                }

                //Hide columns
                DataGridViewColumnCollection column = dgvCategories.Columns;
                column["CategoryId"].Visible = false;
                column["Status"].Visible = false;
                column["Created"].Visible = false;

                //Setting up Column width
                column["SrNo"].Width = 40;
                column["CategoryName"].Width = 120;
                column["HSNCode"].Width = 90;
                column["Description"].Width = dgvCategories.Rows.Count < 6 ? 212 : 196;

                //Setting up Header Text
                column["SrNo"].HeaderText = "Sr No";
                column["CategoryName"].HeaderText = "Category Name";
                column["HSNCode"].HeaderText = "HSN Code";
                column["Description"].HeaderText = "Description";

                //column Read-Only
                column["SrNo"].ReadOnly = true;
                column["CategoryName"].ReadOnly = true;
                column["HSNCode"].ReadOnly = true;
                column["Description"].ReadOnly = true;

                //Setting up Alignment
                column["SrNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["CategoryName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["HSNCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            catch (Exception ex) { log.Error("Error applying validations on grid"); }
        }

        private void AddButtonsToGrid()
        {
            try
            {
                DataGridViewColumnCollection column = dgvCategories.Columns;

                //Delete column before adding 
                if (dgvCategories.Columns.Contains("Edit"))
                    dgvCategories.Columns.Remove("Edit");

                //Add Edit Column
                DataGridViewImageColumn editImg = new DataGridViewImageColumn();
                editImg.HeaderText = "Edit";
                Image edit = Properties.Resources.edit;
                editImg.Image = edit;
                editImg.Name = "Edit";
                editImg.Width = 40;
                if (!dgvCategories.Columns.Contains("Edit"))
                    dgvCategories.Columns.Add(editImg);

                //Delete column before adding 
                if (dgvCategories.Columns.Contains("Delete"))
                    dgvCategories.Columns.Remove("Delete");

                //Add Delete Column
                DataGridViewImageColumn delImg = new DataGridViewImageColumn();
                delImg.HeaderText = "Disabled";
                Image del = Properties.Resources.enable;
                delImg.Image = del;
                delImg.Name = "Delete";
                delImg.Width = 40;
                if (!dgvCategories.Columns.Contains("Delete"))
                    dgvCategories.Columns.Add(delImg);

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
                for (int i = 0; i < dgvCategories.Rows.Count; i++)
                {
                    if (isDisabled(i))
                    {
                        dgvCategories.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        dgvCategories.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                        if (dgvCategories.Columns.Contains("Edit"))
                            dgvCategories.Rows[i].Cells["Edit"].Value = new Bitmap(1, 1);

                        if (dgvCategories.Columns.Contains("Delete"))
                            dgvCategories.Rows[i].Cells["Delete"].Value = Properties.Resources.disable;
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
            return dgvCategories.Rows[r].Cells["Status"].Value.ToString() == "0";
        }
        #endregion

        #endregion
    }
}
