using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weinrechner.Models;

namespace WeinRechnerWinForm
{
    public partial class Verschnittcs : UserControl
    {

        private Controller _controller = new Controller();
        Ergebnis_gen_Vs ergebnis;
        public Verschnittcs()
        {
            InitializeComponent();


        }




        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out _))
            {


                MessageBox.Show("Bitte geben Sie valide Werte ein", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                errorProvider1.SetError(textBox1,"Bitte geben Sie valide Werte ein");
                return;

            }
            ergebnis = _controller.VerschnittGenerellBerechnung(Convert.ToDouble(textBox1.Text));
            EregbnisMeneSüßwein.Text = ergebnis.max_sr1.ToString();
            ErgebnisMaxMengeSüßreserve2.Text = ergebnis.max_sr2.ToString();
            ErgebnisMengeMaxMengeVerschnittWein.Text = ergebnis.max_vw.ToString();
            ErgebnisMengeverschnittWein.Text = ergebnis.max_vw1.ToString();
            ZeigeErgebnis();

        }

        private void ZeigeErgebnis()
        {
            tableLayoutPanel1.Visible = true;
            Export.Visible = true;

        }

        private void Export_Click(object sender, EventArgs e)
        {
            _controller.Berechnungsklasse.Datenzugriff.CreatePdf(ergebnis);
        }


    }
}
