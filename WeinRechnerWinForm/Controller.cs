using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechner.Models;
using WeinRechnerWinForm.Business;

namespace WeinRechnerWinForm
{
    public class Controller
    {
        public Controller()
        {
            berechnungsklasse = new Berechnungsklasse();
        }

        private Berechnungsklasse berechnungsklasse;

        public Berechnungsklasse Berechnungsklasse
        {

            get
            {
                return berechnungsklasse;
            }


            set
            {
                berechnungsklasse = value;
            }
        }


        public Ergebnis_gen_Vs VerschnittGenerellBerechnung(double mengeLiter)
         {

            return berechnungsklasse.BerechneVerschnittGenerell(mengeLiter);
         }
    }
}
