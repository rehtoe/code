using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accessor.assets.enhancedObjects.GENERAL;

namespace accessor.assets.enhancedObjects.scapeVerse {
    class Camera : obj {
        public num FOV { get; set; }
        public Camera() {
            FOV = new num();
            FOV.mods["range"] = new range(0.00M, 360.00M);
            FOV.mods["range"].isActive = true;
        }
        public Camera(decimal fov) { 
            FOV = new num(fov);
            FOV.mods["range"] = new range(0.00M, 360.00M);
            FOV.mods["range"].isActive = true;
        }
    }
}
