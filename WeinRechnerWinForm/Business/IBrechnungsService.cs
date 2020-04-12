using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechner.Models;

namespace WeinRechnerWinForm.Business
{
    interface IBrechnungsService
    {
        Ergebnis_gen_Vs BerechneVerschnittGenerellService (double mengeLiter);

      
     
    }
}
