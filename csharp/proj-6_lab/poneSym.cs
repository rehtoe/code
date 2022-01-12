
namespace csharp.lab{
  class sanbox{
    string path = "retose/API/ASCII/test.txt";
    public void enter(){
      string[] lines = File.ReadAllLines(path);
      foreach(string linea in lines){
        Console.WriteLine(linea);
      }
    }
  }
}
