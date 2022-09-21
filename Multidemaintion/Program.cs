using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidemaintion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4]
            {
                {1, 2, 3, 4},
                {5,6, 7, 8},
                {9,10, 11, 12},
            };

           foreach(var i in arr)
            {
                    Console.WriteLine(i);
            }
        }
    }
}
