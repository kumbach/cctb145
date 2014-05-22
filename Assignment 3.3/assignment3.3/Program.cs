using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3._3
{
  enum OfficeDepartment
  {
    Accounting,
    HumanResources,
    InformationTechnology,
    Shipping,
    Mailroom,
    Management
  }

  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();

      foreach (OfficeDepartment department in Enum.GetValues(typeof(OfficeDepartment)))
      {
        Console.WriteLine("{0} has {1} employees", GetDepartmentName(department), random.Next(1,100));
      }
    }

    static string GetDepartmentName(OfficeDepartment officeDepartmentType)
    {
      string officeDepartment;

      switch (officeDepartmentType)
      {
        case OfficeDepartment.Accounting:
          officeDepartment = "Accounting";
          break;
        case OfficeDepartment.HumanResources:
          officeDepartment = "Human Resources";
          break;
        case OfficeDepartment.InformationTechnology:
          officeDepartment = "Information Technology";
          break;
        case OfficeDepartment.Shipping:
          officeDepartment = "Shipping";
          break;
        case OfficeDepartment.Mailroom:
          officeDepartment = "Mailroom";
          break;
        case OfficeDepartment.Management:
          officeDepartment = "Management";
          break;
        default:
          officeDepartment = "Unknown";
          break;
      }

      return officeDepartment;
    }

  }
}
