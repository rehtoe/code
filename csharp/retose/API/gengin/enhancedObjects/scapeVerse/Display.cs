using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accessor.assets.enhancedObjects.GENERAL;

namespace accessor.assets.enhancedObjects.scapeVerse {
    class Display {
        public Camera current { get; set; }
        public Point[][] points { get; set; }
        
        public Display() {
            current = new Camera(120m);
        }
    }
}
