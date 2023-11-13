using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using helloGastro1._0;

namespace helloGastro1._0
{
    public class Globals
    {
        public class FuncionesComunes
        {
            public void ControlTxt(Button btn, TextBox txtUser, TextBox txtPass)
            {
                if (txtPass.Text != "" && txtUser.Text != "")
                {
                    btn.Visible = true;
                }
            }
            public void FormToPanel(Form formToShow, Panel panelToShowIn)
            {
                formToShow.TopLevel = false;
                panelToShowIn.Controls.Clear();
                panelToShowIn.Controls.Add(formToShow);
                formToShow.Dock = DockStyle.Fill;   
                formToShow.Show();
            }
        }

    }
}