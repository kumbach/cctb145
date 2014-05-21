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
      string enteredNumber = Console.ReadLine();
      int number = Convert.ToInt32(enteredNumber);

      if (number >= 1 && number <= 100)
      {
        int evenNumberTotal = 0;
        for (int currentNumber = 1; currentNumber <= number; ++currentNumber)
        {
          if (IsEvenNumber(currentNumber))
          {
            evenNumberTotal += currentNumber;
            Console.Write(currentNumber);
            if (currentNumber < number)
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
          Console.WriteLine("There are no even numbers between 1 and " + number);
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
