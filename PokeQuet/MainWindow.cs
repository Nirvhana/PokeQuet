using System;
using Gtk;
using PokeQuet;
using Newtonsoft.Json;
using System.IO;

public partial class MainWindow : Gtk.Window
{
    public Card[] AllCards;
    public Player ActivePlayer { get; set; }
    public Player Player1 { get; set; }
    public Player Player2 { get; set; }
    public Deck TieCards { get; set; }

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    public void InitGame()
    {
        LoadCards();
        Player1 = new Player("Red");
        Player2 = new Player("Bug Catcher");
        Deck.FillDecksFromCardPool(AllCards, Player1.Deck, Player2.Deck);
    }

    public void LoadCards()
    {
        AllCards = JsonConvert.DeserializeObject<Card[]>(File.ReadAllText(@"./AllCards.json"));;
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
