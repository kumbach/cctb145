using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
  class Program
  {
    static void Main(string[] args)
    {
      Student kevin = new Student(1, "Kevin", "89123456");
      kevin.increaseCoursesTaken();
      kevin.OutputStudentDetails();
    }
  }
}
