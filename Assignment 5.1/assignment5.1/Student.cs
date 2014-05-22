using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._1
{
  class Student
  {
    public int Id { set; get; }
    public string Name { set; get; }
    public string PhoneNumber { set; get; }

    public Student()
    {
    }

    public Student(int Id, string Name, string PhoneNumber)
    {
      this.Id = Id;
      this.Name = Name;
      this.PhoneNumber = PhoneNumber;
    }

    public void DisplayStudent()
    {
      Console.Write("Id: {0} Name: {1} Phone: {2}", Id, Name, PhoneNumber);
    }
  }
}
