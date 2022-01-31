using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_assignment
{
    class Furniture
    {
        public int order_id;
        public DateTime orderdate = new DateTime(2015, 12, 31);
        public string furniture_type;
        public int quantity;
        public double amount;

    
        public void Getdata()
        {
            Console.WriteLine("Enter the order id:");
            order_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter furniture type:");
            Console.ReadLine();
            Console.WriteLine("Enter the quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount:");
            amount = Convert.ToDouble(Console.ReadLine());
        }
        public void Details()
        {
            Console.WriteLine("The Order Id: " + order_id);
            Console.WriteLine("The Order Date: " + orderdate);
            Console.WriteLine("The Furniture type: " + furniture_type);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Amount: " + amount);
        }
    }
    class Chair : Furniture
    {
        public string chairtype;
        public string purpose;
        public string woodtype;
        public string steeltype;
        public string color;
        
        new public void Getdata()
        {
            if (furniture_type == "Chair")
            {
                Console.WriteLine("Enter the Chair type(Wood/Steel/Plastic): " + chairtype);
                Console.ReadLine();
                Console.WriteLine("Enter the purpose of use (Home/Office): " + purpose);
                Console.ReadLine();
                if (chairtype == "Wood")
                {
                    Console.WriteLine("please select (Teak Wood/Oak Wood): " + woodtype);
                    Console.ReadLine();
                    Console.WriteLine("MRP: 40$");
                }
                if (chairtype == "Steel")
                {
                    Console.WriteLine("Please select color(Grey steel/Green steel/Brown steel): " + steeltype);
                    Console.ReadLine();
                    Console.WriteLine("MRP: 34$");
                }
                if (chairtype == "Plastic")
                {
                    Console.WriteLine("Please select a color(Green/Red/Blue/White): " + color);
                    Console.ReadLine();
                    Console.WriteLine("MRP: 20$");
                }
                else
                {
                    Console.WriteLine("Enter correct info");
                }
            }
        }
        

    }
    class Cot : Furniture
    {
        public string cot_type;
        public string capacity;
        public string Woodtype;
        public string Steeltype;

        new public void Getdata()
        {
            if (furniture_type == "Cot")
            {
                Console.WriteLine("Enter Cot type(Wood/Steel): " + cot_type);
                Console.ReadLine();
                Console.WriteLine("Enter the capacity(single/double): " + capacity);
                if (cot_type == "Wood")
                {
                    Console.WriteLine("please select (Teak Wood/Oak Wood): " + Woodtype);
                    Console.ReadLine();
                    Console.WriteLine("You have selected{0} type", Woodtype);
                    Console.WriteLine("MRP: 60$");
                }
                if (cot_type == "Steel")
                {

                    Console.WriteLine("Please select color(Grey steel/Green steel/Brown steel): " + Steeltype);
                    Console.ReadLine();
                    Console.WriteLine("You have selected{0} type", Steeltype);
                    Console.WriteLine("MRP: 89$");
                }
            }
        }
    }
    
    class Programm
    {
        static void Main(string[] args)
        {
            Furniture k = new Furniture();
            k.Getdata();
            k.Details();
            Console.ReadKey();

        }
    }
}
