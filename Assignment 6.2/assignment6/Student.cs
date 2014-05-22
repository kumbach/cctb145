using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
  class Student
  {
    private int id;
    public string Name;
    public int Mark;

    private bool _paidFees;
    public string PaidFees
    {
      get
      {
        return _paidFees ? "Paid" : "Unpaid";
      }
    }

    public Student(int id, string name, int mark, bool paidFees)
    {
      this.id = id;
      this.Name = name;
      this.Mark = mark;
      this._paidFees = paidFees;
    }
  }
}
