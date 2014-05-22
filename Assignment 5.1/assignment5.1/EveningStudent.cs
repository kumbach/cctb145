using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._1
{
  class EveningStudent : Student
  {
    string RoomNumber;
    string CourseName;

    public EveningStudent(int Id, string Name, string PhoneNumber, string RoomNumber, string CourseName)
      : base(Id, Name, PhoneNumber)
    {
      this.RoomNumber = RoomNumber;
      this.CourseName = CourseName;
    }

    public void DisplayStudent()
    {
      // intentionally does not call the base class method here...
      Console.WriteLine("Id: {0} Name: {1} Phone: {2} Room Number: {3} Course Name: {4}", Id, Name, PhoneNumber, RoomNumber, CourseName);
    }
  }
}

