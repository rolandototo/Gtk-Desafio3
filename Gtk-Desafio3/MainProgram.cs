using System;
using Gtk;
namespace GtkDesafio3
{
    public partial class MainProgram : Gtk.Window
    {
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
        }
    }
}
