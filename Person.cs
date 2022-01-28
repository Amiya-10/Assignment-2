using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_on_classes
{
    class Person
    {
        public string fname;
        public string lname;
        public string email;
        public DateTime dob = new DateTime(2000,01,03);

        public Person(string fn, string ln, string mail)
        {
            this.fname = fn;
            this.lname = ln;
            this.email = mail;
            
        }
        public void Details()
        {
            Console.WriteLine("First Name " + fname);
            Console.WriteLine("Last Name " + lname);
            Console.WriteLine("Email " + email);

            Console.WriteLine("Date Of Brith:" + dob);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Person k = new Person( "Amiya","Sahu","absds@gmail.com");
            k.Details();
            Console.ReadKey();
        }
    }

}
