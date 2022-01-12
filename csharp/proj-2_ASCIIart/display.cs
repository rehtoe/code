namespace csharp.ASCIIart{
  class RandomImage{
    public Cuadro[] linea { get; set; }

    public RandomImage(){
      linea = new Cuadro[new Random().Next(10,30)];
      for(int i = 0; i < linea.Count(); i++){
        linea[i] = new Cuadro();
      }
    }

    public void Display(){
      foreach(Cuadro c in linea){
        Console.BackgroundColor = c.Background;
        Console.ForegroundColor = c.Foreground;
        Console.Write(c.Symbolo);
      }
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.White;

      Console.WriteLine();

    }
  }

  class Cuadro{
    public ConsoleColor Background { get; set; }
    public ConsoleColor Foreground { get; set; }
    public string Symbolo { get; set; }

    public Cuadro(){
      Random r = new Random();
      Background = (ConsoleColor)r.Next(0,16);
      Foreground = (ConsoleColor)r.Next(0,16);
      Symbolo = ("X");
    }
  }
}
