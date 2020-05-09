using System;
using System.IO.Compression;


namespace GtkDesafio3
{
    public class ZipFile
    {
        Recursos rs = new Recursos();
        public void Zip()
        {
            string path = @"Archivos";
            string pathzip = @"Archivos.zip";

        //    ZipFile.CreateFromDirectory(path, pathzip);

            // ZipFile.ExtractToDirectory(pathzip, path);
        }
    }
}
