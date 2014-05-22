using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("{0:#,##0}", KCalculator.Add(225, 5));
      Console.WriteLine("{0:#,##0}", KCalculator.Subtract(225, 5));
    }
  }
}
