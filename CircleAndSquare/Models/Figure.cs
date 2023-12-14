using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndSquare.Models
{
	abstract class Figure
	{
		public double X { get; set; }

		public double Y { get; set; }

		public abstract void DrawBlack();

		public abstract void HideDrawingBackGround();

		public async Task MoveRightAsync() 
		{
			for (int i = 0; i <= 50; i++)
			{
				DrawBlack();
				await Task.Delay(60);
				HideDrawingBackGround();
				X++;
			}
		}
    }
}
