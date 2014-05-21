using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter a number between 1 and 100 : ");
      string numberEntry = Console.ReadLine();
      int enteredNumber = int.Parse(numberEntry);

      if (enteredNumber >= 1 && enteredNumber <= 100)
      {
        int evenNumberTotal = 0;
        for (int currentNumber = 1; currentNumber <= enteredNumber; ++currentNumber)
        {
          if (IsEvenNumber(currentNumber))
          {
            evenNumberTotal += currentNumber;
            Console.Write(currentNumber);
            if (currentNumber < enteredNumber)
            {
              Console.Write(" + ");
            }
          }
        }

        if (evenNumberTotal > 0)
        {
          Console.WriteLine(" = " + evenNumberTotal);
        }
        else
        {
          Console.WriteLine("There are no even numbers between 1 and " + enteredNumber);
        }
      }
      else
      {
        Console.WriteLine("The number you entered is not between 1 and 100.");
      }
    }

    static public bool IsEvenNumber(int intNumber)
    {
      return intNumber % 2 == 0;
    }
  }
}
