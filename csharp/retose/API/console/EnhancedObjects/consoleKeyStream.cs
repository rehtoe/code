using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static csharp.retose.API.console.Collections;

namespace csharp.retose.API.console.EnhancedObjects{
  //START
  // KEY STREAM
  //
  public class KeyStream{

    public ConsoleKey BreakKey { get; set; }
    public Dictionary<ConsoleKey, Collections.Method> Actions { get; set; }

        public KeyStream(){
          BreakKey = ConsoleKey.Escape;
          Actions = new Dictionary<ConsoleKey, Collections.Method>();
        }
        public KeyStream(ConsoleKey stoppingKey){
          BreakKey = stoppingKey;
          Actions = new Dictionary<ConsoleKey, Collections.Method>();
        }

    public void Read(bool clearConsole){
      // sets up the colors so that its blank
      ConsoleKeyInfo CKI = new ConsoleKeyInfo();
      while(CKI.Key != BreakKey){
        if(clearConsole){
          Collections.clear();
        }
        CKI = readKey();
        Collections.Method mmm = new Collections.Method();
        if(Actions.TryGetValue(CKI.Key, out mmm)){
            mmm.call();
        }
      }
    }

    public void AddInteraction(ConsoleKey KEY, Collections.Method CODE){
      if(!Actions.ContainsKey(KEY)){
        Actions.Add(KEY, CODE);
      }else{
        Actions[KEY] = CODE;
      }
    }

  }
  //
  // KEY STREAM
  //END
}
