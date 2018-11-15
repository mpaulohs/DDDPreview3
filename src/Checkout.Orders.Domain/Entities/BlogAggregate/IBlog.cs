using Checkout.Orders.Domain.Entities.PostAggregate;
using Checkout.Orders.Domain.SeedWork;
using System.Collections.Generic;

namespace Checkout.Orders.Domain.Entities.BlogAggregate
{
    public interface IBlog
    {
        int BlogId { get; set; }
        string Url { get; set; }

        BlogImage BlogImage { get; set; }
        List<Post> Posts { get; set; }
    }

}
