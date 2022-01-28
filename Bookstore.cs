using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_on_classes
{
    class Bookstore
    {
        public int book_id;
        public string book_name;
        public string author;
        public int quantity_books;
        public float price;

        public void Accept_details()
        {
            Console.WriteLine("Enter the book id");
            book_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the book name");
            book_name = Console.ReadLine();
            Console.WriteLine("Enter the author name");
            author = Console.ReadLine();
            Console.WriteLine("Enter the quantity of copies");
            quantity_books = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price");
            price = float.Parse(Console.ReadLine());
        }
        public void Details()
        {
            Console.WriteLine("Book Name:" + book_name);
            Console.WriteLine("Book ID: " + book_id);
            Console.WriteLine("Author Name: " + author);
            Console.WriteLine("Total copies: " + quantity_books);
            Console.WriteLine("Price: " + price);
        }
        static void Main(string[] args)
        {
            Bookstore k = new Bookstore();
            k.Accept_details();
            k.Details();
            Console.ReadKey();

        }
    }
}
