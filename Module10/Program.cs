using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {5, 4, 3, 2, 1, 10, 1, 3, 0};
            var lowNums =
                from num in numbers
                where num < 5
                select num;
            foreach (var num in lowNums)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
