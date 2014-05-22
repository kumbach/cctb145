using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programflow1
{
  class Program
  {
    static void Main(string[] args)
    {
      Program myApp = new Program();
      Color color = Enum.Parse(Color, Console.ReadLine(), true);
      myApp.EnumSample(color);

      myApp.IfStatementSample();
      myApp.ForStatementSample();
      myApp.WhileStatementSamples();
      myApp.ListDivisibleBy(3);
      int someNumber;
      Console.Write("\nEnter a number between 2 and 20: ");
      someNumber = int.Parse(Console.ReadLine());
      myApp.ListDivisibleBy(someNumber);

      Console.Write("\nPress [ENTER] to exit.");
      Console.ReadLine();
    }

    private void EnumSample(Color favoriteColor)
    {
      Console.WriteLine("Sample Enumeration...");
      
      switch (favoriteColor)
      {
        case Color.Red:
          Console.WriteLine("Your color is red.");
          break;
        case Color.Blue:
          Console.WriteLine("Your color is blue.");
          break;
        case Color.Green:
          Console.WriteLine("Your color is green.");
          break;
        default:
          Console.WriteLine("You entered a different color: " + favoriteColor);
          break;
      }
    }
    private void ListDivisibleBy(int divisor)
    {
      Console.WriteLine("List all the numbers from 1 to 100 that are divisible by {0}", divisor);
      for (int counter = 1; counter <= 100; counter++)
      {
        if (counter % divisor == 0)
        {
          Console.Write(counter);
          if (counter <= 100 - divisor)
          {
            Console.Write(", ");
          }
        }
      }
      Console.WriteLine();
    }

    private void ForStatementSample()
    {
      Console.WriteLine("For Statement Sample...");
      for (int counter = 1; counter <= 10; counter++)
      {
        Console.WriteLine(counter);
      }
    }

    private void WhileStatementSamples()
    {
      Console.WriteLine("While and Do-While Samples...");

      int counter = 10;
      while (counter > 0)
      {
        Console.WriteLine(counter);
        counter--;
      }

      int age;
      do
      {
        Console.Write("Enter your age once more: ");
        string stringAge = Console.ReadLine();
        age = int.Parse(stringAge);
      } while (age < 1 || age > 100);
      string message = string.Format("You are {0} years old!", age);
      Console.WriteLine(message);
    }

    public void IfStatementSample()
    {
      Console.WriteLine("If Statement Sample...");

      Console.Write("Enter your age: ");
      string stringAge = Console.ReadLine();
      int age = int.Parse(stringAge);
      
      if (age >= 65)
      {
        Console.WriteLine("You are a senior");
      }
      else if (age >= 18)
      {
        Console.WriteLine("You are an adult");
      }
      else
      {
        Console.WriteLine("You are not an adult");
      }
    }
  }
}
