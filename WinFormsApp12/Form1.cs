namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random r = new Random();
            for (int i = 0, coordinate = 0, j = 10, b = 15, h = 300, w = 10; i < 11; i++, j += 24, b += 22, h -= 12, w += 12)
            {
                coordinate = r.Next(10, 225);
                Pen blackPen = new Pen(Color.Red, 1);
                Pen pen = new Pen(Color.FromArgb(r.Next(0, 254), r.Next(0, 254), r.Next(0, 254)));
                e.Graphics.DrawEllipse(pen, r.Next(0, 700), r.Next(0, 300), coordinate, coordinate);

                e.Graphics.DrawLine(blackPen, 50, 250, 50, 75);
                e.Graphics.DrawLine(blackPen, 250, 250, 250, 75);
                e.Graphics.DrawEllipse(blackPen, 40, j, 140, 125);

                e.Graphics.DrawLine(blackPen, 309, 250, 405, 2);
                e.Graphics.DrawEllipse(blackPen, h, j, b, 400);
            }
        }
    }
}