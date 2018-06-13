using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeQuet
{
    public class Player
    {
        /// <summary>
        /// Ein Random Number Generator,
        /// Statisch um Zufälligkeit besser zu gewährleisten und ständige Neuerzeugung des Objekts vorzubeugen
        /// </summary>
        public static readonly Random RNG = new Random();

        /// <summary>
        /// Das Deck des Spielers
        /// </summary>
        public Deck Deck { get; } = new Deck();
        /// <summary>
        /// Der Name des Spielers
        /// </summary>
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
    }

    /// <summary>
    /// Eine Klasse für Computergesteuerte Gegner die selbstständig Züge machen.
    /// </summary>
    public abstract class AIPlayer : Player
    {
        /// <summary>
        /// Ein Array aller Disziplinen in <see cref="Discipline"/>
        /// </summary>
        public static readonly Discipline[] DISCIPLINES = (Discipline[])Enum.GetValues(typeof(Discipline));

        public AIPlayer(string name) : base(name) { }

        /// <summary>
        /// Eine Methode zum initialisieren der KI sodass diese aufgrund des Kartensatzes z.B.
        /// die statitisch optimale Disziplin für jede Karte berechnen könnten, aber das Umzusetzen erfordert
        /// den ganzen Disziplinvergleich selbst zu implementieren oder das der Disziplinvergleich vom restlichen
        /// Spielverlauf getrennt wird.
        /// </summary>
        /// <param name="cardPool">Der komplette Kartensatz</param>
        /// <remarks>Diese Methode ist obsolet</remarks>
        public void Init(Card[] cardPool) { }
        /// <summary>
        /// Die Methode zur Bestimmung des Zugs des Computerspielers
        /// </summary>
        /// <param name="opponent">Der gegnerische Spieler</param>
        /// <param name="tieCards">Der Stich-Stapel</param>
        /// <returns>Die Disziplin die als Zug gewählt wird.</returns>
        public abstract Discipline MakeTurn(Player opponent, Deck tieCards);
    }
    
    /// <summary>
    /// KI für leichten Computergegner, der völlig zufällige Disziplinen auswählt.
    /// </summary>
    public class AIPlayerRandom : AIPlayer
    {
        public AIPlayerRandom() : base("Bug Catcher") { } //Heißt immer Bug Catcher

        public override Discipline MakeTurn(Player opponent, Deck tieCards)
        {
            //Nimmt ein zufälliges Element aus DISCIPLINES
            return DISCIPLINES[RNG.Next(DISCIPLINES.Length)];
        }
    }

    /// <summary>
    /// KI für schweren Computergegner, der logische Entscheidungen trifft und immer den höchsten Wert wählt, aber Type ignoriert.
    /// </summary>
    public class AIPlayerSimple : AIPlayer
	{
		public AIPlayerSimple() : base("Gym Leader") { } //Heißt immer Gym Leader

		public override Discipline MakeTurn(Player opponent, Deck tieCards)
		{
			var card = Deck.GetCurrentCard();
            //Packe alle Kartenwerte in der richtigen Reihenfolge in eine Liste
            var values = new List<int>(){ card.hp, card.atk, card.def, card.spd };
            //Finde den Index des höchsten Werts
            var index = values.IndexOf(values.Max());
            //Gib die Disziplin an der entsprechenden Stelle in DISCIPLINES zurück; +1, weil TYPE in DISCIPLINES an erster Stelle steht
            return DISCIPLINES[index+1];
	  	}
    }
}
