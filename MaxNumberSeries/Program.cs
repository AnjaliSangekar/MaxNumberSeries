using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a series of numbers, seperated by commas: ");

            var Input = Console.ReadLine();

            var numbers = Input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max number is " + max);

        }
    }
}
