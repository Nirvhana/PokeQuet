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

        labelP1Name.Text = Player1.Name;
        labelP2Name.Text = Player2.Name;

        StartGame();
    }

    public void LoadCards()
    {
        CardPool = JsonConvert.DeserializeObject<Card[]>(File.ReadAllText(@"./AllCards.json"));
    }

    public void StartGame()
    {
        Deck.FillDecksFromCardPool(CardPool, Player1.Deck, Player2.Deck);
        TieCards.Clear();
        ActivePlayer = Player1;
        NextTurn();
    }

    public void NextTurn()
    {
        DisplayCards();
        if (ActivePlayer is AIPlayer)
            MakeCPUMove();
        else
        {
            buttonSelectType.Sensitive = true;
            buttonSelectHP.Sensitive = true;
            buttonSelectATK.Sensitive = true;
            buttonSelectDEF.Sensitive = true;
            buttonSelectSPD.Sensitive = true;
        }
    }

    public void DisplayCards()
    {
        var p1card = Player1.Deck.GetCurrentCard();
        imageP1.File = p1card.texture;
        labelP1CardName.Text = p1card.name;
        labelP1FlavourText.Text = p1card.flavorText;
        labelP1Type.Text = p1card.type;
        labelP1HP.Text = p1card.hp.ToString();
        labelP1ATK.Text = p1card.atk.ToString();
        labelP1DEF.Text = p1card.def.ToString();
        labelP1SPD.Text = p1card.spd.ToString();
        var p2card = Player2.Deck.GetCurrentCard();
        imageP2.File = p2card.texture;
        labelP2CardName.Text = p2card.name;
        labelP2FlavourText.Text = p2card.flavorText;
        labelP2Type.Text = p2card.type;
        labelP2HP.Text = p2card.hp.ToString();
        labelP2ATK.Text = p2card.atk.ToString();
        labelP2DEF.Text = p2card.def.ToString();
        labelP2SPD.Text = p2card.spd.ToString();
    }

    protected void TypeDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.TYPE);
    protected void HPDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.HP);
    protected void ATKDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.ATK);
    protected void DEFDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.DEF);
    protected void SPDDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.SPD);

    public void ChooseDiscipline(Discipline discipline)
    {
        buttonSelectType.Sensitive = false;
        buttonSelectHP.Sensitive = false;
        buttonSelectATK.Sensitive = false;
        buttonSelectDEF.Sensitive = false;
        buttonSelectSPD.Sensitive = false;
        CompareDiscipline(discipline);
    }

    public void MakeCPUMove()
    {
        CompareDiscipline(Player2.MakeTurn(Player1, TieCards));
    }

    // Vergleicht ausgewählte Disziplinen und entscheidet welcher Spieler die aktuelle Runde gewinnt / verliert / unentschieden
    public void CompareDiscipline(Discipline discipline)
    {
        var p1Card = Player1.Deck.GetCurrentCard();
        var p2Card = Player2.Deck.GetCurrentCard();


        // selected Discipline needs to get implemented
        switch (discipline)
        {
            // Type
            case Discipline.TYPE:
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
            case Discipline.HP:
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
            case Discipline.ATK:
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
            case Discipline.DEF:
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
            case Discipline.SPD:
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
            TieCards.PutCardsAtBack(p1Card, p2Card);
        }
        else if (winningPlayer == Player1)
        {
            Player1.Deck.PutCardsAtBack(p1Card, p2Card);
        }
        else if (winningPlayer == Player2)
        {
            Player2.Deck.PutCardsAtBack(p2Card, p1Card);
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
