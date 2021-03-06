using System;
using System.Collections.Generic;
using System.Text;

namespace Panofy
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public double Divide(int x, int y)
        {
            return x / y;
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
