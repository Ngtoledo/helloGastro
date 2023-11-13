using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using helloGastro1._0;

namespace helloGastro1._0
{
    public partial class frmInitial : Form
    {

        public frmInitial()
        {
            InitializeComponent();
        }

        private void frmInitial_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm");
            btnStart.Visible = false;
            btnTable.Visible = false;
            btnMoves.Visible = false;
            btnProducts.Visible = false;
            btnSuppliers.Visible = false;
            btnCustomer.Visible = false;
            btnEmployee.Visible = false;
            btnReports.Visible = false;
            btnFinish.Visible = false;
            lblUserName.Visible = false;
            btnLog.Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            frmTables frmTables = new frmTables();
            Globals.FuncionesComunes funcionesComunes = new Globals.FuncionesComunes();
            funcionesComunes.FormToPanel(frmTables, panelContainer);

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            Globals.FuncionesComunes funcionesComunes = new Globals.FuncionesComunes();
            funcionesComunes.ControlTxt(btnLog, txtUser, txtPass);

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            Globals.FuncionesComunes funcionesComunes = new Globals.FuncionesComunes();
            funcionesComunes.ControlTxt(btnLog, txtUser, txtPass);

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            btnTable.Visible = true;
            btnMoves.Visible = true;
            btnProducts.Visible = true;
            btnSuppliers.Visible = true;
            btnCustomer.Visible = true;
            btnEmployee.Visible = true;
            btnReports.Visible = true;
            btnFinish.Visible = true;
            lblUser.Text = "Nehemias";
            lblUserName.Visible = true;


        }
    }
}
