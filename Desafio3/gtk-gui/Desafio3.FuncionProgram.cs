
// This file has been generated by the GUI designer. Do not modify.
namespace Desafio3
{
	public partial class FuncionProgram
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action saveAction;

		private global::Gtk.Action dialogInfoAction;

		private global::Gtk.Action sortAscendingAction;

		private global::Gtk.Action sortDescendingAction;

		private global::Gtk.Action dndAction;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Toolbar toolbar1;

		private global::Gtk.Table table2;

		private global::Gtk.Button button2;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.Label label5;

		private global::Gtk.Table table4;

		private global::Gtk.Entry Code_Entry;

		private global::Gtk.Entry Hora_Entry;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.Entry Nom_Entry;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Button button3;

		private global::Gtk.Button button1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeview2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Desafio3.FuncionProgram
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.saveAction = new global::Gtk.Action("saveAction", null, null, "gtk-save");
			w1.Add(this.saveAction, null);
			this.dialogInfoAction = new global::Gtk.Action("dialogInfoAction", null, null, "gtk-dialog-info");
			w1.Add(this.dialogInfoAction, null);
			this.sortAscendingAction = new global::Gtk.Action("sortAscendingAction", null, null, "gtk-sort-ascending");
			w1.Add(this.sortAscendingAction, null);
			this.sortDescendingAction = new global::Gtk.Action("sortDescendingAction", null, null, "gtk-sort-descending");
			w1.Add(this.sortDescendingAction, null);
			this.dndAction = new global::Gtk.Action("dndAction", null, null, "gtk-dnd");
			w1.Add(this.dndAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "Desafio3.FuncionProgram";
			this.Title = global::Mono.Unix.Catalog.GetString("FuncionProgram");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Desafio3.FuncionProgram.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar1\'><toolitem name=\'saveAction\' action=\'saveAction\'/></t" +
					"oolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.vbox3.Add(this.toolbar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.toolbar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.BorderWidth = ((uint)(9));
			this.button2.Label = global::Mono.Unix.Catalog.GetString("Operar y Mostrar");
			this.table2.Add(this.button2);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2[this.button2]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XPadding = ((uint)(8));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.table2.Add(this.hseparator1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2[this.hseparator1]));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.table2.Add(this.hseparator2);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2[this.hseparator2]));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Datos trabajadores");
			this.table2.Add(this.label5);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.label5]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(0));
			w6.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table2.Gtk.Table+TableChild
			this.table4 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			this.table4.BorderWidth = ((uint)(24));
			// Container child table4.Gtk.Table+TableChild
			this.Code_Entry = new global::Gtk.Entry();
			this.Code_Entry.CanFocus = true;
			this.Code_Entry.Name = "Code_Entry";
			this.Code_Entry.IsEditable = true;
			this.Code_Entry.InvisibleChar = '•';
			this.table4.Add(this.Code_Entry);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table4[this.Code_Entry]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.Hora_Entry = new global::Gtk.Entry();
			this.Hora_Entry.CanFocus = true;
			this.Hora_Entry.Name = "Hora_Entry";
			this.Hora_Entry.IsEditable = true;
			this.Hora_Entry.InvisibleChar = '•';
			this.table4.Add(this.Hora_Entry);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table4[this.Hora_Entry]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Codigo: ");
			this.label6.Justify = ((global::Gtk.Justification)(2));
			this.table4.Add(this.label6);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table4[this.label6]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre del Trabajador");
			this.table4.Add(this.label7);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table4[this.label7]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Horas trabajadas");
			this.table4.Add(this.label8);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table4[this.label8]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.Nom_Entry = new global::Gtk.Entry();
			this.Nom_Entry.CanFocus = true;
			this.Nom_Entry.Name = "Nom_Entry";
			this.Nom_Entry.IsEditable = true;
			this.Nom_Entry.InvisibleChar = '•';
			this.table4.Add(this.Nom_Entry);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table4[this.Nom_Entry]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table2.Add(this.table4);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2[this.table4]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(7));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("Mostrar Max/Min");
			this.vbox1.Add(this.button3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.button3]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Mostrar Sal>300");
			this.vbox1.Add(this.button1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.button1]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.table2.Add(this.vbox1);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2[this.vbox1]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(2));
			w16.RightAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add(this.table2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.table2]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview2 = new global::Gtk.TreeView();
			this.treeview2.CanFocus = true;
			this.treeview2.Name = "treeview2";
			this.GtkScrolledWindow.Add(this.treeview2);
			this.vbox3.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.GtkScrolledWindow]));
			w19.Position = 2;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 681;
			this.DefaultHeight = 542;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.saveAction.Activated += new global::System.EventHandler(this.OnSaveActionActivated);
			this.button3.Clicked += new global::System.EventHandler(this.OnButton3Clicked);
			this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
			this.button2.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
		}
	}
}
