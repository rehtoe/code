using accessor;
using accessor.assets;
using accessor.assets.enhancedObjects;
using accessor.assets.enhancedObjects.scapeVerse;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessor.assets.enhancedObjects.scapeVerse
{
    class Point : obj
    {
        public VisualData dta { get; set; }
        public Point() {
            dta = new VisualData();
        }

    }

    class VisualData : Component {
        public ConsoleColor Foreground { get; set; }
        public ConsoleColor Background { get; set; }
        public string Symbol { get; set; }

        public VisualData() {
            Symbol = " ";
            Foreground = ConsoleColor.DarkRed;
            Background = ConsoleColor.Black;
            randShade();
        }
        public VisualData(string Sybol) {
            Symbol = Sybol.Substring(0, 1);
            Foreground = ConsoleColor.DarkRed;
            Background = ConsoleColor.Black;
            randShade();
        }

        void randShade() {
            ConsoleColor[] ccs = new ConsoleColor[16];
            for(int i = 0; i < 16; i++) {
                ccs[i] = (ConsoleColor)i;
            }
            Random r = new Random();
            Foreground = ccs[r.Next(0, 16)];
            Background = ccs[r.Next(0, 16)];
            Foreground = ccs[r.Next(0, 16)];
            Background = ccs[r.Next(0, 16)];
            Foreground = ccs[r.Next(0, 16)];
            Background = ccs[r.Next(0, 16)];
            Foreground = ccs[r.Next(0, 16)];
            Background = ccs[r.Next(0, 16)];

            Symbol = "\\" + r.Next(176, 255).ToString();
        }
    }
}
