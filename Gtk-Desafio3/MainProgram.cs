using System;
using Gtk;
namespace GtkDesafio3
{
    public partial class MainProgram : Gtk.Window
    {
        public MainProgram() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
