
using csharp.retose.API.console;

namespace csharp.TiledMap{

  class Program{

    public void enter(){
      Console.Clear();

      var tileN = new Color(ConsoleColor.Red, ConsoleColor.DarkRed, Gradient.None);
      var tileL = new Color(ConsoleColor.Red, ConsoleColor.DarkRed, Gradient.Light);
      var tileM = new Color(ConsoleColor.Red, ConsoleColor.DarkRed, Gradient.Medium);
      var tileD = new Color(ConsoleColor.Red, ConsoleColor.DarkRed, Gradient.Dark);
      var tileF = new Color(ConsoleColor.Red, ConsoleColor.DarkRed, Gradient.Full);

      tileN.display();
      tileL.display();
      tileM.display();
      tileD.display();
      tileF.display();
      Console.WriteLine();

      var rtileN = new Color(ConsoleColor.DarkRed, ConsoleColor.Red, Gradient.None);
      var rtileL = new Color(ConsoleColor.DarkRed, ConsoleColor.Red, Gradient.Light);
      var rtileM = new Color(ConsoleColor.DarkRed, ConsoleColor.Red, Gradient.Medium);
      var rtileD = new Color(ConsoleColor.DarkRed, ConsoleColor.Red, Gradient.Dark);
      var rtileF = new Color(ConsoleColor.DarkRed, ConsoleColor.Red, Gradient.Full);

      rtileF.display();
      rtileD.display();
      rtileM.display();
      rtileL.display();
      rtileN.display();
      Console.WriteLine();

    }

  }

}
