using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_on_classes
{
    class Account
    {

        private double balance = 100000;
        public double bal
        {
            get { return balance; }
            set { balance = value; }
        }
        class fuctions
        {
            Account i = new Account();
            string name;
            int account;
            double withdraw, dep, tobal;

            public void fun1()
            {
                Console.WriteLine("Enter the name of depositor");
                name = Console.ReadLine();
                Console.WriteLine("Enter the account no.");
                account = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the deposit amount");
                dep = Convert.ToDouble(Console.ReadLine());
                tobal = i.bal + dep;
                Console.WriteLine("Name of Depositor" + name);
                Console.WriteLine("Account no." + account);
                Console.WriteLine("Total balance in account after deposit" + tobal);

            }

            public void fun2()
            {

                Console.WriteLine("Enter Account Name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter Account Number:");
                account = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Withdraw Amount:");
                withdraw = Convert.ToDouble(Console.ReadLine());
                if (withdraw <= i.bal)
                {
                    tobal = i.bal - withdraw;
                    Console.WriteLine("Account Name" + name);
                    Console.WriteLine("Account Number" + account);
                    Console.WriteLine("Total balance after withdrawal" + tobal);

                }
                else
                    Console.WriteLine("Withdraw amount doesn't exist in your account");

            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                char agn;
                do
                {
                    fuctions k = new fuctions();
                    int num;
                    Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.");
                    num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {

                        case 1:

                            k.fun1();
                            break;

                        case 2:

                            k.fun2();
                            break;

                        default:

                            Console.WriteLine("Invalid Selection!!!");
                            break;

                    }
                    Console.WriteLine("\nDo you want to continue this program ? (y / n)");

                    agn = Convert.ToChar(Console.ReadLine());
                } while (agn == 'y');
            }
        }
    }
}
