using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int thirdDigit = (number / 100) % 10;
            if (thirdDigit == 7)
            {
                Console.WriteLine("The third digit is 7");
            }
            else
            {
                Console.WriteLine("The third digit is not 7");
            }
        }
    }
}
