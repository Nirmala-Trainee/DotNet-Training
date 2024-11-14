using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Books
    {
        string BookName;
        string AuthorName;
        public Books(string Book_name, string Author_name)
        {
            this.BookName = Book_name;
            this.AuthorName = Author_name;
        }
        public void Display()
        {
            Console.WriteLine($"The Book Title is {BookName} and Written by {AuthorName}");
        }
    }
    class BookShelf
    {
        public Books[] Book_list = new Books[5];  
        public Books this[int i]
        {
            get { return Book_list[i]; }
            set { Book_list[i] = value; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Books details:");
            Console.WriteLine();
            string Book_name;
            string Author_name;

            BookShelf bs = new BookShelf();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter book {i + 1} details");
                Console.Write("Enter the book name : ");
                Book_name = Console.ReadLine();
                Console.Write("Enter Author name : ");
                Author_name = Console.ReadLine();
                bs[i] = new Books(Book_name, Author_name);
            }

            Console.WriteLine();
            Console.WriteLine("-----Books Details---");
            Console.WriteLine();
            for (int j = 0; j < 5; j++)
            {
                bs[j].Display();
            }
            Console.ReadLine();

        }
    }
}