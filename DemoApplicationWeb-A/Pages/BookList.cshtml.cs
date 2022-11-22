using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApplicationWeb_A.Models;
using DemoApplicationWeb_A.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApplicationWeb_A.Pages
{
    public class BookListModel : PageModel
    {
        JsonFileBookService BookService;
        public IEnumerable<Book> Books;

        public BookListModel(JsonFileBookService bookService)
        {
            this.BookService = bookService;
        }
        public void OnGet()
        {
            Books = BookService.getBookRecords();
        }
    }
}
