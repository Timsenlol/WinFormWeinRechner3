using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechner.Models;

namespace WeinRechnerWinForm.Business
{
    public static class PdfHelper
    {
        public static void CreatePdf(Ergebnis_gen_Vs ergebnis)
        {


            PdfDocument document = new PdfDocument();


            document.Info.Title = "Verschnitt generell";

            PdfPage page = document.AddPage();


            XGraphics gfx = XGraphics.FromPdfPage(page);



            //XTextFormatter tf = new XTextFormatter(gfx);

            XFont font = new XFont("Arial", 22, XFontStyle.BoldItalic);
            XFont font2 = new XFont("Arial", 18, XFontStyle.Italic);
            XFont font3 = new XFont("Arial", 13, XFontStyle.Regular);
            XFont font4 = new XFont("Arial", 13, XFontStyle.Bold);

            gfx.DrawString("Verschnitt generell", font, XBrushes.Black, new XRect(50, 50, page.Width, page.Height), XStringFormats.TopCenter);


            gfx.DrawString("1: Verschnitt Basiswein ", font2, XBrushes.Black, new XRect(50, 100, page.Width - 200, 600), XStringFormats.TopLeft);

            var recta = new XRect(50, 130, page.Width - 200, 600);

            gfx.DrawString("Max. Menge Verschnittwein: " + ergebnis.max_vw1, font3, XBrushes.Black, recta, XStringFormats.TopLeft);
            gfx.DrawString(Convert.ToString(ergebnis.max_vw1), font4, XBrushes.Black, recta, XStringFormats.TopRight);

            gfx.DrawString("2. Verschnittberechnung: Basiswein + Süßreserve", font2, XBrushes.Black, new XRect(50, 180, page.Width - 200, 600), XStringFormats.TopLeft);


            var rectb = new XRect(50, 210, page.Width - 200, 600);

            gfx.DrawString("max Menge Süßwein : ", font3, XBrushes.Black, rectb, XStringFormats.TopLeft);

            gfx.DrawString(Convert.ToString(ergebnis.max_sr2), font4, XBrushes.Black, rectb, XStringFormats.TopRight);




            gfx.DrawString("3.Verschnittberechnung: Basiswein + Verschnittwein + Süßreserve", font2, XBrushes.Black, new XRect(50, 260, page.Width - 200, 600), XStringFormats.TopLeft);

            var rectc = new XRect(50, 290, page.Width - 200, 600);
            gfx.DrawString("max Menge Verschnittwein : " , font3, XBrushes.Black, rectc, XStringFormats.TopLeft);
            gfx.DrawString(Convert.ToString(ergebnis.max_vw), font4, XBrushes.Black, rectc, XStringFormats.TopRight);

            var rectd = new XRect(50, 320, page.Width - 200, 600);

            gfx.DrawString("max Menge Süßreserve : ", font3, XBrushes.Black, rectd, XStringFormats.TopLeft);
            gfx.DrawString(Convert.ToString(ergebnis.max_sr1), font4, XBrushes.Black, rectd, XStringFormats.TopRight);

            const string filename = "Verschnitt generell.pdf";

            document.Save(filename);



            Process.Start(filename);



        }
    }
}
