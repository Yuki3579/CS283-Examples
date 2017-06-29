using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace PokemonRunLibrary
{
	public class GameController
	{
		public List<Pokemon> pokedex;
		private EasyRandom random;

		public Player player;

		#region 初始化設定遊戲

		public void Initailize()
		{
			// Step 1: 建立遊戲資料庫

			#region 定義Pokemon資料庫

			pokedex = new List<Pokemon>();
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
				EvolveCandy = 25
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
				EvolveCandy = 100
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
				EvolveCandy = 25
			});
			pokedex[2].Type.Add(PokemonType.FIRE);

			#endregion 定義Pokemon資料庫

			// Step 2: 初始亂數產生器
			random = new EasyRandom();

			// Step 4: 建立一個玩家的物件
			player = new Player();
			player.Initialize();
		}

		#endregion 初始化設定遊戲

		#region 提供隨機產生的寶可夢

		public Pokemon Generate()
		{
			return pokedex[random.Next(0, pokedex.Count)];
		}

		#endregion 提供隨機產生的寶可夢

		public void StartConsole()
		{
			Initailize();
			Pokemon p = Generate();
			Console.WriteLine("遇到野生的{0}", p.Name);
			Console.WriteLine("開始戰鬥，丟出寶貝球");

			if (player.Catch(p))
			{
				Console.WriteLine("抓到野生的{0}", p.Name);
			}
			else
			{
				Console.WriteLine("好可惜，{0}逃走了", p.Name);
			}
		}
	}
}