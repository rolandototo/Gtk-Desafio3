
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Table table1;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Label label4;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label Usuario;

	private global::Gtk.Entry entry1;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label3;

	private global::Gtk.Entry entry2;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("LogIn");
		this.vbox4.Add(this.label4);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label4]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.Usuario = new global::Gtk.Label();
		this.Usuario.Name = "Usuario";
		this.Usuario.LabelProp = global::Mono.Unix.Catalog.GetString("Usuario");
		this.hbox1.Add(this.Usuario);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Usuario]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.hbox1.Add(this.entry1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entry1]));
		w3.Position = 1;
		this.vbox4.Add(this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Contraseña");
		this.hbox2.Add(this.label3);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label3]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.hbox2.Add(this.entry2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entry2]));
		w6.Position = 1;
		this.vbox4.Add(this.hbox2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox2]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.table1.Add(this.vbox4);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.vbox4]));
		w8.TopAttach = ((uint)(1));
		w8.BottomAttach = ((uint)(2));
		w8.LeftAttach = ((uint)(1));
		w8.RightAttach = ((uint)(2));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		this.Add(this.table1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}