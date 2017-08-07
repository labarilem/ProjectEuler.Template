using System;
using System.Numerics;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProblemProjectEuler.Template
{
  class Program
  {
    static void Main(string[] args)
    {
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();

      stopWatch.Stop();
      Console.WriteLine("Result: ");
      Console.WriteLine("Elapsed time: " + stopWatch.Elapsed.ToString());
    }
  }
}