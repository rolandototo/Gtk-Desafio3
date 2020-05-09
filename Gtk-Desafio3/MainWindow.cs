using System;
using Gtk;
using System.Security;
using static System.Console;
using GtkDesafio3;

public partial class MainWindow : Gtk.Window
{
    LogIn lg = new LogIn();
    SendAlertEmail Sa = new SendAlertEmail();
    bool error = false;
    int ContSendEmail = 1;
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {

            error = lg.LoginInit(UsuarioIngreso.Text, PassIngreso.Text);
        if (ContSendEmail >3)
        {
            //Sa.Send(); En testeo la funcion 
            MessageDialog em = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Close, "Se a equibocado 3 veces se enviara un correo al administrador y se cerrara el programa");
            em.Run();
            em.Destroy();
            Application.Quit();
            
        }
        else if (error == true)
            {
                MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Close, "Usuario o Contraseña erronea");
                md.Run();
                md.Destroy();

                ContSendEmail++;
            }
        
        

    }

   
}
