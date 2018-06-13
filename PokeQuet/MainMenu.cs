using System;
using Gtk;
using System.Media;
using System.Diagnostics;

namespace PokeQuet
{
    // Hauptmenü, das vor dem eigentlichen Spiel erscheint. Bietet diverse Spieloptionen.
    public partial class MainMenu : Gtk.Window
    {
        public MainMenu() : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            imageMainMenu.Pixbuf = new Gdk.Pixbuf(@"./images/PokemonQuartettLogo.png");
        }

        #region Autogeneriert

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        // Start Game - Button: Anklicken -> Öffnet das Spielfenster und startet das Spiel.
        protected void StartGameClicked(object sender, EventArgs e)
        {
            new MainWindow(
                entryPlayerName.Text,
                radiobuttonAIType1.Active ? 1 : 2,
                radiobuttonStarting1.Active ? 1 : radiobuttonStarting2.Active ? 2 : 0,
                radiobuttonDeckSize16.Active ? 1 : radiobuttonDeckSize8.Active ? 2 : radiobuttonDeckSize4.Active ? 3 : 0).Show();
        }

        // Quit Game - Button: Anklicken -> Beendet das Programm.
        protected void QuitClicked(object sender, EventArgs e)
        {
            this.Destroy();
            Application.Quit();
        }

        #endregion
    }
}
