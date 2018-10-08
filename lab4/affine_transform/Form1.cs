using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace affine_transform
{

    public partial class Form1 : Form
    {

        private Graphics g;
        private Point startPoint, endPoint = Point.Empty;
        private Point[] edge = new Point[2];
        private Point[] polygon = new Point[0];
        private Pen penColor = Pens.BlueViolet;
        private PointF clickedPosition = new PointF(0, 0);
        private Point minPolyCoordinates, maxPolyCoordinates;
        private Point minEdgeCoordinates, maxEdgeCoordinates;

        //private int edgeLen = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            minEdgeCoordinates = new Point(9999999, 9999999);
            maxEdgeCoordinates = new Point(-1, -1);
            chosenPointTb.Text = string.Format("X: {0} Y: {1}", clickedPosition.X, clickedPosition.Y);
        }

        //INTERFACE

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lineChk.Checked)
                {
                    startPoint = e.Location;
                }
                else if (polyChk.Checked && polygon.Length == 0)
                {
                    startPoint = e.Location;
                    minPolyCoordinates = e.Location;
                    maxPolyCoordinates = e.Location;
                    Array.Resize(ref polygon, 1);
                    polygon[polygon.Length - 1] = startPoint;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lineChk.Checked)
                {
                    endPoint = e.Location;
                    pictureBox1.Invalidate();
                }
                else if (polyChk.Checked)
                {
                    endPoint = e.Location;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lineChk.Checked)
                {
                    edge[edge.Length - 2] = new Point(startPoint.X, startPoint.Y);
                    edge[edge.Length - 1] = new Point(endPoint.X, endPoint.Y);
                    Array.Resize(ref edge, edge.Length + 2);

                    if (endPoint.X < minEdgeCoordinates.X)
                        minEdgeCoordinates.X = endPoint.X;
                    if (endPoint.Y < minEdgeCoordinates.Y)
                        minEdgeCoordinates.Y = endPoint.Y;
                    if (endPoint.X > maxEdgeCoordinates.X)
                        maxEdgeCoordinates.X = endPoint.X;
                    if (endPoint.Y > maxEdgeCoordinates.Y)
                        maxEdgeCoordinates.Y = endPoint.Y;

                    if (startPoint.X < minEdgeCoordinates.X)
                        minEdgeCoordinates.X = startPoint.X;
                    if (startPoint.Y < minEdgeCoordinates.Y)
                        minEdgeCoordinates.Y = startPoint.Y;
                    if (startPoint.X > maxEdgeCoordinates.X)
                        maxEdgeCoordinates.X = startPoint.X;
                    if (startPoint.Y > maxEdgeCoordinates.Y)
                        maxEdgeCoordinates.Y = startPoint.Y;
                }
                else if (polyChk.Checked)
                {
                    Array.Resize(ref polygon, polygon.Length + 1);
                    polygon[polygon.Length - 1] = endPoint;
                    if (endPoint.X < minPolyCoordinates.X)
                        minPolyCoordinates.X = endPoint.X;
                    if (endPoint.Y < minPolyCoordinates.Y)
                        minPolyCoordinates.Y = endPoint.Y;
                    if (endPoint.X > maxPolyCoordinates.X)
                        maxPolyCoordinates.X = endPoint.X;
                    if (endPoint.Y > maxPolyCoordinates.Y)
                        maxPolyCoordinates.Y = endPoint.Y;
                    startPoint = endPoint;
                }
            }
            else
            {
                clickedPosition.X = e.Location.X;
                clickedPosition.Y = e.Location.Y;
                chosenPointTb.Text = string.Format("X: {0} Y: {1}", e.Location.X, e.Location.Y);
            }


            pictureBox1.Invalidate();
        }

        private void refresh_labels()
        {
            if (polygon.Length > 2)
            {
                bool res = isInside(polygon, clickedPosition);
                if (isInside(polygon, clickedPosition))
                {
                    label11.Text = "Принадлежит многоугольнику";
                }
                else
                {
                    label11.Text = "Не принадлежит многоугольнику";
                }
            }
            else
            {
                label11.Text = "";
            }

            if (edge.Length > 3)
            {
                int n = edge.Length - 3;
                int pos = findWhereThePointIs(clickedPosition, edge[n - 1], edge[n]);
                if (pos == 0)
                    label13.Text = "Лежит на линии";
                else
                    if (pos > 0)
                    label13.Text = "Лежит слева от линии";
                else
                    label13.Text = "Лежит справа от линии";
            }
            else
            {
                label13.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Invalidate();
            Array.Clear(edge, 0, edge.Length);
            Array.Clear(polygon, 0, polygon.Length);
            Array.Resize(ref edge, 2);
            Array.Resize(ref polygon, 0);
            startPoint = endPoint = Point.Empty;
            minEdgeCoordinates = new Point(9999999, 9999999);
            maxEdgeCoordinates = new Point(-1, -1);
        }

        private void lineChk_CheckedChanged(object sender, EventArgs e)
        {
            if (lineChk.Checked)
            {
                polyChk.Checked = false;

            }
        }

        private void polyChk_CheckedChanged(object sender, EventArgs e)
        {
            if (polyChk.Checked)
            {
                lineChk.Checked = false;

            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            float x = 0;
            float y = 0;
            float angle = 0;
            float scaleX = 0;
            float scaleY = 0;

            x = (float)numericUpDown1.Value;
            y = (float)numericUpDown2.Value;
            scaleX = (float)numericUpDown3.Value / 100;
            scaleY = (float)numericUpDown4.Value / 100;
            angle = (float)numericUpDown5.Value;

            Matrix matr = new Matrix();

            PointF rotationPoint;

            if (lineChk.Checked)
            {
                rotationPoint = rotateAroundPointCb.Checked ? new PointF(clickedPosition.X, clickedPosition.Y) : new PointF((edge[0].X + edge[1].X) / 2, (edge[0].Y + edge[1].Y) / 2);
                matr.RotateAt(angle, rotationPoint, MatrixOrder.Append);
                matr.Translate(x, y, MatrixOrder.Append);
                matr.TransformPoints(edge);

                PointF TransformVector = new PointF((edge[0].X + edge[1].X) / 2, (edge[0].Y + edge[1].Y) / 2);

                matr = new Matrix();
                matr.Translate(-1 * TransformVector.X, -1 * TransformVector.Y, MatrixOrder.Append);
                //matr.TransformPoints(edge);

                //matr = new Matrix();
                matr.Scale(scaleX, scaleY, MatrixOrder.Append);
                //matr.TransformPoints(edge);

                //matr = new Matrix();
                matr.Translate(TransformVector.X, TransformVector.Y, MatrixOrder.Append);
                matr.TransformPoints(edge);
            }
            else if (polyChk.Checked)
            {
                rotationPoint = rotateAroundPointCb.Checked ? new PointF(clickedPosition.X, clickedPosition.Y) : new PointF((minPolyCoordinates.X + maxPolyCoordinates.X) / 2, (minPolyCoordinates.Y + maxPolyCoordinates.Y) / 2);
                matr.RotateAt(angle, rotationPoint, MatrixOrder.Append);
                matr.Translate(x, y, MatrixOrder.Append);
                matr.TransformPoints(polygon);

                PointF TransformVector = new PointF(minPolyCoordinates.X + (maxPolyCoordinates.X - minPolyCoordinates.X) / 2, minPolyCoordinates.Y + (maxPolyCoordinates.Y - minPolyCoordinates.Y) / 2);

                matr = new Matrix();
                matr.Translate(-1 * TransformVector.X, -1 * TransformVector.Y);
                matr.TransformPoints(polygon);

                matr = new Matrix();
                matr.Scale(scaleX, scaleY);
                matr.TransformPoints(polygon);

                matr = new Matrix();
                matr.Translate(TransformVector.X, TransformVector.Y);
                matr.TransformPoints(polygon);

            }

            startPoint = endPoint = Point.Empty;

            pictureBox1.Invalidate();

        }

        private void ninetyDegBtn_Click(object sender, EventArgs e)
        {
            numericUpDown5.Value = 90;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < edge.Length; i += 2)
            {
                e.Graphics.DrawLine(penColor, edge[i], edge[i + 1]);
            }

            if (polygon.Length > 1)
                e.Graphics.DrawPolygon(penColor, polygon);

            e.Graphics.DrawLine(penColor, startPoint, endPoint);
            e.Graphics.DrawEllipse(Pens.Red, clickedPosition.X-1, clickedPosition.Y-1, 3, 3);

            refresh_labels();
        }

        private void intersectionBtn_Click(object sender, EventArgs e)
        {
            PointF intersection;

            if (edge.Length > 4)
            {
                int n = edge.Length - 3;
                intersection = findIntersection(edge[n - 3], edge[n - 2], edge[n - 1], edge[n]);
            }
            else
            {
                intersection = new PointF(-1, -1);
            }

            if (intersection.X == -1 && intersection.Y == -1)
            {
                intersectionTb.Text = "Не найдено";
            }
            else
            {
                intersectionTb.Text = string.Format("X: {0:N2} Y: {1:N2}", intersection.X, intersection.Y);
                g.DrawEllipse(Pens.Green, intersection.X - 2, intersection.Y - 2, 5, 5);
                pictureBox1.Invalidate();
            }


        }



        // ALGORITHMS

        bool onSegment(PointF q, PointF p, PointF r)
        {
            if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                    q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
                return true;
            return false;
        }

        // 0 --> p, q and r are colinear
        // 1 --> Clockwise
        // 2 --> Counterclockwise
        int orientation(PointF p, PointF q, PointF r)
        {
            float val = (q.Y - p.Y) * (r.X - q.X) -
                      (q.X - p.X) * (r.Y - q.Y);

            if (val == 0) return 0;  // colinear
            return (val > 0) ? 1 : 2; // clock or counterclock wise
        }

        bool isInside(Point[] polygon, PointF p)
        {
            int n = polygon.Length;
            if (n < 3) return false;

            PointF extreme = new PointF(pictureBox1.Width, p.Y);

            int count = 0, i = 0;
            do
            {
                int next = (i + 1) % n;
                PointF intersection = findIntersection(polygon[i], polygon[next], p, extreme);
                if (intersection.X != -1)
                {
                    // If the point 'p' is colinear with line segment 'i-next',
                    // then check if it lies on segment. If it lies, return true,
                    // otherwise false
                    if (orientation(polygon[i], p, polygon[next]) == 0)
                        return onSegment(polygon[i], p, polygon[next]);

                    count++;
                }
                i = next;
            } while (i != 0);

            // Return true if count is odd, false otherwise
            return count % 2 == 1;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown2.Value = numericUpDown5.Value = 0;
            numericUpDown3.Value = numericUpDown4.Value = 100;
        }

        PointF findIntersection(PointF p0, PointF p1, PointF p2, PointF p3)
        {
            PointF i = new PointF(-1, -1);
            PointF s1 = new PointF();
            PointF s2 = new PointF();
            s1.X = p1.X - p0.X;
            s1.Y = p1.Y - p0.Y;
            s2.X = p3.X - p2.X;
            s2.Y = p3.Y - p2.Y;
            float s, t;
            s = (-s1.Y * (p0.X - p2.X) + s1.X * (p0.Y - p2.Y)) / (-s2.X * s1.Y + s1.X * s2.Y);
            t = (s2.X * (p0.Y - p2.Y) - s2.Y * (p0.X - p2.X)) / (-s2.X * s1.Y + s1.X * s2.Y);

            if (s >= 0 && s <= 1 && t >= 0 && t <= 1)
            {
                i.X = p0.X + (t * s1.X);
                i.Y = p0.Y + (t * s1.Y);

            }
            return i;
        }

    //0 - belongs to the line, > 0 - left side, < 0 - right side
    int findWhereThePointIs(PointF p, Point A, Point B)
        {
            float result = (B.X - A.X) * (p.Y - B.Y) - (B.Y - A.Y) * (p.X - B.X);
            return (int)result;
        }
    }

}
