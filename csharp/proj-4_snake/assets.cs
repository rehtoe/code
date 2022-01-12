using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.IO;
using System.Timers;
using System.Data;

namespace csharp.snake {

  public class Board {
    public Tile[][] map { get; set; }
    int length { get; set; }
    int width { get; set; }


    public Board(){
      Random r = new Random();
      length = r.Next(8, 16);
      width = r.Next(8, 16);
      map = new Program().mapa(length, width);

      create();
    }

    public Board(int x, int y){
      length = x;
      width = y;
      map = new Program().mapa(length, width);

      create();
    }

    void create(){
      // creates a wall as a row(width)
      Tile[] rowWall = new Tile[width];
      for(int i = 0; i < width; i++){
        Tile ph1 = new Tile();
        ph1.occupiedBy = new Wall();
        rowWall[i] = ph1;
      }
      // Tiles for the play space
      Tile[] scapeBtwn = new Tile[width];
      for(int i = 0; i < width; i++){
        switch(i){
          default:
            if(i == width - 1){
              Tile ph2 = new Tile();
              ph2.occupiedBy = new Wall();
              scapeBtwn[i] = ph2;
            }else{
              Tile ph3 = new Tile();
              ph3.occupiedBy = new Air();
              scapeBtwn[i] = ph3;
            }
            break;
          case 0:
            Tile ph4 = new Tile();
            ph4.occupiedBy = new Wall();
            scapeBtwn[i] = ph4;
            break;
        }
      }
      //adding each row to the map,(length)
      for(int j = 0; j < length; j++){
        switch(j){
          default:
            if(j == length - 1){
              map[j] = rowWall;
            }else{
              map[j] = scapeBtwn;
            }
            break;
          case 0:
            map[j] = rowWall;
            break;
        }
      }

      // la snake
      // while(true){
      //   int xz = new Random().Next(0, length);
      //   int yz = new Random().Next(0, width);
      //   if(map[xz][yz].occupiedBy.isBlank){
      //     map[xz][yz].occupiedBy = new Snake();
      //     break;
      //   }
      // }
    }

    void update(){

    }

    public void Display(){
      update();
      Console.Clear();
      foreach(Tile[] row in map){
        foreach(Tile next in row){
          Console.BackgroundColor = next.occupiedBy.Background;
          Console.ForegroundColor = next.occupiedBy.Foreground;
          Console.Write(next.occupiedBy.label);
        }
        Console.Write("\n");
      }
    }

    public void Play(){
      bool running = true;
      while(running){
        Console.Clear();
        Display();
        switch(Console.ReadKey().Key){
          case ConsoleKey.A:
          case ConsoleKey.LeftArrow:
          running = false;
              break;
        }
      }
    }
  }

  public class Tile{
    public Occupant occupiedBy { get; set; }

    public Tile(){
      occupiedBy = new Occupant();
    }
  }

  public class Occupant{
    public ConsoleColor Background { get; set; }
    public ConsoleColor Foreground { get; set; }
    public string label { get; set; }

    public bool isBlank { get; set; }
    public bool willKill { get; set; }
    public bool isEdible { get; set; }
    public bool isHealthy { get; set; }

    public Occupant(){
      Background = ConsoleColor.Black;
      Foreground = ConsoleColor.DarkGray;
      label = ";";

      isBlank = true;
      willKill = true;
      isEdible = false;
      isHealthy = false;
    }
  }

  public class Air : Occupant {
    public Air(){
      Background = ConsoleColor.Gray;
      Foreground = ConsoleColor.DarkGray;
      label = " ";
      isBlank = true;
      willKill = false;
      isEdible = false;
      isHealthy = false;
    }
  }

  public class Snake : Occupant{
    Direction Facing { get; set; }

    public Snake(){
      Background = ConsoleColor.Green;
      Foreground = ConsoleColor.Red;
      label = "O";
      isBlank = false;
      willKill = false;
      isEdible = true;
      isHealthy = false;

      switch(new Random().Next(0, 4)){
        case 0:
          Facing = Direction.up;
          label = "^";
          break;
        case 1:
          Facing = Direction.left;
          label = "<";
          break;
        case 2:
          Facing = Direction.down;
          label = "v";
          break;
        default:
        case 3:
          Facing = Direction.right;
          label = ">";
          break;
      }
    }
  }

  public class Body : Snake{
    Direction To { get; set; }
    Direction From { get; set; }
  }

  public class Grub : Occupant{
    public Grub(){
      Background = ConsoleColor.Gray;
      Foreground = ConsoleColor.Red;
      label = "O";
      isBlank = false;
      willKill = false;
      isEdible = true;
      isHealthy = true;
    }
  }

  public class Wall : Occupant{
    public Wall(){
      Background = ConsoleColor.DarkGray;
      Foreground = ConsoleColor.DarkGray;
      label = "X";
      isBlank = false;
      willKill = true;
      isEdible = false;
      isHealthy = false;
    }
  }

  public enum Direction{
    up,
    left,
    down,
    right
  }

}
