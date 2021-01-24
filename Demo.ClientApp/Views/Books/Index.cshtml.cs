using System.Collections.Generic;
using Demo.ClientApp.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo.ClientApp.Pages
{
    public class BooksModel
    {
        public IEnumerable<BookDto> Books { get; }

        public BooksModel(IEnumerable<BookDto> books)
        {
            Books = books;
        }
    }
}