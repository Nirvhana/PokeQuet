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
        public static readonly Random RNG = new Random();

        public Card GetCurrentCard()
        {
            return this.First.Value;
        }

        public void PutCardAtBack(Card card)
        {

        }

        public static void FillDecksFromCardPool(Card[] pool, Deck deck1, Deck deck2)
        {
            deck1.Clear();
            deck2.Clear();
            //TODO: Kartenmischlogik hier

            for (int i = 1; pool.Length > i ; i++ )
            {
                int j = Deck.RNG.Next(i+1);
                var card1 = pool[i];
                pool[i] = pool[j];
                pool[j] = card1;
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
