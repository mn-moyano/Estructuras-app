using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

class Program
{
    static void Main()
    {
        var document = new PdfDocument();
        document.Info.Title = "Reporte PDF";

        var page = document.AddPage();
        var gfx = XGraphics.FromPdfPage(page);
        var font = new XFont("Verdana", 20, XFontStyle.Bold);

        gfx.DrawString("¡Hola, Madelyn!", font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

        document.Save("ReporteMadelyn.pdf");
    }
}