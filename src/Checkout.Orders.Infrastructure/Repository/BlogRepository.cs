using Checkout.Orders.Domain.Entities.BlogAggregate;
using Checkout.Orders.Infrastructure.Data;

namespace Checkout.Orders.Infrastructure.Repository
{
    public class BlogRepository : EfRepository<Blog>, IBlogRepository
    {
        public BlogRepository(OrderDbContext dbContext) : base(dbContext)
        {
        }        
    }
}
