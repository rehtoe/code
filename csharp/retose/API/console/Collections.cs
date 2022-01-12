using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.retose.API.console {
    // general enhanced experienced whilst coding such as the hassle of Console.WriteLine() simplified to writenl()
    public class Collections {
        public static void clear() {
            Console.Clear();
        }
        public static void write(object o) {
            Console.Write(o.ToString());
        }
        public static void writenl(object o) {
            Console.WriteLine(o.ToString());
        }
        public static void writexl(object o) {
            Console.Write("\n" + o.ToString());
        }
        public static void writec(object o, ConsoleColor ofType, ConsoleColor ofHighlight){
          Console.ForegroundColor = ofType;
          Console.BackgroundColor = ofHighlight;
          write(o.ToString());
          Console.ForegroundColor = ConsoleColor.White;
          Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void writect(object o, ConsoleColor coloredType) {
            Console.ForegroundColor = coloredType;
            write(o);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void writech(object o, ConsoleColor coloredHighlight) {
            Console.BackgroundColor = coloredHighlight;
            write(o);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static int read() {
            return Console.Read();
        }
        public static int readInt() {
            string ph = Console.ReadLine();
            int x = 0;
            if(int.TryParse(ph, out x)) {
                return int.Parse(ph);
            }
            return x;
        }
        public static char readChar() {
            return Console.ReadKey().KeyChar;
        }
        public static ConsoleKeyInfo readKey() {
            return Console.ReadKey();
        }
        public static string readnl() {
            return Console.ReadLine();
        }
        public struct Method {
            public delegate void MyDelegate();
            private MyDelegate method;
            private bool loop;
            public Method(MyDelegate choice) {
                method = choice;
                loop = false;
            }
            public void set(MyDelegate choice) {
                method = choice;
            }
            public bool Loop(){
              return loop;
            }
            public bool Loop(bool update){
              loop = update;
              return loop;
            }
            public void call() {
              if(loop){
                while(loop){
                    method();
                }
              }else{
                method();
              }
            }
        }
    }
}
