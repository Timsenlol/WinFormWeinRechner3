using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechner.Models;

namespace WeinRechnerWinForm.Business
{
    public interface IDataService
    {
        bool ReadSettings();
        void WriteSettings(bool best);
        void CreatePdf(Ergebnis_gen_Vs ergebnis);
    }
}
