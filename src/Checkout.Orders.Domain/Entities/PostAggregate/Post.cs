using Checkout.Orders.Domain.Entities.BlogAggregate;
using Checkout.Orders.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout.Orders.Domain.Entities.PostAggregate
{
    public class Post : Entity
    {
       // public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public List<PostTag> PostTags { get; set; }
    }
}
