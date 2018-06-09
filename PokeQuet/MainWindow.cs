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

    // Vergleicht ausgewählte Disziplinen und entscheidet welcher Spieler die aktuelle Runde gewinnt / verliert / unentschieden
    public void CompareDiscipline()
    {
        var p1Card = Player1.Deck.GetCurrentCard();
        var p2Card = Player2.Deck.GetCurrentCard();

        // Needs to be changed
        int selectedDiscipline = 1;

        // selected Discipline needs to get implemented
        switch (selectedDiscipline) 
        {
            // Type
            case 1:
                if (p1Card.type == "Fire")
                {
                    if (p2Card.type == "Fire")
                    {
                        RoundDecided(null, null);
                    }
                    if (p2Card.type == "Grass")
                    {
                        RoundDecided(Player1, Player2);
                    }
                    if (p2Card.type == "Water")
                    {
                        RoundDecided(Player2, Player1);
                    }
                }
                if (p1Card.type == "Water")
                {
                    if (p2Card.type == "Fire")
                    {
                        RoundDecided(Player1, Player2);
                    }
                    if (p2Card.type == "Grass")
                    {
                        RoundDecided(Player2, Player1);
                    }
                    if (p2Card.type == "Water")
                    {
                        RoundDecided(null, null);
                    }
                }

                if (p1Card.type == "Grass")
                {
                    if (p2Card.type == "Fire")
                    {
                        RoundDecided(Player2, Player1);
                    }
                    if (p2Card.type == "Grass")
                    {
                        RoundDecided(null, null);
                    }
                    if (p2Card.type == "Water")
                    {
                        RoundDecided(Player1, Player2);
                    }
                }
                break;

            // HP
            case 2:
                if (p1Card.hp > p2Card.hp) 
                {
                    RoundDecided(Player1, Player2);
                }
                if (p1Card.hp < p2Card.hp)
                {
                    RoundDecided(Player2, Player1);
                }
                if (p1Card.hp == p2Card.hp) 
                {
                    RoundDecided(null, null);
                }
                break;

            // ATK
            case 3:
                if (p1Card.atk > p2Card.atk)
                {
                    RoundDecided(Player1, Player2);
                }
                if (p1Card.atk < p2Card.atk)
                {
                    RoundDecided(Player2, Player1);
                }
                if (p1Card.atk == p2Card.atk) 
                {
                    RoundDecided(null, null);
                }
                break;

            // DEF
            case 4:
                if (p1Card.def > p2Card.def)
                {
                    RoundDecided(Player1, Player2);
                }
                if (p1Card.def < p2Card.def)
                {
                    RoundDecided(Player2, Player1);
                }
                if (p1Card.def == p2Card.def)
                {
                    RoundDecided(null, null);
                }
                break;

            // SPEED
            case 5:
                if (p1Card.spd > p2Card.spd)
                {
                    RoundDecided(Player1, Player2);
                }
                if (p1Card.spd < p2Card.spd)
                {
                    RoundDecided(Player2, Player1);
                }
                if (p1Card.spd == p2Card.spd)
                {
                    RoundDecided(null, null);
                }
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
