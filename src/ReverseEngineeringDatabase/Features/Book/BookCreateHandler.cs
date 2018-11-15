using MediatR;
using ReverseEngineeringDatabase.Data.Models;
using System.Threading;
using System.Threading.Tasks;

namespace ReverseEngineeringDatabase.Features.Book
{

    public class BookCreateHandler : IRequestHandler<BookCreateCommand, int>
    {
        private readonly RevEngDbContext _db;
        public BookCreateHandler(RevEngDbContext db) => _db = db;
       

        public async Task<int> Handle(BookCreateCommand message, CancellationToken token)
        {
            
            var book = new DTOBook() { Title = message.Title };          
            _db.Book.Add(book);
            await _db.SaveChangesAsync();

            return book.Id;
        }
    }
}
