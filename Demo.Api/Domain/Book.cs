using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Api.Domain
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
