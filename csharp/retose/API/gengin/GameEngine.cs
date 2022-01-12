using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static csharp.retose.API.console.Collections;

using csharp.retose.API.console.EnhancedObjects;

namespace csharp.retose.API.gengin {
  // START
  // GameEngine wrkspc (2d and 3d)
  public class GameEngine {

    // Properties
    public object reference;
    public KeyStream Controls { get; set; }
    public bool Running { get; set; }
    public Method runFunction;
    public string Name { get; set; }


    // Initializers
    public GameEngine(object funcRef){
      reference = funcRef;
      Controls  = new KeyStream();
      Running = false;
      runFunction = new Method();
      Name = "";

    }

    public GameEngine(object funcRef, string name){
      reference = funcRef;
      Controls  = new KeyStream();
      Running = false;
      runFunction = new Method();
      Name = name;

    }

    // Updates
    public void addControl(ConsoleKey ck, Method m){
        Controls.AddInteraction(ck, m);
    }
    public void runAtStart(Method RunFunction){
      runFunction = RunFunction;
    }

    // Methods
    public void Run() {
      clear();
      runFunction.call();
      // KeyStream allows you to set methods of code('void's for now) to a key input
      Controls.Read(true);
    }

  }
}
