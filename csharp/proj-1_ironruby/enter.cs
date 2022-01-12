using System;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Data.Common;

namespace csharp.ironruby{
  // ACCESSOR
  class Program{
    public void enter(){
      Console.WriteLine(Environment.CurrentDirectory);

      ProcessStartInfo psi = new ProcessStartInfo(){
        //FileName = "/usr/share/applications/xfce4-terminal-emulator.desktop",
        FileName = "/run/media/reware/p0/code/ruby/proj-0_testing/run.rb",
        //Arguments = "/run/media/reware/p0/code/ruby/proj-0_testing/run.rb",
        WorkingDirectory = "/run/media/reware/p0/code/ruby/proj-0_testing/",
        UseShellExecute = true,
        UserName = "reware",
      };

      Process proc = new Process();

      proc.StartInfo = psi;

      proc.Start();

      proc.WaitForExit();
    }
  }
}
