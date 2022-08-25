using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private static List<Book> Books =new List<Book>{
            new Book(),
            new Book{id =1, Name="The Morning"},
            new Book{id =2, Name="The new World"}
        };
        //Get no id
        [HttpGet]
        public ActionResult<List<Book>> Get(){
            return Ok(Books);
        }
        // Get by id
        [HttpGet("{id}")]
        public ActionResult<Book> GetID( int id){
            return Ok(Books.FirstOrDefault(c => c.id==id));
        }
    }
}