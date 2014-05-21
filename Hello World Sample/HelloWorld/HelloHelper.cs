using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  class HelloHelper
  {
    List<string> people = new List<string>();

    internal void addPerson(string name)
    {
      if (people.Contains(name))
      {
        Console.WriteLine("I'm already going to say hello to " + name);
      }
      people.Add(name);
    }

    protected internal void sayHiToEveryone()
    {
      if (people.Count() > 0)
      {

        Console.WriteLine("\nI'd like to say hello to the following people:");
        foreach (string person in people)
        {
          Console.WriteLine("  - " + person);
        }
      }
      else
      {
        Console.WriteLine("\nOkay then, I won't say hello to anyone.");
      }
    }
  }
}
