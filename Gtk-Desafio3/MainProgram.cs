using System;
using Gtk;
namespace GtkDesafio3
{
    public partial class MainProgram : Gtk.Window
    {
        bool ErrorHora = false;
        Calc Cl = new Calc();
        public MainProgram() : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        protected void OnButton3Clicked(object sender, EventArgs e)
        {
            ErrorHora = Cl.Empresa(NAME_ENTRY.Text,CODE_ENTRY.Text,int.Parse(HORA_ENTRY.Text));
            if(ErrorHora == true)
            {
                MessageDialog em = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Close, "Ingreso mas de 250 horas de trabajo");
            }
        }
    }
}
