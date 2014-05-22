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
      myApp.IfStatementSample();
      Console.WriteLine("Goodbye.");
    }

    public void IfStatementSample()
    {
      Console.WriteLine("If Statement Sample...");

      Console.Write("Enter your age: ");
      string stringAge = Console.ReadLine();
      int age = int.Parse(stringAge);

      if (age >= 18)
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
