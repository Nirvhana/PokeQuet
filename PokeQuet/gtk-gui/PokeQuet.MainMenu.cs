
// This file has been generated by the GUI designer. Do not modify.
namespace PokeQuet
{
	public partial class MainMenu
	{
		private global::Gtk.Table table1;

		private global::Gtk.Button button59;

		private global::Gtk.Entry entryPlayerName;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.RadioButton radiobuttonAIType1;

		private global::Gtk.RadioButton radiobuttonAIType2;

		private global::Gtk.RadioButton radiobuttonStarting1;

		private global::Gtk.RadioButton radiobuttonStarting2;

		private global::Gtk.RadioButton radiobuttonStarting3;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget PokeQuet.MainMenu
			this.Name = "PokeQuet.MainMenu";
			this.Title = global::Mono.Unix.Catalog.GetString("MainMenu");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child PokeQuet.MainMenu.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(7)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.button59 = new global::Gtk.Button();
			this.button59.CanFocus = true;
			this.button59.Name = "button59";
			this.button59.UseUnderline = true;
			this.button59.Label = global::Mono.Unix.Catalog.GetString("Start Game");
			this.table1.Add(this.button59);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.button59]));
			w1.TopAttach = ((uint)(6));
			w1.BottomAttach = ((uint)(7));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryPlayerName = new global::Gtk.Entry();
			this.entryPlayerName.CanFocus = true;
			this.entryPlayerName.Name = "entryPlayerName";
			this.entryPlayerName.Text = global::Mono.Unix.Catalog.GetString("Red");
			this.entryPlayerName.IsEditable = true;
			this.entryPlayerName.InvisibleChar = '●';
			this.table1.Add(this.entryPlayerName);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.entryPlayerName]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("AI Type:");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Player Name:");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Starting Player:");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonAIType1 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Bug Catcher"));
			this.radiobuttonAIType1.CanFocus = true;
			this.radiobuttonAIType1.Name = "radiobuttonAIType1";
			this.radiobuttonAIType1.DrawIndicator = true;
			this.radiobuttonAIType1.UseUnderline = true;
			this.radiobuttonAIType1.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.table1.Add(this.radiobuttonAIType1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonAIType1]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonAIType2 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Gym Leader"));
			this.radiobuttonAIType2.CanFocus = true;
			this.radiobuttonAIType2.Name = "radiobuttonAIType2";
			this.radiobuttonAIType2.DrawIndicator = true;
			this.radiobuttonAIType2.UseUnderline = true;
			this.radiobuttonAIType2.Group = this.radiobuttonAIType1.Group;
			this.table1.Add(this.radiobuttonAIType2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonAIType2]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonStarting1 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Player 1 (Human)"));
			this.radiobuttonStarting1.CanFocus = true;
			this.radiobuttonStarting1.Name = "radiobuttonStarting1";
			this.radiobuttonStarting1.DrawIndicator = true;
			this.radiobuttonStarting1.UseUnderline = true;
			this.radiobuttonStarting1.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.table1.Add(this.radiobuttonStarting1);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonStarting1]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonStarting2 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Player 2 (AI)"));
			this.radiobuttonStarting2.CanFocus = true;
			this.radiobuttonStarting2.Name = "radiobuttonStarting2";
			this.radiobuttonStarting2.DrawIndicator = true;
			this.radiobuttonStarting2.UseUnderline = true;
			this.radiobuttonStarting2.Group = this.radiobuttonStarting1.Group;
			this.table1.Add(this.radiobuttonStarting2);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonStarting2]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonStarting3 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Random"));
			this.radiobuttonStarting3.CanFocus = true;
			this.radiobuttonStarting3.Name = "radiobuttonStarting3";
			this.radiobuttonStarting3.DrawIndicator = true;
			this.radiobuttonStarting3.UseUnderline = true;
			this.radiobuttonStarting3.Group = this.radiobuttonStarting1.Group;
			this.table1.Add(this.radiobuttonStarting3);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonStarting3]));
			w10.TopAttach = ((uint)(5));
			w10.BottomAttach = ((uint)(6));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.button59.Clicked += new global::System.EventHandler(this.StartGameClicked);
		}
	}
}