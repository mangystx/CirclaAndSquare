using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndSquare.Models
{
	internal class Rhomb : Figure
	{
		public double HorDiagLen { get; set; }
		public double VertDiagLen { get; set; }

		public Rhomb(double diagonal1, double diagonal2)
		{
			X = 50;
			Y = 150;
			HorDiagLen = diagonal1;
			VertDiagLen = diagonal2;
		}

		public override void DrawBlack()
		{
			Point[] points = new Point[4];

			points[0] = new Point((int)X, (int)(Y - HorDiagLen / 2));
			points[1] = new Point((int)(X + VertDiagLen / 2), (int)Y);
			points[2] = new Point((int)X, (int)(Y + HorDiagLen / 2));
			points[3] = new Point((int)(X - VertDiagLen / 2), (int)Y);

			Form1.ActiveForm.CreateGraphics().DrawPolygon(Pens.Black, points);
		}

		public override void HideDrawingBackGround()
		{
			Point[] points = new Point[4];

			points[0] = new Point((int)X, (int)(Y - HorDiagLen / 2));
			points[1] = new Point((int)(X + VertDiagLen / 2), (int)Y);
			points[2] = new Point((int)X, (int)(Y + HorDiagLen / 2));
			points[3] = new Point((int)(X - VertDiagLen / 2), (int)Y);

			Form1.ActiveForm.CreateGraphics().DrawPolygon(new Pen(Form1.ActiveForm.BackColor), points);
		}
	}
}
