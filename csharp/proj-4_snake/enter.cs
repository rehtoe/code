using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.IO;
using System.Timers;
using System.Data;
using static csharp.retose.API.console.Collections;

namespace csharp.snake {
  class Program{
    public void enter(){

      Board level = new Board(10, 20);
      //level.map[0][2].occupiedBy = new Snake();
      level.Display();
    }

    public Tile[][] mapa(int rows, int columns){
      Tile[][] ph = new Tile[rows][];
      for(int g = 0; g < ph.Count(); g++){
          ph[g] = new Tile[columns];
      }
      return ph;
    }
  }
}
