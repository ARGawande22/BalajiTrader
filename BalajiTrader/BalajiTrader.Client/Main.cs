using BalajiTrader.Client.UI.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalajiTrader.Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tsCategory_Click(object sender, EventArgs e)
        {
            frmCategory _frmCatagory = new frmCategory();
            _frmCatagory.ShowDialog();
        }

        private void tsBrands_Click(object sender, EventArgs e)
        {
            frmBrand _frmBrand = new frmBrand();
            _frmBrand.ShowDialog();
        }

        private void tsUnits_Click(object sender, EventArgs e)
        {
            frmUnits _frmUnits = new frmUnits();
            _frmUnits.ShowDialog();
        }

        private void tsSizes_Click(object sender, EventArgs e)
        {
            frmSizes _frmSizes = new frmSizes();
            _frmSizes.ShowDialog();
        }
    }
}
