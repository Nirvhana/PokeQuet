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
            imageMainMenu.File = "./images/PokemonQuartettLogo.png";
        }


        /// <summary>
        /// Wenn der "Start Game"-Knopf gedrückt wird eine neues Spiel mit den Einstellungen gestartet.
        /// </summary>
        protected void StartGameClicked(object sender, EventArgs e)
        {
            new MainWindow(
                entryPlayerName.Text, //Name des Spielers aus Textbox
                radiobuttonAIType1.Active ? 1 : 2, //KI-Level vom Radiobutton
                radiobuttonStarting1.Active ? 1 : radiobuttonStarting2.Active ? 2 : 0, //Beginnender Spieler vom Radiobutton
                radiobuttonDeckSize16.Active ? 1 : radiobuttonDeckSize8.Active ? 2 : radiobuttonDeckSize4.Active ? 3 : 0 //Deckgrößen vom Radiobutton
            ).Show();
        }

        /// <summary>
        /// Wenn der "Quit"-Knopf gedrückt wird das komplette Programm geschlossen.
        /// </summary>
        protected void QuitClicked(object sender, EventArgs e)
        {
            this.Destroy();
            Application.Quit();
        }

        #region Autogeneriert

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        #endregion
    }
}
