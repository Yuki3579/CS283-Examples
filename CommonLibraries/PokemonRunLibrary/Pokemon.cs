using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRunLibrary
{
	public enum PokemonType
	{ GRASS, POISSON, FIRE, FLYING, DRAGON, WATER, BUG }

	public class Pokemon
	{
		public int Number;
		public string Name;
		public int HP;
		public int CurrentHP;
		public int CP;
		public double Weight;
		public double Height;
		public List<PokemonType> Type = new List<PokemonType>();
		public int PowerUpCandy;
		public int PowerStardust;
		public int EvoleCandy;
	}
}