using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeinRechnerWinForm.Business;

namespace WeinRechnerWinForm
{
    public partial class Weinrechner : Form
    {
        public bool zugestimmt;
        Controller controller = new Controller();
        public Weinrechner()
        {
            InitializeComponent();
            zugestimmt = controller.Berechnungsklasse.Datenzugriff.ReadSettings();
            if (!zugestimmt)
            {
                menuStrip1.Visible = false;
                LoadNutzBed();
            }

            WindowState = FormWindowState.Normal;

        }

        private void LoadNutzBed()
        {
            splitContainer1.Panel2.Controls.Add(new Nutzerbedinungen(this));
            splitContainer1.Panel2.Controls[0].Dock = DockStyle.Fill;
        }

        public void OnSelectedIndexChangedcomboAuswahlRechnung(object sender,
        EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new Verschnittcs());
            splitContainer1.Panel2.Controls[0].Dock = DockStyle.Fill;



        }

        private void impressumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new Impressum());
            splitContainer1.Panel2.Controls[0].Dock = DockStyle.Fill;
        }

        private void nutzungsbedingungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new Nutzerbedinungen(this));
            splitContainer1.Panel2.Controls[0].Dock = DockStyle.Fill;
        }
    }
}
