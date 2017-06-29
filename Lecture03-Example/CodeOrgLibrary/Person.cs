using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOrgLibrary
{
	public class Person
	{
		public string Name;
		public Position CurrentPosition;

		public void TurnRight(double angle)
		{
			this.CurrentPosition.Orientation += angle;
		}

		public void MoverForward(double distance)
		{
			double arc = this.CurrentPosition.Orientation * 2.0 * Math.PI / 360.0;
			this.CurrentPosition.X += distance * Math.Cos(arc);
			this.CurrentPosition.X += distance * Math.Sin(arc);
		}

		public void DrawRectangle(double width)
		{
			ShowPosition();
			for (int count = 0; count < 4; count++)
			{
				this.MoverForward(width);
				this.TurnRight(90);
				ShowPosition();/*每次轉彎之後秀位置*/
			}
		}

		public void ShowPosition()
		{
			Console.WriteLine("{3}現在位置:({0}, {1})方向是: {2}",
				CurrentPosition.X,
				CurrentPosition.Y,
				CurrentPosition.Orientation, Name);
		}
	}
}