using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affine_transforms_in_space
{
    class Edge
    { 
        public Edge(Point3D p1, Point3D p2)
        {
            this.P1 = p1.Copy();
            this.P2 = p2.Copy();
        }

        public Point3D P1 { get; set; }

        public Point3D P2 { get; set; }


        public Point3D Copy()
        {
            return (Point3D)this.MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            Edge otherEdge = obj as Edge;
            if (otherEdge == null)
                return false;
            else
                return this.P1 == otherEdge.P1 && this.P2 == otherEdge.P2;
        }
    }
}
