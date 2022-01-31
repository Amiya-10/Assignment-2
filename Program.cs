using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_assignment
{
    class CompuondInterest
    {
        static void Main(string[] args)
        {
            double Total = 0, Rate, years, annualCompound, Amount;
            Console.Write("Enter the Initial Amount: ");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Rate of Interest: ");
            Rate = Convert.ToDouble(Console.ReadLine())/100;
            Console.Write("Enter the Number of Years: ");
            years = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of Times the Interest will be Compounded: ");
            annualCompound = Convert.ToDouble(Console.ReadLine());
            for (int t = 1; t < years + 1; t++)
            {
                Total = Amount * Math.Pow((1 + Rate / annualCompound),
                                         (annualCompound * t));
                Console.Write("Your Total for Year {0} "
                            + "is {1:F0}. \n", t, Total);

            }

            Console.ReadLine();
        }
    }
}
