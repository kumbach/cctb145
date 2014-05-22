using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._2
{
  class Fraction
  {
    public int Numerator;
    public int Denominator;

    public Fraction()
    {
      Numerator = 1;
      Denominator = 1;
    }

    public Fraction(int Numerator, int Denominator)
    {
      this.Numerator = Numerator;
      this.Denominator = Denominator;
    }

    public override string ToString()
    {
      return Numerator + "/" + Denominator;
    }

    public static Fraction operator +(Fraction p1, Fraction p2)
    {
      Fraction result = new Fraction();
      result.Numerator = p1.Numerator * p2.Denominator + p2.Numerator * p1.Denominator;
      result.Denominator = p1.Denominator * p2.Denominator;
      return result;
    }

  }
}
