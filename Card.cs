using System;

namespace CardGUI
{
	/// <summary>
	/// Summary description for Card.
	/// </summary>
	public class Card
	{
        /// <summary>
        /// Name of the song
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Foot rating for the song
        /// </summary>
        public int FootRating
        {
            get;
            private set;
        }

        /// <summary>
        /// Difficulty of the song (Basic, Difficult, Expert, Hard, etc)
        /// </summary>
        public Difficulty SongDifficulty
        {
            get;
            private set;
        }

		public Card(string songName, int songRating, Difficulty songDiff)
		{
            Name = songName;
            FootRating = songRating;
            SongDifficulty = songDiff;
		}

		public override bool Equals(object obj)
		{
            Card temp = obj as Card;

            if (temp == null)
				return false;

			if (this.Name == temp.Name && this.SongDifficulty == temp.SongDifficulty && this.FootRating == temp.FootRating)
			    return true;

			return false;
		}

		public override int GetHashCode()
		{
            return Name.GetHashCode();
		}

		public override string ToString()
		{
			return Name + " " + SongDifficulty.ToString() + ": " + FootRating + " footer";
		}
	}	
}
