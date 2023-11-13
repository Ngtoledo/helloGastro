using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloGastro1._0
{
    public partial class frmTables : Form
    {
        public frmTables()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConslt_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditTable frmEditTable = new frmEditTable();
            frmEditTable.Show();
        }

        private void btnOpenTable_Click(object sender, EventArgs e)
        {
            frmOpenTable frmOpenTable = new frmOpenTable();
            frmOpenTable.Show();
        }

        private void btnCloseTable_Click(object sender, EventArgs e)
        {
            frmCloseTable frmCloseTable = new frmCloseTable();
            frmCloseTable.Show();

        }

    }
}
