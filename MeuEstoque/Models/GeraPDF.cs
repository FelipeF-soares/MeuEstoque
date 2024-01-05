using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;

namespace MeuEstoque.Models;

public class GeraPDF
{
    private string path;
    private string diretorio;
    private Recibo _recibo;
    private Document document;

    public GeraPDF(Recibo recibo)
    {
        _recibo = recibo;
        diretorio = @"C:\Recibos\";
        path = @"C:\Recibos\UltimoRecibo.pdf"; 
        if (!(Directory.Exists(diretorio)))
        {
            Directory.CreateDirectory(diretorio);
        }
        document = new Document(PageSize.A4);
        document.SetMargins(40, 40, 40, 80);
        document.AddCreationDate();
        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
        
    }


    public void Materiais()
    {
        document.Open();
        Paragraph paragraph = new Paragraph();
        paragraph.Alignment = Element.ALIGN_CENTER;
        paragraph.Add(_recibo.ToString());
        document.Add(paragraph);
        document.Close();
    }

    public void AbriArquivo()
    {
        Process.Start("explorer.exe",path);
    }
}
