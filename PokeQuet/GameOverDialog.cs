using System;
using Gtk;
using PokeQuet;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace PokeQuet
{
    // Fenster das nach jedem Spiel erscheint.
	public partial class GameOverDialog : Gtk.Dialog
	{
		public const string PLAYER_WON = "{0}(P{1}) WON!";
		public const string DRAW = "DRAW!";
		private MainWindow _main;

		public GameOverDialog(MainWindow window,Player winningPlayer,int playerNum)
		{
            this.Build();
            this.Modal = true;

			_main = window;

            // Anzeige welcher Spieler gewonnen hat, oder das Spielergebnis unentschieden ist.
			if (winningPlayer != null)
				this.labelResult.Text = String.Format(PLAYER_WON, winningPlayer.Name, playerNum);
			else
				this.labelResult.Text = DRAW;
		}

        // Restart Game - Button: Anklicken -> Startet das Spiel erneut.
		protected void RestartClicked(object sender, EventArgs e)
		{
			this._main.StartGame();
			this.Destroy();
		}

        // Quit Game - Button: Anklicken -> Beendet das Programm, schließt GameOverDialog- & Main- Fenster.
		protected void QuitClicked(object sender, EventArgs e)
		{
            
			this._main.Destroy();
			this.Destroy();
            Application.Quit();
		}

    /*    // Main Menu - Button: not working yet
        protected void OnButtonMainMenuClicked(object sender, EventArgs e)
        {
            this._main.Destroy();
            this.Destroy();
            Process.Start(@"./MainMenu.cs");
        }
        */
	}
}