using DemoApplicationWeb_A.Models;
using DemoApplicationWeb_A.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplicationWeb_A.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookRecordController : ControllerBase
    {
        JsonFileBookService BookService;
        public BookRecordController(JsonFileBookService bookService)
        {
            this.BookService = bookService;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return BookService.getBookRecords();
        }
    }
}
