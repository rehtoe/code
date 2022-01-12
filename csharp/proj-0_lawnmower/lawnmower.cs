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
  //
  // GAME ITSELF(MECHANICS AND SHII)
  //
  class Lawnmower : object{
    public Dictionary<string, productData> product { get; set; }
    public struct productData{

      /*
      ORDER TO 'dataArray', TO WORK;
      _Price
      _Blessing
      chanceBlessing_
      _Containers
      spaceContainers_
      totalSpace__
      _Amount
      totalAmount_
      sourceAmount_
      perSource__
      runtimeSource__
      runningSource__
      */
      Int64[] dataArray;
      public string label;
      public productData(string Name, Int64[] pass_setup){
        dataArray = new Int64[12];
        label = Name;
        setup(pass_setup);
      }

      void setup(Int64[] newDataVar){
        Int64 _Price = newDataVar[0];
        Int64 _Blessing = newDataVar[1];
        Int64 chanceBlessing_ = newDataVar[2];
        Int64 _Containers = newDataVar[3];
        Int64 spaceContainers_ = newDataVar[4];
        Int64 totalSpace__ = newDataVar[5];
        Int64 _Amount = newDataVar[6];
        Int64 totalAmount_ = newDataVar[7];
        Int64 sourceAmount_ = newDataVar[8];
        Int64 perSource__ = newDataVar[9];
        Int64 runtimeSource__ = newDataVar[10];
        Int64 runningSource__ = newDataVar[11];
        dataArray[0] = _Price;
        dataArray[1] = _Blessing;
        dataArray[2] = chanceBlessing_;
        dataArray[3] = _Containers;
        dataArray[4] = spaceContainers_;
        dataArray[5] = totalSpace__;
        dataArray[6] = _Amount;
        dataArray[7] = totalAmount_;
        dataArray[8] = sourceAmount_;
        dataArray[9] = perSource__;
        dataArray[10] = runtimeSource__;
        dataArray[11] = runningSource__;
      }

    }

    public Lawnmower(bool setup){
      if(setup){
        Int64[] ph_APD = new Int64[12];
        ph_APD[0] = 10;
        ph_APD[1] = Convert.ToInt64(Convert.ToString(("wastespace".ToCharArray(), 2)));
        ph_APD[2] = 1;
        ph_APD[3] = 1;
        ph_APD[4] = 1;
        ph_APD[5] = ph_APD[3] * ph_APD[4];
        ph_APD[6] = 0;
        ph_APD[7] = 0;
        ph_APD[8] = 0;
        ph_APD[9] = 107713;
        ph_APD[10] = 600000;
        ph_APD[11] = 0;


        productData phPD = new productData("tree", ph_APD);
        product.Add(phPD.label, phPD);
      }
    }

  }

}
