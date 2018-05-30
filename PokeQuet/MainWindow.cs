using System;
using Gtk;
using PokeQuet;

public partial class MainWindow : Gtk.Window
{

    public Player ActivePlayer { get; set; }
    public Deck TieCards { get; set; }

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    public void InitGame()
    {

    }

    public void LoadCards()
    {

    }

    public void RestartGame()
    {

    }

    //TODO: Auswahl der Disziplin durch Event-Callback bei Klick

    public void MakeCPUMove()
    {

    }

    //TODO: Vielleicht Enum für Disziplin benutzen
    public void CompareDiscipline(int discipline)
    {

    }

    public void RoundDecided(Player winningPlayer, Player losingPlayer)
    {

    }

    public void CheckWinningState()
    {

    }


    #region Autogeneriert

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    #endregion
}
