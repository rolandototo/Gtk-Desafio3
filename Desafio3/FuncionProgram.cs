using System.Collections.Generic;
using Gtk;

namespace Desafio3
{
    public partial class FuncionProgram : Gtk.Window
    {
        Calc Cl = new Calc();
        // Create a model that will hold two strings - Artist Name and Song Title
        Gtk.ListStore DATA_LIST_EMPLE = new Gtk.ListStore(typeof(string), typeof(string), typeof(int), typeof(double), typeof(double), typeof(double), typeof(double), typeof(double));

        public FuncionProgram() :
                base(Gtk.WindowType.Toplevel)
        {

            this.Build();

            TreeViewColumn CodeColumn = new TreeViewColumn
            {
                Title = "Codigo"
            };
            TreeViewColumn NomColumn = new TreeViewColumn
            {
                Title = "Nombre"
            };
            TreeViewColumn HoraColumn = new TreeViewColumn
            {
                Title = "Horas"
            };
            TreeViewColumn AFPCOL = new TreeViewColumn
            {
                Title = "AFP"
            };
            TreeViewColumn IssCol = new TreeViewColumn
            {
                Title = "ISSS"
            };
            TreeViewColumn RentCol = new TreeViewColumn
            {
                Title = "Renta"
            };
            TreeViewColumn SalaLiqcol = new TreeViewColumn
            {
                Title = "Sal.Liqui"
            };
            TreeViewColumn SalaNetCol = new TreeViewColumn
            {
                Title = "Sal.Neto"
            };
            // Add the columns to the TreeView
            treeview2.AppendColumn(CodeColumn);
            treeview2.AppendColumn(NomColumn);
            treeview2.AppendColumn(HoraColumn);
            treeview2.AppendColumn(AFPCOL);
            treeview2.AppendColumn(IssCol);
            treeview2.AppendColumn(RentCol);
            treeview2.AppendColumn(SalaLiqcol);
            treeview2.AppendColumn(SalaNetCol);
            // Assign the model to the TreeView
            treeview2.Model = DATA_LIST_EMPLE;

        }

        protected void OnButton2Clicked(object sender, System.EventArgs e)
        {
            int Datahora = Val();

            var DATA_OUT_CALC = Cl.Empresa(Nom_Entry.Text, Code_Entry.Text,Datahora );

            foreach (var DT_IN in DATA_OUT_CALC)
            {
                if (DT_IN.e == true)
                {
                    MessageDialog em = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Close, "Las horas no pueden ser meno a una hora");
                }
                else
                {
                    DATA_LIST_EMPLE.AppendValues(DT_IN.CODE_EMPLE1, DT_IN.NOM_EMPLE1, DT_IN.HORA_EMPLE1, DT_IN.AFP1, DT_IN.ISS1, DT_IN.RENTA1, DT_IN.SAL_LIQUIDO1, DT_IN.SAL_NETO1);

                }
            }

        }

        protected void OnDeleteEvent(object o, Gtk.DeleteEventArgs args)
        {
            Application.Quit();
            args.RetVal = true;
        }

        int Val()
        {
            int opcion;
            string op;
            bool opval = false;
            bool opdata = false;
            do
            {
                op = Hora_Entry.Text;

                //Opucpe Tryparse ya que devuelve datos booleanos
                opval = int.TryParse(op, out opcion);
                if (opcion > 250)
                {
                    opdata = false;
                    MessageDialog em = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Close, "Ingrese un monto valido en horas <= 250");
                }
                else
                {
                    opdata = true;
                }
                if (opval == false)
                {
                    MessageDialog em = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Close, "Ingrese un dato valido en horas");

                }
            }

            while (!opval&&!opdata);
            return opcion;
        }
    }
}
