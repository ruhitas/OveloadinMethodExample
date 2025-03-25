using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OveloadinMethodExample
{
    class Program
    {
        static int addNumbers (int x, int y)
        {

            return x + y;

        }

        static double addNumbers(double x, int y)
        {

            return x + y;

        }

        static double subtractM(double x, double y)
        {

            return x - y;

        }

        static string addNumbers(string x, string y)
        {

            return x +" " +y;

        }

        static string addNumbers(int x, string y)
        {

            return x + " " + y;

        }
        static void Main(string[] args)
        {

            var addded =addNumbers(1,2);
            var doublenumber = subtractM(1.2, 5);
            var doublestring = addNumbers("ostim", "teknk");

            Console.WriteLine("added integer 1 and 2 " + addded);
            Console.WriteLine("subtruction double 1.2  5 " + doublenumber);
            Console.WriteLine("strşng concat strings  " + doublestring);
            Console.ReadKey();

        }
    }
}
