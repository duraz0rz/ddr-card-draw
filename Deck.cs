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

            }
        }

        public static ArrayList LoadSongs(string fileName)
        {
            string line;
            string name, difficulty;
            int footRating;
            Card temp;
            string[] rawr;

            ArrayList songs = new ArrayList();

            // Load DDR Heavy by Default
            StreamReader sr = new StreamReader(fileName);
            line = sr.ReadLine();

            try
            {
                do
                {
                    rawr = line.Split(',');
                    name = rawr[0];
                    difficulty = rawr[1];
                    footRating = int.Parse(rawr[2]);

                    // Create new Card instance
                    temp = new Card(name, footRating, difficulty);

                    System.Diagnostics.Debug.WriteLine(temp.ToString());

                    // Add it to songs ArrayList
                    songs.Add(temp);

                    // Get the next line
                    line = sr.ReadLine();
                } while (line != null);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }

            return songs;
        }
    }
}
