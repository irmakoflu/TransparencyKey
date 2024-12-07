namespace transparancykey
{
    using System.Drawing;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TransparencyKey=Color.Pink;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
             SolidBrush solidBrush = new SolidBrush(Color.Pink);
            graphics.FillEllipse(solidBrush, new Rectangle(this.Width / 2, this.Height - 200, this.Width, 200));

        }
    }
}
