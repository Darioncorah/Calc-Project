using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double Add(int i1, int i2)
        {
            return i1 + i2;
        }

        public double Add(int i1, double i2)
        {
            return i1 + i2;
        }

        public double Add(double i1, int i2)
        {
            return i1 + i2;
        }

        public double Add(double i1, double i2)
        {
            return i1 + i2;
        }

        public double Sub(int i1, int i2)
        {
            return i1 - i2;
        }

        public double Sub(int i1, double i2)
        {
            return i1 - i2;
        }

        public double Sub(double i1, int i2)
        {
            return i1 - i2;
        }

        public double Sub(double i1, double i2)
        {
            return i1 - i2;
        }

        public double Div(int i1, int i2)
        {
            return i1 / i2;
        }

        public double Div(int i1, double i2)
        {
            return i1 / i2;
        }

        public double Div(double i1, int i2)
        {
            return i1 / i2;
        }

        public double Div(double i1, double i2)
        {
            return i1 / i2;
        }

        public double Mult(int i1, int i2)
        {
            return i1 * i2;
        }

        public double Mult(int i1, double i2)
        {
            return i1 * i2;
        }

        public double Mult(double i1, int i2)
        {
            return i1 * i2;
        }

        public double Mult(double i1, double i2)
        {
            return i1 * i2;
        }

        public string Dec2Hex(int i)
        {
            return i.ToString("X");
        }

        public int Dec2Hex(string s)
        {
            return int.Parse(s, System.Globalization.NumberStyles.HexNumber);
        }
    }
}
