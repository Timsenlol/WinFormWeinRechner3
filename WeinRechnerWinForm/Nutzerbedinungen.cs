using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeinRechnerWinForm
{
    public partial class Nutzerbedinungen : UserControl
    {
        Controller controller = new Controller();

        Weinrechner _weinrechner;
        public Nutzerbedinungen(Weinrechner weinrechner)
        {
            InitializeComponent();
            _weinrechner = weinrechner;
           if (_weinrechner.zugestimmt)
            {
                button1.Visible = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            controller.Berechnungsklasse.Datenzugriff.WriteSettings(true);
            this._weinrechner.splitContainer1.Panel2.Controls.Clear();
            this._weinrechner.menuStrip1.Visible = true;
        }
    }
}
