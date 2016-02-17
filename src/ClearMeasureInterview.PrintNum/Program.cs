using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearMeasureInterview.PrintNumLib;

namespace ClearMeasureInterview.PrintNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzbuzz = new FizzBuzz(100, new Dictionary<int, string>
                                            {
                                                {3, "Fizz"},
                                                {5, "Buzz"},
                                            });

            foreach (var result in fizzbuzz.CalculateFizzBuzzNumbers())
            {
                Console.WriteLine(result);
            }
        }
    }
}
