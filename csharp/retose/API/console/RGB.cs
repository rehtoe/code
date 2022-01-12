

namespace csharp.retose.API.console {

  public class Color{
    public ConsoleColor Foreground { get; set; }
    public ConsoleColor Background { get; set; }
    public string Overlay { get; set; }
    public Gradient TileGradient { get; set; }
    public Shade ColorGroup { get; set; }

    public Color(){
      Foreground = Console.ForegroundColor;
      Background = Console.BackgroundColor;
      Overlay = " ";
      TileGradient = Gradient.None;
      ColorGroup = getShade();
    }

    public Color(ConsoleColor Fore, ConsoleColor Back, Gradient gradient){
      Foreground = Fore;
      Background = Back;
      TileGradient = gradient;

      switch(gradient){
          default:
            Overlay = " ";
            break;
          case Gradient.Light:
            Overlay = "░";
            break;
          case Gradient.Medium:
            Overlay = "▒";
            break;
          case Gradient.Dark:
            Overlay = "▓";
            break;
          case Gradient.Full:
            Overlay = "█";
            break;
      }

      ColorGroup = getShade();

      logic();
    }

    public void display(){
      ConsoleColor phB = Console.BackgroundColor;
      ConsoleColor phF = Console.ForegroundColor;
      Console.BackgroundColor = Background;
      Console.ForegroundColor = Foreground;
      Console.Write(Overlay);
      Console.BackgroundColor = phB;
      Console.ForegroundColor = phF;
    }

    Shade getShade(){

      return Shade.Null;
    }
    void logic(){

    }

  }

  public enum Shade{
    Null,
    Grayscale,
    Red,
    Green,
    Blue,
    Magenta,
    Yellow,
    Cyan
  }
  public enum Gradient{
    None,
    Light,
    Medium,
    Dark,
    Full
  }

  public class Library{
    public Dictionary<Shade, List<Color>> RGBMCY { get; set; }

    public Library(){
      RGBMCY = new Dictionary<Shade, List<Color>>();

      List<Color> R = new List<Color>();
      List<Color> G = new List<Color>();
      List<Color> B = new List<Color>();
      List<Color> M = new List<Color>();
      List<Color> C = new List<Color>();
      List<Color> Y = new List<Color>();
      RGBMCY.Add(Shade.Red, R);
      RGBMCY.Add(Shade.Green, G);
      RGBMCY.Add(Shade.Blue, B);
      RGBMCY.Add(Shade.Magenta, M);
      RGBMCY.Add(Shade.Cyan, C);
      RGBMCY.Add(Shade.Yellow, Y);

      logic();
    }

    void logic(){
      string sLight = "░";
      string sMedium = "▒";
      string sDark = "▓";

    }

  }

}
