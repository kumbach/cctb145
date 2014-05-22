using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._3
{
  static class KCalculator
  {

    public static int Add(int value1, int value2)
    {
      return (value1 * 1000) + (value2 * 1000);
    }

    public static int Subtract(int value1, int value2)
    {
      return (value1 * 1000) - (value2 * 1000);
    }
  }
}
