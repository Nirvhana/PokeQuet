using System;
namespace PokeQuet
{
	public partial class GameOverDialog : Gtk.Dialog
	{
        public GameOverDialog(int winOrLoose)
		{
            this.Build();
            this.Modal = true;


            if (winOrLoose == 1)
            {
                this.imageGameResult.Pixbuf = new Gdk.Pixbuf ("./images/vitory.jpg");
            }
            else if (winOrLoose == 2)
            {
                this.imageGameResult.Pixbuf = new Gdk.Pixbuf("./images/game-over.png");
            }

		}
	}
}