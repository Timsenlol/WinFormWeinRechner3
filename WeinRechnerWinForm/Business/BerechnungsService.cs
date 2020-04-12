using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechner.Models;

namespace WeinRechnerWinForm.Business
{
    public class BerechnungsService : IBrechnungsService
    {
        public Ergebnis_gen_Vs BerechneVerschnittGenerellService(double mengeLiter)
        {
            var ergebnis = new Ergebnis_gen_Vs();

            //1. Berechnung
            double a;
            a = mengeLiter / 0.85 - mengeLiter;
            double b = Math.Floor(a);
            ergebnis.max_vw = Convert.ToInt32(a);

            //2. Berechnung
            double x;
            x = mengeLiter / 0.75 - mengeLiter;
            x = Math.Floor(x);
            ergebnis.max_sr1 = Convert.ToInt32(x);

            //3. Berechnung
            //Ausgabe max_sr2
            double z;
            z = mengeLiter / 0.75 - (Convert.ToDouble(ergebnis.max_vw) + mengeLiter);
            z = Math.Floor(z);
            ergebnis.max_sr2 = Convert.ToInt32(z);
            ergebnis.max_vw1 = ergebnis.max_vw;
            return ergebnis;
        }
    }
}
