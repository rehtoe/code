using accessor;
using accessor.assets;
using accessor.assets.enhancedObjects;
using accessor.assets.enhancedObjects.scapeVerse;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessor.assets.enhancedObjects
{
    class PlaneViewer
    {
        public Plane[] Planes { get; set; }
        public PlaneViewer(Plane norm)
        {
            Planes = new Plane[1];
            Planes[0] = norm;
        }

        public void addPlane(Plane addThis)
        {
            Plane[] ph = Planes;
            Planes = new Plane[Planes.Count() + 1];
            for (int i = 0; i < ph.Length; i++)
            {
                Planes[i] = ph[i];
            }
            Planes[Planes.Count() - 1] = addThis;
        }

        public void Display()
        {

        }

    }
}
