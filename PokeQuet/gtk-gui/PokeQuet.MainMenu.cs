
// This file has been generated by the GUI designer. Do not modify.
namespace PokeQuet
{
	public partial class MainMenu
	{
		private global::Gtk.Table table1;

		private global::Gtk.Button button59;

		private global::Gtk.Button buttonQuit;

		private global::Gtk.Entry entryPlayerName;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HSeparator hseparator21;

		private global::Gtk.HSeparator hseparator3;

		private global::Gtk.HSeparator hseparator5;

		private global::Gtk.HSeparator hseparator7;

		private global::Gtk.HSeparator hseparator9;

		private global::Gtk.Image imageMainMenu;

		private global::Gtk.Label label1;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.RadioButton radiobuttonAIType1;

		private global::Gtk.RadioButton radiobuttonAIType2;

		private global::Gtk.RadioButton radiobuttonDeckSize16;

		private global::Gtk.RadioButton radiobuttonDeckSize4;

		private global::Gtk.RadioButton radiobuttonDeckSize8;

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
			this.table1 = new global::Gtk.Table(((uint)(15)), ((uint)(5)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(4));
			this.table1.BorderWidth = ((uint)(1));
			// Container child table1.Gtk.Table+TableChild
			this.button59 = new global::Gtk.Button();
			this.button59.CanFocus = true;
			this.button59.Name = "button59";
			this.button59.UseUnderline = true;
			this.button59.Label = global::Mono.Unix.Catalog.GetString("Start Game");
			this.table1.Add(this.button59);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.button59]));
			w1.TopAttach = ((uint)(13));
			w1.BottomAttach = ((uint)(14));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonQuit = new global::Gtk.Button();
			this.buttonQuit.CanFocus = true;
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.UseUnderline = true;
			this.buttonQuit.Label = global::Mono.Unix.Catalog.GetString("_Quit Game");
			this.table1.Add(this.buttonQuit);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.buttonQuit]));
			w2.TopAttach = ((uint)(13));
			w2.BottomAttach = ((uint)(14));
			w2.LeftAttach = ((uint)(4));
			w2.RightAttach = ((uint)(5));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryPlayerName = new global::Gtk.Entry();
			this.entryPlayerName.CanFocus = true;
			this.entryPlayerName.Name = "entryPlayerName";
			this.entryPlayerName.Text = global::Mono.Unix.Catalog.GetString("Red");
			this.entryPlayerName.IsEditable = true;
			this.entryPlayerName.InvisibleChar = '●';
			this.table1.Add(this.entryPlayerName);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.entryPlayerName]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.table1.Add(this.hseparator1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator1]));
			w4.TopAttach = ((uint)(12));
			w4.BottomAttach = ((uint)(13));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator21 = new global::Gtk.HSeparator();
			this.hseparator21.Name = "hseparator21";
			this.table1.Add(this.hseparator21);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator21]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.RightAttach = ((uint)(5));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator3 = new global::Gtk.HSeparator();
			this.hseparator3.Name = "hseparator3";
			this.table1.Add(this.hseparator3);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator3]));
			w6.TopAttach = ((uint)(12));
			w6.BottomAttach = ((uint)(13));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator5 = new global::Gtk.HSeparator();
			this.hseparator5.Name = "hseparator5";
			this.table1.Add(this.hseparator5);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator5]));
			w7.TopAttach = ((uint)(12));
			w7.BottomAttach = ((uint)(13));
			w7.LeftAttach = ((uint)(2));
			w7.RightAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator7 = new global::Gtk.HSeparator();
			this.hseparator7.Name = "hseparator7";
			this.table1.Add(this.hseparator7);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator7]));
			w8.TopAttach = ((uint)(12));
			w8.BottomAttach = ((uint)(13));
			w8.LeftAttach = ((uint)(3));
			w8.RightAttach = ((uint)(4));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator9 = new global::Gtk.HSeparator();
			this.hseparator9.Name = "hseparator9";
			this.table1.Add(this.hseparator9);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator9]));
			w9.TopAttach = ((uint)(12));
			w9.BottomAttach = ((uint)(13));
			w9.LeftAttach = ((uint)(4));
			w9.RightAttach = ((uint)(5));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.imageMainMenu = new global::Gtk.Image();
			this.imageMainMenu.CanFocus = true;
			this.imageMainMenu.Name = "imageMainMenu";
			this.table1.Add(this.imageMainMenu);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.imageMainMenu]));
			w10.RightAttach = ((uint)(5));
			w10.XOptions = ((global::Gtk.AttachOptions)(7));
			w10.YOptions = ((global::Gtk.AttachOptions)(7));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Cards per Deck:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w11.TopAttach = ((uint)(9));
			w11.BottomAttach = ((uint)(10));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("AI Type:");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Player Name:");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Starting Player:");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w14.TopAttach = ((uint)(6));
			w14.BottomAttach = ((uint)(7));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonAIType1 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Bug Catcher"));
			this.radiobuttonAIType1.CanFocus = true;
			this.radiobuttonAIType1.Name = "radiobuttonAIType1";
			this.radiobuttonAIType1.DrawIndicator = true;
			this.radiobuttonAIType1.UseUnderline = true;
			this.radiobuttonAIType1.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.table1.Add(this.radiobuttonAIType1);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonAIType1]));
			w15.TopAttach = ((uint)(4));
			w15.BottomAttach = ((uint)(5));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonAIType2 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Gym Leader"));
			this.radiobuttonAIType2.CanFocus = true;
			this.radiobuttonAIType2.Name = "radiobuttonAIType2";
			this.radiobuttonAIType2.DrawIndicator = true;
			this.radiobuttonAIType2.UseUnderline = true;
			this.radiobuttonAIType2.Group = this.radiobuttonAIType1.Group;
			this.table1.Add(this.radiobuttonAIType2);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonAIType2]));
			w16.TopAttach = ((uint)(5));
			w16.BottomAttach = ((uint)(6));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonDeckSize16 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("16"));
			this.radiobuttonDeckSize16.CanFocus = true;
			this.radiobuttonDeckSize16.Name = "radiobuttonDeckSize16";
			this.radiobuttonDeckSize16.DrawIndicator = true;
			this.radiobuttonDeckSize16.UseUnderline = true;
			this.radiobuttonDeckSize16.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.table1.Add(this.radiobuttonDeckSize16);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonDeckSize16]));
			w17.TopAttach = ((uint)(9));
			w17.BottomAttach = ((uint)(10));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonDeckSize4 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("4"));
			this.radiobuttonDeckSize4.CanFocus = true;
			this.radiobuttonDeckSize4.Name = "radiobuttonDeckSize4";
			this.radiobuttonDeckSize4.DrawIndicator = true;
			this.radiobuttonDeckSize4.UseUnderline = true;
			this.radiobuttonDeckSize4.Group = this.radiobuttonDeckSize16.Group;
			this.table1.Add(this.radiobuttonDeckSize4);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonDeckSize4]));
			w18.TopAttach = ((uint)(11));
			w18.BottomAttach = ((uint)(12));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonDeckSize8 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("8"));
			this.radiobuttonDeckSize8.CanFocus = true;
			this.radiobuttonDeckSize8.Name = "radiobuttonDeckSize8";
			this.radiobuttonDeckSize8.DrawIndicator = true;
			this.radiobuttonDeckSize8.UseUnderline = true;
			this.radiobuttonDeckSize8.Group = this.radiobuttonDeckSize16.Group;
			this.table1.Add(this.radiobuttonDeckSize8);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonDeckSize8]));
			w19.TopAttach = ((uint)(10));
			w19.BottomAttach = ((uint)(11));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonStarting1 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Player 1 (Human)"));
			this.radiobuttonStarting1.CanFocus = true;
			this.radiobuttonStarting1.Name = "radiobuttonStarting1";
			this.radiobuttonStarting1.DrawIndicator = true;
			this.radiobuttonStarting1.UseUnderline = true;
			this.radiobuttonStarting1.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.table1.Add(this.radiobuttonStarting1);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonStarting1]));
			w20.TopAttach = ((uint)(6));
			w20.BottomAttach = ((uint)(7));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonStarting2 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Player 2 (AI)"));
			this.radiobuttonStarting2.CanFocus = true;
			this.radiobuttonStarting2.Name = "radiobuttonStarting2";
			this.radiobuttonStarting2.DrawIndicator = true;
			this.radiobuttonStarting2.UseUnderline = true;
			this.radiobuttonStarting2.Group = this.radiobuttonStarting1.Group;
			this.table1.Add(this.radiobuttonStarting2);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonStarting2]));
			w21.TopAttach = ((uint)(7));
			w21.BottomAttach = ((uint)(8));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonStarting3 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Random"));
			this.radiobuttonStarting3.CanFocus = true;
			this.radiobuttonStarting3.Name = "radiobuttonStarting3";
			this.radiobuttonStarting3.DrawIndicator = true;
			this.radiobuttonStarting3.UseUnderline = true;
			this.radiobuttonStarting3.Group = this.radiobuttonStarting1.Group;
			this.table1.Add(this.radiobuttonStarting3);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobuttonStarting3]));
			w22.TopAttach = ((uint)(8));
			w22.BottomAttach = ((uint)(9));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 905;
			this.DefaultHeight = 671;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.buttonQuit.Clicked += new global::System.EventHandler(this.QuitClicked);
			this.button59.Clicked += new global::System.EventHandler(this.StartGameClicked);
		}
	}
}
