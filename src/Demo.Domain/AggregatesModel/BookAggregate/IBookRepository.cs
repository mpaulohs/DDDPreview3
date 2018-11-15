using Demo.Domain.SeedWork;
using System.Threading.Tasks;

namespace Demo.Domain.AggregatesModel.BookAggregate
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetByIdWithItems(int id);
    }
}
