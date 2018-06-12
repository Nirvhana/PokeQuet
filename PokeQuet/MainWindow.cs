using System;
using Gtk;
using PokeQuet;
using Newtonsoft.Json;
using System.IO;


public partial class MainWindow : Gtk.Window
{
    public const string TURN_RESULT_WINNER = "{0} won the turn!";
    public const string TURN_RESULT_TIE = "It's a tie!";

	public static readonly Random RNG = new Random(); 
    public static readonly Gdk.Color RED = new Gdk.Color((byte)255, (byte)20, (byte)20);
    public static readonly Gdk.Color GREEN = new Gdk.Color((byte)0, (byte)215, (byte)0);
    public static readonly Gdk.Color GREY = new Gdk.Color((byte)0, (byte)0, (byte)0);
    public static readonly Gdk.Color BLACK = new Gdk.Color((byte)0, (byte)0, (byte)0);

	private int startingPlayer = 0;
    private int deckSize = 0;

    public Card[] CardPool { get; set; }
    public Player ActivePlayer { get; set; }
    public Player Player1 { get; set; }
    public AIPlayer Player2 { get; set; }
    public Deck TieCards { get; set; }
   // Image image = 

    // Aufruf des Hauptmenüs.
    public MainWindow(string playerName, int aiType, int startingPlayer, int deckSize) : base(Gtk.WindowType.Toplevel)
    {
        Build();
		this.startingPlayer = startingPlayer;
        this.deckSize = deckSize;
        InitGame(playerName,aiType);
    }

    // Initialisierung des Spiels
	public void InitGame(string playerName, int aiType)
    {
        LoadCards();
		Player1 = new Player(playerName);

		if(aiType==1)
        	Player2 = new AIPlayerRandom();
		else
			Player2 = new AIPlayerSimple();
        Player2.Init(CardPool);

        Deck.FillDecksFromCardPool(CardPool, Player1.Deck, Player2.Deck, deckSize);
        TieCards = new Deck();

        labelP1Name.Text = Player1.Name;
        labelP2Name.Text = Player2.Name;

        StartGame();
    }

    // Laden aller Karten aus der .Json.
    public void LoadCards()
    {
        CardPool = JsonConvert.DeserializeObject<Card[]>(File.ReadAllText(@"./AllCards.json"));
    }

    // Start des Spiels
    public void StartGame()
    {
        Deck.FillDecksFromCardPool(CardPool, Player1.Deck, Player2.Deck, deckSize);
        TieCards.Clear();
		if (startingPlayer == 1 || startingPlayer == 0 && RNG.Next(2) == 0)
			ActivePlayer = Player1;
		else
			ActivePlayer = Player2;

		buttonSelectType.Sensitive = false;
        buttonSelectHP.Sensitive = false;
        buttonSelectATK.Sensitive = false;
        buttonSelectDEF.Sensitive = false;
        buttonSelectSPD.Sensitive = false;

        NextTurn();
    }

    protected void NextCardClicked(object sender, EventArgs e) => NextTurn();

    // Spielrunde
    public void NextTurn()
    {
        DisplayCards();
        buttonNextCard.Sensitive = false;

        if (ActivePlayer is AIPlayer)
            MakeCPUMove();

        // Wenn Spieler am Zug ist -> Diciplines Buttons = klickbar
        else
        {
            buttonSelectType.Sensitive = true;
            buttonSelectHP.Sensitive = true;
            buttonSelectATK.Sensitive = true;
            buttonSelectDEF.Sensitive = true;
            buttonSelectSPD.Sensitive = true;
        }
    }

    // Anzeigen der Karten
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
        labelP2CardName.Text = "???";
        labelP2FlavourText.Text = "???";
        labelP2Type.Text = "?";
        labelP2HP.Text = "?";
        labelP2ATK.Text = "?";
        labelP2DEF.Text = "?";
        labelP2SPD.Text = "?";

        labelP1Type.ModifyFg(StateType.Normal, BLACK);
        labelP2Type.ModifyFg(StateType.Normal, BLACK);
        labelP1HP.ModifyFg(StateType.Normal, BLACK);
        labelP2HP.ModifyFg(StateType.Normal, BLACK);
        labelP1ATK.ModifyFg(StateType.Normal, BLACK);
        labelP2ATK.ModifyFg(StateType.Normal, BLACK);
        labelP1DEF.ModifyFg(StateType.Normal, BLACK);
        labelP2DEF.ModifyFg(StateType.Normal, BLACK);
        labelP1SPD.ModifyFg(StateType.Normal, BLACK);
        labelP2SPD.ModifyFg(StateType.Normal, BLACK);

        labelP1CardCount.Text = Player1.Deck.Count.ToString();
        labelP2CardCount.Text = Player2.Deck.Count.ToString();
        labelTieCardCount.Text = TieCards.Count.ToString();

        labelTurnResult.Text = "";
    }

    protected void TypeDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.TYPE);
    protected void HPDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.HP);
    protected void ATKDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.ATK);
    protected void DEFDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.DEF);
    protected void SPDDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.SPD);

    // Diciplines Buttons
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

    // Aufdecken der verdeckte Karte & Werte von Spieler 2
    // Wird bei CompareDiscipline() aufgerufen (nach Auswahl der Discipline)
    public void ShowOpponentCard()
    {
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

    // Anzeige welcher Spieler die aktuelle Runde gewonnen hat
    public void ShowTurnWinner(Discipline discipline, Player winningPlayer)
    {
        Gdk.Color p1color, p2color;

        if (winningPlayer == null)
        {
            p1color = GREY;
            p2color = GREY;

            labelTurnResult.Text = TURN_RESULT_TIE;
        }
        else
        {
            if (winningPlayer == Player1)
            {
                p1color = GREEN;
                p2color = RED;
            }
            else
            {
                p1color = RED;
                p2color = GREEN;
            }

            labelTurnResult.Text = String.Format(TURN_RESULT_WINNER, winningPlayer.Name);
        }

        switch (discipline)
        {
            case Discipline.TYPE:
                labelP1Type.ModifyFg(StateType.Normal, p1color);
                labelP2Type.ModifyFg(StateType.Normal, p2color);
                break;
            case Discipline.HP:
                labelP1HP.ModifyFg(StateType.Normal, p1color);
                labelP2HP.ModifyFg(StateType.Normal, p2color);
                break;
            case Discipline.ATK:
                labelP1ATK.ModifyFg(StateType.Normal, p1color);
                labelP2ATK.ModifyFg(StateType.Normal, p2color);
                break;
            case Discipline.DEF:
                labelP1DEF.ModifyFg(StateType.Normal, p1color);
                labelP2DEF.ModifyFg(StateType.Normal, p2color);
                break;
            case Discipline.SPD:
                labelP1SPD.ModifyFg(StateType.Normal, p1color);
                labelP2SPD.ModifyFg(StateType.Normal, p2color);
                break;
        }
    }

    // * Kampflogik *
    // Vergleicht ausgewählte Disziplinen und entscheidet welcher Spieler die aktuelle Runde gewinnt / verliert / unentschieden
    public void CompareDiscipline(Discipline discipline)
    {
        ShowOpponentCard();
        var p1Card = Player1.Deck.GetCurrentCard();
        var p2Card = Player2.Deck.GetCurrentCard();

        switch (discipline)
        {
            // Type - Schere, Stein, Papier Prinzip
            case Discipline.TYPE:
                if (p1Card.type == "Fire")
                {
                    if (p2Card.type == "Fire")
                    {
                        RoundDecided(null, null, discipline);
                    }
                    else if (p2Card.type == "Grass")
                    {
                        RoundDecided(Player1, Player2, discipline);
                    }
                    else if (p2Card.type == "Water")
                    {
                        RoundDecided(Player2, Player1, discipline);
                    }
                }
                if (p1Card.type == "Water")
                {
                    if (p2Card.type == "Fire")
                    {
                        RoundDecided(Player1, Player2, discipline);
                    }
                    else if (p2Card.type == "Grass")
                    {
                        RoundDecided(Player2, Player1, discipline);
                    }
                    else if (p2Card.type == "Water")
                    {
                        RoundDecided(null, null, discipline);
                    }
                }

                if (p1Card.type == "Grass")
                {
                    if (p2Card.type == "Fire")
                    {
                        RoundDecided(Player2, Player1, discipline);
                    }
                    else if (p2Card.type == "Grass")
                    {
                        RoundDecided(null, null, discipline);
                    }
                    else if (p2Card.type == "Water")
                    {
                        RoundDecided(Player1, Player2, discipline);
                    }
                }
                break;

            // HP
            case Discipline.HP:
                if (p1Card.hp > p2Card.hp)
                {
                    RoundDecided(Player1, Player2, discipline);
                }
                else if (p1Card.hp < p2Card.hp)
                {
                    RoundDecided(Player2, Player1, discipline);
                }
                else if (p1Card.hp == p2Card.hp)
                {
                    RoundDecided(null, null, discipline);
                }
                break;

            // ATK
            case Discipline.ATK:
                if (p1Card.atk > p2Card.atk)
                {
                    RoundDecided(Player1, Player2, discipline);
                }
                else if (p1Card.atk < p2Card.atk)
                {
                    RoundDecided(Player2, Player1, discipline);
                }
                else if (p1Card.atk == p2Card.atk)
                {
                    RoundDecided(null, null, discipline);
                }
                break;

            // DEF
            case Discipline.DEF:
                if (p1Card.def > p2Card.def)
                {
                    RoundDecided(Player1, Player2, discipline);
                }
                else if (p1Card.def < p2Card.def)
                {
                    RoundDecided(Player2, Player1, discipline);
                }
                else if (p1Card.def == p2Card.def)
                {
                    RoundDecided(null, null, discipline);
                }
                break;

            // SPEED
            case Discipline.SPD:
                if (p1Card.spd > p2Card.spd)
                {
                    RoundDecided(Player1, Player2, discipline);
                }
                else if (p1Card.spd < p2Card.spd)
                {
                    RoundDecided(Player2, Player1, discipline);
                }
                else if (p1Card.spd == p2Card.spd)
                {
                    RoundDecided(null, null, discipline);
                }
                break;
        }
    }

    // 1. Entfernt die beiden Karten der aktuellen Runde aus den Decks und fügt sie dem Deck des Gewinners hinzu. 
    //    Bzw bei einem Unentschieden werdem die Karten dem 'TieDeck' hinzugefügt.
    //
    // 2. Gibt dem Gewinner der aktuellen Runde den Status: 'ActivePlayer'.
    //
    // 3. Am Ende wird immer die 'CheckWinningState' Funktion aufgerufen.
    public void RoundDecided(Player winningPlayer, Player losingPlayer, Discipline discipline)
    {
        ShowTurnWinner(discipline, winningPlayer);

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
            ActivePlayer = Player1;
        }
        else if (winningPlayer == Player2)
        {
            Player2.Deck.PutCardsAtBack(p2Card, p1Card);
            ActivePlayer = Player2;
        }
        if (winningPlayer != null)
        {
            winningPlayer.Deck.PutCardsAtBack(TieCards);
            TieCards.Clear();
        }
        CheckWinningState();
    }

    // Überprüft anhand der verbleibenden Karten in den Decks, ob ein Spieler das Spiel gewonnen hat.
    public void CheckWinningState()
    {
        var p1Count = Player1.Deck.Count;
        var p2Count = Player2.Deck.Count;

        if (p1Count == 0 || p2Count == 0)
        {
            if (p1Count == 0 && p2Count == 0)
            {
				new GameOverDialog(this,null,0).Show();
            }
            else if (p1Count == 0)
            {
				new GameOverDialog(this,Player2,0).Show();
            }
            else if (p2Count == 0)
            {
				new GameOverDialog(this,Player1,0).Show();
            }
        }
        else
        {
            buttonNextCard.Sensitive = true;
        }
    }
}
