using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diamondSquare
{
    public partial class Form1 : Form
    {
        Bitmap image;
        int R;
        Point p1, p2;
        Random rand = new Random();
        List<int> yCoordinates;
        private Graphics g;
        Brush brush = (Brush)Brushes.Black;
        Pen pen = Pens.BlueViolet;
        int pbWidth, pbHeight;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pbWidth = pictureBox1.Width;
            pbHeight = pictureBox1.Height;
            p1 = new Point();
            p2 = new Point();
            p1.X = 0;
            p2.X = pbWidth;
            p1.Y = pbHeight/2;
            p2.Y = pbHeight/2;
            yCoordinates = new List<int>(pbWidth);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter =
                "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(openDialog.FileName);
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void roughnessTb_TextChanged(object sender, EventArgs e)
        {
            //проверка
        }

        private void roughnessBtn_Click(object sender, EventArgs e)
        {
            if (roughnessTb.Text == null)
                return;
            R = Convert.ToInt32(roughnessTb.Text);
        }

        private void x1HeightTb_TextChanged(object sender, EventArgs e)
        {
            if (x1HeightTb.Text != "" && x1HeightTb.Text != "-")
                p1.Y += Convert.ToInt32(x1HeightTb.Text);
            
        }

        private void x2HeightTb_TextChanged(object sender, EventArgs e)
        {
            if (x2HeightTb.Text != "" && x2HeightTb.Text != "-")
                p2.Y += Convert.ToInt32(x2HeightTb.Text);
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            yCoordinates.Add(p1.Y);
            yCoordinates.Add(p2.Y);
            generate(p1, p2);
            for (int i = 0; i < yCoordinates.Count-1; ++i)
            {
                g.DrawLine(pen, i, yCoordinates[i], i + 1, yCoordinates[i + 1]);
                pictureBox1.Invalidate();
            }
        }

        private void generate(Point a, Point b)
        {
            if (a.X == b.X - 1)
                return;
            int i = b.X - a.X;
            Point p = new Point();
            p.Y = Convert.ToInt32((a.Y + b.Y) / 2 * rand.Next(-R * i, R * i)) % (pbHeight / 2);
            p.X = (b.X + a.X) / 2;
            int insertTo = yCoordinates.IndexOf(b.Y);
            yCoordinates.Insert(insertTo, p.Y);
            generate(a, p);
            generate(p, b);
        }
    }
}
