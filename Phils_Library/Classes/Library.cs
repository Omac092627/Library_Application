using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Phils_Library
{
    public class Library<Book> : IEnumerable<Book>
    {

        Book[] items = new Book[5];
        int count;


        public void Add(Book item)
        {
            // evaluate the length of items vs the count. 
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count++] = item;

            //// if count = 3
            //count++;  // output 3, and then incrament to 4
            //++count; // incrament to 4, then output 4
        }


        // If something is enumerable (interface)
        // you need an enumerator ("get enumerator"_
        // to be able to enumerate through generic collections

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                // yield break
                yield return items[i];
            }

        }


        public int Count()
        {
            return count;
        }



        // Foreach does not require IEnumerable
        // Ienumerator only requires the GetEnumerator (non-generic)
        // Non-generic getenumerator requires teh generic GetEnumerator

        // Enumerable - means it can be iterated through
        // Enumerator - is the actual "thing" that walks through the sequence through the list

        // Magic, don't touch.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    
    }

}
