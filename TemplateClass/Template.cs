\\Клас без використання темлейту, оскільки я не знаю цієї теми\\
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;



namespace ConsoleApp1
{
    class Book
    {
        string name;
        string author;
        int pages;
       
        

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string Author
        {
            get { return author; }
            set { author = value; }

        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
            

        }

        public Book(string n,string a,int p)
        {
            name = n;
            author = a;
            pages = p;
        }

 

        public void print()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Author:" + author);
            Console.WriteLine("Pages:" + pages);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {


            List<Book> book = new List<Book>();
            FileStream fs = new FileStream(@"C:\Users\ore31\source\repos\ConsoleApp1\ConsoleApp1\Info.txt",FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            int N = 0;
            
            while(!sr.EndOfStream)
            {
                
                string name = sr.ReadLine();

               if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    { throw new System.ArgumentException("Parameter cannot be non letter"); }
                }
                string author = sr.ReadLine();
                if (!Regex.IsMatch(author, @"^[a-zA-Z]+$"))
                {
                    { throw new System.ArgumentException("Parameter cannot be non letter"); }
                }
                int pages = int.Parse(sr.ReadLine());
                if (pages<=0)
                { throw new System.ArgumentException("Parameter cannot be negative"); }
                book.Add(new Book(name,author,pages));
                
                N++;
            }
            sr.Close();


            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
            bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Sort by Pages");
                Console.WriteLine("2) Sort by Author");
                Console.WriteLine("3) Sort by Name");
                Console.WriteLine("4) Find Author");
                Console.WriteLine("5) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        SortyByPages();
                        return true;
                    case "2":
                        SortyByAuthor();
                        return true;
                    case "3":
                        SortyByName();
                        return true;
                    case "4":
                        AuthorSearch();
                        return true;
                    case "5":
                        return false;
                    default:
                        return true;
                }
            }

            void SortyByPages()
            {
                book.Sort((a, b) => a.Pages.CompareTo(b.Pages));
                for (int i = 0; i < N; i++)
                {
                    book[i].print();

                }
                
                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }

            void SortyByAuthor()
            {
                book.Sort((a, b) => a.Author.CompareTo(b.Author));
                for (int i = 0; i < N; i++)
                {
                    book[i].print();

                }

                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }
            void SortyByName()
            {
                book.Sort((a, b) => a.Name.CompareTo(b.Name));
                for (int i = 0; i < N; i++)
                {
                    book[i].print();

                }

                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }
            void AuthorSearch()
            {
               string a;
               Console.WriteLine("Enter author whose book you want to find");
               a= Console.ReadLine();
               Book found= book.Find(x => x.Author.Contains(a));
               found.print();
               Console.Write("\r\nPress Enter to return to Main Menu");
               Console.ReadLine();
            }
        

 
        }
       
    }
}
