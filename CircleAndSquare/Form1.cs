using CircleAndSquare.Models;

namespace CircleAndSquare
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var circle = new Circle(50);
			await circle.MoveRightAsync();
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			var square = new Square(50);
			await square.MoveRightAsync();
		}

		private async void button3_Click(object sender, EventArgs e)
		{
			var rhomb = new Rhomb(50, 30);
			await rhomb.MoveRightAsync();
		}
	}
}