using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_on_classes
{
    class Student
    {
        public string stud_name;
        public int roll;
        public int sem;
        public string branch;
        public int avg;
        public int sum = 0;
        public int i;
        public int[] marks = new int[5];
        public void Accept_details()
        {
            Console.WriteLine("Enter student name");
            stud_name = Console.ReadLine();
            Console.WriteLine("Enter roll no.");
            roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter current sem");
            sem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter branch");
            branch = Console.ReadLine();
            marks[0] = 60;
            marks[1] = 89;
            marks[2] = 77;
            marks[3] = 34;
            marks[4] = 70;
        }
        public void Print_details()
        {
            Console.WriteLine("Student name" + stud_name);
            Console.WriteLine("Roll no." + roll);
            Console.WriteLine("Sem" + sem);
            Console.WriteLine("Branch" + branch);
            for(i=0;i<5;i++)
            {
                Console.WriteLine(marks[i] + " ");
            }
            Console.WriteLine();
        }
        public void total()
        {
            foreach(int k in marks)
            {
                sum += k;
            }
            avg = sum / 5;
            Console.WriteLine("Total marks is {0}", sum);
            Console.WriteLine("Average is {0}", avg);
        }
        public void result()
        {
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(marks[i] + " ");
            }
            Console.WriteLine();
            if (marks[i]<35)
            {
                Console.WriteLine("Failed");
            }
            else if(marks[i]>35 && avg<50)
            {
                Console.WriteLine("Failed");
            }
            else if(marks[i]>50)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Passed");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student k = new Student();
            k.Accept_details();
            k.Print_details();
            k.total();
            k.result();
            Console.ReadKey();
        }
    }
}
