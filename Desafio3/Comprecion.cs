using System;
using System.IO;
using System.IO.Compression;
namespace Desafio3
{
    public class Comprecion
    {
        Recursos rs = new Recursos();
        DateTime fecha = DateTime.Now;
        public void Zip()
        {
            string SelfDir = Directory.GetCurrentDirectory();
            string pat = SelfDir + "/../CalculoEmple";
            string patzip = SelfDir + "/../hist/calculoSalario_" + fecha.ToString("dd-MM-yyyy_HH-mm-ss") + ".zip";
            if (File.Exists(patzip))
            {
                File.Delete(patzip);
            }
            ZipFile.CreateFromDirectory(pat, patzip);
        }
    }
}
