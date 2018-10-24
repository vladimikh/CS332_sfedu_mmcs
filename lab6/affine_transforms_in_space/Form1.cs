using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace affine_transforms_in_space
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private int centerX, centerY;
        private Pen pen;
        private Polyhedron polyhedron;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            centerX = pictureBox1.Width / 2;
            centerY = pictureBox1.Height / 2;
            pen = new Pen(Color.Black);
            polyhedron = new Polyhedron();
        }

        private void drawFacet(Facet f)
        {
            foreach (Edge e in f.edges)
            {
                g.DrawLine(pen, (int)e.P1.X + centerX,
                    (int)e.P1.Y + centerY,
                    (int)e.P2.X + centerX,
                    (int)e.P2.Y + centerY);
            }

        }

        private void drawPolyhedron()
        {
            g.Clear(Color.White);
            foreach (Facet f in polyhedron.facets)
            {
                drawFacet(f);
            }
            pictureBox1.Invalidate();
        }


        private void initTetrahedron(int size)
        {
            double h = size * Math.Sqrt(3);

            Point3D p1 = new Point3D(-size, -h / 2, -h / 2);
            Point3D p2 = new Point3D(size, -h / 2, -h / 2);
            Point3D p3 = new Point3D(0, -h / 2, h / 2);
            Point3D p4 = new Point3D(0, h / 2, 0);

            Edge e1 = new Edge(p1, p2);
            Edge e2 = new Edge(p2, p3);
            Edge e3 = new Edge(p3, p1);
            Edge e4 = new Edge(p1, p4);
            Edge e5 = new Edge(p2, p4);
            Edge e6 = new Edge(p3, p4);

            Facet f1 = new Facet();
            f1.edges.Add(e1);
            f1.edges.Add(e2);
            f1.edges.Add(e3);

            Facet f2 = new Facet();
            f2.edges.Add(e1);
            f2.edges.Add(e4);
            f2.edges.Add(e5);

            Facet f3 = new Facet();
            f3.edges.Add(e2);
            f3.edges.Add(e5);
            f3.edges.Add(e6);

            Facet f4 = new Facet();
            f4.edges.Add(e3);
            f4.edges.Add(e4);
            f4.edges.Add(e6);

            polyhedron = new Polyhedron();
            polyhedron.facets.Add(f1);
            polyhedron.facets.Add(f2);
            polyhedron.facets.Add(f3);
            polyhedron.facets.Add(f4);
        }

        private void initHexahedron(int size)
        {
            Point3D p1 = new Point3D(-size / 2, -size / 2, -size / 2);
            Point3D p2 = new Point3D(size / 2, -size / 2, -size / 2);
            Point3D p3 = new Point3D(size / 2, -size / 2, size / 2);
            Point3D p4 = new Point3D(-size / 2, -size / 2, size / 2);
            Point3D p5 = new Point3D(-size / 2, size / 2, -size / 2);
            Point3D p6 = new Point3D(size / 2, size / 2, -size / 2);
            Point3D p7 = new Point3D(size / 2, size / 2, size / 2);
            Point3D p8 = new Point3D(-size / 2, size / 2, size / 2);

            Edge e1 = new Edge(p1, p2);
            Edge e2 = new Edge(p2, p3);
            Edge e3 = new Edge(p3, p4);
            Edge e4 = new Edge(p1, p4);
            Edge e5 = new Edge(p5, p6);
            Edge e6 = new Edge(p6, p7);
            Edge e7 = new Edge(p7, p8);
            Edge e8 = new Edge(p5, p8);
            Edge e9 = new Edge(p4, p8);
            Edge e10 = new Edge(p1, p5);
            Edge e11 = new Edge(p2, p6);
            Edge e12 = new Edge(p3, p7);

            Facet f1 = new Facet();
            f1.edges.Add(e1);
            f1.edges.Add(e2);
            f1.edges.Add(e3);
            f1.edges.Add(e4);

            Facet f2 = new Facet();
            f2.edges.Add(e5);
            f2.edges.Add(e6);
            f2.edges.Add(e7);
            f2.edges.Add(e8);

            Facet f3 = new Facet();
            f3.edges.Add(e4);
            f3.edges.Add(e10);
            f3.edges.Add(e8);
            f3.edges.Add(e9);

            Facet f4 = new Facet();
            f4.edges.Add(e10);
            f4.edges.Add(e1);
            f4.edges.Add(e11);
            f4.edges.Add(e5);

            Facet f5 = new Facet();
            f5.edges.Add(e6);
            f5.edges.Add(e11);
            f5.edges.Add(e2);
            f5.edges.Add(e12);

            Facet f6 = new Facet();
            f6.edges.Add(e7);
            f6.edges.Add(e12);
            f6.edges.Add(e3);
            f6.edges.Add(e9);

            polyhedron = new Polyhedron();
            polyhedron.facets.Add(f1);
            polyhedron.facets.Add(f2);
            polyhedron.facets.Add(f3);
            polyhedron.facets.Add(f4);
            polyhedron.facets.Add(f5);
            polyhedron.facets.Add(f6);
        }

        private void initOctahedron(int size)
        {
            Point3D p1 = new Point3D(-size / 2, 0, 0);
            Point3D p2 = new Point3D(0, 0, -size / 2);
            Point3D p3 = new Point3D(size / 2, 0, 0);
            Point3D p4 = new Point3D(0, 0, size / 2);
            Point3D p5 = new Point3D(0, size / 2, 0);
            Point3D p6 = new Point3D(0, -size / 2, 0);

            Edge e1 = new Edge(p1, p2);
            Edge e2 = new Edge(p2, p3);
            Edge e3 = new Edge(p3, p4);
            Edge e4 = new Edge(p1, p4);
            Edge e5 = new Edge(p1, p5);
            Edge e6 = new Edge(p2, p5);
            Edge e7 = new Edge(p3, p5);
            Edge e8 = new Edge(p4, p5);
            Edge e9 = new Edge(p1, p6);
            Edge e10 = new Edge(p2, p6);
            Edge e11 = new Edge(p3, p6);
            Edge e12 = new Edge(p4, p6);

            Facet f1 = new Facet();
            f1.edges.Add(e1);
            f1.edges.Add(e6);
            f1.edges.Add(e5);

            Facet f2 = new Facet();
            f2.edges.Add(e2);
            f2.edges.Add(e7);
            f2.edges.Add(e6);

            Facet f3 = new Facet();
            f3.edges.Add(e3);
            f3.edges.Add(e7);
            f3.edges.Add(e8);

            Facet f4 = new Facet();
            f4.edges.Add(e4);
            f4.edges.Add(e8);
            f4.edges.Add(e5);

            Facet f5 = new Facet();
            f5.edges.Add(e1);
            f5.edges.Add(e9);
            f5.edges.Add(e10);

            Facet f6 = new Facet();
            f6.edges.Add(e2);
            f6.edges.Add(e10);
            f6.edges.Add(e11);

            Facet f7 = new Facet();
            f7.edges.Add(e3);
            f7.edges.Add(e11);
            f7.edges.Add(e12);

            Facet f8 = new Facet();
            f1.edges.Add(e4);
            f1.edges.Add(e9);
            f1.edges.Add(e12);

            polyhedron = new Polyhedron();
            polyhedron.facets.Add(f1);
            polyhedron.facets.Add(f2);
            polyhedron.facets.Add(f3);
            polyhedron.facets.Add(f4);
            polyhedron.facets.Add(f5);
            polyhedron.facets.Add(f6);
            polyhedron.facets.Add(f7);
            polyhedron.facets.Add(f8);

        }

        private void initIcosahedron(int radius)
        {
            var magicAngle = Math.PI * 26.565f / 180;
            var segmentAngle = Math.PI * 72 / 180;
            var currentAngle = 0f;

            var v = new Point3D[12];
            v[0] = new Point3D(0, radius, 0);
            v[11] = new Point3D(0, -radius, 0);

            for (var i = 1; i < 6; i++)
            {
                v[i] = new Point3D(radius * Math.Sin(currentAngle) * Math.Cos(magicAngle),
                    radius * Math.Sin(magicAngle),
                    radius * Math.Cos(currentAngle) * Math.Cos(magicAngle));
                currentAngle += (float)segmentAngle;
            }
            currentAngle = (float)Math.PI * 36 / 180;
            for (var i = 6; i < 11; i++)
            {
                v[i] = new Point3D(radius * Math.Sin(currentAngle) * Math.Cos(-magicAngle),
                    radius * Math.Sin(-magicAngle),
                    radius * Math.Cos(currentAngle) * Math.Cos(-magicAngle));
                currentAngle += (float)segmentAngle;
            }

            Edge e1 = new Edge(v[0], v[1]);
            Edge e2 = new Edge(v[1], v[2]);
            Edge e3 = new Edge(v[0], v[2]);

            Edge e4 = new Edge(v[0], v[2]);
            Edge e5 = new Edge(v[2], v[3]);
            Edge e6 = new Edge(v[0], v[3]);

            Edge e7 = new Edge(v[0], v[3]);
            Edge e8 = new Edge(v[3], v[4]);
            Edge e9 = new Edge(v[0], v[4]);

            Edge e10 = new Edge(v[0], v[4]);
            Edge e11 = new Edge(v[4], v[5]);
            Edge e12 = new Edge(v[0], v[5]);

            Edge e13 = new Edge(v[0], v[5]);
            Edge e14 = new Edge(v[5], v[1]);
            Edge e15 = new Edge(v[0], v[1]);

            Edge e16 = new Edge(v[11], v[7]);
            Edge e17 = new Edge(v[7], v[6]);
            Edge e18 = new Edge(v[11], v[6]);

            Edge e19 = new Edge(v[11], v[8]);
            Edge e20 = new Edge(v[8], v[7]);
            Edge e21 = new Edge(v[11], v[7]);

            Edge e22 = new Edge(v[11], v[9]);
            Edge e23 = new Edge(v[9], v[8]);
            Edge e24 = new Edge(v[11], v[8]);

            Edge e25 = new Edge(v[11], v[10]);
            Edge e26 = new Edge(v[10], v[9]);
            Edge e27 = new Edge(v[11], v[9]);

            Edge e28 = new Edge(v[11], v[6]);
            Edge e29 = new Edge(v[6], v[10]);
            Edge e30 = new Edge(v[11], v[10]);

            Edge e31 = new Edge(v[2], v[1]);
            Edge e32 = new Edge(v[1], v[6]);
            Edge e33 = new Edge(v[2], v[6]);

            Edge e34 = new Edge(v[3], v[2]);
            Edge e35 = new Edge(v[2], v[7]);
            Edge e36 = new Edge(v[3], v[7]);

            Edge e37 = new Edge(v[4], v[3]);
            Edge e38 = new Edge(v[3], v[8]);
            Edge e39 = new Edge(v[4], v[8]);

            Edge e40 = new Edge(v[5], v[4]);
            Edge e41 = new Edge(v[4], v[9]);
            Edge e42 = new Edge(v[5], v[9]);

            Edge e43 = new Edge(v[1], v[5]);
            Edge e44 = new Edge(v[5], v[10]);
            Edge e45 = new Edge(v[1], v[10]);

            Edge e46 = new Edge(v[6], v[7]);
            Edge e47 = new Edge(v[7], v[2]);
            Edge e48 = new Edge(v[6], v[2]);

            Edge e49 = new Edge(v[7], v[8]);
            Edge e50 = new Edge(v[8], v[3]);
            Edge e51 = new Edge(v[7], v[3]);

            Edge e52 = new Edge(v[8], v[9]);
            Edge e53 = new Edge(v[9], v[4]);
            Edge e54 = new Edge(v[8], v[4]);

            Edge e55 = new Edge(v[9], v[10]);
            Edge e56 = new Edge(v[10], v[5]);
            Edge e57 = new Edge(v[9], v[5]);

            Edge e58 = new Edge(v[10], v[6]);
            Edge e59 = new Edge(v[6], v[1]);
            Edge e60 = new Edge(v[10], v[1]);

            Facet f1 = new Facet();
            f1.edges.Add(e1);
            f1.edges.Add(e2);
            f1.edges.Add(e3);

            Facet f2 = new Facet();
            f2.edges.Add(e4);
            f2.edges.Add(e5);
            f2.edges.Add(e6);

            Facet f3 = new Facet();
            f3.edges.Add(e7);
            f3.edges.Add(e8);
            f3.edges.Add(e9);

            Facet f4 = new Facet();
            f4.edges.Add(e10);
            f4.edges.Add(e11);
            f4.edges.Add(e12);

            Facet f5 = new Facet();
            f5.edges.Add(e13);
            f5.edges.Add(e14);
            f5.edges.Add(e15);

            Facet f6 = new Facet();
            f6.edges.Add(e16);
            f6.edges.Add(e17);
            f6.edges.Add(e18);

            Facet f7 = new Facet();
            f7.edges.Add(e19);
            f7.edges.Add(e20);
            f7.edges.Add(e21);

            Facet f8 = new Facet();
            f8.edges.Add(e22);
            f8.edges.Add(e23);
            f8.edges.Add(e24);

            Facet f9 = new Facet();
            f9.edges.Add(e25);
            f9.edges.Add(e26);
            f9.edges.Add(e27);

            Facet f10 = new Facet();
            f10.edges.Add(e28);
            f10.edges.Add(e29);
            f10.edges.Add(e30);

            Facet f11 = new Facet();
            f11.edges.Add(e31);
            f11.edges.Add(e32);
            f11.edges.Add(e33);

            Facet f12 = new Facet();
            f12.edges.Add(e34);
            f12.edges.Add(e35);
            f12.edges.Add(e36);

            Facet f13 = new Facet();
            f13.edges.Add(e37);
            f13.edges.Add(e38);
            f13.edges.Add(e39);

            Facet f14 = new Facet();
            f14.edges.Add(e40);
            f14.edges.Add(e41);
            f14.edges.Add(e42);

            Facet f15 = new Facet();
            f15.edges.Add(e43);
            f15.edges.Add(e44);
            f15.edges.Add(e45);

            Facet f16 = new Facet();
            f16.edges.Add(e46);
            f16.edges.Add(e47);
            f16.edges.Add(e48);

            Facet f17 = new Facet();
            f17.edges.Add(e49);
            f17.edges.Add(e50);
            f17.edges.Add(e51);

            Facet f18 = new Facet();
            f18.edges.Add(e52);
            f18.edges.Add(e53);
            f18.edges.Add(e54);

            Facet f19 = new Facet();
            f19.edges.Add(e55);
            f19.edges.Add(e56);
            f19.edges.Add(e57);

            Facet f20 = new Facet();
            f20.edges.Add(e58);
            f20.edges.Add(e59);
            f20.edges.Add(e60);

            polyhedron = new Polyhedron();
            polyhedron.facets.Add(f1);
            polyhedron.facets.Add(f2);
            polyhedron.facets.Add(f3);
            polyhedron.facets.Add(f4);
            polyhedron.facets.Add(f5);
            polyhedron.facets.Add(f6);
            polyhedron.facets.Add(f7);
            polyhedron.facets.Add(f8);
            polyhedron.facets.Add(f9);
            polyhedron.facets.Add(f10);
            polyhedron.facets.Add(f11);
            polyhedron.facets.Add(f12);
            polyhedron.facets.Add(f13);
            polyhedron.facets.Add(f14);
            polyhedron.facets.Add(f15);
            polyhedron.facets.Add(f16);
            polyhedron.facets.Add(f17);
            polyhedron.facets.Add(f18);
            polyhedron.facets.Add(f19);
            polyhedron.facets.Add(f20);
        }

        private void initDodecahedron(int size)
        {
            double s = size;
            //double t1 = 2.0 * Math.PI / 5.0;
            double t2 = Math.PI / 10.0;
            double t3 = 3.0 * Math.PI / 10.0;
            double t4 = Math.PI / 5.0;
            double d1 = s / 2.0 / Math.Sin(t4);
            double d2 = d1 * Math.Cos(t4);
            double d3 = d1 * Math.Cos(t2);
            double d4 = d1 * Math.Sin(t2);
            double Fx =
                (s * s - (2.0 * d3) * (2.0 * d3) -
                    (d1 * d1 - d3 * d3 - d4 * d4)) /
                        (2.0 * (d4 - d1));
            double d5 = Math.Sqrt(0.5 *
                (s * s + (2.0 * d3) * (2.0 * d3) -
                    (d1 - Fx) * (d1 - Fx) -
                        (d4 - Fx) * (d4 - Fx) - d3 * d3));
            double Fy = (Fx * Fx - d1 * d1 - d5 * d5) / (2.0 * d5);
            double Ay = d5 + Fy;

            Point3D A = new Point3D(d1, Ay, 0);
            Point3D B = new Point3D(d4, Ay, d3);
            Point3D C = new Point3D(-d2, Ay, s / 2);
            Point3D D = new Point3D(-d2, Ay, -s / 2);
            Point3D E = new Point3D(d4, Ay, -d3);
            Point3D F = new Point3D(Fx, Fy, 0);
            Point3D G = new Point3D(Fx * Math.Sin(t2), Fy,
                Fx * Math.Cos(t2));
            Point3D H = new Point3D(-Fx * Math.Sin(t3), Fy,
                Fx * Math.Cos(t3));
            Point3D I = new Point3D(-Fx * Math.Sin(t3), Fy,
                -Fx * Math.Cos(t3));
            Point3D J = new Point3D(Fx * Math.Sin(t2), Fy,
                -Fx * Math.Cos(t2));
            Point3D K = new Point3D(Fx * Math.Sin(t3), -Fy,
                Fx * Math.Cos(t3));
            Point3D L = new Point3D(-Fx * Math.Sin(t2), -Fy,
                Fx * Math.Cos(t2));
            Point3D M = new Point3D(-Fx, -Fy, 0);
            Point3D N = new Point3D(-Fx * Math.Sin(t2), -Fy,
                -Fx * Math.Cos(t2));
            Point3D O = new Point3D(Fx * Math.Sin(t3), -Fy,
                -Fx * Math.Cos(t3));
            Point3D P = new Point3D(d2, -Ay, s / 2);
            Point3D Q = new Point3D(-d4, -Ay, d3);
            Point3D R = new Point3D(-d1, -Ay, 0);
            Point3D S = new Point3D(-d4, -Ay, -d3);
            Point3D T = new Point3D(d2, -Ay, -s / 2);

            Edge e1 = new Edge(A, B);
            Edge e2 = new Edge(B, C);
            Edge e3 = new Edge(C, D);
            Edge e4 = new Edge(D, E);
            Edge e5 = new Edge(A, E);

            Edge e6 = new Edge(E, J);
            Edge e7 = new Edge(J, O);
            Edge e8 = new Edge(O, F);
            Edge e9 = new Edge(A, F);

            Edge e10 = new Edge(F, K);
            Edge e11 = new Edge(K, G);
            Edge e12 = new Edge(G, B);

            Edge e13 = new Edge(G, L);
            Edge e14 = new Edge(L, H);
            Edge e15 = new Edge(H, C);

            Edge e16 = new Edge(H, M);
            Edge e17 = new Edge(M, I);
            Edge e18 = new Edge(D, I);

            Edge e19 = new Edge(I, N);
            Edge e20 = new Edge(N, J);

            Edge e22 = new Edge(G, L);
            Edge e23 = new Edge(L, H);
            Edge e24 = new Edge(H, C);

            Edge e25 = new Edge(N, S);
            Edge e26 = new Edge(S, T);
            Edge e27 = new Edge(T, O);

            Edge e28 = new Edge(T, P);
            Edge e29 = new Edge(P, K);

            Edge e30 = new Edge(P, Q);
            Edge e31 = new Edge(Q, L);

            Edge e32 = new Edge(Q, R);
            Edge e33 = new Edge(R, M);

            Edge e34 = new Edge(R, S);

            Facet f1 = new Facet();
            f1.edges.Add(e5);
            f1.edges.Add(e1);
            f1.edges.Add(e2);
            f1.edges.Add(e3);
            f1.edges.Add(e4);

            Facet f2 = new Facet();
            f2.edges.Add(e1);
            f2.edges.Add(e9);
            f2.edges.Add(e10);
            f2.edges.Add(e11);
            f2.edges.Add(e12);

            Facet f3 = new Facet();
            f3.edges.Add(e2);
            f3.edges.Add(e12);
            f3.edges.Add(e13);
            f3.edges.Add(e23);
            f3.edges.Add(e24);

            Facet f4 = new Facet();
            f4.edges.Add(e24);
            f4.edges.Add(e16);
            f4.edges.Add(e17);
            f4.edges.Add(e18);
            f4.edges.Add(e3);

            Facet f5 = new Facet();
            f5.edges.Add(e4);
            f5.edges.Add(e18);
            f5.edges.Add(e19);
            f5.edges.Add(e20);
            f5.edges.Add(e6);

            Facet f6 = new Facet();
            f6.edges.Add(e5);
            f6.edges.Add(e6);
            f6.edges.Add(e7);
            f6.edges.Add(e8);
            f6.edges.Add(e9);

            Facet f7 = new Facet();
            f7.edges.Add(e28);
            f7.edges.Add(e27);
            f7.edges.Add(e8);
            f7.edges.Add(e10);
            f7.edges.Add(e29);

            Facet f8 = new Facet();
            f8.edges.Add(e29);
            f8.edges.Add(e11);
            f8.edges.Add(e13);
            f8.edges.Add(e31);
            f8.edges.Add(e30);

            Facet f9 = new Facet();
            f9.edges.Add(e32);
            f9.edges.Add(e31);
            f9.edges.Add(e23);
            f9.edges.Add(e16);
            f9.edges.Add(e33);

            Facet f10 = new Facet();
            f10.edges.Add(e34);
            f10.edges.Add(e33);
            f10.edges.Add(e17);
            f10.edges.Add(e19);
            f10.edges.Add(e25);

            Facet f11 = new Facet();
            f11.edges.Add(e26);
            f11.edges.Add(e25);
            f11.edges.Add(e20);
            f11.edges.Add(e7);
            f11.edges.Add(e27);

            Facet f12 = new Facet();
            f12.edges.Add(e28);
            f12.edges.Add(e30);
            f12.edges.Add(e32);
            f12.edges.Add(e34);
            f12.edges.Add(e26);

            polyhedron = new Polyhedron();
            polyhedron.facets.Add(f1);
            polyhedron.facets.Add(f2);
            polyhedron.facets.Add(f3);
            polyhedron.facets.Add(f4);
            polyhedron.facets.Add(f5);
            polyhedron.facets.Add(f6);
            polyhedron.facets.Add(f7);
            polyhedron.facets.Add(f8);
            polyhedron.facets.Add(f9);
            polyhedron.facets.Add(f10);
            polyhedron.facets.Add(f11);
            polyhedron.facets.Add(f12);

        }

        private void phComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            polyhedron = new Polyhedron();
            if (phComboBox.SelectedItem.ToString() == "Tetrahedron")
                initTetrahedron(150);
            else if (phComboBox.SelectedItem.ToString() == "Hexahedron")
                initHexahedron(250);
            else if (phComboBox.SelectedItem.ToString() == "Octahedron")
                initOctahedron(300);
            else if (phComboBox.SelectedItem.ToString() == "Icosahedron")
                initIcosahedron(200);
            else if (phComboBox.SelectedItem.ToString() == "Dodecahedron")
                initDodecahedron(150);

            drawPolyhedron();
        }

        private void translate(int tx, int ty, int tz)
        {
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge e in f.edges)
                {
                    e.P1.X += tx;
                    e.P1.Y += ty;
                    e.P1.Z += tz;
                    e.P2.X += tx;
                    e.P2.Y += ty;
                    e.P2.Z += tz;

                }
            }
        }

        private void rotateOX(Edge e, double angle)
        {
            double y1 = e.P1.Y;
            double z1 = e.P1.Z;
            double y2 = e.P2.Y;
            double z2 = e.P2.Z;

            e.P1.Y = y1 * Math.Cos(angle) - z1 * Math.Sin(angle);
            e.P1.Z = y1 * Math.Sin(angle) + z1 * Math.Cos(angle);

            e.P2.Y = y2 * Math.Cos(angle) - z2 * Math.Sin(angle);
            e.P2.Z = y2 * Math.Sin(angle) + z2 * Math.Cos(angle);
        }

        private void rotateOY(Edge e, double angle)
        {
            double x1 = e.P1.X;
            double z1 = e.P1.Z;
            double x2 = e.P2.X;
            double z2 = e.P2.Z;

            e.P1.X = x1 * Math.Cos(angle) + z1 * Math.Sin(angle);
            e.P1.Z = -x1 * Math.Sin(angle) + z1 * Math.Cos(angle);

            e.P2.X = x2 * Math.Cos(angle) + z2 * Math.Sin(angle);
            e.P2.Z = -x2 * Math.Sin(angle) + z2 * Math.Cos(angle);
        }

        private void rotateOZ(Edge e, double angle)
        {
            double x1 = e.P1.X;
            double y1 = e.P1.Y;
            double x2 = e.P2.X;
            double y2 = e.P2.Y;

            e.P1.X = x1 * Math.Cos(angle) - y1 * Math.Sin(angle);
            e.P1.Y = x1 * Math.Sin(angle) + y1 * Math.Cos(angle);

            e.P2.X = x2 * Math.Cos(angle) - y2 * Math.Sin(angle);
            e.P2.Y = x2 * Math.Sin(angle) + y2 * Math.Cos(angle);
        }

        private void rotate(double angleX, double angleY, double angleZ)
        {
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge edge in f.edges)
                {
                    rotateOX(edge, angleX);
                    rotateOY(edge, angleY);
                    rotateOZ(edge, angleZ);
                }
            }
        }


        private void scale(double mx, double my, double mz)
        {
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge e in f.edges)
                {
                    e.P1.X *= mx;
                    e.P1.Y *= my;
                    e.P1.Z *= mz;
                    e.P2.X *= mx;
                    e.P2.Y *= my;
                    e.P2.Z *= mz;

                }
            }
        }

        private void reflectByYoZ()
        {
            for (int i = 0; i < polyhedron.facets.Count; ++i)
            {
                for (int j = 0; j < polyhedron.facets[i].edges.Count; ++j)
                {
                    Point3D p1 = polyhedron.facets[i].edges[j].P1.Copy();
                    Point3D p2 = polyhedron.facets[i].edges[j].P2.Copy();
                    p1.X = -p1.X;
                    p2.X = -p2.X;

                    polyhedron.facets[i].edges[j] = new Edge(p1, p2);
                }
            }
        }

        private void reflectByZoX()
        {
            for (int i = 0; i < polyhedron.facets.Count; ++i)
            {
                for (int j = 0; j < polyhedron.facets[i].edges.Count; ++j)
                {
                    Point3D p1 = polyhedron.facets[i].edges[j].P1.Copy();
                    Point3D p2 = polyhedron.facets[i].edges[j].P2.Copy();
                    p1.Y = -p1.Y;
                    p2.Y = -p2.Y;

                    polyhedron.facets[i].edges[j] = new Edge(p1, p2);
                }
            }
        }

        private void reflectByXoY()
        {
            for (int i = 0; i < polyhedron.facets.Count; ++i)
            {
                for (int j = 0; j < polyhedron.facets[i].edges.Count; ++j)
                {
                    Point3D p1 = polyhedron.facets[i].edges[j].P1.Copy();
                    Point3D p2 = polyhedron.facets[i].edges[j].P2.Copy();
                    p1.Z = -p1.Z;
                    p2.Z = -p2.Z;

                    polyhedron.facets[i].edges[j] = new Edge(p1, p2);
                }
            }
        }

        private void orthographicYoZ()
        {

        }

        private void orthographicZoX()
        {

        }

        private void orthographicXoY()
        {

        }

        private void applyTransBtn_Click(object sender, EventArgs e)
        {
            int tx = (int)transXNUD.Value;
            int ty = (int)transYNUD.Value;
            int tz = (int)transZNUD.Value;

            translate(tx, ty, tz);
            drawPolyhedron();
        }

        private void applyRotBtn_Click(object sender, EventArgs e)
        {
            double angleX = ((double)rotXNUD.Value * Math.PI) / 180;
            double angleY = ((double)rotYNUD.Value * Math.PI) / 180;
            double angleZ = ((double)rotZNUD.Value * Math.PI) / 180;

            rotate(angleX, angleY, angleZ);
            drawPolyhedron();
        }

        private void reflectByYoZBtn_Click(object sender, EventArgs e)
        {
            reflectByYoZ();
            drawPolyhedron();
        }

        private void reflectByZoXBtn_Click(object sender, EventArgs e)
        {
            reflectByZoX();
            drawPolyhedron();
        }

        private void reflectByXoYBtn_Click(object sender, EventArgs e)
        {
            reflectByXoY();
            drawPolyhedron();
        }


        private void applyScaleBtn_Click(object sender, EventArgs e)
        {
            double mx = (double)scaleXNUD.Value;
            double my = (double)scaleYNUD.Value;
            double mz = (double)scaleZNUD.Value;

            scale(mx, my, mz);
            drawPolyhedron();
        }


        private void applyRotationAroundBtn_Click(object sender, EventArgs e)
        {
            double x1 = (double)rotAroundX1NUD.Value;
            double y1 = (double)rotAroundY1NUD.Value;
            double z1 = (double)rotAroundZ1NUD.Value;
            double x2 = (double)rotAroundX2NUD.Value;
            double y2 = (double)rotAroundY2NUD.Value;
            double z2 = (double)rotAroundZ2NUD.Value;

            double angle = ((double)rotAroundAngleNUD.Value * Math.PI) / 180;


            double x = Math.Abs(x1 - x2);
            double y = Math.Abs(y1 - y2);
            double z = Math.Abs(z1 - z2);
            double absVec = Math.Sqrt(x * x + y * y + z * z);

            double l = x / absVec;
            double m = y / absVec;
            double n = z / absVec;

            double d = Math.Sqrt(m * m + n * n);
            double psi = -Math.Asin(m / d);
            double teta = Math.Asin(l);
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge edge in f.edges)
                {
                    edge.P1.X -= x1;
                    edge.P2.X -= x1;
                    edge.P1.Y -= y1;
                    edge.P2.Y -= y1;
                    edge.P1.Z -= z1;
                    edge.P2.Z -= z1;

                    rotateOX(edge, psi);
                    rotateOY(edge, teta);
                    rotateOZ(edge, angle);
                    rotateOY(edge, -teta);
                    rotateOX(edge, -psi);

                    edge.P1.X += x1;
                    edge.P2.X += x1;
                    edge.P1.Y += y1;
                    edge.P2.Y += y1;
                    edge.P1.Z += z1;
                    edge.P2.Z += z1;

                }
            }

            drawPolyhedron();

        }

        private void perspectiveProjBtn_Click(object sender, EventArgs e)
        {
            double focus = (double)perspectiveProjNUD.Value;
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge edge in f.edges)
                {
                    edge.P1.X = edge.P1.X * focus / edge.P1.Z;
                    edge.P1.Y = edge.P1.Y * focus / edge.P1.Z;
                    edge.P1.Z = focus;
                    edge.P2.X = edge.P2.X * focus / edge.P2.Z;
                    edge.P2.Y = edge.P2.Y * focus / edge.P2.Z;
                    edge.P2.Z = focus;
                }
            }
            drawPolyhedron();
        }

        private void orthographicCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*
            switch (orthographicCB.SelectedItem.ToString())
            {
                case "YoZ":
                    orthographicYoZ();
                    break;
                case "ZoX":
                    orthographicZoX();
                    break;
                case "XoY":
                    orthographicXoY();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            */
        }

        private void orthographicProjBtn_Click(object sender, EventArgs e)
        {
            switch (orthographicCB.SelectedItem.ToString())
            {
                case "YoZ":
                    orthographicYoZ();
                    break;
                case "ZoX":
                    orthographicZoX();
                    break;
                case "XoY":
                    orthographicXoY();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
