using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Phils_Library
{
    public class Book 
    {
        public  string Title { get; set; }
        public  string Author { get; set; }

        public int NumberOfPages { get; set; }
        public Genre Genre { get;  set; }
    }
}
