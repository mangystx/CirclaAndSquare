using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleAndSquare.Models
{
	internal class Circle : Figure
	{
		public double Radius { get; set; }

		public Circle(double radius)
		{
			X = 50;
			Y = 150;
			Radius = radius;
		}

		public override void DrawBlack()
		{
			Form1.ActiveForm.CreateGraphics().DrawEllipse(Pens.Black, 
			   (float)(X - Radius),
			   (float)(Y - Radius),
			   (float)(2 * Radius),
			   (float)(2 * Radius));
		}

		public override void HideDrawingBackGround()
		{
			Form1.ActiveForm.CreateGraphics().DrawEllipse(new Pen(Form1.ActiveForm.BackColor),
				(float)(X - Radius),
				(float)(Y - Radius),
				(float)(2 * Radius),
				(float)(2 * Radius));
		}
	}
}
