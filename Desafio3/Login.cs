using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Desafio3
{
    public class LogIn : Recursos
    {

        public bool LoginInit(string NombreIn, string PassIn)
        {
            Json js = new Json();
            bool Confirmacion = false;

            var Data_Logs = js.DesUS();
            foreach (var BusquedaLogs in Data_Logs.Log)
            {
                if (NombreIn == BusquedaLogs.User)
                {
                    string ShaPass = GetSHA256(PassIn);
                    if (ShaPass == BusquedaLogs.Pass)
                    {
                        string ruta = js.SelfDir + "/../Json_Data/Data_Temp.json";
                        if (File.Exists(ruta))
                        {
                            File.Delete(ruta);
                            FileStream fs = File.Create("Empresa.json");
                            fs.Close();

                            DATA_TEMP DT = new DATA_TEMP()
                            {
                                DATA = new List<DATA_LIST>()
                            };

                            File.WriteAllText(ruta, JsonConvert.SerializeObject(DT));

                        }
                        else
                        {
                            FileStream fs = File.Create(ruta);
                            fs.Close();
                        }

                            
                        FuncionProgram fg = new FuncionProgram();
                        fg.Show();
                    }
                    else
                    {
                        Confirmacion = true;

                    }

                }
                else
                {
                    Confirmacion = true;
                }
            }




            return Confirmacion;
        }
        public class DATA_TEMP
        {
            public List<DATA_LIST> DATA { get; set; }
        }

        public class DATA_LIST
        {
            public string NOM_EMPLE { get; set; }
            public string CODE_EMPLE { get; set; }
            public int HORA_EMPLE { get; set; }
            public double AFP { get; set; }
            public double RENTA { get; set; }
            public double ISS { get; set; }
            public double SAL_LIQUIDO { get; set; }
            public double SAL_NETO { get; set; }
        }
    }
}
