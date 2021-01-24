using Demo.ClientApp.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.ClientApp.Queries.GetBooks
{
    public class GetBooksQuery : IRequest<IEnumerable<BookDto>>
    {
    }
}
