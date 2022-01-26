using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Ex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
        }
    }
    class EX2
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter user name");
            name = Console.ReadLine();
            Console.WriteLine("Hi { 0} in your first csharp program", name);
        }
    }
    class EX3
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter first no.");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = num1; i < num2; i++)
            {
                Console.WriteLine("the numbers between {0} and {1} are: ", num1, num2, i);
            }
        }
    }
        class EX4
        {
            static void Main(string[] args)
            {
                int num;
                Console.Write("Enter your number:\t");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("{0} is Even Number", num);
                }
                else
                {
                    Console.WriteLine("{0} is Odd number", num);
                }
                Console.ReadLine();
            }
        }
        class EX5
        {
            static void Main(string[] args)
            {
                int[] numbers = { 10, 7, 25, 40, 93, 22, 45, 52, 85 };
                int evenCount, oddCount;
                evenCount = oddCount = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
                Console.WriteLine("Number of Even and Odd Numbers in Array");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine("Even Numbers Count: " + evenCount);
                Console.WriteLine("Odd Numbers Count: " + oddCount);
            }
        }
        class EX6
        {
            static void Main(string[] args)
            {
                double far, celf;
                Console.WriteLine("enter the temperature in farenheit");
                far = Convert.ToDouble(Console.ReadLine());
                celf = (5 * (far - 32)) / 9;
                Console.WriteLine("The temperature in celsius is {0}", celf);
            }
        }
        class EX7
        {
            static void Main(string[] args)
            {
                int n, i = 1;
                Console.WriteLine("Enter the range of number(limit)");
                n = Convert.ToInt32(Console.ReadLine());
                while (i <= n)
                {
                    Console.WriteLine(i * i);
                    i++;
                }
            }
        }
        class EX8
        {
            static void Main(string[] args)
            {
                int num, factorial = 1;
                Console.Write("Enter the number: ");
                num = Convert.ToInt32(Console.ReadLine());
                while (num >= 1)
                {
                    factorial = factorial * num;
                    num--;
                }
                Console.Write("Factorial: " + factorial);
            }
        }
        class EX9
        {
            static void Main(string[] args)
            {
                int num, firstNum = 0, secondNum = 1, temp, thirdNum = 3;
                Console.Write("Enter the number: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.Write(firstNum + "\t" + secondNum);
                while (thirdNum <= num)
                {
                    temp = firstNum + secondNum;
                    Console.Write("\t" + temp);
                    firstNum = secondNum;
                    secondNum = temp;
                    thirdNum = thirdNum + 1;
                }
            }
        }
        class EX10
        {
            static void Main(string[] args)
            {
                int num,sum=0;
                Console.WriteLine("Enter the number:");
                num = Convert.ToInt32(Console.ReadLine());
                if(num>5)
                {
                for (int i = 5; i <= num; i++)
                    sum += i * i * i;
                }
                Console.WriteLine("{0}", sum);
            }
        }
        class EX11
        {
                static void Main(string[] args)
            {
                int num1, res, i;
                Console.WriteLine("Enter a number");
                num1 = Convert.ToInt32(Console.ReadLine());
                i = 1;
                while (i <= 20)
                {
                     res = num1 * i;
                     Console.WriteLine("{0} x {1} = {2}", num1, i, res);
                     i++;
                }
             }
        }
        class EX12
        {
             static void Main(string[] args)
             {
                  int i;
                  for(i=200;i<300;i++)
                  {
                      if(i%7==0)
                      {
                          Console.WriteLine(i);
                      }
                  }
             }
        }
        class EX13
        {
             static void Main(string[] args)
             {
                  int num1, num2, num3;
                  Console.WriteLine("Enter first no.");
                  num1 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter second no.");
                  num2 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter third no.");
                  num3 = Convert.ToInt32(Console.ReadLine());
                  if(num1>num2 && num1>num3)
                  {
                      Console.WriteLine("The no. {0} is largest", num1);
                  }
                  else if(num2>num1 && num2>num3)
                  {
                      Console.WriteLine("The no. {0} is largest", num2);
                  }
                  else
                  {
                      Console.WriteLine("The no. {0} is largest", num3);
                  }
             }
        }
        class EX14
        {
             static void Main(string[] args)
             {
                 int n;
                 float small;
                 int[] a = new int[50];
                 Console.WriteLine("Enter the size of Array");
                 string s = Console.ReadLine();
                 n = Int32.Parse(s);
                 Console.WriteLine("Enter the array elements");
                 for (int i = 0; i < n; i++)
                 {
                      string s1 = Console.ReadLine();
                      a[i] = Int32.Parse(s1);
                 }
                 Console.Write("");
                 small = a[0];
                 for (int i = 1; i < n; i++)
                 { 
                     if (a[i] < small)
                          small = a[i];
                 }
                 Console.WriteLine("Smallest element in the array is {0}", small);
             }
        }
        class EX15
        {
            static void Main(string[] args)
            {
                int total = 0;
                float min, max;
                double average;
                int[] num = new int[10];
                Console.WriteLine("Enter 10 numbers");
                for (int i = 0; i < 10; i++)
                {
                    num[i] = int.Parse(Console.ReadLine());
                    total += num[i];
                }
                average = total / 10.0;
                Console.WriteLine("The total is: {0}\n And average is: {1}", total, average);
                min = num[0];
                max = num[0];
                for (int i = 1; i < 10; i++)
                {
                    if (num[i] > max)
                        max = num[i];
                    else if (num[i] < min)
                        min = num[i];
                }
                Console.WriteLine("Largest element in the array is {0}", max);
                Console.WriteLine("Smallest element in the array is {0}", min);
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10 - 1; j++)
                    {
                        if (num[j] > num[j + 1])
                        {
                            int temp = num[j];
                            num[j] = num[j + 1];
                            num[j + 1] = temp;
                        }
                    }
                }
                Console.Write("Ascending order : ");
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(num[i] + " ");
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = i + 1; j < 10; j++)
                    {
                        if (num[i] < num[j])
                        {
                            int temp = num[i];
                            num[i] = num[j];
                            num[j] = temp;
                        }
                    }
                }
                Console.Write("\nDescending order:\n");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0} ", num[i]);
                }
                Console.Write("\n\n");
            }
        }
        class EX16
        {
            static void Main(string[] args)
            {
            string str; 
            int l = 0;
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            foreach (char chr in str)
            {
                l += 1;
            }
            Console.Write("Length of the string is : {0}\n\n", l);
            }
        }
        class EX17
        {
            static void Main(string[] args)
            {
            string str = "", reverse = "";
            int Length = 0;
            Console.WriteLine("Enter a Word");
            str = Console.ReadLine(); 
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
            }
        }
        class EX18
        {
            static void Main(string[] args)
            {
            string s1 = "Amiya";
            string s2 = "Amiyas";
            Console.WriteLine(s1.Equals(s2));
            }
        }
        class EX19
        {
            static void Main(string[] args)
            {
                 int num, temp = 0, orginalNum;
                 Console.Write("Enter the number: ");
                 num = Convert.ToInt32(Console.ReadLine());
                 orginalNum = num; 
                 while (num >= 1)
                 {
                     temp = temp * 10 + num % 10;
                     num = num / 10;
                 }
                 if (temp == orginalNum)
                 {
                      Console.Write("Palidrome Number");
                 }
                 else
                 {
                      Console.Write("Not a Palidrome Number");
                 }
            }
        }
    
    
}
    
   
