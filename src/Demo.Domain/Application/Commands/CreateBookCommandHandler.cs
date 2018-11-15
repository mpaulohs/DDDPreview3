using Demo.Domain.AggregatesModel.BookAggregate;
using Demo.Domain.Application.Core;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Domain.Application.Commands
{

    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Response>
    {
        private readonly IBookRepository _bookRepository;

        public CreateBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Response> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Title);

            await _bookRepository.AddAsync(book);

            return new Response("Book criado com sucesso");
        }
    }
}
