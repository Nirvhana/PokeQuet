using System;
using Gtk;
using PokeQuet;
using Newtonsoft.Json;
using System.IO;
using System.Media;

/// <summary>
/// Das Hauptfenster (das Spiel)
/// </summary>
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

    /// <summary>
    /// Array aller geladenen Karten
    /// </summary>
    public Card[] CardPool { get; set; }
    /// <summary>
    /// Der aktive Spieler(= der Spieler der am Zug ist)
    /// </summary>
    public Player ActivePlayer { get; set; }
    public Player Player1 { get; set; }
    public AIPlayer Player2 { get; set; }
    /// <summary>
    /// Der Stich-Stapel
    /// </summary>
    public Deck TieCards { get; set; }

    /// <summary>
    /// Konstruktor des Hauptfensters. Startet bereitet das Fenster vor und startet das Spiel.
    /// </summary>
    /// <param name="playerName">Name für Spieler 1</param>
    /// <param name="aiType">KI-Level: 1=Bug Catcher(Zufall), 2=Gym Leader(höchster Wert)</param>
    /// <param name="startingPlayer">Beginnender Spieler: 1|2: Spieler 1|2, 0: Zufall</param>
    /// <param name="deckSize">Anfängliche Deckgröße der Spieler</param>
    public MainWindow(string playerName, int aiType, int startingPlayer, int deckSize) : base(Gtk.WindowType.Toplevel)
    {
        Build();
        imageDeck1.File = "./images/pokemonCardBack3.png";
        imageDeck2.File = "./images/pokemonCardBack3.png";
        imageDeck3.File = "./images/pokemonCardBack3.png";
        imageDeck3.Visible = false;
		this.startingPlayer = startingPlayer;
        this.deckSize = deckSize;
        InitGame(playerName,aiType);
    }

    // Initialisierung des Spiels
    /// <summary>
    /// Initialisierung des Spiels:
    /// Laden der Karten,
    /// Erzeugung von Spielern auf Grundlage der gewählten KI,
    /// (Initialisierung der KI; obsolet)
    /// Erzeugung des Stich-Stapels
    /// Beginne Spiel
    /// </summary>
    /// <param name="playerName">Name für Spieler 1</param>
    /// <param name="aiType">KI-Level: 1=Bug Catcher(Zufall), 2=Gym Leader(höchster Wert)</param>
    /// <remarks>Code ausschließlich von André</remarks>
	public void InitGame(string playerName, int aiType)
    {
        //Lade Kartendaten
        LoadCards();
        //Erzeuge und benenne Spieler
		Player1 = new Player(playerName);
        
        if (aiType==1) //Falls KI-Level 1 ist
        	Player2 = new AIPlayerRandom(); //Spieler 2 ist Bug Catcher-KI(Zufall)
        else //Falls KI-Level 2 ist
            Player2 = new AIPlayerSimple(); //Spieler 2 ist Gym Leader-KI(höchster Wert)
        //Initalisiere Spieler 2 KI(obsolet)
        Player2.Init(CardPool);
        
        //Initialisiere leeren Stich-Stapel
        TieCards = new Deck();

        //Zeige Spielernamen an
        labelP1Name.Text = Player1.Name;
        labelP2Name.Text = Player2.Name;

        //Beginne Spiel
        StartGame();
    }

    /// <summary>
    /// Lädt Karten aus der AllCards.json Datei und speicher sie in <see cref="CardPool"/>.
    /// </summary>
    /// <remarks>Code von Tim mit Hilfe von André(Generic-Syntax) auf Grundlage eines Beispiels in der JSON.NET Dokumentaion</remarks>
    public void LoadCards()
    {
        CardPool = JsonConvert.DeserializeObject<Card[]>(File.ReadAllText(@"./AllCards.json"));
    }

    /// <summary>
    /// Startet das Spiel: mischt und verteilt Decks, leert den Stich-Stapel, bestimmt den beginnenden Spieler, startet den ersten Zug
    /// </summary>
    /// <remarks>Code fast ausschließlich von André</remarks>
    public void StartGame()
    {
        Deck.FillDecksFromCardPool(CardPool, Player1.Deck, Player2.Deck, deckSize);
        TieCards.Clear();

        //Falls Spieler 1 anfängt oder ein Zufallspieler und eine zufällige Zahl(0 oder 1) gleich 0 ist(50% Chance)
		if (startingPlayer == 1 || startingPlayer == 0 && RNG.Next(2) == 0)
			ActivePlayer = Player1; //Spieler 1 beginnt
        else //Falls 2 beginnt oder die zufällige Zahl gleich 1 war(50% Chance)
			ActivePlayer = Player2;

        //Deaktiviere die Disziplin-Knöpfe für den Fall das Spieler 2(CPU) beginnt. Mit diesen Knöpfen macht Spieler 1 seinen Zug.
		buttonSelectType.Sensitive = false;
        buttonSelectHP.Sensitive = false;
        buttonSelectATK.Sensitive = false;
        buttonSelectDEF.Sensitive = false;
        buttonSelectSPD.Sensitive = false;

        //Beginne den ersten Zug
        NextTurn();
    }

    /// <summary>
    /// Wenn der Spieler auf den "Next Card"-Knopf drückt: Beginne den nächsten Zug
    /// </summary>
    /// <remarks>Code ausschließlich von André</remarks>
    protected void NextCardClicked(object sender, EventArgs e) => NextTurn();

    /// <summary>
    /// Beginne einen neuen Zug:
    /// aktiviere Knöpfe falls Spieler 1 am Zug ist,
    /// mache CPU-Zug falls ein nicht-Spieler am Zug ist
    /// </summary>
    /// <remarks>Code ausschließlich von André</remarks>
    public void NextTurn()
    {
        //Zeige eigene Karte an. Verstecke die des Gegners.
        DisplayCards();
        //Deaktiviere den "Next Card"-Button, welcher einen neuen Zug starten würde.
        buttonNextCard.Sensitive = false;

        //Falls ein KI-Spieler am Zug ist
        if (ActivePlayer is AIPlayer)
            //Mache den CPU-Zug.
            MakeCPUMove();
        else //Ansonsten; falls der menschliche Spieler am Zug ist 
        {
            //Aktiviere die Disziplin-Knöpfe für den Fall das Spieler 1 am Zug ist. Mit diesen Knöpfen macht Spieler 1 seinen Zug.
            buttonSelectType.Sensitive = true;
            buttonSelectHP.Sensitive = true;
            buttonSelectATK.Sensitive = true;
            buttonSelectDEF.Sensitive = true;
            buttonSelectSPD.Sensitive = true;

            labelTurnResult.Text = "Choose a Discipline to compare with the opponent";
            labelTurnResult.ModifyFg(StateType.Normal, BLACK);
        }
    }

    /// <summary>
    /// Zeigt alle Informationen zur Karte von Spieler 1(die eigene) an;
    /// Leert die Informationen zur Karte von Spieler 2;
    /// Aktualisiert Kartenanzahlen für Decks;
    /// Stellt die normale Schriftfarbe der Disziplinen wieder her
    /// </summary>
    /// <remarks>Code ausschließlich von André</remarks>
    public void DisplayCards()
    {
        Card p1card = Player1.Deck.GetCurrentCard();
        imageP1.File = p1card.texture;
        labelP1CardName.Text = p1card.name;
        labelP1FlavourText.Text = p1card.flavorText;
        labelP1Type.Text = p1card.type;
        labelP1HP.Text = p1card.hp.ToString();
        labelP1ATK.Text = p1card.atk.ToString();
        labelP1DEF.Text = p1card.def.ToString();
        labelP1SPD.Text = p1card.spd.ToString();

        Card p2card = Player2.Deck.GetCurrentCard();
        imageP2.File = "./card_textures/Unown.png";
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

    // Falls der Spieler einen Disziplinknopf anklickt: Wähle die entsprechende Disziplin aus 
    // Code ausschließlich von André
    protected void TypeDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.TYPE);
    protected void HPDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.HP);
    protected void ATKDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.ATK);
    protected void DEFDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.DEF);
    protected void SPDDisciplineSelected(object sender, EventArgs e) => ChooseDiscipline(Discipline.SPD);


    /// <summary>
    /// Wenn der Spieler eine Disziplin ausgewählt hat: Deaktiviere Disziplin-Knöpfe, Vergleiche Disziplin
    /// </summary>
    /// <param name="discipline">Die gewählte Disziplin</param>
    /// <remarks>Code ausschließlich von André</remarks>
    public void ChooseDiscipline(Discipline discipline)
    {
        //Deaktiviere Disziplin-Knöpfe um mehrfachzüge von Spieler 1 zu verhindern.
        buttonSelectType.Sensitive = false;
        buttonSelectHP.Sensitive = false;
        buttonSelectATK.Sensitive = false;
        buttonSelectDEF.Sensitive = false;
        buttonSelectSPD.Sensitive = false;
        //Vergleiche Diziplin(Gewinnerbestimmung)
        CompareDiscipline(discipline);
    }

    /// <summary>
    /// Mache den CPU-Zug (Spieler 2 macht seinen Zug)
    /// </summary>
    public void MakeCPUMove()
    {
        //Bestimme den Zug von Spieler 2 und führe ihn aus(Vergleiche Disziplin) 
        CompareDiscipline(Player2.MakeTurn(Player1, TieCards));
    }

    /// <summary>
    /// Aufdecken der aktuellen Karte und Werte von Spieler 2.
    /// Wird durch <see cref="CompareDiscipline(Discipline)"/> aufgerufen, nach Auswahl der Disziplin
    /// </summary>
    /// <remarks>Code ausschließlich von André</remarks>
    public void ShowOpponentCard()
    {
        Card p2card = Player2.Deck.GetCurrentCard();
        imageP2.File = p2card.texture;
        labelP2CardName.Text = p2card.name;
        labelP2FlavourText.Text = p2card.flavorText;
        labelP2Type.Text = p2card.type;
        labelP2HP.Text = p2card.hp.ToString();
        labelP2ATK.Text = p2card.atk.ToString();
        labelP2DEF.Text = p2card.def.ToString();
        labelP2SPD.Text = p2card.spd.ToString();
    }

    /// <summary>
    /// Anzeige welcher Spieler die aktuelle Runde gewonnen hat:
    /// Färbt Kartenwerte der gewählten Disziplin ein,
    /// Zeigt Gewinner über "Next Card"-Knopf an
    /// </summary>
    /// <param name="discipline">Die gewählte Disziplin zum Einfärben</param>
    /// <param name="winningPlayer">Der Spieler, der gewonnen hat oder null bei Unentschieden</param>
    /// <remarks>Code ausschließlich von André</remarks>
    public void ShowTurnWinner(Discipline discipline, Player winningPlayer)
    {
        //Behälter für die Farbe, die die Kartenwerte von Spieler 1 und 2 einnehmen werden; Rot=Niederlage, Grün=Sieg, Grau=Unentschieden
        Gdk.Color p1color, p2color;

        //Falls es keinen Sieger gibt (Unentschieden)
        if (winningPlayer == null)
        {
            //Setze die Farbe beider Spieler auf Grau
            p1color = GREY;
            p2color = GREY;

            //Zeige Unentschieden-Text
            labelTurnResult.Text = TURN_RESULT_TIE;
        }
        else
        {
            //Falls es Spieler 1 gewinnt
            if (winningPlayer == Player1)
            {
                //Setze die Farbe von Spieler 2 auf rot und Spieler 1 auf grün
                p1color = GREEN;
                p2color = RED;
                labelTurnResult.ModifyFg(StateType.Normal, p1color);
            }
            else //Falls es Spieler 2 gewinnt
            {
                //Setze die Farbe von Spieler 1 auf rot und Spieler 2 auf grün
                p1color = RED;
                p2color = GREEN;
                labelTurnResult.ModifyFg(StateType.Normal, p1color);
            }

            //Zeige Unentschieden-Text mit eingefügtem Spielernamen
            labelTurnResult.Text = String.Format(TURN_RESULT_WINNER, winningPlayer.Name);
        }

        //Überprufe die Disziplin und setze die Schriftfarbe der entsprechenden Kartenwertanzeigen auf die Farbe der entsprechenden Spieler
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

    /// <summary>
    /// Kampflogik: Vergleicht ausgewählte Disziplinen und entscheidet welcher Spieler die aktuelle Runde gewinnt oder ob es unentschieden endet.
    /// </summary>
    /// <param name="discipline"></param>
    /// <remarks>Code fast ausschließlich von Tim</remarks>
    public void CompareDiscipline(Discipline discipline)
    {
        ShowOpponentCard();
        Card p1Card = Player1.Deck.GetCurrentCard();
        Card p2Card = Player2.Deck.GetCurrentCard();

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

            // HP: Der größere Wert gewinnt
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

            // ATK: Der größere Wert gewinnt
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

            // DEF: Der größere Wert gewinnt
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

            // SPEED: Der größere Wert gewinnt
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

    /// <summary>
    /// Nach dem die Runde entschieden wurde:
    /// Entfernt die beiden Karten der aktuellen Runde aus den Decks und fügt sie dem Deck des Gewinners hinzu, bzw. bei einem Unentschieden werden die Karten den <see cref="TieCards"/> hinzugefügt;
    /// Weise dem <see cref="ActivePlayer"/> den Gewinner der aktuellen Runde zu (Der Gewinner ist als nächster am Zug.);
    /// Überprüfe ob das Spiel zuende ist durch einen Aufruf von <see cref="CheckWinningState"/>
    /// </summary>
    /// <param name="winningPlayer">Der gewinnende Spieler</param>
    /// <param name="losingPlayer">Der verlierende Spieler</param>
    /// <param name="discipline">Die gespielte Disiplin</param>
    /// <remarks>Code fast ausschließlich von Tim</remarks>
    public void RoundDecided(Player winningPlayer, Player losingPlayer, Discipline discipline)
    {
        //Zeige Gewinner an
        ShowTurnWinner(discipline, winningPlayer);

        //Nimm die aktuellen Karten beider Spieler
        Card p1Card = Player1.Deck.GetCurrentCard();
        Card p2Card = Player2.Deck.GetCurrentCard();

        Player1.Deck.RemoveAt(0);
        Player2.Deck.RemoveAt(0);

        //Es keinen Sieger gibt (Stich)
        if (winningPlayer == null)
        {
            //Packe Karten beider Spieler auf den Stichstapel
            TieCards.PutCardsAtBack(p1Card, p2Card);

            //Zeige einen Stich-Stapel an
            imageDeck3.Visible = true;
        }
        else if (winningPlayer == Player1)//Falls Spieler 1 gewinnt
        {
            //Packe Karten beider Spieler hinten auf das Deck von Spieler 1
            Player1.Deck.PutCardsAtBack(p1Card, p2Card);
            //Stelle sicher das Spieler 1 als nächstes am Zug ist
            ActivePlayer = Player1;
        }
        else if (winningPlayer == Player2)//Falls Spieler 2 gewinnt
        {
            //Packe Karten beider Spieler hinten auf das Deck von Spieler 2
            Player2.Deck.PutCardsAtBack(p2Card, p1Card);
            //Stelle sicher das Spieler 2 als nächstes am Zug ist
            ActivePlayer = Player2;
        }
        if (winningPlayer != null)//Es einen Sieger gibt (kein Stich)
        {
            //Packe die Karten von Stich-Stapel hinten auf das Deck des Siegers
            //Entferne die Grafik für den Stich-Stapel
            winningPlayer.Deck.PutCardsAtBack(TieCards);
            TieCards.Clear();
            imageDeck3.Visible = false;
        }
        //Überprüfe ob das Spiel zuende ist
        CheckWinningState();
    }

    /// <summary>
    /// Überprüft anhand der verbleibenden Karten in den Decks, ob ein Spieler das Spiel gewonnen hat, oder ob das Spiel unentschieden endet.
    /// </summary>
    /// <remarks>Code fast ausschließlich von Tim</remarks>
    public void CheckWinningState()
    {
        int p1Count = Player1.Deck.Count;
        int p2Count = Player2.Deck.Count;

        //Falls einer der beiden Spieler keine Karten mehr hat; =Spielende
        if (p1Count == 0 || p2Count == 0)
        {
            //Falls beide Spieler keine Karten mehr haben (alle Karten im Stich-Stapel); =Unentschieden
            if (p1Count == 0 && p2Count == 0)
            {
                //Blendet die Grafiken der Spieler Decks aus
                imageDeck1.Visible = false;
                imageDeck2.Visible = false;

                //Zeige Unentschieden Dialog
				new GameOverDialog(this, null, 0).Show();
            }
            else if (p1Count == 0) //Falls nur Spieler 1 keine Karten mehr hat; =Spieler 2 gewinnt(Niederlage)
            {
                //Blendet die Grafik des Decks von Spieler 1 aus
                imageDeck1.Visible = false;

                //Zeige Spieler 2 gewinnt Dialog
                new GameOverDialog(this, Player2, 2).Show();
            }
            else if (p2Count == 0) //Falls nur Spieler 2 keine Karten mehr hat; =Spieler 1 gewinnt(Sieg)
            {
                //Blendet die Grafik des Decks von Spieler 2 aus
                imageDeck2.Visible = false;

                //Zeige Spieler 1 gewinnt Dialog
                new GameOverDialog(this, Player1, 1).Show();
            }
        }
        else //Wenn das Spiel nicht zuende ist
        {
            //Aktiviere den "Next Card"-Knopf der die nächste Runde startet
            buttonNextCard.Sensitive = true;
        }
    }
}