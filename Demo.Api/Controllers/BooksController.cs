using System.Collections.Generic;
using System.Threading.Tasks;
using Demo.Api.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> GetAll() => Task.FromResult((IActionResult) Ok(new List<Book>
        {
             new Book("Pan Tadeusz", "Adam Mickiewicz"),
             new Book("Chaos pierwszego poziomu", "Mateusz Pakuła") 
        }));
    }
}
