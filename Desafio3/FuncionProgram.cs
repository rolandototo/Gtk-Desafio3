using System;
using System.Collections.Generic;
using System.IO;
using Gtk;

namespace Desafio3
{
    public partial class FuncionProgram : Gtk.Window
    {
        Calc Cl = new Calc();
        Json js = new Json();
        DateTime fecha = DateTime.Now;
        Comprecion Cp = new Comprecion();
        // Create a model that will hold two strings - Artist Name and Song Title
        Gtk.ListStore DATA_LIST_EMPLE = new Gtk.ListStore(typeof(string), typeof(string), typeof(int), typeof(double), typeof(double), typeof(double), typeof(double), typeof(double));


        TreeViewColumn CodeColumn, NomColumn, HoraColumn, AFPCOL, IssCol, RentCol, SalaLiqcol, SalaNetCol;
        CellRendererText CodeCell, NomCell, HoraCell, AFPCell, IssCell, RentCell, SalaLiqcell, SalaNetCell;

        public FuncionProgram() :
                base(Gtk.WindowType.Toplevel)
        {

            this.Build();
            CodeColumn = new TreeViewColumn { Title = "Codigo" };
            CodeCell = new CellRendererText();
            CodeColumn.PackStart(CodeCell, true);

            NomColumn = new TreeViewColumn { Title = "Nombre" };
            NomCell = new CellRendererText();
            NomColumn.PackStart(NomCell, true);

            HoraColumn = new TreeViewColumn { Title = "Horas" };
            HoraCell = new CellRendererText();
            HoraColumn.PackStart(HoraCell, true);

            AFPCOL = new TreeViewColumn { Title = "AFP" };
            AFPCell = new CellRendererText();
            AFPCOL.PackStart(AFPCell, true);

            IssCol = new TreeViewColumn { Title = "ISSS" };
            IssCell = new CellRendererText();
            IssCol.PackStart(IssCell, true);

            RentCol = new TreeViewColumn { Title = "Renta" };
            RentCell = new CellRendererText();
            RentCol.PackStart(RentCell, true);

            SalaLiqcol = new TreeViewColumn { Title = "Sal.Liqui" };
            SalaLiqcell = new CellRendererText();
            SalaLiqcol.PackStart(SalaLiqcell, true);

            SalaNetCol = new TreeViewColumn { Title = "Sal.Neto" };
            SalaNetCell = new CellRendererText();
            SalaNetCol.PackStart(SalaNetCell, true);

            // Add the columns to the TreeView
            treeview2.AppendColumn(CodeColumn);
            treeview2.AppendColumn(NomColumn);
            treeview2.AppendColumn(HoraColumn);
            treeview2.AppendColumn(AFPCOL);
            treeview2.AppendColumn(IssCol);
            treeview2.AppendColumn(RentCol);
            treeview2.AppendColumn(SalaLiqcol);
            treeview2.AppendColumn(SalaNetCol);

            CodeColumn.AddAttribute(CodeCell, "text", 0);
            NomColumn.AddAttribute(NomCell, "text", 1);
            HoraColumn.AddAttribute(HoraCell, "text", 2);
            AFPCOL.AddAttribute(AFPCell, "text", 3);
            IssCol.AddAttribute(IssCell, "text", 4);
            RentCol.AddAttribute(RentCell, "text", 5);
            SalaLiqcol.AddAttribute(SalaLiqcell, "text", 6);
            SalaNetCol.AddAttribute(SalaNetCell, "text", 7);

            // Assign the model to the TreeView

            treeview2.Model = DATA_LIST_EMPLE;
        }

        protected void OnButton2Clicked(object sender, System.EventArgs e)
        {
            int Datahora = Val();

            var DATA_OUT_CALC = Cl.Empresa(Nom_Entry.Text, Code_Entry.Text, Datahora);

            foreach (var DT_IN in DATA_OUT_CALC)
            {
                if (DT_IN.e == true)
                {
                    MessageDialog em = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Close, "Las horas no pueden ser meno a una hora");
                }
                else
                {
                    DATA_LIST_EMPLE.AppendValues(DT_IN.CODE_EMPLE1, DT_IN.NOM_EMPLE1, DT_IN.HORA_EMPLE1, DT_IN.AFP1, DT_IN.ISS1, DT_IN.RENTA1, DT_IN.SAL_LIQUIDO1, DT_IN.SAL_NETO1);


                    ShowAll();
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

            while (!opval && !opdata);
            return opcion;
        }

        protected void OnSaveActionActivated(object sender, System.EventArgs e)
        {
            var DATA_JSON = js.DesTemp();
            string ruta = js.SelfDir + "/../CalculoEmple/calculoSalario_" + fecha.ToString("dd-MM-yyyy_HH-mm-ss") + ".txt";
            using (StreamWriter sw = new StreamWriter(ruta, true))
            {
                foreach (var DT in DATA_JSON.DATA)
                {
                    sw.WriteLine("-------------------------------\n");
                    sw.WriteLine("Código empleado: "+DT.CODE_EMPLE);
                    sw.WriteLine("Nombre Empleado: " + DT.NOM_EMPLE);
                    sw.WriteLine("Horas = " + DT.HORA_EMPLE);
                    sw.WriteLine("ISSS = $" + DT.ISS);
                    sw.WriteLine("AFP = $" + DT.AFP);
                    sw.WriteLine("RENTA = $" + DT.RENTA);
                    sw.WriteLine("SUELDO L = $" + DT.SAL_LIQUIDO);
                    sw.WriteLine("SUELDO NETO = $" + DT.SAL_NETO+"\n");
                    sw.WriteLine("-------------------------------");

                }

            }
            Cp.Zip();

        }

        protected void OnSortDescendingActionActivated(object sender, EventArgs e)
        {

        }

        protected void OnSortAscendingActionActivated(object sender, EventArgs e)
        {

        }


    }
}
