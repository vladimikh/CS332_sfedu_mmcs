﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezierCurve
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private List<Point> points;
        private Point p;
        private bool isCurveDrawn = false;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            points = new List<Point>();
            comboBox1.SelectedIndex = 0;
        }

        private void redrawPoints()
        {
            g.Clear(Color.White);
            SolidBrush b = new SolidBrush(Color.Red);
            for (int i = 0; i < points.Count; ++i)
                g.FillEllipse(b, points[i].X - 2, points[i].Y - 2, 5, 5);
            pictureBox1.Invalidate();
        }

        private void addPoint(Point p, int ind)
        {
            if (ind == -1)
                points.Add(p);
            else
                points.Insert(ind, p);
            SolidBrush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, p.X - 2, p.Y - 2, 5, 5);
            pictureBox1.Invalidate();
        }

        private int removePoint(Point p)
        {
            int ind = 0;
            while (ind < points.Count &&!(Math.Abs(points[ind].X - p.X) < 5 && Math.Abs(points[ind].Y - p.Y) < 5)){
                ++ind;
            }
            if (ind < points.Count)
            {
                points.RemoveAt(ind);
                redrawPoints();
            }
            else
                return -1;
            return ind;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                addPoint(e.Location, -1);
                if (isCurveDrawn)
                {
                    redrawPoints();
                    DrawCompositeBezier();
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                removePoint(e.Location);
                if (isCurveDrawn)
                {
                    redrawPoints();
                    DrawCompositeBezier();
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
                p = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedIndex == 2 && e.Location != p)
            {
                int ind = removePoint(p);
                if (ind != -1)
                    addPoint(e.Location, ind);
                if (isCurveDrawn)
                {
                    redrawPoints();
                    DrawCompositeBezier();
                }
            }
        }

        private void DrawBezier(Point p0, Point p1, Point p2)
        {
            Point p1_1 = new Point(p0.X + 2 * (p1.X - p0.X) / 3,
                                    p0.Y + 2 * (p1.Y - p0.Y) / 3);

            Point p1_2 = new Point(p1.X + (p2.X - p1.X) / 3,
                                p1.Y + (p2.Y - p1.Y) / 3);

            DrawBezier(p0, p1_1, p1_2, p2);

        }

        private void DrawBezier(Point p0, Point p1, Point p2, Point p3)
        {
            Point[] V = new Point[4] { p0, p1, p2, p3 };
            int[,] M = new int[4, 4] { { 1, -3, 3, -1 }, { 0, 3, -6, 3 }, { 0, 0, 3, -3 }, { 0, 0, 0, 1 } };
            float[] T = new float[4];

            Point[] VM = new Point[4] { new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0) };
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                {
                    VM[i].X += V[j].X * M[j, i];
                    VM[i].Y += V[j].Y * M[j, i];
                }

            for (float t = 0; t <= 1; t += (float)0.001)
            {
                T[0] = 1;
                T[1] = t;
                T[2] = t * t;
                T[3] = T[2] * t;
                PointF VMT = new PointF(0, 0);
                for (int i = 0; i < 4; ++i)
                {
                    VMT.X += VM[i].X * T[i];
                    VMT.Y += VM[i].Y * T[i];
                }
                (pictureBox1.Image as Bitmap).SetPixel((int)VMT.X, (int)VMT.Y, Color.Blue);
            }
            pictureBox1.Invalidate();
        }

        private void DrawCompositeBezier()
        {
            //points.Sort((x, y) => x.X - y.X);
            if (points.Count < 2)
                return;
            if (points.Count == 2)
            {
                Pen p = new Pen(Color.Black);
                g.DrawLine(p, points[0], points[1]);
                pictureBox1.Invalidate();
                return;
            }
            Point next, prev;
            prev = points[0];
            for (int i = 0; i < points.Count - 4; i += 2)
            {
                next = new Point((points[i + 2].X + points[i + 3].X) / 2, (points[i + 2].Y + points[i + 3].Y) / 2);
                DrawBezier(prev, points[i + 1], points[i + 2], next);
                prev = next;
            }
            if (points.Count % 2 == 0)
                DrawBezier(prev, points[points.Count - 3], points[points.Count - 2], points[points.Count - 1]);
            else
                DrawBezier(prev, points[points.Count - 2], points[points.Count - 1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawCompositeBezier();
            isCurveDrawn = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isCurveDrawn = false;
            points.Clear();
            g.Clear(Color.White);
            pictureBox1.Invalidate();
        }
    }
}
