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

      char singleDigit = '5';
      int simpleNumber = 25;
      string stringDigits = "42";
      Console.WriteLine((int)30.5);

      Console.WriteLine("'5' " + (int)singleDigit + " " + Convert.ToInt32(singleDigit));
      Console.WriteLine("25 " + (double)simpleNumber + " " + Convert.ToDouble(simpleNumber));
      Console.WriteLine("\"42\" " + double.Parse(stringDigits.ToString()) + " " + Convert.ToDouble(stringDigits));

      string sentence = "A string can hold many characters.";
      string empty = ""; // a string can be "empty" (zero characters)
      string nothing = null; // a string can be null (not the same as "empty")

      Console.WriteLine("Nothing is actually this when you print it: \"" + nothing + "\"");
      try
      {
        if (nothing.Length == 3) { int a = 333; }
      }
      catch (NullReferenceException e)
      {
        Console.WriteLine("You can't check the length of the variable named \"nothing\"!!");
      }

      Boolean booleanVariable = true; // can only hold true or false
      // please note that bool true is not the same as the string "true"

      // Variable names are case sensitive. i.e. namE is not the same as Name, nAme, or naMe. Kinda like a lot of other languages.
      int number = 25;
      int Number = 30;
      int NUMbER = 35;
      // All the above are DIFFERENT variables...
      
      // play with boolean expressions and logical operators
      int highNumber = 500;
      int lowNumber = 2;

      bool highIsBiggerThanLow = highNumber > lowNumber;
      //                        \relational expression/
      //                         \ true or false???  /
      bool highIsBiggerThan50 = highNumber > 50;
      bool highIs100 = highNumber == 100;
      bool highIsBiggerThanLowAndBiggerThan50 = highIsBiggerThanLow && highIsBiggerThan50;


      Boolean b = true;
      Boolean c = true;
      if(b.Equals(c)) Console.WriteLine("yes!");
    }
  }
}
