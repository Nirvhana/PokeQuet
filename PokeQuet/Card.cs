using System;
using System.Collections.Generic;
using System.Linq;

namespace PokeQuet
{
    /// <summary>
    /// Klasse die eine Karte darstellt und durch Modelbinding via JSON.NET zusammengebaut wird.
    /// </summary>
    public class Card
    {
        public string name, flavorText, texture, type;
        public int hp, atk, def, spd;
    }

    /// <summary>
    /// Klasse die ein Kartendeck darstellt und keine 
    /// </summary>
    public class Deck : List<Card>
    {
        public static readonly Random RNG = new Random();

        /// <summary>
        /// Gibt die aktuelle(vorderste) Karte des Decks zurück.
        /// Im wesentlichen nur eine Wrapperfunktion, die dazu da ist Listenoperationen durch Analogien aus dem echten Leben verständlicher zu machen.
        /// </summary>
        /// <returns>Die aktuelle Karte des Decks</returns>
        /// <remarks>Code ausschließlich von André</remarks>
        public Card GetCurrentCard()
        {
            return this.First();
        }

        /// <summary>
        /// Packt eine Menge an Karten hinten auf das Deck.
        /// Im wesentlichen nur eine Wrapperfunktion, die dazu da ist Listenoperationen durch Analogien aus dem echten Leben verständlicher zu machen.
        /// </summary>
        /// <returns>Die aktuelle Karte des Decks</returns>
        /// <remarks>Code ausschließlich von André</remarks>
        public void PutCardsAtBack(IEnumerable<Card> cards)
        {
			this.AddRange(cards);
        }

        /// <summary>
        /// Packt eine Menge an Karten hinten auf das Deck.
        /// Implementiert um params-Aufrufe zu ermöglichen.
        /// Im wesentlichen nur eine Wrapperfunktion, die dazu da ist Listenoperationen durch Analogien aus dem echten Leben verständlicher zu machen.
        /// </summary>
        /// <returns>Die aktuelle Karte des Decks</returns>
        /// <remarks>Code ausschließlich von André</remarks>
        public void PutCardsAtBack(params Card[] cards)
		{
			this.AddRange(cards);
        }

        /// <summary>
        /// Packt eine Menge an Karten hinten auf das Deck.
        /// Implementiert um params-Aufrufe zu ermöglichen.
        /// Im wesentlichen nur eine Wrapperfunktion, die dazu da ist Listenoperationen durch Analogien aus dem echten Leben verständlicher zu machen.
        /// </summary>
        /// <returns>Die aktuelle Karte des Decks</returns>
        /// <remarks>Code von Tim und André</remarks>
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
            deck1.AddRange(pool.Take(pool.Length / 2)); //Erste Hälfte an Deck 1
            deck2.AddRange(pool.Skip(pool.Length / 2)); //Zweite Hälfte and Deck 2

            //Beschränkung der Deckgröße durch entfernen einer fixen Anzahl an Elementen
            //Geschrieben von Tim, kommentiert von André
            //Problem 1: Kartenzahlen im Hauptmenü stimmen nicht wenn die Gesamtzahl der Karten sich ändert
            //Problem 2: Bei zu wenigen Karten im Deck kann es zu einem Absturz kommen
            switch (deckSize)
            {
                case 2:
                    {
                        deck1.RemoveRange(0, 7);
                        deck2.RemoveRange(0, 7);
                    }
                    break;
                case 3:
                    {
                        deck1.RemoveRange(0, 11);
                        deck2.RemoveRange(0, 11);
                    }
                    break;
            }
        }
    }

    /// <summary>
    /// Ein Enum der die Kartendisziplinen darstellt. 
    /// </summary>
	public enum Discipline
	{
		TYPE,
		HP,
		ATK,
		DEF,
		SPD
	}
}