using System;
using System.Collections.Generic;
using System.Text;

namespace Phils_Library
{
    public class Author : Book
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static implicit operator string(Author v)
        {
            throw new NotImplementedException();
        }
    }
}
