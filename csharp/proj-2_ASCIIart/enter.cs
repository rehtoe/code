using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Text;
using csharp.retose.API;
using static csharp.retose.API.console.Collections;

namespace csharp.ASCIIart{
  //  ACCESSOR
  class Program{
    public void enter(){
      clear();
      for(int i = 0; i < 1000000; i++){
        RandomImage ri = new RandomImage();
        Console.Write(i + " -> ");
        ri.Display();
      }
    }
  }
}
/*

01100111
00011111

RGBA?
ARGB?
split into pairs and have 16 "combinations"
 after doing the math to the 16 consolecolors

rr = clear/grayscale?
rR = darker
Rr = lighter
RR = normal/saturated?
*/
