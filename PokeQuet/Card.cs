using System;
using System.Collections.Generic;
using System.Linq;

namespace PokeQuet
{
    public class Card
    {
        public string name, flavorText, texture, type;
        public int hp, atk, def, spd;
    }

    public class Deck : List<Card>
    {
        public static readonly Random RNG = new Random();

        public Card GetCurrentCard()
        {
            return this.First();
        }

        public void PutCardAtBack(Card card)
        {

        }

        public static void FillDecksFromCardPool(Card[] pool, Deck deck1, Deck deck2)
        {
            deck1.Clear();
            deck2.Clear();

            // Schleife zum Mischen der Karten, nach dem Fisher-Yates-Mischalgorithmus.
            for (int i = 1; pool.Length > i; i++)
            {
                int j = Deck.RNG.Next(i + 1);
                var card1 = pool[i];
                pool[i] = pool[j];
                pool[j] = card1;
            }

            // Verteilung der gemischten Karten in die Spielerdecks
            deck1.AddRange(pool.Take(pool.Length / 2));
            deck2.AddRange(pool.Skip(pool.Length / 2));
        }
    }

    public class Player
    {
        public Deck Deck { get; } = new Deck();
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
    }

    public abstract class AIPlayer : Player
    {
        public AIPlayer(string name) : base(name){}

        public abstract void Init(Card[] cardPool);
        public abstract int MakeTurn(Player opponent, Deck tieCards);
    }

    public class AIPlayerRandom : AIPlayer
    {
        //Name ist immer Bug Catcher Toby!
        public AIPlayerRandom() : base("Bug Catcher Toby") { }

        public override void Init(Card[] cardPool){}

        public override int MakeTurn(Player opponent, Deck tieCards)
        {
            return Deck.RNG.Next(5);
        }
    }
}