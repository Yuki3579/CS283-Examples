using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunLibrary;
using EasyMathLibrary;

namespace Example03
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			#region 定義Pokemon資料庫

			List<Pokemon> pokedex = new List<Pokemon>();
			pokedex.Add(new Pokemon()
			{
				Name = "妙蛙種子",
				Number = 1,
				CP = 499,
				Height = 0.67,
				Weight = 5.94,
				HP = 60,
				CurrentHP = 60,
				PowerStardust = 3000,
				PowerUpCandy = 3,
				EvoleCandy = 25
			});

			pokedex[0].Type.Add(PokemonType.GRASS);
			pokedex[0].Type.Add(PokemonType.POISSON);

			pokedex.Add(new Pokemon()
			{
				Name = "妙蛙草",
				Number = 2,
				CP = 630,
				Height = 1.02,
				Weight = 7.36,
				HP = 67,
				CurrentHP = 67,
				PowerStardust = 2200,
				PowerUpCandy = 2,
				EvoleCandy = 100
			});

			pokedex[1].Type.Add(PokemonType.GRASS);
			pokedex[1].Type.Add(PokemonType.POISSON);

			pokedex.Add(new Pokemon()
			{
				Name = "小火龍",
				Number = 3,
				CP = 459,
				Height = 0.55,
				Weight = 5.84,
				HP = 54,
				CurrentHP = 54,
				PowerStardust = 2500,
				PowerUpCandy = 2,
				EvoleCandy = 25
			});

			pokedex[2].Type.Add(PokemonType.FIRE);

			#endregion 定義Pokemon資料庫

			EasyRandom random = new EasyRandom();

			List<Pokemon> Items = new List<Pokemon>();
			for (int index = 1; index <= 10; index++)
			{
				Pokemon pokemon = pokedex[random.Next(0, pokedex.Count)];

				Console.WriteLine(pokemon.Name);
				Items.Add(pokemon);
			}
			int[] magicNumbers = new int[] { 1, 3, 4 };
			Pokemon p = pokedex[random.Next(0, pokedex.Count)];

			Console.WriteLine("遇到野生的{0}", p.Name);
			Console.WriteLine("開始戰鬥,丟出寶貝球");
			int number = random.Next(1, 7);
			bool catched = false;
			for (int index = 0; index < magicNumbers.Length; index++)
			{
				if (number == magicNumbers[index])
				{
					catched = true;
					break;
				}

				if (catched)
				{
					Console.WriteLine("抓到野生的{0}", p.Name);
					Items.Add(p);
				}
				else
				{
					Console.WriteLine("好可惜,{0}逃走了", p.Name);
				}
			}
		}
	}
}