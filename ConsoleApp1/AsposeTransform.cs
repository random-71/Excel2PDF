using Aspose.Cells;
using System.Globalization;
using System.IO;

namespace ConsoleApp1.AsposePdf
{
    public static class AsposeTransfrom
    {

        public static byte[] ExcelToPdf(string name)
        {
            try
            {
                Aspose.Cells.License license = new Aspose.Cells.License();
                license.SetLicense(@"C:\Aspose.Total.NET.lic");

                using (Stream data = new FileStream("PoS Support.xlsx", FileMode.Open, FileAccess.Read))
                {
                    
                    data.Position = 0;

                    using (MemoryStream dstStream = new MemoryStream())
                    {
                        var s = new Workbook(data);
                        s.Save(@"kk.pdf");
                        s.Save(dstStream, SaveFormat.Pdf);
                        return dstStream.ToArray();
                    } 
                }
            }
            catch
            {
                return new byte[0];
            }
        }

    }
}
