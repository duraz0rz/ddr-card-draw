using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace CardGUI
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		#region Form Variables

		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menu_Exit;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menu_DDRStand;
		private System.Windows.Forms.MenuItem menu_DDRHeavy;
		private System.Windows.Forms.MenuItem menu_ITGHard;
		private System.Windows.Forms.MenuItem menu_ITGExpert;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboNumCards;
		private System.Windows.Forms.Button btnDraw;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.Label lblPick2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboMaxFoot;
		private System.Windows.Forms.ComboBox cboMinFoot;
		private System.Windows.Forms.Label lblGameType;
		private System.Windows.Forms.OpenFileDialog dlgOpenSongList;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.CheckedListBox lstSongs;
		private System.Windows.Forms.Button btnPutBack;
		private System.Windows.Forms.MenuItem menuItem10;

		#endregion

		#region Private Variables

		ArrayList songs, drawn;
		object[] itg_diff = new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"};
		object[] ddr_diff = new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
		int cardsPutBack = 0;

		string filePath;
		string game;

		#endregion

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menu_Exit = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menu_DDRStand = new System.Windows.Forms.MenuItem();
			this.menu_DDRHeavy = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menu_ITGHard = new System.Windows.Forms.MenuItem();
			this.menu_ITGExpert = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.cboNumCards = new System.Windows.Forms.ComboBox();
			this.btnDraw = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cboMaxFoot = new System.Windows.Forms.ComboBox();
			this.cboMinFoot = new System.Windows.Forms.ComboBox();
			this.lblGameType = new System.Windows.Forms.Label();
			this.dlgOpenSongList = new System.Windows.Forms.OpenFileDialog();
			this.lblPick2 = new System.Windows.Forms.Label();
			this.lstSongs = new System.Windows.Forms.CheckedListBox();
			this.btnPutBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menu_Exit});
			this.menuItem1.Text = "File";
			// 
			// menu_Exit
			// 
			this.menu_Exit.Index = 0;
			this.menu_Exit.Text = "Exit";
			this.menu_Exit.Click += new System.EventHandler(this.menu_Exit_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.menuItem5});
			this.menuItem3.Text = "Game";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menu_DDRStand,
																					  this.menu_DDRHeavy,
																					  this.menuItem10,
																					  this.menuItem2,
																					  this.menuItem6});
			this.menuItem4.Text = "DDR";
			// 
			// menu_DDRStand
			// 
			this.menu_DDRStand.Index = 0;
			this.menu_DDRStand.Text = "Standard";
			this.menu_DDRStand.Click += new System.EventHandler(this.menu_DDRStand_Click);
			// 
			// menu_DDRHeavy
			// 
			this.menu_DDRHeavy.Index = 1;
			this.menu_DDRHeavy.Text = "Heavy";
			this.menu_DDRHeavy.Click += new System.EventHandler(this.menu_DDRHeavy_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 2;
			this.menuItem10.Text = "Standard + Heavy";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 3;
			this.menuItem2.Text = "-";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "Custom DDR Songlist";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menu_ITGHard,
																					  this.menu_ITGExpert,
																					  this.menuItem9,
																					  this.menuItem7,
																					  this.menuItem8});
			this.menuItem5.Text = "ITG";
			// 
			// menu_ITGHard
			// 
			this.menu_ITGHard.Index = 0;
			this.menu_ITGHard.Text = "Hard";
			this.menu_ITGHard.Click += new System.EventHandler(this.menu_ITGHard_Click);
			// 
			// menu_ITGExpert
			// 
			this.menu_ITGExpert.Index = 1;
			this.menu_ITGExpert.Text = "Expert";
			this.menu_ITGExpert.Click += new System.EventHandler(this.menu_ITGExpert_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Text = "Hard and Expert";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 4;
			this.menuItem8.Text = "Custom ITG Song List";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cards to Draw:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cboNumCards
			// 
			this.cboNumCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboNumCards.Items.AddRange(new object[] {
															 "2",
															 "3",
															 "4",
															 "5",
															 "6",
															 "7"});
			this.cboNumCards.Location = new System.Drawing.Point(128, 16);
			this.cboNumCards.Name = "cboNumCards";
			this.cboNumCards.Size = new System.Drawing.Size(96, 24);
			this.cboNumCards.TabIndex = 1;
			// 
			// btnDraw
			// 
			this.btnDraw.Location = new System.Drawing.Point(24, 152);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(96, 56);
			this.btnDraw.TabIndex = 2;
			this.btnDraw.Text = "&Draw";
			this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Min Foot:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Max Foot:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cboMaxFoot
			// 
			this.cboMaxFoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaxFoot.Items.AddRange(new object[] {
															"1",
															"2",
															"3",
															"4",
															"5",
															"6",
															"7",
															"8",
															"9",
															"10"});
			this.cboMaxFoot.Location = new System.Drawing.Point(128, 112);
			this.cboMaxFoot.Name = "cboMaxFoot";
			this.cboMaxFoot.Size = new System.Drawing.Size(96, 24);
			this.cboMaxFoot.TabIndex = 7;
			// 
			// cboMinFoot
			// 
			this.cboMinFoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMinFoot.Items.AddRange(new object[] {
															"1",
															"2",
															"3",
															"4",
															"5",
															"6",
															"7",
															"8",
															"9",
															"10"});
			this.cboMinFoot.Location = new System.Drawing.Point(128, 64);
			this.cboMinFoot.Name = "cboMinFoot";
			this.cboMinFoot.Size = new System.Drawing.Size(96, 24);
			this.cboMinFoot.TabIndex = 8;
			// 
			// lblGameType
			// 
			this.lblGameType.Location = new System.Drawing.Point(8, 224);
			this.lblGameType.Name = "lblGameType";
			this.lblGameType.Size = new System.Drawing.Size(224, 32);
			this.lblGameType.TabIndex = 9;
			this.lblGameType.Text = "Blah";
			this.lblGameType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dlgOpenSongList
			// 
			this.dlgOpenSongList.Title = "Open Custom Song List";
			// 
			// lblPick2
			// 
			this.lblPick2.Location = new System.Drawing.Point(248, 224);
			this.lblPick2.Name = "lblPick2";
			this.lblPick2.Size = new System.Drawing.Size(440, 32);
			this.lblPick2.TabIndex = 11;
			this.lblPick2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lstSongs
			// 
			this.lstSongs.CheckOnClick = true;
			this.lstSongs.Location = new System.Drawing.Point(240, 16);
			this.lstSongs.Name = "lstSongs";
			this.lstSongs.Size = new System.Drawing.Size(448, 184);
			this.lstSongs.TabIndex = 12;
			// 
			// btnPutBack
			// 
			this.btnPutBack.Enabled = false;
			this.btnPutBack.Location = new System.Drawing.Point(136, 152);
			this.btnPutBack.Name = "btnPutBack";
			this.btnPutBack.Size = new System.Drawing.Size(96, 56);
			this.btnPutBack.TabIndex = 13;
			this.btnPutBack.Text = "Put selected cards back";
			this.btnPutBack.Click += new System.EventHandler(this.btnPutBack_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(694, 263);
			this.Controls.Add(this.btnPutBack);
			this.Controls.Add(this.lstSongs);
			this.Controls.Add(this.lblPick2);
			this.Controls.Add(this.lblGameType);
			this.Controls.Add(this.cboMinFoot);
			this.Controls.Add(this.cboMaxFoot);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnDraw);
			this.Controls.Add(this.cboNumCards);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Card Draw";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Load DDR by default
			filePath = "Song Lists\\ddr_heavy.txt";
			game = "DDR Heavy";
			reloadSongs();
			cboNumCards.SelectedIndex = 3;
		}

		private void btnDraw_Click(object sender, System.EventArgs e)
		{
			// Clear the listbox first
			lstSongs.Items.Clear();

			// Then get foot ratings range
			int minfoot = int.Parse(cboMinFoot.Items[ cboMinFoot.SelectedIndex ].ToString() );
			int maxfoot = int.Parse(cboMaxFoot.Items[ cboMaxFoot.SelectedIndex ].ToString() );

			// Get # of cards to draw
			int cardsToDraw = int.Parse(cboNumCards.Items[ cboNumCards.SelectedIndex ].ToString() );
			int cardsDrawn = 0;
			bool redraw = false;
			int randNum;
			Random random = new Random( DateTime.Now.Millisecond );
			Card temp;

			drawn = new ArrayList();
			ArrayList songsToDrawFrom = narrowDown(minfoot, maxfoot);

			try
			{
				// ERror check to see if min foot doesn't blah
				if (minfoot > maxfoot)
					throw new ApplicationException ("Your max foot cannot be smaller than your min foot!");

				// Check to see if there are any songs to draw from
				if (songsToDrawFrom.Count == 0)
					throw new ApplicationException ("No songs are in the specified foot range!");

				// Check to see if there are enough cards to draw
				else if ((songs.Count < cardsToDraw) || (songsToDrawFrom.Count < cardsToDraw))
					throw new IndexOutOfRangeException ("Not enough songs to draw from...restocking");

				else
				{
                    // Pretty sure this can be optimized more/better.
                    // Basically, this will draw cards until the number to be drawn is reached
					while (cardsDrawn < cardsToDraw)
					{
						redraw = false;

						// Pick a random number
						randNum = random.Next() % songsToDrawFrom.Count;
						
						// Don't add it just yet...assign it to temp
						temp = (Card)songsToDrawFrom[randNum];

						// Check to see if its in the foot range
						if ( (temp.FootRating > maxfoot) || (temp.FootRating < minfoot)	)
						{
							System.Diagnostics.Debug.WriteLine(temp.ToString() + " not in foot bounds...redrawing");
							redraw = true;
						}
						else
						{
							// Skip if this is the first card drawn
							if (cardsDrawn == 0)
							{
							}
							else
							{
								// If it is in the foot range, check to see if it's a duplicate
								for (int i = 0; i < cardsDrawn; i++)
								{
									if ( (temp.Equals (drawn[i])) && songs.Count > cardsToDraw )
									{
										System.Diagnostics.Debug.WriteLine("Duplicate found: " + temp.ToString() + "...redrawing");
										redraw = true;
									}
								}
							}
						}

						// If we don't need to redraw, then add it to the drawn pie
						// and increment our counter to tell that we have drawn the card
						if (!redraw)
						{
							drawn.Add(temp);
                            lstSongs.Items.Add(temp]);
							cardsDrawn++;
						}
					}

					// Take out the songs from the songs list
					TakeOutSongs (drawn);
			
					lblPick2.Text = "Pick songs to put back...";
					btnDraw.Enabled = false;
					btnPutBack.Enabled = true;
				}
			}
			catch (ApplicationException err)
			{
				MessageBox.Show(err.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
			}
			catch (IndexOutOfRangeException err)
			{
				MessageBox.Show(err.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
				reloadSongs();
			}
		}

		private void TakeOutSongs ( ArrayList drawn )
		{
            foreach (object hello in drawn)
            {
                songs.Remove(hello);
                Debug.WriteLine("Songs remaining: " + songs.Count);
            }
		}
				

		#region Menu Event Handlers

		private void menu_Exit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menu_DDRStand_Click(object sender, System.EventArgs e)
		{
			game = "DDR Standard";
			filePath = "Song Lists\\ddr_standard.txt";
			reloadSongs();
		}

		private void menu_DDRHeavy_Click(object sender, System.EventArgs e)
		{
			game = "DDR Heavy";
			filePath = "Song Lists\\ddr_heavy.txt";
			reloadSongs();
		}

		private void menu_ITGHard_Click(object sender, System.EventArgs e)
		{
			game = "ITG Hard";
			filePath = "Song Lists\\itg_hard.txt";
			reloadSongs();
		}

		private void menu_ITGExpert_Click(object sender, System.EventArgs e)
		{
			game = "ITG Expert";
			filePath = "Song Lists\\itg_expert.txt";
			reloadSongs();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			if (this.dlgOpenSongList.ShowDialog() == DialogResult.OK)
			{
				game = "DDR Custom";
				filePath = this.dlgOpenSongList.FileName;
				reloadSongs();
			}
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			if (this.dlgOpenSongList.ShowDialog() == DialogResult.OK)
			{
				game = "ITG Custom";
				filePath = this.dlgOpenSongList.FileName;
				reloadSongs();
			}
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			game = "ITG Hard and Expert";
			filePath = "Song Lists\\itg_hardexpert.txt";
			reloadSongs();
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			game = "DDR Heavy and Standard";
			filePath = "Song Lists\\ddr_heavystandard.txt";
			reloadSongs();
		}

		#endregion

		private void reloadSongs()
		{
			songs = SongLoader.LoadSongs(filePath);
			changeDiff();
		}

		private void changeDiff()
		{
			if ((game == "ITG Expert") || (game == "ITG Custom") || (game == "ITG Hard and Expert"))
			{
				this.cboMinFoot.Items.Clear();
				this.cboMinFoot.Items.AddRange(itg_expert);
				this.cboMaxFoot.Items.Clear();
				this.cboMaxFoot.Items.AddRange(itg_expert);
			}
			else if (game == "ITG Hard")
			{
				this.cboMinFoot.Items.Clear();
				this.cboMinFoot.Items.AddRange(itg_hard);
				this.cboMaxFoot.Items.Clear();
				this.cboMaxFoot.Items.AddRange(itg_hard);
			}
			else
			{
				this.cboMinFoot.Items.Clear();
				this.cboMinFoot.Items.AddRange(ddr_diff);
				this.cboMaxFoot.Items.Clear();
				this.cboMaxFoot.Items.AddRange(ddr_diff);
			}

			// Select 1 for min and 10 for max
			cboMinFoot.SelectedIndex = 0;
			cboMaxFoot.SelectedIndex = 9;

			// Change label so user knows what game is picked
			this.lblGameType.Text = game + " is loaded.";
		}


		// Finds songs in the appropriate foot range, and sends it back
		private ArrayList narrowDown(int minfoot, int maxfoot)
		{
			ArrayList narrowed = new ArrayList();

			for (int i = 0; i < songs.Count; i++)
			{
				if ( (((Card)songs[i]).FootRating <= maxfoot) && (((Card)songs[i]).FootRating >= minfoot) )
				{
					System.Diagnostics.Debug.WriteLine("Found song between " + minfoot + " and " + maxfoot + ": " + ((Card)songs[i]).ToString());
					narrowed.Add(songs[i]);
				}
			}

			return narrowed;
		}

		private void btnPutBack_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.CheckedListBox.CheckedItemCollection index = lstSongs.CheckedItems;

			foreach (Card lol in index)
			{
				Debug.WriteLine("Putting back: " + lol.ToString());
				songs.Add(lol);
				lstSongs.Items.Remove(lol);
				Debug.WriteLine("Songs remaining: " + songs.Count);
			}

			btnDraw.Enabled = true;
			btnPutBack.Enabled = false;
			lblPick2.Text = "";
		}

		
	}
}