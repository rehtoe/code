using accessor;
using accessor.assets;
using accessor.assets.enhancedObjects;
using accessor.assets.enhancedObjects.scapeVerse;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessor.assets.stimulations {
    /// <summary>
    /// retose game engine
    /// </summary>
    class Gengin {
        // VARIABLES
        public string label { get; set; }
        public Tree wrkspcevrs { get; set; }
        // INITIALIZERS
        public Gengin() {
            label = "";
            wrkspcevrs = new Tree();
        }
        // LOGISTICS
        public void exe() {
            bool xfs = true;
            while (xfs) {
                Console.Clear();

                switch (Console.ReadKey().Key) {
                    default:
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        Console.Write("~");
                        switch (Console.ReadLine()) {
                            default:
                                break;
                            case "make":
                                switch (Console.ReadLine()) {
                                    default:
                                        break;
                                    case "point":
                                        wrkspcevrs.Create(0, new Point());
                                        break;
                                    case "plane":
                                        wrkspcevrs.Create(0, new Plane());
                                        break;
                                    case "line":
                                        wrkspcevrs.Create(0, new Line());
                                        break;
                                }
                                break;
                            case "select":
                                switch (Console.Read()) {
                                    default:
                                    case 0:
                                        switch (Console.ReadLine()) {
                                            default:
                                                
                                                break;
                                        }
                                        break;
                                }

                                break;

                        }
                        break;
                    case ConsoleKey.O:
                        xfs = false;
                        break;
                        

                }
            }
        }
    }
}
