using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._1
{
  class DayTimeStudent : Student
  {
    string Section;
    string Locker;

    public DayTimeStudent(int Id, string Name, string PhoneNumber, string Section, string Locker)
      : base(Id, Name, PhoneNumber)
    {
      this.Section = Section;
      this.Locker = Locker;
    }

    public void DisplayStudent()
    {
      base.DisplayStudent();
      Console.WriteLine(" Section: {0} Locker Number: {1}", Section, Locker);
    }
  }
}
