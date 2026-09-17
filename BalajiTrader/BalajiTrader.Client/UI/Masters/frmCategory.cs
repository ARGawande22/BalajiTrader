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

        private int rowIndex, columnIndex, firstRowIndex = 0;
        string _message = string.Empty;
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
            Clear();
            FStatus = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetCategoryObject();
            if (BindValidationsToControl())
            {
                if (CommonProcess.AddUpdateCategory(_categoryId, _category.CategoryName, _category.HSNCode, _category.Description))
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
            _event = "New";
        }

        private void refreshData()
        {
            CommonProcess.GetAllCategories();

            BindCategoriesDetails(0);
        }

        private void BindCategoriesDetails(int categoryId)
        {
            List<Category> _tmpCategories = new List<Category>();
            _tmpCategories = CommonProcess.GetCategories(categoryId);

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

        #region Grid Event
        private void dgvCategories_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { }
        }

        private void dgvCategories_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex != 7 && e.ColumnIndex != 8) || e.RowIndex < 0 || ((e.ColumnIndex == 7) && isDisabled(e.RowIndex)))
                {
                    dgvCategories.Cursor = Cursors.Default;
                    return;
                }

                dgvCategories.Cursor = Cursors.Hand;
                var cell = dgvCategories[e.ColumnIndex, e.RowIndex];
                if (e.ColumnIndex == 7)
                    cell.ToolTipText = "Edit category details..!";
                else if (e.ColumnIndex == 8)
                    cell.ToolTipText = isDisabled(e.RowIndex) ? "Re-enable the category" : "Disable the category from here..!";
            }
            catch (Exception ex) { log.Error("Error on cell mouse enter :" + ex.Message); }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            else if ((e.ColumnIndex == 7) && isDisabled(e.RowIndex)) //It is only to prevent edit if the category is disabled.
                return;
            else if (e.ColumnIndex == 7)
                EditUser(e.RowIndex);
            else if (e.ColumnIndex == 8)
                EnableDisableUser();
        }

        private void EditUser(int r)
        {
            try
            {
                string CategoryName = dgvCategories.Rows[r].Cells["CategoryName"].Value.ToString();
                _message = string.Format("Want to edit {0} category details.", CategoryName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dialog == DialogResult.No)
                    return;

                _categoryId = Validations.ConvertToInt(dgvCategories.Rows[r].Cells["CategoryId"].Value.ToString());
                string HSNCde = dgvCategories.Rows[r].Cells["HSNCode"].Value.ToString();
                string Description = dgvCategories.Rows[r].Cells["Description"].Value.ToString();

                _event = "Edit";
                txtCategoryName.Text = CategoryName;
                txtHSNCode.Text= HSNCde;
                txtDescription.Text = Description;
            }
            catch (Exception ex) { log.Error("Error while editing category details :" + ex.Message); }
        }

        private void EnableDisableUser()
        {
            try
            {
                string CategoryName = dgvCategories.Rows[rowIndex].Cells["CategoryName"].Value.ToString();
                _message = String.Format("Want to {0} category: {1}", isDisabled(rowIndex) ? "Re-enable the" : "disable the", CategoryName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (_dialog == DialogResult.No)
                    return;

                firstRowIndex = dgvCategories.FirstDisplayedScrollingRowIndex;
                int categoryId = Validations.ConvertToInt(dgvCategories.Rows[rowIndex].Cells["CategoryId"].Value.ToString());
                string Status = isDisabled(rowIndex) ? "1" : "0";

                if (CommonProcess.EnableDisableCategory(categoryId, Status))
                {
                    _message = String.Format("Category {0} ", isDisabled(rowIndex) ? "Re-enable successfully...!" : "is disabled now..!");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                    dgvCategories.FirstDisplayedScrollingRowIndex = firstRowIndex;
                }
                else
                {
                    _message = String.Format("Error in {0} catogory:", isDisabled(rowIndex) ? "Re-enabling the" : "disabling the");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { log.Error("Error while enabling/disabling category :" + ex.Message); }
        }
        #endregion
        #endregion
    }
}
