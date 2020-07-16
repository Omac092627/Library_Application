using System;
using System.Collections.Generic;


namespace Phils_Library
{
    public enum Genre {Horror, Action, Comedy, Drama, Romance, Fantasy}

    public class Program
    {
        //Properties//
        public static Library<Book> Library { get; set; }
        public static List<Book> BookBag { get; set; }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UserInterface();

            Library = new Library<Book>();

            BookBag = new List<Book>();

        }



        public static void LoadBooks()
        {
            AddABook("Chicken", "Bob", "Dylan", 145, Genre.Action);
            AddABook("Battle of The Code", "Tiger", "Woods", 600, 0);
            AddABook("Dude wheres my code", "Tony", "The Tiger", 400, Genre.Comedy);
            AddABook("Pokemon the code", "Ash", "Catchum", 145, Genre.Drama);
            AddABook("Suh dude", "Dang", "Daniel", 145, Genre.Fantasy);
        }




        public static void UserInterface()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Welcome to the Library, please choose an option:");
                    Console.WriteLine("1) Add a Book");
                    Console.WriteLine("2) Borrow a Book");
                    Console.WriteLine("3) Return a Book");
                    Console.WriteLine("4) View Book Bag");
                    Console.WriteLine("5) Exit");
                    string option = Console.ReadLine();

                    if (option == "1")
                    {

                    }
                    else if (option == "2")
                    {

                    }
                    else if (option == "3")
                    {

                    }
                    else if (option == "4")
                    {
               
                    }    
                    else
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

        static void AddABook(string title, string firstName, string lastName, int numberOfPages, Genre genre)
        {
            Book book = new Book()
            {
                Title = title,
                Author = new Author()
                {
                    FirstName = firstName,
                    LastName = lastName
                },

                NumberOfPages = numberOfPages,
                Genre = genre
            };

            Library.Add(book);
        }




    }
}


