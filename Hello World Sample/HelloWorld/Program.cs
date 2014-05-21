using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("math expression: 123.45 X 67.89 = " + 123.45 * 67.89);

      HelloHelper helper = new HelloHelper();
      string name;
      for(;;)
      {
        Console.Write("Tell me a name: ");
        name = Console.ReadLine().Trim();
        if (name.Length == 0) 
        {
          break;
        }
        helper.addPerson(name);
      };

      helper.sayHiToEveryone();
    }
  }
}
