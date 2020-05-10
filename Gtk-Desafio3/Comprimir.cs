using System;
//Libreria
using System.IO.Compression;
using System.IO;

namespace GtkDesafio3
{
    public class Comprimir
    {
        Recursos rs = new Recursos();
        public void Zip()
        {
            string SelfDir = Directory.GetCurrentDirectory();
            string pat = SelfDir + "/../CalculoEmple";
            string patzip = SelfDir + "/../hist/Hist.zip";
            if (File.Exists(patzip))
            {
                File.Delete(patzip);
            }
            ZipFile.CreateFromDirectory(pat, patzip);
        }

    }
}
