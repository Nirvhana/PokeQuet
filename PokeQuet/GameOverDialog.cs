using System;
namespace PokeQuet
{
	public partial class GameOverDialog : Gtk.Dialog
	{
		public GameOverDialog()
		{
			this.Build();
            this.Modal = true;
		}
	}
}