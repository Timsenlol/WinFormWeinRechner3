using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechner.Models;

namespace WeinRechnerWinForm.Business
{
    public class DataService : IDataService
    {
        public bool ReadSettings()
        {

            return XmlHelper.Read(); ;
        }

        public void WriteSettings(bool best)
        {
            XmlHelper.WriteSettings(best);
        }

        public void CreatePdf(Ergebnis_gen_Vs ergebnis)
        {
            PdfHelper.CreatePdf(ergebnis);
        }


    }
}
