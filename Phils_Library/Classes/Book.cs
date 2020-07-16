using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Phils_Library.Classes
{
    class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public int NumberOfPages { get; set; }

        public Genre Genre { get; set; }

    }
    enum Genre
    {
        Horror,
        Action,
        Comedy,
        Drama,
        Romance,
        Fantasy

    }
}
