using BalajiTrader.Business.Classes;
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
using static BalajiTrader.Business.Models.Common;

namespace BalajiTrader.Client.UI.Masters
{
    public partial class frmUnits : BaseAsyncForm
    {
        #region  Instance Variable
        private static readonly ILog log = LogManager.GetLogger(typeof(frmUnits));
        public bool FStatus { get; set; }
        ToolTip toolTip1 = new ToolTip();
        private ValidationProcess _process;
        public static List<Units> _units;
        private Units _unit = null;
        private int _unitId = 0;
        private string _event = "New";

        private int rowIndex, columnIndex, firstRowIndex = 0;
        string _message = string.Empty;
        #endregion

        public frmUnits()
        {
            InitializeComponent();
            _process = new ValidationProcess();
            _unit = new Units();
            _unitId = 0;
            CommonProcess.AddUnit = _unit;
            _event = "New";
        }

        protected override void OnEscapePressed()
        {
            Close();
        }

        #region Events
        private void frmUnits_Load(object sender, EventArgs e)
        {
            BindUnitsDetails(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonProcess.AddCategory = null;
            Clear();
            FStatus = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetUnitObject();
            if (BindValidationsToControl())
            {
                if (CommonProcess.AddUpdateUnit(_unitId, _unit.UnitName, _unit.Unit))
                {
                    MessageBox.Show(string.Format("unit details {0} successfully..!", _event == "New" ? "inserted" : "updated"), Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FStatus = true;
                    Clear();
                    refreshData();
                }
                else
                {
                    MessageBox.Show(string.Format("Error {0} unit details..! \n{1}", _event == "New" ? "inserting" : "updating", Constant.assistsnce),
                        Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FStatus = false;
                }
            }
        }

        #endregion


        #region Methods
        private void Clear()
        {
            _unitId = 0;
            txtUnitName.Clear();
            txtUnit.Clear();
            _event = "New";
        }

        private void GetUnitObject()
        {
            #region Get Category Details
            _unit.UnitId = _unitId;
            _unit.UnitName = txtUnitName.Text;
            _unit.Unit = txtUnit.Text;
            #endregion
        }

        private bool BindValidationsToControl()
        {
            CommonProcess.AddUnit = _unit;
            ValidationErrors validateErrors = _process.UnitValidation;

            validationerrors.SetError(txtUnitName, validateErrors.GetMessageByProperty(Constant.Namekey));
            validationerrors.SetError(txtUnit, validateErrors.GetMessageByProperty(Constant.Namekey1));

            if (validateErrors.Count == 0)
                return true;
            else
                return false;
        }

        private void refreshData()
        {
            CommonProcess.GetAllUnits();
            BindUnitsDetails(0);
        }

        private void BindUnitsDetails(int unitId)
        {
            List<Units> _tmpUnits = new List<Units>();
            _tmpUnits = CommonProcess.GetUnits(unitId);

            _units = new List<Units>();
            foreach (Units _tmpunit in _tmpUnits)
            {
                _units.Add(CommonProcess.UnitCopy(_tmpunit));
            }

            if (_units.Count <= 0)
            {
                //stsMessage.Visible = true;
                dgvUnits.Visible = false;
                //stsMessage.DisplayText = "Data not found for 🔎 search criteria...!";
            }
            else
            {
                //stsMessage.Visible = false;
                dgvUnits.Visible = true;
            }

            var _list = _units.Select(ud => new
            {
                ud.UnitId,
                ud.UnitName,
                ud.Unit,
                ud.Status,
                ud.Created
            }).ToList();

            dgvUnits.DataSource = _list;
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
                foreach (DataGridViewRow row in dgvUnits.Rows)
                {
                    row.Cells["SrNo"].Value = i;
                    i++;

                    row.DefaultCellStyle.Font = Fonts.DefaultFont;
                    row.DefaultCellStyle.BackColor = Fonts.DefaultBackColor;


                    //Highlight the CategoryName
                    //row.Cells["CategoryName"].Style.Font = Fonts.DefaultBold;
                }

                //Hide columns
                DataGridViewColumnCollection column = dgvUnits.Columns;
                column["UnitId"].Visible = false;
                column["Status"].Visible = false;
                column["Created"].Visible = false;

                //Setting up Column width
                column["SrNo"].Width = 50;
                column["UnitName"].Width = dgvUnits.Rows.Count < 7 ? 243 : 227;
                column["Unit"].Width = 150;


                //Setting up Header Text
                column["SrNo"].HeaderText = "Sr No";
                column["UnitName"].HeaderText = "Unit Name";
                column["Unit"].HeaderText = "Unit Symbol";

                //column Read-Only
                column["SrNo"].ReadOnly = true;
                column["UnitName"].ReadOnly = true;
                column["Unit"].ReadOnly = true;

                //Setting up Alignment
                column["SrNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["UnitName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                column["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex) { log.Error("Error applying validations on grid"); }
        }

        private void AddButtonsToGrid()
        {
            try
            {
                DataGridViewColumnCollection column = dgvUnits.Columns;

                //Delete column before adding 
                if (dgvUnits.Columns.Contains("Edit"))
                    dgvUnits.Columns.Remove("Edit");

                //Add Edit Column
                DataGridViewImageColumn editImg = new DataGridViewImageColumn();
                editImg.HeaderText = "Edit";
                Image edit = Properties.Resources.edit;
                editImg.Image = edit;
                editImg.Name = "Edit";
                editImg.Width = 50;
                if (!dgvUnits.Columns.Contains("Edit"))
                    dgvUnits.Columns.Add(editImg);

                //Delete column before adding 
                if (dgvUnits.Columns.Contains("Delete"))
                    dgvUnits.Columns.Remove("Delete");

                //Add Delete Column
                DataGridViewImageColumn delImg = new DataGridViewImageColumn();
                delImg.HeaderText = "Disabled";
                Image del = Properties.Resources.enable;
                delImg.Image = del;
                delImg.Name = "Delete";
                delImg.Width = 50;
                if (!dgvUnits.Columns.Contains("Delete"))
                    dgvUnits.Columns.Add(delImg);

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
                for (int i = 0; i < dgvUnits.Rows.Count; i++)
                {
                    if (isDisabled(i))
                    {
                        dgvUnits.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        dgvUnits.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                        if (dgvUnits.Columns.Contains("Edit"))
                            dgvUnits.Rows[i].Cells["Edit"].Value = new Bitmap(1, 1);

                        if (dgvUnits.Columns.Contains("Delete"))
                            dgvUnits.Rows[i].Cells["Delete"].Value = Properties.Resources.disable;
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
            return dgvUnits.Rows[r].Cells["Status"].Value.ToString() == "0";
        }
        #endregion

        #region Grid Event
        private void dgvUnits_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { }
        }

        private void dgvUnits_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex != 6 && e.ColumnIndex != 7) || e.RowIndex < 0 || ((e.ColumnIndex == 6) && isDisabled(e.RowIndex)))
                {
                    dgvUnits.Cursor = Cursors.Default;
                    return;
                }

                dgvUnits.Cursor = Cursors.Hand;
                var cell = dgvUnits[e.ColumnIndex, e.RowIndex];
                if (e.ColumnIndex == 6)
                    cell.ToolTipText = "Edit unit details..!";
                else if (e.ColumnIndex == 7)
                    cell.ToolTipText = isDisabled(e.RowIndex) ? "Re-enable the unit" : "Disable the unit from here..!";
            }
            catch (Exception ex) { log.Error("Error on cell mouse enter :" + ex.Message); }
        }

        private void dgvUnits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            else if ((e.ColumnIndex == 6) && isDisabled(e.RowIndex)) //It is only to prevent edit if the category is disabled.
                return;
            else if (e.ColumnIndex == 6)
                EditUnit(e.RowIndex);
            else if (e.ColumnIndex == 7)
                EnableDisableUnit();
        }

        private void EditUnit(int r)
        {
            try
            {
                string UnitName = dgvUnits.Rows[r].Cells["UnitName"].Value.ToString();
                _message = string.Format("Want to edit {0} unit details.", UnitName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dialog == DialogResult.No)
                    return;

                _unitId = Validations.ConvertToInt(dgvUnits.Rows[r].Cells["UnitId"].Value.ToString());
                string Unit = dgvUnits.Rows[r].Cells["Unit"].Value.ToString();

                _event = "Edit";
                txtUnitName.Text = UnitName;
                txtUnit.Text = Unit;
            }
            catch (Exception ex) { log.Error("Error while editing unit details :" + ex.Message); }
        }

        private void EnableDisableUnit()
        {
            try
            {
                string UnitName = dgvUnits.Rows[rowIndex].Cells["UnitName"].Value.ToString();
                _message = String.Format("Want to {0} unit: {1}", isDisabled(rowIndex) ? "Re-enable the" : "disable the", UnitName);
                DialogResult _dialog = MessageBox.Show(_message, Constant.title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (_dialog == DialogResult.No)
                    return;

                firstRowIndex = dgvUnits.FirstDisplayedScrollingRowIndex;
                int unitid = Validations.ConvertToInt(dgvUnits.Rows[rowIndex].Cells["UnitId"].Value.ToString());
                string Status = isDisabled(rowIndex) ? "1" : "0";

                if (CommonProcess.EnableDisableUnit(unitid, Status))
                {
                    _message = String.Format("Unit {0} ", isDisabled(rowIndex) ? "Re-enable successfully...!" : "is disabled now..!");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                    dgvUnits.FirstDisplayedScrollingRowIndex = firstRowIndex;
                }
                else
                {
                    _message = String.Format("Error in {0} unit:", isDisabled(rowIndex) ? "Re-enabling the" : "disabling the");
                    MessageBox.Show(_message, Constant.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { log.Error("Error while enabling/disabling unit :" + ex.Message); }
        }
        #endregion
        #endregion
    }
}
