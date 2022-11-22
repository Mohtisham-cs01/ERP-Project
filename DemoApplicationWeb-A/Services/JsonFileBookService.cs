using DemoApplicationWeb_A.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoApplicationWeb_A.Services
{
    public class JsonFileBookService
    { 
        public IWebHostEnvironment WebHostEnvironment;
        
        public JsonFileBookService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
            
        }
        public string fileAddress { 
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "books.json");
            } 
        }
        public string cssAdddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "css", "site.css");
            }
        }
        public IEnumerable<Book> getBookRecords()
        {
            using (var file_stream = File.OpenText(fileAddress))
            {
                return JsonSerializer.Deserialize<Book[]>(file_stream.ReadToEnd());
            }
        }
        public string getCss()
        {
            using (var file_stream = File.OpenText(cssAdddress))
            {
                return file_stream.ReadToEnd();
            }
        }

        public void setBookRecords(Book obj, JsonFileBookService BookService)
        {
            IEnumerable<Book> BookRecords = BookService.getBookRecords();
            List<Book> listBookRecords = BookRecords.ToList();
            listBookRecords.Add(obj);

            string finalData = JsonSerializer.Serialize<List<Book>>(listBookRecords);
            StreamWriter file_stream = new StreamWriter(fileAddress);
            file_stream.Write(finalData);
            file_stream.Flush();
            file_stream.Close();
        }
    }
}
