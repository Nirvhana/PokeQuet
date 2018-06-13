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

        // Gibt dem Spieler die oberste Karte seines Decks ([0]) in seine Hand.
        public Card GetCurrentCard()
        {
            return this.First();
        }

        // Funktion um Karten dem Deck des Gewinners einer Runde hinzuzufügen.
		public void PutCardsAtBack(IEnumerable<Card> cards)
        {
			this.AddRange(cards);
        }

        // Funktion um Karten dem Deck des Gewinners einer Runde hinzuzufügen.
		public void PutCardsAtBack(params Card[] cards)
		{
			this.AddRange(cards);
        }

        // Generiert gleichgroße Decks aus allen Karten für beide Spieler.
        public static void FillDecksFromCardPool(Card[] pool, Deck deck1, Deck deck2, int deckSize)
        {
            deck1.Clear();
            deck2.Clear();

            // Schleife zum Mischen der Karten, nach dem Fisher-Yates-Mischalgorithmus.
            for (int i = 1; pool.Length > i; i++)
            {
                int j = Deck.RNG.Next(i + 1);
                Card card1 = pool[i];
                pool[i] = pool[j];
                pool[j] = card1;
            }

            // Verteilung der gemischten Karten in die Spielerdecks
            deck1.AddRange(pool.Take(pool.Length / 2));
            deck2.AddRange(pool.Skip(pool.Length / 2));  

            switch (deckSize)
            {
                case 2:
                    {
                        deck1.RemoveRange(1, 8);
                        deck2.RemoveRange(1, 8);
                    }
                    break;
                case 3:
                    {
                        deck1.RemoveRange(1, 12);
                        deck2.RemoveRange(1, 12);
                    }
                    break;
            }
        }
    }

	public enum Discipline
	{
		TYPE,
		HP,
		ATK,
		DEF,
		SPD
	}
}