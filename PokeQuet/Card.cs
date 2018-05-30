using System;
using System.Collections.Generic;

namespace PokeQuet
{
    public class Card
    {
        public string name, flavorText, texture, type;
        public int hp, atk, def, spd;
    }

    public class Deck : LinkedList<Card> {

        public Card GetCurrentCard()
        {
            return this.First.Value;
        }

        public void PutCardAtBack(Card card)
        {

        }

        public static void FillDecksFromCardPool(IEnumerable<Card> pool, Deck deck1, Deck deck2)
        {
            deck1.Clear();
            deck2.Clear();
            //TODO: Kartenmischlogik hier
        }
    }

    public class Player{
        public Deck Deck { get; } = new Deck();
        public string Name { get; set; }

        public Player(string name) {
            this.Name = name;
        }

        //TODO: Abgrenzen von CPU und menschlichen Spielern
    }
}
