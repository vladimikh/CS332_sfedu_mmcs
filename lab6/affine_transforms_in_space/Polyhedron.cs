using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affine_transforms_in_space
{
    class Polyhedron
    {
        public List<Facet> facets;

        public Polyhedron()
        {
            facets = new List<Facet>();
        }
    }
}
