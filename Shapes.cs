using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_on_classes
{
    class Shapes
    {
        public int length, breadth,side;
        public float r;
        public double ht, bdtriangle;
        
        public int Area(int a,int b)
        {
            int ar;
            Console.WriteLine("Enter the Length");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            breadth = int.Parse(Console.ReadLine());
            ar = length * breadth;
            Console.WriteLine("Area of rectangle is :{0}", ar);
            return ar;
        }
        public int Area(float c)
        {
            int ar;
            Console.WriteLine("Enter the Radius");
            r = float.Parse(Console.ReadLine());
            ar = (int)(3.14 * r * r);
            Console.WriteLine("Area of Circle is:{0}",ar );
            return ar;

        }
        public int Area(int d)
        {
            int ar;
            Console.WriteLine("Enter the side of a square");
            side = int.Parse(Console.ReadLine());
            ar = side * side;
            Console.WriteLine("Area of Square is:{0}", ar);
            return ar;
        }
        public double Area(double x, double y)
        {
            double ar;
            Console.WriteLine("Enter the Breadth");
            bdtriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hieght for Triangle ");
            ht = double.Parse(Console.ReadLine());
            ar = (bdtriangle * ht) / 2;
            Console.WriteLine("Area of Triangle is:{0}", ar);
            return ar;
        }
        static void Main(string[] args)
        {
            Shapes a = new Shapes();
            int area1 = a.Area(2,3);
            Console.WriteLine("Area of rectangle is"+area1);
            Console.ReadKey();
        }
    }
}
