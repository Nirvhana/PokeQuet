using System;
using Gtk;

namespace PokeQuet
{
	public partial class MainMenu : Gtk.Window
	{
		public MainMenu() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}


		#region Autogeneriert

		protected void OnDeleteEvent(object sender, DeleteEventArgs a)
		{
			Application.Quit();
			a.RetVal = true;
		}

		protected void StartGameClicked(object sender, EventArgs e)
		{
			new MainWindow(
				entryPlayerName.Text,
				radiobuttonAIType1.Active ? 1 : 2,
				radiobuttonStarting1.Active ? 1 : radiobuttonStarting2.Active ? 2 : 0).Show();
		}

		#endregion
	}
}
