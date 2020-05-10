using System;
using Gtk;
namespace GtkDesafio3
{
    public partial class MainProgram : Gtk.Window
    {
        bool ErrorHora = false;
        Calc Cl = new Calc();
        int HORAS;
        public MainProgram() : base(Gtk.WindowType.Toplevel)
        {
            Build();
        }
        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        protected void OnButton3Clicked(object sender, EventArgs e)
        {
            valMenu();

            ErrorHora = Cl.Empresa(NAME_ENTRY.Text, CODE_ENTRY.Text, HORAS);
            if (ErrorHora == true)
            {
                MessageDialog em = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Close, "Ingreso mas de 250 horas de trabajo");
            }
        }
        void valMenu()
        {
            string op;
            bool opval = false;
            do
            {
                op = HORA_ENTRY.Text;
                opval = int.TryParse(op, out HORAS);
                if (opval == false)
                {
                    MessageDialog em = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Close, "Ingrese dato valido en el campo horas");
                }
            }
            while (!opval);
        }

    }
}
