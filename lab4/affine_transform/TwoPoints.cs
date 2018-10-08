using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace affine_transform
{
    class TwoPoints
    {
        public Point p1;
        public Point p2;

        public TwoPoints(Point _p1, Point _p2)
        {
            this.p1 = _p1;
            this.p2 = _p2;
        }
    }
}
