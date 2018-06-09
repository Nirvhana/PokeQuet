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
        InitGame();
    }

    public void InitGame()
    {
        
        LoadCards();
        Player1 = new Player("Red");
        Player2 = new Player("Bug Catcher");
        Deck.FillDecksFromCardPool(AllCards, Player1.Deck, Player2.Deck);
        CompareDiscipline();
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
    public void CompareDiscipline()
    {
        var p1Card = Player1.Deck.GetCurrentCard();
        var p2Card = Player2.Deck.GetCurrentCard();

        int discipline = 1;
        // selected Discipline needs to get implemented
        switch (discipline) 
        {
            // Type
            case 1:
                if (p1Card.type == "Fire") {
                    label3.Text = "hi fire";
                    return;

                }

                else if (p1Card.type == "Water")
                {
                    label3.Text = "hi water";

                }

                else if (p1Card.type == "Grass")
                {
                    label3.Text = "hi grass";

                }


                break;

            // HP
            case 2:
                
                break;

            // ATK
            case 3:
                
                break;

            // DEF
            case 4:
                
                break;

            // SPEED
            case 5:
                
                break;
        }
    }

    public void RoundDecided(Player winningPlayer, Player losingPlayer)
    {
        //take the current card form losing player and put it on winningPlayers Deck
        //take the cards from the tie pile and put them on winningPlayers Deck
        //check if the active player needs to be changed
    }

    public void CheckWinningState()
    {
        //check if player1 has no cards
        //  yes? check if player2 has no cards
        //        yes? game draw!
        //        no? player 2 wins!
        //    no? check if player2 has no cards
        //        yes? player 1 wins!
        //        no? game continues!
    }


    #region Autogeneriert

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    #endregion
}
