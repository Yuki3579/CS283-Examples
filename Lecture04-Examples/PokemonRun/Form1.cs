using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonRunLibrary;

namespace PokemonRun
{
	public partial class Form1 : Form
	{
		private Random random = new Random();
		private GameController Game = new GameController();
		private List<Pokemon> pokemons = new List<Pokemon>();

		public Form1()
		{
			InitializeComponent();
			Game.Initailize();
		}

		private void GeneratePokemonBox()
		{
			PictureBox pokemonBox = new PictureBox();

			int x = random.Next(0, 1100 - 90 + 1);
			int y = random.Next(0, 700 - 55 - 90 + 1);
			pokemonBox.Location = new Point(x, y);
			Pokemon pokemon = Game.Generate();
			switch (pokemon.Number)
			{
				case 1:
					pokemonBox.Image = global::PokemonRun.Properties.Resources._001;
					break;

				case 2:
					pokemonBox.Image = global::PokemonRun.Properties.Resources._002;
					break;

				case 3:
					pokemonBox.Image = global::PokemonRun.Properties.Resources._003;
					break;

				case 4:
					pokemonBox.Image = global::PokemonRun.Properties.Resources._004;
					break;

				default:
					pokemonBox.Image = global::PokemonRun.Properties.Resources._001;
					break;
			}

			pokemonBox.Name = pokemon.Name;
			pokemonBox.Size = new Size(90, 90);
			pokemonBox.SizeMode = PictureBoxSizeMode.Zoom;
			pokemonBox.TabIndex = 1;
			pokemonBox.TabStop = false;
			pokemonBox.Click += new System.EventHandler(this.pokemonBox_Click);
			((ISupportInitialize)(pokemonBox)).EndInit();
			pokemons.Add(pokemon);
			this.Controls.Add(pokemonBox);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (pokemons.Count < 10)
			{
				GeneratePokemonBox();
			}
		}

		private void pokemonBox_Click(object sender, EventArgs e)
		{
			MessageBox.Show("遇見野生的寶可夢");
		}
	}
}