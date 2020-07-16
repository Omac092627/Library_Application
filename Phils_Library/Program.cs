using System;
using System.Collections.Generic;
using System.ComponentModel;
using Phils_Library.Classes;


namespace Phils_Library
{

     class Program
    {
        //Properties//
          public static Library<Book> Library { get; set; }
          public static List<Book> BookBag { get; set; }




        static void Main(string[] args)
        {


            Library = new Library<Book>();

            BookBag = new List<Book>();

            LoadBooks();
            UserInterface();
        }





        static void UserInterface()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Welcome to the Library, please choose an option:");
                    Console.WriteLine("1) View all Books");
                    Console.WriteLine("2) Add a Book");
                    Console.WriteLine("3) Borrow a Book");
                    Console.WriteLine("4) Return a Book");
                    Console.WriteLine("5) View Book Bag");
                    Console.WriteLine("6) Exit");
                    string option = Console.ReadLine();

                    if (option == "1")
                    {
                        Console.Clear();

                        OutputBooks();

                    }
                    else if (option == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Which book would you like to add?");
                        string twoOption = Console.ReadLine();
                        AddABook(twoOption, twoOption, twoOption, 0);
                    }
                    else if (option == "3")
                    {
                        Console.Clear();

                        Dictionary<int, string> books = new Dictionary<int, string>();
                        Console.WriteLine("Which book would you like to borrow? Please only select the number.");
                        int counter = 1;
                        foreach (Book book in Library)
                        {
                            books.Add(counter, book.Title);
                            Console.WriteLine($"{counter++}. {book.Title} - {book.Author.FirstName} {book.Author.LastName}");
                        }
                        string response = Console.ReadLine();
                        int.TryParse(response, out int selection);
                        books.TryGetValue(selection, out string borrowtitle);
                        Borrow(borrowtitle);
                    }
                    else if (option == "4")
                    {
                        ReturnBook();

                    }
                    else if(option == "5")
                    {
                        Console.Clear();

                        foreach (Book book in BookBag)
                        {
                            Console.WriteLine($"{book.Title} - {book.Author.FirstName} {book.Author.LastName}");
                        }
                    }
                    else if(option == "6")
                    {
                        Console.WriteLine("Thank you for using our terrible service!");
                        break;
                    }    

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

         static void AddABook(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book()
            {
                Title = title,
                Author = new Author() { FirstName = firstName, LastName = lastName },
                NumberOfPages = numberOfPages,
                Genre = Genre.Romance
            };

            Library.Add(book);
        }

        static void OutputBooks()
        {

            int counter = 1;
            foreach (Book book in Library)
            {
             Console.WriteLine($"{counter++}.{book.Title} - {book.Author.FirstName} {book.Author.LastName}");
              
            }
        }

        static void LoadBooks()
        {
            Book a = new Book
            {
                Title = "Harry Potter",
                Author = new Author() { FirstName = "JK", LastName = "Rowling" },
                Genre = Genre.Fantasy
            };

            Book b = new Book
            {
                Title = "Holes",
                Author = new Author() { FirstName = "Louis", LastName = "Sichar" },
                Genre = Genre.Drama
            };

            Book c = new Book
            {
                Title = "Alex Cross",
                Author = new Author() { FirstName = "James", LastName = "Patterson" },
                Genre = Genre.Action
            };

            Book d = new Book
            {
                Title = "How to not give a F**k",
                Author = new Author() { FirstName = "Mark", LastName = "Maron" },
                Genre = Genre.Comedy
            };

            Book e = new Book
            {
                Title = "Interstellar",
                Author = new Author() { FirstName = "Christopher", LastName = "Nolan" },
                Genre = Genre.Fantasy
            };

            Library.Add(a);
            Library.Add(b);
            Library.Add(c);
            Library.Add(d);
            Library.Add(e);

        }


        static void ReturnBook()
        {
            Dictionary<int, Book> books = new Dictionary<int, Book>();
            Console.WriteLine("Which book would you like to return?");
            int counter = 1;
            foreach (var item in BookBag)
            {
                books.Add(counter, item);
                Console.WriteLine($"{counter++}. {item.Title} - {item.Author.FirstName} {item.Author.LastName}");
            }

            string response = Console.ReadLine();
            int.TryParse(response, out int selection);
            books.TryGetValue(selection, out Book returnedBook);
            BookBag.Remove(returnedBook);
            Library.Add(returnedBook);
        }

        public static Book Borrow(string title)
        {
            Book borrowedBook = null;
            foreach (Book book in Library)
            {
                if (book.Title == title)
                {
                    borrowedBook = book;
                    BookBag.Add(Library.Remove(borrowedBook));
                    break;
                }
            }
            return borrowedBook;
        }


    }
}


