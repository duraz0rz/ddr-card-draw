using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CardGUI
{
    public class Deck
    {
        List<Card> songsInDeck = new List<Card>();

        public GameType Game
        {
            get;
            private set;
        }

        public Deck(GameType g)
        {
            Game = g;
        }

        /// <summary>
        /// Loads a deck with the specified difficulty
        /// </summary>
        /// <param name="diff"></param>
        public void LoadDeck(Difficulty diff)
        {
            List<String> songList = new List<string>();
            String[] splitLine;

            switch (diff)
            {
                case Difficulty.Expert:
                    songList = CardGUI.Properties.Resources.itg_expert.Split('\n').ToList();
                    break;
                case Difficulty.Hard:
                    songList = CardGUI.Properties.Resources.itg_hard.Split('\n').ToList();
                    break;
                case Difficulty.Heavy:
                    songList = CardGUI.Properties.Resources.ddr_heavy.Split('\n').ToList();
                    break;
                case Difficulty.Standard:
                    songList = CardGUI.Properties.Resources.ddr_standard.Split('\n').ToList();
                    break;
                default:
                    songList = CardGUI.Properties.Resources.custom.Split('\n').ToList();
                    break;
            }

            if (songList.Count == 0)
                return;

            songsInDeck.Clear();

            foreach (String song in songList)
            {
                splitLine = song.Split(',');
                songsInDeck.Add(new Card(splitLine[0], Convert.ToInt32(splitLine[2]), (Difficulty)Enum.Parse(typeof(Difficulty), splitLine[1])));
            }
        }

        public Card DrawCard()
        {
            Random randNum = new Random();
            Card drawnCard = songsInDeck[randNum.Next(0, songsInDeck.Count - 1])];
            songsInDeck.Remove(drawnCard);
            return drawnCard;
        }

        public List<Card> DrawCards(int numToDraw)
        {
            List<Card> drawnCards = new List<Card>(numToDraw);

            for (int i = 1; i <= numToDraw; i++)
                drawnCards.Add(DrawCard());

            return drawnCards;
        }

        /// <summary>
        /// Put back one or more cards that were drawn into the deck
        /// </summary>
        /// <param name="cardsToPutBack"></param>
        public void ReplaceCards(Card[] cardsToPutBack)
        {
            songsInDeck.AddRange(cardsToPutBack);
        }
    }
}
