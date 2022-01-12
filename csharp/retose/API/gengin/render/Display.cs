using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static csharp.retose.API.console.Collections;

namespace csharp.retose.API.gengin.render{

  public class Display{
    //units per pixel for the math, if you put 1.0 itll only have data for math calculations for the tents
    float unitPerPixel { get; set; }

    public Display(){
      unitPerPixel = 1.00f;
    }
    public Display(float UPIdefault1){
      unitPerPixel = UPIdefault1;
    }


  }

}
