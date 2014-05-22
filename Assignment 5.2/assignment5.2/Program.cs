using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._2
{
  class Program
  {
    static void Main(string[] args)
    {
      Fraction a = new Fraction(1, 2);
      Fraction b = new Fraction(1, 4);

      Fraction newFraction = a + b;
      Console.WriteLine("{0} + {1} = {2}", a.ToString(), b.ToString(), newFraction.ToString());
    }
  }
}
