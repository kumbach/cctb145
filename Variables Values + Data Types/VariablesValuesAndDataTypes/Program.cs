using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesValuesAndDataTypes.Kevin
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(true && false);



      char singleDigit = '5';
      int simpleNumber = 25;
      string stringDigits = "42";
      Console.WriteLine((int)30.5);

      Console.WriteLine("'5' " + (int)singleDigit + " " + Convert.ToInt32(singleDigit));
      Console.WriteLine("25 " + (double)simpleNumber + " " + Convert.ToDouble(simpleNumber));
      Console.WriteLine("\"42\" " + double.Parse(stringDigits.ToString()) + " " + Convert.ToDouble(stringDigits));
    }
  }
}
