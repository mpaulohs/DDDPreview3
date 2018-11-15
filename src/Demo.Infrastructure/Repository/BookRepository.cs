using Demo.Domain.AggregatesModel.BookAggregate;
using Demo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Repository
{
    public class BookRepository : EfRepository<Book>, IBookRepository
    {
        public BookRepository(DemoDbContext dbContext) : base(dbContext)
        {
        }

        public Book GetByIdWithItems(int id)
        {
            return _dbContext.Book.FirstOrDefault();
        }

        public Task<Book> GetByIdWithItemsAsync(int id)
        {
            return _dbContext.Book
                .FirstOrDefaultAsync();
        }
    }
}
