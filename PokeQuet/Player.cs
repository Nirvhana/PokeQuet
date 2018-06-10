using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeQuet
{
    public class Player
    {
        public static readonly Random RNG = new Random();

        public Deck Deck { get; } = new Deck();
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
    }

    public abstract class AIPlayer : Player
    {
        public AIPlayer(string name) : base(name) { }

        public void Init(Card[] cardPool) { }
        public abstract Discipline MakeTurn(Player opponent, Deck tieCards);
    }

    public class AIPlayerRandom : AIPlayer
    {
        public static readonly Discipline[] DISCIPLINES = (Discipline[])Enum.GetValues(typeof(Discipline));

        //Name ist immer Bug Catcher!
        public AIPlayerRandom() : base("Bug Catcher") { }

        public override Discipline MakeTurn(Player opponent, Deck tieCards)
        {
            return DISCIPLINES[RNG.Next(DISCIPLINES.Length)];
        }
    }
}
