using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndSquare.Models
{
	internal class Square : Figure
	{
		public double SideLength { get; set; }

		public Square(double sideLength)
		{
			X = 50;
			Y = 150;
			SideLength = sideLength;
		}

		public override void DrawBlack()
		{
			Form1.ActiveForm.CreateGraphics().DrawRectangle(Pens.Black,
			(float)(X - SideLength / 2),
			(float) (Y - SideLength / 2),
			(float) SideLength,
			(float)SideLength);
		}

		public override void HideDrawingBackGround()
		{
			Form1.ActiveForm.CreateGraphics().DrawRectangle(new Pen(Form1.ActiveForm.BackColor),
			(float)(X - SideLength / 2),
			(float)(Y - SideLength / 2),
			(float)SideLength,
			(float)SideLength);
		}
	}
}
