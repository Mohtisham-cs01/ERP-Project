using DemoApplicationWeb_A.Models;
using DemoApplicationWeb_A.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoApplicationWeb_A.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {

        JsonFileBookService BookService;
        public FormHandlerController(JsonFileBookService bookService)
        {
            this.BookService = bookService;
        }
        [HttpGet]
        public string Get(int id, string name, string image)
        {
            Book obj = new Book();
            obj.book_id = id;
            obj.name = name;
            obj.image = image;


            BookService.setBookRecords(obj, BookService);
            return "Function Exec";
        }
    }
}
