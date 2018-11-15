using Checkout.Orders.Domain.Entities.PostAggregate;
using Checkout.Orders.Domain.SeedWork;
using System.Collections.Generic;

namespace Checkout.Orders.Domain.Entities.BlogAggregate
{
    public class Blog : Entity
    {
       // public int BlogId { get; set; }
        public string Url { get; set; }

        public BlogImage BlogImage { get; set; }
        public List<Post> Posts { get; set; }
    }

}
