using System;
namespace PokeQuet
{
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

			if (winningPlayer != null)
				this.labelResult.Text = String.Format(PLAYER_WON, winningPlayer.Name, playerNum);
			else
				this.labelResult.Text = DRAW;
		}

		protected void RestartClicked(object sender, EventArgs e)
		{
			this._main.StartGame();
			this.Destroy();
		}

		protected void QuitClicked(object sender, EventArgs e)
		{
			this._main.Destroy();
			this.Destroy();
		}
	}
}