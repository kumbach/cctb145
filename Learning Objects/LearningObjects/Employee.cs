using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningObjects
{
  class Employee
  {
    #region vars (auto-implemented)
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary {get; set; }
    public DateTime StartingDate {get; set;}
    public string PhoneNumber { get; set; }
    #endregion

    #region constructors
    public Employee()
    {
    }

    public Employee(string name, int age, double salary, DateTime startedOn, string phone)
    {

    }

    #endregion

  }
}
