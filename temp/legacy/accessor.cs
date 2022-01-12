using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Timers;
using System.Data;

using csharp.retose.API.console;
using static csharp.retose.API.console.Collections;
using csharp.retose.API.gengin;

namespace csharp.lawnmower{
  class Program{
    public static GameEngine lmGE;
    public void enter(){
      Lawnmower lm = new Lawnmower(true);
      lmGE = new GameEngine(lm, "Lawnmower");
      Method phM = new Method(testobj);
      lmGE.addControl(ConsoleKey.M, phM);
      lmGE.Run();
    }
    void testobj(){
      writenl(lmGE.reference.product["tree"]);
    }
  }
}
