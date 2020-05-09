using System;
using System.Security;
namespace GtkDesafio3
{
    public class LogIn : Recursos
    {

       public bool LoginInit(string NombreIn,string PassIn)
        {
            Json js = new Json();
            bool Confirmacion=false;
            
            var Data_Logs = js.DesUS();
            foreach (var BusquedaLogs in Data_Logs.Log)
            {
                if (NombreIn == BusquedaLogs.User)
                {
                    string ShaPass = GetSHA256(PassIn);
                    if (ShaPass == BusquedaLogs.Pass)
                    {

                        MainProgram Mp = new MainProgram();
                        Mp.Show();
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
    }
}
