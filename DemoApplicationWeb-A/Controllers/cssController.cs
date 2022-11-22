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
    public class cssController : ControllerBase
    {
        JsonFileBookService BookService;
        public cssController(JsonFileBookService bookService)
        {
            this.BookService = bookService;
        }

        [HttpGet]
        public string Get()
        {
            return BookService.getCss();
        }
    }
}
