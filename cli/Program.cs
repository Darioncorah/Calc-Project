using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc cal = new Calc();
            Console.WriteLine("type ? for help");
            switch (args[0].ToLower())
            {
                case "?":
                    Console.WriteLine("add Num1 Num2 -- Adds numbers");
                    Console.WriteLine("sub Num1 Num2 -- Subtracts numbers");
                    Console.WriteLine("div Num1 Num2 -- Divides numbers");
                    Console.WriteLine("mult Num1 Num2 -- Multiplys numbers");
                    Console.WriteLine("dec2hex Num1 -- coverts a number to Hexadecimal");
                    Console.WriteLine("hex2dec Hex -- converts Hexadecimal to number");
                    break;
                case "add":
                    Console.WriteLine(cal.Add(Convert.ToDouble(args[1]), Convert.ToDouble(args[2])));
                    break;
                case "sub":
                    Console.WriteLine(cal.Sub(Convert.ToDouble(args[1]), Convert.ToDouble(args[2])));
                    break;
                case "mult":
                    Console.WriteLine(cal.Mult(Convert.ToDouble(args[1]), Convert.ToDouble(args[2])));
                    break;
                case "div":
                    Console.WriteLine(cal.Div(Convert.ToDouble(args[1]), Convert.ToDouble(args[2])));
                    break;
                case "dec2hex":
                    Console.WriteLine(cal.Dec2Hex(Convert.ToInt32(args[1])));
                    break;
                case "hex2dec":
                    Console.WriteLine(cal.Dec2Hex(args[1]));
                    break;
                default:
                    Console.WriteLine("Incorrect Entry");
                    break;
            }
            Console.ReadKey();
        }
    }
}
