using System;
using System.Threading;
using System.Threading.Tasks;
using Demo.ClientApp.Pages;
using Demo.ClientApp.Queries.GetBooks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.ClientApp.Controllers
{
    [Controller]
    public class BooksController : Controller
    {
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken = default)
        {
            var books = await _mediator.Send(new GetBooksQuery(), cancellationToken);

            return View("Index", new BooksModel(books));
        }
    }
}