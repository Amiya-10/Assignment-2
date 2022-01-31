using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_assignment
{
    class Building
    {
        public string type;
        public string capacity;
        public string dimension;

        public Building(string type,string capacity,string dimension)
        {
            this.type = type;
            this.capacity = capacity;
            this.capacity = dimension;

        }
        public virtual void Showdata()
        {
            Console.WriteLine("The type of building is{0}", type);
            Console.WriteLine("The capacity is {0}", capacity);
            Console.WriteLine("The Dimension is: " + dimension);
        }
    }
    class Flat : Building
    {
        public int flatno;
        public string address;

        public Flat(string type, string capacity, string dimension, int flatno, string address) : base(type, capacity, dimension)
        {
            if (type == "Flat")
            {
                if (capacity == "2BHK")
                {
                    Console.WriteLine("The rate is: 5000$");
                }
                if (capacity == "3BHK")
                {
                    Console.WriteLine("The rate is: 6000$");
                }
                if (capacity == "4BHK")
                {
                    Console.WriteLine("The rate is: 7000$");
                }
            }
        }
        public override void Showdata()
        {
            Console.WriteLine("The Flat no. is {0}", flatno);
            Console.WriteLine("The address is {0}", address);
            Console.WriteLine("The capacity is {0}", capacity);

        }
    }
        
    class Villa : Building
    {
          public Villa(string type,string capacity, string dimension) : base(type,capacity,dimension) 
          {
              if (type == "Villa")
              {
                  Console.WriteLine("Enter the size(2BHK/3BHK/4BHK):");
                  Console.ReadLine();
                  if (capacity == "2BHK")
                  {
                      Console.WriteLine("The rate is: 8000$");
                  }
                  if (capacity == "3BHK")
                  {
                      Console.WriteLine("The rate is: 9000$");
                  }
                  if (capacity == "4BHK")
                  {
                      Console.WriteLine("The rate is: 10000$");
                  }
              }
          }
        public override void Showdata()
        {
            Console.WriteLine("The Villa is of {0}",capacity );
            
        }
    }
    
    class program
    {
        static void Main(string[] args)
        {
            Building k = new Building("Flat","2BHK","20x30x40");
            k.Showdata();
            Building m = new Flat("Flat","2BHK","20x20x20",103,"abcd");
            m.Showdata();
            Console.ReadKey();
        }
    }
    

}
