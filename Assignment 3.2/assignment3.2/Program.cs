using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3._2
{
  class Program
  {
    static void Main(string[] args)
    {
      int lessThanFiveCount = 0;
      int greaterThanFiveCount = 0;
      for (int outerLoop = 5; outerLoop >= 1; outerLoop--)
      {
        for (int innerLoop = 1; innerLoop <= 3; innerLoop++)
        {
          int result = outerLoop * innerLoop;
          if (result < 5)
          {
            lessThanFiveCount++;
          }
          else if (result > 5)
          {
            greaterThanFiveCount++;
          }

          if (result != 5)
          {
            Console.WriteLine(result);
          }
        }
      }

      Console.WriteLine(lessThanFiveCount + " are less than 5");
      Console.WriteLine(greaterThanFiveCount + " are greater than 5");
    }
  }
}
