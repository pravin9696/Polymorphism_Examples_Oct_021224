using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Examples_Oct_021224.Assignment_1
{
    internal class Calculator
    {
        public void Add(double x, double y)
        {
            double Ans;
            Ans = x + y;
            Console.WriteLine($" Addition of {x} & {y} is {Ans}");
        }
        //public void Add(params int[]x)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < x.Length; i++)
        //    {
        //        sum += x[i];
        //    }
        //    Console.WriteLine($" Addition of {x.Length} numbers is {sum}");
        //}

        public void Add(int x, int y)
        {
            int Ans;
            Ans = x + y;
            Console.WriteLine($" Addition of {x} & {y} is {Ans}");
        }

        public void Add(int x, int y, int z)
        {
            int Ans;
            Ans = x + y + z;
            Console.WriteLine($" Addition of {x} , {y} & {z} is {Ans}");
        }
    }
}
