using System;
using Gtk;
using PokeQuet;
using Newtonsoft.Json;
using System.IO;
using System.Threading;


public partial class MainWindow : Gtk.Window
{
    public Card[] CardPool { get; set; }
    public Player ActivePlayer { get; set; }
    public Player Player1 { get; set; }
    public AIPlayer Player2 { get; set; }
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
        Player2 = new AIPlayerRandom();
        Player2.Init(CardPool);
        Deck.FillDecksFromCardPool(CardPool, Player1.Deck, Player2.Deck);
        TieCards = new Deck();
        StartGame();
    }

    public void LoadCards()
    {
        CardPool = JsonConvert.DeserializeObject<Card[]>(File.ReadAllText(@"./AllCards.json"));
    }

    public void StartGame()
    {
        //TODO: Main Game loop
    }

    public void RestartGame()
    {
        Deck.FillDecksFromCardPool(CardPool, Player1.Deck, Player2.Deck);
        TieCards.Clear();
    }

    //TODO: Auswahl der Disziplin durch Event-Callback bei Klick

    public void MakeCPUMove()
    {
        CompareDiscipline(Player2.MakeTurn(Player1,TieCards));
    }

    // Vergleicht ausgewählte Disziplinen und entscheidet welcher Spieler die aktuelle Runde gewinnt / verliert / unentschieden
    public void CompareDiscipline(int selectedDiscipline)
    {
        var p1Card = Player1.Deck.GetCurrentCard();
        var p2Card = Player2.Deck.GetCurrentCard();
        

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
                        return;
                    }
                    if (p2Card.type == "Grass")
                    {
                        RoundDecided(Player1, Player2);
                        return;
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
                        return;
                    }
                    if (p2Card.type == "Grass")
                    {
                        RoundDecided(Player2, Player1);
                        return;
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
                        return;
                    }
                    if (p2Card.type == "Grass")
                    {
                        RoundDecided(null, null);
                        return;
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
                    return;
                }
                if (p1Card.hp < p2Card.hp)
                {
                    RoundDecided(Player2, Player1);
                    return;

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
                    return;
                }
                if (p1Card.atk < p2Card.atk)
                {
                    RoundDecided(Player2, Player1);
                    return;
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
                    return;
                }
                if (p1Card.def < p2Card.def)
                {
                    RoundDecided(Player2, Player1);
                    return;
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
                    return;
                }
                if (p1Card.spd < p2Card.spd)
                {
                    RoundDecided(Player2, Player1);
                    return;
                }
                if (p1Card.spd == p2Card.spd)
                {
                    RoundDecided(null, null);
                }
                break;
        }
    }

    // Entfernt die beiden Karten der aktuellen Runde aus den Decks und fügt sie dem Deck des Gewinners hinzu. 
    // Bzw bei einem Unentschieden werdem die Karten dem 'TieDeck' hinzugefügt.
    public void RoundDecided(Player winningPlayer, Player losingPlayer)
    {
        var p1Card = Player1.Deck.GetCurrentCard();
        var p2Card = Player2.Deck.GetCurrentCard();
        Player1.Deck.RemoveAt(0);
        Player2.Deck.RemoveAt(0);

        if (winningPlayer == null)
        {
            TieCards.PutCardAtBack(p1Card, p2Card);
        }
        else if (winningPlayer == Player1)
        {
            Player1.Deck.PutCardAtBack(p1Card, p2Card);
        }
        else if (winningPlayer == Player2)
        {
            Player2.Deck.PutCardAtBack(p2Card, p1Card);
        }

        CheckWinningState();
        //take the current card form losing player and put it on winningPlayers Deck
        //take the cards from the tie pile and put them on winningPlayers Deck
        //check if the active player needs to be changed
    }

    // Überprüft, ob ein Spieler gewonnen hat, anhand der verbleibenden Karten in den Decks.
    public void CheckWinningState()
    {
        var p1Count = Player1.Deck.Count;
        var p2Count = Player2.Deck.Count;

        if (p1Count == 0 || p2Count == 0)
        {
            if (p1Count == 0 && p2Count == 0)
            {
                
            }
            else if (p1Count == 0)
            {

            }
            else if (p2Count == 0)
            {

            }
        }


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
