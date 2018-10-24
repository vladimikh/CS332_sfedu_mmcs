using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affine_transforms_in_space
{
    class Point3D
    {
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D Copy()
        {
            return (Point3D)this.MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            Point3D otherPoint = obj as Point3D;
            if (otherPoint == null)
                return false;
            else
                return this.X == otherPoint.X 
                       && this.Y == otherPoint.Y
                       && this.Z == otherPoint.Z;
        }
    }
}
