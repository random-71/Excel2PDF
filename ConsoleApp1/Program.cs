using ConsoleApp1.AsposePdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Byte[] data = AsposeTransfrom.ExcelToPdf("");

                File.WriteAllBytes("EndFile.pdf", data);

                Console.WriteLine("Proccess finished");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any Key...");
                Console.ReadKey();
            }

        }
    }
}
