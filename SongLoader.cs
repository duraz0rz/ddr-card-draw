using System;
using System.Collections;
using System.IO;

namespace CardGUI
{
	/// <summary>
	/// Summary description for SongLoader.
	/// </summary>
	public static class SongLoader
	{
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
