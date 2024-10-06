using AbstractFabryc.Fabrick;
namespace AbstractFabryc
{
    public partial class Form1 : Form
    {
        FigureFactory factory = new FigureFactory();
        public Form1() => InitializeComponent();
        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            string color = GetColor();
            var figure = factory.CreateFigure(color, ComboColorBox.Text);
            figure.Draw(this.CreateGraphics(), new Point(300 + (int)NumericX.Value, 100 + (int)NumericY.Value));
        }

        private string GetColor()
        {
            if (RedRadBut.Checked) return "красный";
            return "зеленый";
        }
    }
}
