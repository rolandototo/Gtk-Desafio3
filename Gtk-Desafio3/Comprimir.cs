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
            string path = @"CalculoEmple";
            string pathzip = @"CalculoEmple.zip";

            ZipFile.CreateFromDirectory(path, pathzip);

            // ZipFile.ExtractToDirectory(pathzip, path);
        }

    }
}
