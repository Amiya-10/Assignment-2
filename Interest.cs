using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_assignment
{
    class Interest
    {
        static void Main(string[] args)
        {
            int count = 0;
            double m = 1000;
            double simpleinterest;
            for (m = 1000; m > 0; count++)
            {
                simpleinterest = (m * 1.5) / 100;
                m -= 100;
                m -= simpleinterest;
                Console.WriteLine("For month {0} balance is {1}",count,m);
            }
            Console.ReadKey();
        }
    }
}
