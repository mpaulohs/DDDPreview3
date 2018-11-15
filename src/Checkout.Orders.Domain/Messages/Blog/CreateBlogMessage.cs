using Checkout.Orders.Domain.Entities.BlogAggregate;
using Checkout.Orders.Domain.Entities.PostAggregate;
using System.Collections.Generic;

namespace Checkout.Orders.Domain.Messages.Blog
{
    public class CreateBlogMessage : IMessage
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public BlogImage BlogImage { get; set; }
        public List<Post> Posts { get; set; }
    }
}