using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechner.Models;

namespace WeinRechnerWinForm.Business
{
    public class Berechnungsklasse
    {

        public IDataService Datenzugriff = new DataService();

        public Ergebnis_gen_Vs BerechneVerschnittGenerell(double mengeLiter)
        {
            var berechnungsService = new BerechnungsService();
            return berechnungsService.BerechneVerschnittGenerellService(mengeLiter);

        }


    }

}
