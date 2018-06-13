using System;
using Gtk;
using PokeQuet;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace PokeQuet
{
    /// <summary>
    /// Fenster das nach Ende des Spiels erscheint und den Sieger bzw. Unentschieden anzeigt und die Option für Neustart oder Ende des aktuellen Spiels gibt
    /// </summary>
	public partial class GameOverDialog : Gtk.Dialog
	{
		public const string PLAYER_WON = "{0}(P{1}) WON!";
		public const string DRAW = "DRAW!";
		private MainWindow _main;

        /// <summary>
        /// Konstukter des Gameover-Dialogs welcher den Sieger bzw. Unentschieden anzeigt und die Option für Neustart oder Ende des aktuellen Spiels gibt
        /// </summary>
        /// <param name="window">Das Hauptspielfenster(benötigt für Neustart/Beendigung)</param>
        /// <param name="winningPlayer">Der Sieger des Spiels oder null falls Unentschieden</param>
        /// <param name="playerNum">Die Zahl des Spielers der gewonnen hat(1 oder 2)</param>
        /// <remarks>Code ausschließlich Tim und André</remarks>
        public GameOverDialog(MainWindow window, Player winningPlayer, int playerNum)
		{
            this.Build();
            //Das Fenster ist Modal und verhindert die Interaktion mit anderen Fenstern.
            this.Modal = true;

			_main = window;

            // Anzeige welcher Spieler gewonnen hat, oder das Spielergebnis unentschieden ist.
            if (winningPlayer != null)
            {
                this.labelResult.Text = String.Format(PLAYER_WON, winningPlayer.Name, playerNum);

                if (winningPlayer is AIPlayer)
                {
                    imageWinner.Pixbuf = new Gdk.Pixbuf(@"./images/game-over.png");
                } 
                else 
                {
                    imageWinner.Pixbuf = new Gdk.Pixbuf(@"./images/vitory.jpg");
                }
            }
            else
            {
                this.labelResult.Text = DRAW;
                imageWinner.Pixbuf = new Gdk.Pixbuf(@"./images/draw.jpg");
            }
        }

        /// <summary>
        /// Wenn Restart-Knopf gedrückt wird: Startet das Spiel neu und schließt den Dialog
        /// </summary>
        /// <remarks>Code ausschließlich von André</remarks>
        protected void RestartClicked(object sender, EventArgs e)
		{
			this._main.StartGame(); //Starte Spiel neu
			this.Destroy(); //Schließe Dialog
		}
        
        /// <summary>
        /// Wenn "Quit Game"-Knopf gedrückt wird: Schließt Fenster und beendet das Programm komplett 
        /// </summary>
        /// <remarks>Code ausschließlich von Tim</remarks>
        protected void QuitClicked(object sender, EventArgs e)
		{
            
			this._main.Destroy();
			this.Destroy();
            Application.Quit();
		}

        /// <summary>
        /// Wenn "Quit Game"-Knopf gedrückt wird: Schließt das Spiel Fenster und den Dialog,
        /// Das Hauptmenü bleibt offen
        /// </summary>
        /// <remarks>Code ausschließlich von Tim</remarks>
        protected void OnButtonMainMenuClicked(object sender, EventArgs e)
        {
            this._main.Destroy();
            this.Destroy();
        }

	}
}